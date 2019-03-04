using System;
using Xunit;

namespace LoggingKata.Test
{
    public class TacoParserTests
    {
        [Fact]
        public void ShouldDoSomething()
        {
            // TODO: Complete Something, if anything
        }

        [Theory]
        [InlineData("0, 0, test")]
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
        [InlineData("")]
        public void ShouldFailParse(string str)
        {
            TacoParser tacoParser = new TacoParser();

            ITrackable result = tacoParser.Parse(str);

            Assert.Null(result);
        }
    }
}
