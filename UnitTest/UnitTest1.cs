using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Test1;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Debit_WithValidAmount_UpdatesBalance()
        {
            List<ulong> ul = new List<ulong>();
            ul.Add(2);
            ul.Add(2);
            ul.Add(2);

            foreach (var i in Program.Prime(8))
                Assert.AreEqual(2, i);
        }
        [TestMethod]
        public void merge_correction()
        {
            int[] a, b;
            a = new int[1];
            b = new int[1];
            b[0] = 7;
            a[0] = 4;
            var c = Program.TwoArr(b, a);
            Assert.AreEqual(c[0], 4);
            Assert.AreEqual(c[1], 7);
            a = new int[0];
            b = new int[0];
            Assert.AreEqual(0, Program.TwoArr(a, b).Length);
            a = new int[3] { 7, 44, 88};
            b = new int[5] { 49, 50, 51, 100, 502 };
            c = Program.TwoArr(b, a);
            for (int i = 1; i < c.Length; i++)
                Assert.IsTrue(c[i] > c[i - 1]);
        }
    }
}
