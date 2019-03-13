using System;
using Xunit;

namespace LoggingKata.Test
{
    public class TacoParserTests
    {
        [Fact]
        public void ShouldDoSomething()
        {
            //
        }

        [Theory]
        [InlineData("0, 0, test")]
        [InlineData("-0.5, 0.5, test")]
        [InlineData("-10, 10, test")]
        [InlineData("-15, 15, test")]
        [InlineData("-20.5, 20.5, test")]

        public void ShouldParse(string str)
        {
            //Arrange
            TacoParser tacoParser = new TacoParser();
            //Act
            ITrackable result = tacoParser.Parse(str);
            //Assert
            Assert.NotNull(result);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("test, test, test")]
        [InlineData("11, fail, true")]
        [InlineData("test, 44, test")]
        [InlineData("100Test, 20, Test")]
        [InlineData("null, null, 1")]
        public void ShouldFailParse(string str)
        {
            //Arrange
            TacoParser tacoParser = new TacoParser();
            //Act
            ITrackable result = tacoParser.Parse(str);
            //Assert
            Assert.Null(result);
        }
    }
}
