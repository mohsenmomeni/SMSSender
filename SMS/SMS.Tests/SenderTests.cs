using System;
using Xunit;
using FluentAssertions;
using SMS.Exceptions;
using Castle.Windsor;
using Castle.MicroKernel.Registration;
using AtiehSMSFacilitator;
using SMS.ProvideSMSFeatures;

namespace SMS.Tests
{
    public class SenderTests
    {
        private ISMSProvider sender;

        public SenderTests()
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
            sender = container.Resolve<ISMSProvider>();
        }

        [Fact]
        public void SendSimple_Of_Sender_Should_Throw_Exception_When_PhoneNumber_IsNull()
        {
            //Act            
            Action action = () => sender.SendSimple(new SimpleMessage(null, null));
            //Assert
            action.Should().Throw<ArgumentException>();
        }

        [Fact]
        public void Inbox_Of_Sender_Should_Throw_Exception_When_PhoneNumber_IsNull()
        {
            var result = sender.Inbox();
            result.Should().BeNull();
        }

        [Fact]
        public void SendSimple_Of_Sender_Should_Throw_Exception_When_PhoneNumber_IsNotValid()
        {
            //Act
            Action action = () => sender.SendSimple(new SimpleMessage("09123456i32", null));
            //Assert
            action.Should().Throw<PhoneNumberInvalidException>();
        }

        [Fact]
        public void SendSimple_Of_Sender_Should_Throw_Exception_When_Message_Is_NullOrEmpty()
        {
            //Act
            Action action = () => sender.SendSimple(new SimpleMessage("09123456132", null));
            //Assert
            action.Should().Throw<MessageIsEmptyException>();
        }

        [Fact(Skip ="It will send sms")]
        public void SendSimple_Of_Sender_Should_Send_When_EveryThingIsOk()
        {
            //Act
            var result = sender.SendSimple(new SimpleMessage("09132204079", "سلام"));
            //Assert
            result.Status.Should().Be(ResultStatus.Successful);
        }
    }
}
