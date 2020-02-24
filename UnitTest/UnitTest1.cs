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
    }
}
