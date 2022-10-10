using Microsoft.VisualStudio.TestTools.UnitTesting;
using If_Form.Program;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_Form.Program.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        public void CmaxTest()
        {
            int[] mas = { 1, 2, 3 };
            int result = Program.Logic.Cmax(mas);
            Assert.AreEqual(3, result);
        }

        [TestMethod()]
        public void SeparateTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void CompareTest()
        {
            Assert.Fail();
        }
    }
}