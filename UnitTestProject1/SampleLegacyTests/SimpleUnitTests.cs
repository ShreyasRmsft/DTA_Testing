﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SampleLegacyTests
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class UnitTest1
    {
        private TestContext _testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return _testContextInstance;
            }
            set
            {
                _testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void PassingTestInLegacyMode()
        {
           var process = System.Diagnostics.Process.GetCurrentProcess().ProcessName;
           Assert.IsTrue( process.IndexOf("QTagent", StringComparison.OrdinalIgnoreCase) >= 0,"this test will pass only when it runs in legacy mode");            
        }


        [TestMethod]
        public void PassingTestInRockSteadyMode()
        {
            var process = System.Diagnostics.Process.GetCurrentProcess().ProcessName;
            Assert.IsTrue(process.IndexOf("Vstest", StringComparison.OrdinalIgnoreCase) >= 0, "this test will pass only when it runs in rocksteady mode");
        }
    }
}
