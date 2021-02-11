using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assig1TestProject;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assig1TestProject.Tests
{
    [TestClass()]
    public class TestCaseTests
    {
        TestCase tc = new TestCase();
        [TestMethod()]
        public void GetLengthTest()
        {
            Assert.AreEqual(10, tc.GetLength());
        }

        [TestMethod()]
        public void SetLengthTest()
        {
            Assert.AreEqual(10, tc.SetLength(10));
        }

        [TestMethod()]
        public void GetWidthTest()
        {
            Assert.AreEqual(20, tc.GetWidth());
        }

        [TestMethod()]
        public void SetWidthTest()
        {
            Assert.AreEqual(20, tc.SetWidth(20));
        }

        [TestMethod()]
        public void GetPerimeterTest()
        {
            Assert.AreEqual(60, tc.GetPerimeter());
        }

        [TestMethod()]
        public void GetAreaTest()
        {
            Assert.AreEqual(60, tc.GetPerimeter());
        }
    }
}