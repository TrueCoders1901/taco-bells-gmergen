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
        [InlineData("Example")]
        public void ShouldParse(string str)
        {
            // TODO: Complete Should Parse
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("not a number,0.0,Taco Bell Test")]
        [InlineData("0.0,not a number,Taco Bell Test")]
        [InlineData("0.0,0.0,Taco Bell Test")]
        [InlineData("-10.0,10.0,Taco Bell Test")]
        public void ShouldFailParse(string str)
        {
            // TODO: Complete Should Fail Parse
        }
    }
}
