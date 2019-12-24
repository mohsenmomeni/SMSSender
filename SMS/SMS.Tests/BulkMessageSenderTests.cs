using Xunit;
using FluentAssertions;
using Castle.Windsor;
using Castle.MicroKernel.Registration;
using AtiehSMSFacilitator;
using System.Collections.Generic;
using SMS.ProvideSMSFeatures;

namespace SMS.Tests
{
    public class BulkMessageSenderTests
    {
        private BulkMessageSender bulkMessageSender;
        private bool OneStepTriggered = false;

        public BulkMessageSenderTests()
        {
            var container = new WindsorContainer();
            container.Register(
                Component.For<ISMSProvider>().ImplementedBy<AtiehSMSProvider>());
            container.Register(
                Component.For<ISMSConfiguration>().ImplementedBy<AtiehSMSConfiguration>());
            container.Register(
                Component.For<IResultRegistrar>().ImplementedBy<MockResultRegistrar>());            
            container.Register(
                Component.For<BulkMessageSender>().ImplementedBy<BulkMessageSender>());
            bulkMessageSender = container.Resolve<BulkMessageSender>();
            bulkMessageSender.OneSendHandled += BulkMessageSender_OneSMSSent;
        }

        private void BulkMessageSender_OneSMSSent(object sender, SendSMSEventArgs e)
        {
            OneStepTriggered = true;
        }

        [Fact(Skip = "Will work if you config atieh correctly.")]
        public void SendList_Of_BulkMessageSender_Should_Send_When_EveryThingIsOk()
        {
            //Arrange
            List<string> phoneNumbers = new List<string>();
            phoneNumbers.Add("09132204079");
            BulkMessage bulkMessage = new BulkMessage("Salam", phoneNumbers, "سلام");
            //Act
            var result = bulkMessageSender.Send(bulkMessage);
            //Assert
            result.Should().NotBeNull();
            result[0].Status.Should().Be(ResultStatus.Successful);
            OneStepTriggered.Should().BeTrue();
        }

        [Fact(Skip ="Will work if you config atieh correctly.")]
        public void SendList_Of_BulkMessageSender_Should_NotSend_When_NumberIsDuplicateForBulkMessage()
        {
            //Arrange
            List<string> phoneNumbers = new List<string>();
            phoneNumbers.Add("09132204079");
            BulkMessage bulkMessage = new BulkMessage("Salam", phoneNumbers, "سلام");
            bulkMessageSender.Send(bulkMessage);
            //Act
            var result = bulkMessageSender.Send(bulkMessage);
            //Assert
            result.Should().NotBeNull();
            result[0].Status.Should().Be(ResultStatus.IsDuplicate);
            OneStepTriggered.Should().BeTrue();
        }

        [Fact(Skip = "Will work if you config atieh correctly.")]
        public void SendList_Of_BulkMessageSender_Should_NotSend_When_NumberIsDuplicateWhenWeRefineItForBulkMessage()
        {
            //Arrange
            List<string> phoneNumbers = new List<string>();
            phoneNumbers.Add("09132204079");
            BulkMessage bulkMessage = new BulkMessage("Salam", phoneNumbers, "سلام");
            bulkMessageSender.Send(bulkMessage);
            //Act
            List<string> phoneNumbers2 = new List<string>();
            phoneNumbers2.Add("9132204079");
            BulkMessage bulkMessage2 = new BulkMessage("Salam", phoneNumbers2, "سلام");
            var result = bulkMessageSender.Send(bulkMessage2);
            //Assert
            result.Should().NotBeNull();
            result[0].Status.Should().Be(ResultStatus.IsDuplicate);
            OneStepTriggered.Should().BeTrue();
        }

        [Fact(Skip = "Will work if you config atieh correctly.")]
        public void SendList_Of_BulkMessageSender_Should_Send_When_NumberIsDuplicateButBulkTitleIsDifferent()
        {
            //Arrange
            List<string> phoneNumbers = new List<string>();
            phoneNumbers.Add("09132204079");
            BulkMessage bulkMessage = new BulkMessage("Salam", phoneNumbers, "سلام");
            bulkMessageSender.Send(bulkMessage);
            //Act
            BulkMessage bulkMessage2 = new BulkMessage("Ali", phoneNumbers, "علی");            
            var result = bulkMessageSender.Send(bulkMessage2);
            //Assert
            result.Should().NotBeNull();
            result[0].Status.Should().Be(ResultStatus.Successful);
            OneStepTriggered.Should().BeTrue();
        }
    }
}
