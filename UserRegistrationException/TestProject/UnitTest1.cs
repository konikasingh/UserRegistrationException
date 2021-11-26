using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistrationException;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ValidFirstNameOfUser()
        {
            //AAA method
            //Arrange
            string message = " ";
            string expected = "invalid";
            //creating object of moodanalyzer class and passing message
            UserException exception = new UserException(message);

            //Act
            string actual = exception.ValidFirstName();

            //Assert
            //comparing actual and expected value
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ValidLastNameOfUser()
        {
            //AAA method
            //Arrange
            string message = " ";
            string expected = "invalid";
            //creating object of moodanalyzer class and passing message
            UserException exception = new UserException(message);

            //Act
            string actual = exception.ValidLastName();

            //Assert
            //comparing actual and expected value
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ValidEmailIdOfUser()
        {
            //AAA method
            //Arrange
            string message = " ";
            string expected = "invalid";
            //creating object of moodanalyzer class and passing message
            UserException exception = new UserException(message);

            //Act
            string actual = exception.EmailIdValid();

            //Assert
            //comparing actual and expected value
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ValidMobileNumOfUser()
        {
            //AAA method
            //Arrange
            string message = " ";
            string expected = "valid";
            //creating object of moodanalyzer class and passing message
            UserException exception = new UserException(message);

            //Act
            string actual = exception.MobileNumValid();

            //Assert
            //comparing actual and expected value
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ValidPasswordOfUser()
        {
            //AAA method
            //Arrange
            string message = " ";
            string expected = "invalid";
            //creating object of moodanalyzer class and passing message
            UserException exception = new UserException(message);

            //Act
            string actual = exception.ValidPassword();

            //Assert
            //comparing actual and expected value
            Assert.AreEqual(expected, actual);
        }
    }
}