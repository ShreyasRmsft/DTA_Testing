using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace CodedUITestProject3
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class CodedUITest1
    {
        private static int _value = 0;

        public CodedUITest1()
        {
        }

        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(_value % 2 == 0);
            _value++;
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.IsTrue(_value % 2 == 0);
            _value++;
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.IsTrue(_value % 2 == 0);
            _value++;
        }

        [TestMethod]
        public void TestMethod4()
        {
            Assert.IsTrue(_value % 2 == 0);
            _value++;
        }

        [TestMethod]
        public void TestMethod5()
        {
            //Always pass
        }

        [TestMethod]
        public void TestMethod6()
        {
            //Always pass
        }

        #region Additional test attributes

        // You can use the following additional attributes as you write your tests:

        ////Use TestInitialize to run code before running each test 
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        ////Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        #endregion

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        private TestContext testContextInstance;

        public UIMap UIMap
        {
            get
            {
                if (this.map == null)
                {
                    this.map = new UIMap();
                }

                return this.map;
            }
        }

        private UIMap map;
    }
}
