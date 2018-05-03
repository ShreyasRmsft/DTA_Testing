﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodedUITestProject3
{
    [CodedUITest]
    public class CodedUITest2
    {
        [TestMethod]
        public void CodedUITest21()
        {
            //Always pass
        }

        [TestMethod]
        public void CodedUITest22()
        {
            //Always pass
        }

        [TestMethod]
        public void CodedUITest23()
        {
            //Always pass
        }

        [TestMethod]
        public void CodedUITest24()
        {
            //Always pass
        }

        [TestMethod]
        public void CodedUITest25()
        {
            //Always pass
        }

        [TestMethod]
        public void CodedUITest26()
        {
            //Always pass
        }

        #region Additional test attributes

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

        private static string tempFile;
        private UIMap map;
    }
}
