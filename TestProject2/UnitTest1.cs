
using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
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
            Assert.True(c.Size() == 0);
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
        public void TestClear()
        {
            IRPNCalculator c = new RPNCalculator();
            Assert.True(c.Size() == 0);
            c.Push(5);
            c.Push(5);
            Assert.True(c.Size() == 2);
            c.Clear();
            Assert.True(c.Size() == 0);
        }

        [Fact]
        public void TestPop()
        {
            IRPNCalculator c = new RPNCalculator();
            Assert.True(c.Size() == 0);
            c.Push(6);
            c.Push(5);
            Assert.True(c.Size() == 2 && c.Top() == 5);
            c.Pop();
            Assert.True(c.Size() == 1 && c.Top() == 6);
        }
        
        [Theory]
        [InlineData(2, 5, 7)]
        [InlineData(5, 5, 10)]
        [InlineData(7, 7, 14)]
        public void TestAdd(double a, double b, double res)
        {
            IRPNCalculator c = new RPNCalculator();
            c.Push(a);
            c.Push(b);
            c.Add();
            Assert.True(c.Top() == res);
        }

        [Theory]
        [InlineData(5, 5, 0)]
        public void TestSub(double a, double b, double res)
        {
            IRPNCalculator c = new RPNCalculator();
            Assert.True(c.Size() == 0);
            c.Push(a);
            c.Push(b);
            Assert.True(c.Size() == 2 && c.Top() == 5);
            c.Subtract();
            Assert.True(c.Size() == 1 && c.Top() == res);
        }

        [Theory]
        [InlineData(5, 5, 25)]
        public void TestMul(double a, double b, double res)
        {
            IRPNCalculator c = new RPNCalculator();
            Assert.True(c.Size() == 0);
            c.Push(a);
            c.Push(b);
            Assert.True(c.Size() == 2 && c.Top() == 5);
            c.Multiply();
            Assert.True(c.Size() == 1 && c.Top() == res);
        }

        [Theory]
        [InlineData(5, 5, 1)]
        [InlineData(2, 5, 2.5)]
        public void TestDiv(double a, double b, double res)
        {
            IRPNCalculator c = new RPNCalculator();
            Assert.True(c.Size() == 0);
            c.Push(a);
            c.Push(b);
            Assert.True(c.Size() == 2 && c.Top() == b);
            c.Divide();
            Assert.True(c.Size() == 1 && c.Top() == res);
        }
        
        [Theory]
        [InlineData(5, 5, 5, 50)]
        [InlineData(2.5, 5, 5, 25)]
        public void TestMoreMaths(double a, double b, double c, double res)
        {
            IRPNCalculator cal = new RPNCalculator();
            Assert.True(cal.Size() == 0);
            cal.Push(a);
            cal.Push(b);
            cal.Push(c);
            Assert.True(cal.Size() == 3 && cal.Top() == 5);
            cal.Add();
            cal.Multiply();
            Assert.True(cal.Top() == res && cal.Size() == 1);
        }

        [Fact]
        public void TestDivZero()
        {
            IRPNCalculator cal = new RPNCalculator();
            Assert.True(cal.Size() == 0);
            cal.Push(0);
            cal.Push(5);
            Assert.Throws<ArgumentException>(() => cal.Divide());
            cal.Add();
            Assert.True(cal.Size() == 1);
        }
    }
}