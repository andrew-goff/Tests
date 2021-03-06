﻿using ConsoleDrivenBattleGame;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using EnemyFighters;

namespace WizardTest
{
    
    
    /// <summary>
    ///This is a test class for WizardTest and is intended
    ///to contain all WizardTest Unit Tests
    ///</summary>
    [TestClass()]
    public class WizardTest
    {


        private TestContext testContextInstance;

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

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


  

        /// <summary>
        /// A test for the Wizard Constructor
        ///</summary>
        [TestMethod()]
        public void WizardConstructorTest()
        {
            int id = 0;

            Wizard target = new Wizard(id);

            Assert.AreEqual(id, target.getId());
        }

        /// <summary>
        /// A test for the ToString method in Wizard
        /// </summary>
        [TestMethod()]
        public void ToStringTest()
        {
            int id = 0; // TODO: Initialize to an appropriate value
            Wizard target = new Wizard(id); // TODO: Initialize to an appropriate value

            Assert.AreEqual("Wizard 0, INVISIBILITY, SWORD", target.ToString());
        }
    }
}
