using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PairProgramming;

namespace TestProject1
{
    [TestClass]
    public class BagSortTest
    {
        [TestMethod]
        public void TestAdd()
        {
            IBagSort b = new BagSort();
            List<int> test = new List<int>()
            {
                5, 6, 1
            };
            b.AddInt(9, test);
            Assert.IsTrue(test.Count == 4);
        }

        [TestMethod]
        public void TestRemove()
        {
            IBagSort b = new BagSort();
            List <int> l = new List<int>()
            {
                1, 2, 3, -9, -5
            };
            b.RemoveInt(l);
            Assert.IsTrue(l.Count == 4);
        }

        [TestMethod]
        public void TestGet()
        {
            IBagSort b = new BagSort();
            List <int> l = new List<int>()
            {
                1, 2, 3, -9, -5
            };
            Assert.IsTrue(b.GetInt(l) == -9);
        }

        [TestMethod]
        public void TestCount()
        {
            IBagSort b = new BagSort();
            List <int> l = new List<int>()
            {
                1, 2, 3, -9, -5
            };
            Assert.IsTrue(b.Count(l) == 5);
        }
    }
}