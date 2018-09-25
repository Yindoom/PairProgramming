using System.Globalization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PairProgramming;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodSuccess()
        {
            IMerge m = new MergeImpl();
            int[] a = new[] {1, 5, 7, 90};
            int[] b = new[] {99999, 666};
            int[] test = new int[6];

        Assert.IsTrue(test.Length == m.Merge(a, b).Length);
        }

        [TestMethod]
        public void TestMethodFail()
        {
            IMerge m = new MergeImpl();
            int[] a = new[] {1, 5, 7, 90};
            int[] b = new[] {99999, 666};
            int[] test = new int[65];

            Assert.IsFalse(test.Length == m.Merge(a, b).Length);
        }

        [TestMethod]
        public void TestSortSuccess()
        {
            IMerge m = new MergeImpl();
            int[] a = new[] {7, 5, 7, 90, 99999, 666, 3};
            int[] test = new[] {3, 5, 7, 7, 90, 666, 99999};
            var sorted = m.SortMerge(a);
            
            for (int i = 0; i < test.Length; i++)
            {
                Assert.IsTrue(test[i] == sorted[i]);                
            }
        }

        [TestMethod]
        public void TestClassSuccess()
        {
            IMerge m = new MergeImpl();
            int[] a = new[] {90, 7, 1, 5};
            int[] b = new[] {99999, 666, 15, 60, 2, 2, 2};
            int[] test = new[] {1, 2, 2, 2, 5, 7, 15, 60, 90, 666, 99999};
            var sorted = m.Merge(a, b);
            
            for (int i = 0; i < test.Length; i++)
            {
                Assert.IsTrue(test[i] == sorted[i]);                
            }
        }
    }
}