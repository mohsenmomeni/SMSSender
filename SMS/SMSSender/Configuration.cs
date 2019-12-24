using System.Windows.Forms;

namespace SMS.Win
{
    public partial class Configuration : Form
    {
        public Configuration()
        {
            InitializeComponent();
            UsernameTxt.Text = Properties.Settings.Default.Username;
            PasswordTxt.Text = Properties.Settings.Default.Password;
            PhoneTxt.Text = Properties.Settings.Default.SourceNumber;
            UrlTxt.Text = Properties.Settings.Default.UrlAddress;
        }

        private void OKBtn_Click(object sender, System.EventArgs e)
        {
            Properties.Settings.Default.Username = UsernameTxt.Text;
            Properties.Settings.Default.Password = PasswordTxt.Text;
            Properties.Settings.Default.SourceNumber = PhoneTxt.Text;
            Properties.Settings.Default.UrlAddress = UrlTxt.Text;
            Properties.Settings.Default.Save();
            DialogResult = DialogResult.OK;
        }
    }
}
