
using System.Runtime.InteropServices;
using PairProgramming;
using Xunit;

namespace TestProject2
{
    public class UnitTest1
    {
        [Fact]
        public void TestInitSize()
        {
            IRPNCalculator c = new RPNCalculator();
            Assert.True(c.Size() == 0);
        }

        [Fact]
        public void TestPush()
        {
            IRPNCalculator c = new RPNCalculator();
            c.Push(5);
            Assert.True(c.Size() == 1);
        }

        [Fact]
        public void TestPushAndTop()
        {
            IRPNCalculator c = new RPNCalculator();
            c.Push(5);
            Assert.True(c.Top() == 5);
        }

        [Fact]
        public void TestAdd()
        {
            IRPNCalculator c = new RPNCalculator();
            c.Push(5);
            c.Push(5);
            c.Add();
            Assert.True(c.Top() == 10);
        }
    }
}