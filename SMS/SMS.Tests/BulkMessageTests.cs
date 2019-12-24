using FluentAssertions;
using SMS.Exceptions;
using SMS.ProvideSMSFeatures;
using System;
using System.Collections.Generic;
using Xunit;

namespace SMS.Tests
{
    public class BulkMessageTests
    {
        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("  ")]
        public void Constractor_of_BulkMessage_ShouldThrowException_WhenMessageIsNullOrWhiteSpace(string message)
        {
            //Arrange
            List<string> receivers = new List<string>();

            //Act
            Action validate = () => new BulkMessage(null, receivers, message);
            //Assert
            validate.Should().Throw<MessageIsEmptyException>();
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("  ")]
        public void Constractor_of_BulkMessage_ShouldThrowException_WhenTitleIsNullOrWhiteSpace(string title)
        {
            //Arrange
            List<string> receivers = new List<string>();

            //Act
            Action validate = () => new BulkMessage(title, receivers, "salam");
            //Assert
            validate.Should().Throw<MessageIsEmptyException>();
        }

        [Theory]
        [InlineData("9182712233\t")]
        [InlineData("00989132204079\t\n")]
        public void Constractor_of_BulkMessage_ShouldSetNumberToValidReceivers(string number)
        {
            //Arrange
            List<string> receivers = new List<string>();
            receivers.Add(number);

            //Act
            var bulkMessage = new BulkMessage("salam", receivers, "salam");
            //Assert
            bulkMessage.ValidReceivers.Count.Should().Be(1);
            bulkMessage.InvalidReceivers.Count.Should().Be(0);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("  ")]
        [InlineData("12 ")]
        [InlineData("77234567\t")]
        [InlineData("0098913220407\t\n")]
        public void Constractor_of_BulkMessage_ShouldSetNumberToInvalidReceivers(string number)
        {
            //Arrange
            List<string> receivers = new List<string>();
            receivers.Add(number);

            //Act
            var bulkMessage = new BulkMessage("salam", receivers, "salam");
            //Assert
            bulkMessage.ValidReceivers.Count.Should().Be(0);
            bulkMessage.InvalidReceivers.Count.Should().Be(1);
        }
    }
}
