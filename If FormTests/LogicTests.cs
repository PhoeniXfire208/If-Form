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
            int result = Logic.Cmax(mas);
            Assert.AreEqual(3, result);
        }

        [TestMethod()]
        public void CmaxTest2()
        {
            int[] mas = { 3, 2, 1 };
            int result = Logic.Cmax(mas);
            Assert.AreEqual(3, result);
        }

        [TestMethod()]
        public void CmaxTest3()
        {
            int[] mas = { 1, 3, 2 };
            int result = Logic.Cmax(mas);
            Assert.AreEqual(3, result);
        }

        [TestMethod()]
        public void CmaxTest4()
        {
            int[] mas = { -1, 0, -3 };
            int result = Logic.Cmax(mas);
            Assert.AreEqual(0, result);
        }

        [TestMethod()]
        public void CmaxTest5()
        {
            int[] mas = { -1, -2, -3 };
            int result = Logic.Cmax(mas);
            Assert.AreEqual(-1, result);
        }

        [TestMethod()]
        public void CmaxTest6()
        {
            int[] mas = { -3, -2, -1 };
            int result = Logic.Cmax(mas);
            Assert.AreEqual(-1, result);
        }

        [TestMethod()]
        public void SeparateTest()
        {
            int x = 123;
            int[] mas = new int[3];
            int[] ma = new int[3] { 1, 2, 3 };
            Logic.Separate(x, mas);
            for (int i = 0; i < ma.Length; i++)
            {
                Assert.AreEqual(ma[i], mas[i]);
            }
        }

        [TestMethod()]
        public void SeparateTest2()
        {
            int x = 321;
            int[] mas = new int[3];
            int[] ma = new int[3] { 3, 2, 1 };
            Logic.Separate(x, mas);
            for (int i = 0; i < ma.Length; i++)
            {
                Assert.AreEqual(ma[i], mas[i]);
            }
        }

        [TestMethod()]
        public void SeparateTest3()
        {
            int x = -123;
            int[] mas = new int[3];
            int[] ma = new int[3] { -1, -2, -3 };
            Logic.Separate(x, mas);
            for (int i = 0; i < ma.Length; i++)
            {
                Assert.AreEqual(ma[i], mas[i]);
            }
        }

        [TestMethod()]
        public void CompareTest()
        {
            int x = 123;
            var A = Logic.Compare(x);
            Assert.AreEqual("Самая большая цифра:\n" + 3, A);
        }

        [TestMethod()]
        public void CompareTest2()
        {
            int x = 321;
            var A = Logic.Compare(x);
            Assert.AreEqual("Самая большая цифра:\n" + 3, A);
        }

        [TestMethod()]
        public void CompareTest3()
        {
            int x = -321;
            var A = Logic.Compare(x);
            Assert.AreEqual("Самая большая цифра:\n" + -1, A);
        }

        [TestMethod()]
        public void CompareTest4()
        {
            int x = -123;
            var A = Logic.Compare(x);
            Assert.AreEqual("Самая большая цифра:\n" + -1, A);
        }

        [TestMethod()]
        public void CompareTest5()
        {
            int x = -103;
            var A = Logic.Compare(x);
            Assert.AreEqual("Самая большая цифра:\n" + 0, A);
        }
    }
}