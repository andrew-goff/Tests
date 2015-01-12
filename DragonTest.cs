using ConsoleDrivenBattleGame;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using EnemyFighters;

namespace DragonTest
{
    /// <summary>
    ///This is a test class for DragonTest and is intended
    ///to contain all DragonTest Unit Tests
    ///</summary>
    [TestClass]
    public class DragonTest
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
        /// A test for the Dragon Constructor
        /// </summary>
        [TestMethod()]
        public void DragonConstructorTest()
        {
            int id = 0;

            Dragon target = new Dragon(id);

            Assert.AreEqual(id, target.getId());
        }

        /// <summary>
        /// A test for the ToString method in Dragon
        /// </summary>
        [TestMethod()]
        public void ToStringTest()
        {
            int id = 0; // TODO: Initialize to an appropriate value
            Dragon target = new Dragon(id); // TODO: Initialize to an appropriate value

            Assert.AreEqual("Dragon 0, NONE, FIRE", target.ToString());
        }
    }
}
