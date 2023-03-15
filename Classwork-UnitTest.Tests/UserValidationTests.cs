using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_UnitTest.Tests
{
    internal class UserValidationTests
    {
        string password;
        [SetUp]
        public void Setup()
        {
            password = "qwerty";
        }

        [Test]
        public void Test_UserValidation_EncryptPassword()
        {
            // Arrange
            string expectedPassword = "rxfsuz";

            // Act
            string actualPassword = UserValidation.EncryptPassword(password);

            // Assert
            Assert.AreEqual(expectedPassword, actualPassword);
        }

        [Test]
        public void Test_UserValidation_ReturnToBeginingCharacter()
        {
            // Arrange
            string expectedPassword = "yza";

            // Act
            string actualPassword = UserValidation.EncryptPassword("xyz");

            // Assert
            Assert.AreEqual(expectedPassword, actualPassword);
        }

        [Test]
        public void Test_UserValidation_DistantiateBetweenLowerAndUpperCase()
        {
            // Arrange
            string expectedPassword = "aAbBcCdDeEfFgGhHiIjJkKlLmMnNoOpPqQrRsStTuUvVwWxXyYzZ";

            // Act
            string actualPassword = UserValidation.EncryptPassword("zZaAbBcCdDeEfFgGhHiIjJkKlLmMnNoOpPqQrRsStTuUvVwWxXyY");

            Assert.AreEqual(expectedPassword, actualPassword);
        }
    }
}
