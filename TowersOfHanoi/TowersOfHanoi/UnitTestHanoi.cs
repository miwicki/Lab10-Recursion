using System;
using Xunit;
using TowersOfHanoi;

namespace XUnitTestHanoi
{
    public class UnitTest1
    {
        [Theory]
        [InlineData (3, 7)]
        [InlineData (4, 15)]
        [InlineData (5, 31)]
       
        public void TestRecursion(int n, int moves)
        {
            Assert.Equal(moves, Program.Hanoi(n));
        }

        [Theory]
        [InlineData(3, 7)]
        [InlineData(4, 15)]
        [InlineData(5, 31)]
       
        public void TestIterative(int n, int moves)
        {
            Assert.Equal(moves, Program.Hanoi2(n));
        }
    }
}