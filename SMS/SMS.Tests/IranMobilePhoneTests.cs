using FluentAssertions;
using SMS.Exceptions;
using System;
using Xunit;

namespace SMS.Tests
{

    public class IranMobilePhoneTests
    {
        [Fact]
        public void IsValid_Of_IranMobilePhone_ShouldThrowException_WhenPhoneNumberIsNull()
        {
            //Arrange
            IranMobilePhone phoneService = new IranMobilePhone();
            //Act
            Action validate = () => phoneService.IsValid(null);
            //Assert
            validate.Should().Throw<ArgumentException>();
        }

        [Theory]
        [InlineData("91322040790")]
        [InlineData("091322040790")]
        [InlineData("+9809132204079")]
        [InlineData("09+21234450")]
        [InlineData("09er1234450")]
        public void IsValid_Of_IranMobilePhone_ShouldreturnFalse_WhenHasInvalidPhoneNumberLength(string entry)
        {
            //Arrange
            IranMobilePhone phoneService = new IranMobilePhone();
            //Act
            var result = phoneService.IsValid(entry);
            //Assert
            result.Should().BeFalse();
        }

        [Theory]
        [InlineData("9132204079")]
        [InlineData("09132204079")]
        [InlineData("00989132204079")]
        [InlineData("+989132204079")]
        public void IsValid_Of_IranMobilePhone_ShouldreturnTrue_WhenItIsCorrect(string entry)
        {
            //Arrange
            IranMobilePhone phoneService = new IranMobilePhone();
            //Act
            var result = phoneService.IsValid(entry);
            //Assert
            result.Should().BeTrue();
        }
        
        [Theory]
        [InlineData("9132204079", "989132204079")]
        public void 
            AddCountryCode_Of_IranMobilePhone_ShouldreturnTrue_WhenItIsCorrectAndHasPlus(string entry, string result)
        {
            //Arrange
            IranMobilePhone phone = new IranMobilePhone();
            //Act
            var answer = phone.AddCountryCode(entry);
            //Assert
            answer.Should().Be(result);
        }

        [Theory]
        [InlineData("91322024030")]
        [InlineData("091322024030")]
        [InlineData("009891322024030")]
        [InlineData("+9891322024030")]
        [InlineData("9891322024030")]
        public void
            AddCountryCode_Of_IranMobilePhone_Should_ThrowException_WhenNumberIsWrong(string entry)
        {
            //Arrange
            IranMobilePhone phoneService = new IranMobilePhone();
            //Act
            Action validate = () => phoneService.AddCountryCode(entry);
            //Assert
            validate.Should().Throw<PhoneNumberInvalidException>();
        }

        [Theory]
        [InlineData("9132204079\t", "9132204079")]
        [InlineData("+989132204079\t\n", "9132204079")]
        [InlineData("0098913nnn2204079", "9132204079")]
        [InlineData("09132204079\t", "9132204079")]
        [InlineData("989132\t\n204079", "9132204079")]
        public void RefineNumber_Of_IranMobilePhone_ShouldCorrectIt_WhenItHasInCorrectNess(string entry, string result)
        {
            //Arrange
            IranMobilePhone phone = new IranMobilePhone();
            //Act
            var answer = phone.RefineNumber(entry);
            //Assert
            answer.Should().Be(result);
        }

        [Theory]
        [InlineData("9132204079\t", "989132204079")]
        [InlineData("+989132204079\t\n", "989132204079")]
        [InlineData("0098913nnn2204079", "989132204079")]
        [InlineData("09132204079\t", "989132204079")]
        [InlineData("989132\t\n204079", "989132204079")]        
        public void RefineNumberAndAddCountryCode_Of_IranMobilePhone_ShouldCorrectIt_WhenItHasInCorrectNess(string entry, string result)
        {
            //Arrange
            IranMobilePhone phone = new IranMobilePhone();
            //Act
            var answer = phone.RefineNumberAndAddCountryCode(entry);
            //Assert
            answer.Should().Be(result);
        }
    }
}
