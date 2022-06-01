using System;
using Xunit;

namespace ConsoleApp.Test
{
    public class BaconTest
    {
        [Fact]
        public void TestNoTwoBaconsAreEqual()
        {
            // arrange 
            // act
            var bacon = new BaconDto();
            var bacon_two = new BaconDto();
            // Assert

            Assert.NotEqual(bacon, bacon_two);

        }

        [Fact]
        public void TestSameBaconsAreEqual()
        {
            // arrange 
            // act
            var bacon = new BaconDto();

            Assert.Equal(bacon, bacon);

        }
    }
}
