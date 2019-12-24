using AtiehSMSFacilitator;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using SMS.ProvideSMSFeatures;
using SMS.Win.Reader;
using SMS.Win.Registrar;
using System;
using System.Windows.Forms;

namespace SMS.Win
{
    public partial class MainApplication : Form
    {
        public string NumbersFilePath
        {
            get { return this.NumbersPathTxt.Text; }
            private set
            {
                this.NumbersPathTxt.Text = value;
            }
        }

        public string ResultPath
        {
            get { return this.ResultPathTxt.Text; }
            private set
            {
                this.ResultPathTxt.Text = value;
            }
        }

        private BulkMessageSender bulkMessageSender;
        private IFileReader reader;
        private ISMSConfiguration config;

        public MainApplication()
        {
            InitializeComponent();
            this.ResultPath = @"D:\Sentresult.txt";
            var container = new WindsorContainer();
            container.Register(
                Component.For<ISMSProvider>().ImplementedBy<AtiehSMSProvider>());
            container.Register(
                Component.For<ISMSConfiguration>().ImplementedBy<AtiehSMSConfiguration>());
            container.Register(
                Component.For<IResultRegistrar>().ImplementedBy<FileResultRegistrar>());
            container.Register(
                Component.For<BulkMessageSender>().ImplementedBy<BulkMessageSender>());
            container.Register(
                Component.For<IFileReader>().ImplementedBy<CSVReader>());
            bulkMessageSender = container.Resolve<BulkMessageSender>();
            reader = container.Resolve<IFileReader>();
            config = container.Resolve<ISMSConfiguration>();
            config.ChangeConfig(Properties.Settings.Default.Username,
                Properties.Settings.Default.Password,
                Properties.Settings.Default.SourceNumber,
                Properties.Settings.Default.UrlAddress
                );
            bulkMessageSender.OneSendHandled += BulkMessageSender_OneSMSSent;
        }
            
        private void IncrementNumber()
        {
           CounterLbl.Text = CounterLbl.Text.Increment(); 
        }

        private void BulkMessageSender_OneSMSSent(object sender, SendSMSEventArgs e)
        {
            IncrementNumber();
            ResultDetailTxt.AppendText(string.Format("{0}\t{1}\r\n",
                e.PhoneNumber,
                e.Result.Status == ResultStatus.Unsuccessful && e.Result.Exception != null ?
                    e.Result.Exception.Message : e.Result.Status.ToString()));
            Application.DoEvents();
        }

        private void NumbersPathBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = reader.Filter;
            var result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.NumbersFilePath = ofd.FileName;
            }
        }
         
        private void ResultPathBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "TXT files (*.txt)|*.txt|All files (*.*)|*.*";
            var result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.ResultPath = ofd.FileName;
            }
        }

        private void SendBtn_Click(object sender, EventArgs e)
        {
            try
            {
                reader.SetPath(NumbersFilePath);
                var bulkMessage = new BulkMessage(this.ResultPath, reader.Read(), MessageTxt.Text);
                HandleInvalidNumbers(bulkMessage);
                bulkMessageSender.Send(bulkMessage);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Exception",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
        }

        private void HandleInvalidNumbers(BulkMessage bulkMessage)
        {
            foreach (var item in bulkMessage.InvalidReceivers)
            {
                ResultDetailTxt.AppendText(string.Format("{0}\t{1}\r\n", item, "Is invalid number"));
            }
        }

        private void ConfigBtn_Click(object sender, EventArgs e)
        {
            var frm = new Configuration();
            var result = frm.ShowDialog(this);
            if (result == DialogResult.OK)
                config.ChangeConfig(Properties.Settings.Default.Username,
                    Properties.Settings.Default.Password,
                    Properties.Settings.Default.SourceNumber,
                    Properties.Settings.Default.UrlAddress
                    );
        }
    }
}
