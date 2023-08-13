using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Moq;
using Castle.Core.Logging;
using Microsoft.Extensions.Logging;

namespace StringManipulation.Test
{
    public class StringOperationsTest
    {
        [Fact(Skip = "Esta prueba no es valida en este momento Ticket-001")]
        public void ConcatenateStrings()
        {
            // Arrange
            var strOperations = new StringOperations();

            // Act
            var result = strOperations.ConcatenateStrings("Hello", "JCSIVO");

            // Assert
            Assert.NotNull(result);
            Assert.NotEmpty(result);
            Assert.Equal("Hello JCSIVO", result);  
        }

        [Fact]
        public void IsPalindrome_True()
        {
            // Arrange
            var strOperations = new StringOperations();

            // Act
            var result = strOperations.IsPalindrome("ama");

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsPalindrome_False()
        {
            // Arrange
            var strOperations = new StringOperations();

            // Act
            var result = strOperations.IsPalindrome("hello");

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void QuantintyInWords() 
        {
            // Arrange
            var strOperations = new StringOperations();

            // Act
            var result = strOperations.QuantintyInWords("cat", 10);

            // Assert
            Assert.StartsWith("die", result);
            Assert.Contains("cat", result);
        }
        [Fact]
        public void GetStringLength_Exception()
        {
            var strOperations = new StringOperations();

            Assert.ThrowsAny<ArgumentNullException>(()=> strOperations.GetStringLength(null));
        }

        [Theory]
        [InlineData("V", 5)]
        [InlineData("III", 3)]
        [InlineData("X", 10)]
        // [InlineData("P", -1)]
        public void FromRomanToNumber(string romanNumber, int expected)
        {
            var strOperations = new StringOperations();

            var result = strOperations.FromRomanToNumber(romanNumber);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void CountOccurrences()
        {
            var mockLogger = new Mock<ILogger<StringOperations>>();
            var strOperations = new StringOperations(mockLogger.Object);

            var result = strOperations.CountOccurrences("Hello JCSIVO", 'l');

            Assert.Equal(2, result);
        }

        [Fact]
        public void ReadFile()
        {
            var strOperations = new StringOperations();
            var mockFileReader = new Mock<IFileReaderConector>();
            mockFileReader.Setup(p => p.ReadString(It.IsAny<string>() /*"file.txt"*/)).Returns("Reading file");

            var result = strOperations.ReadFile(mockFileReader.Object, "file.txt");

            Assert.Equal("Reading file", result);
        }
    }
}
