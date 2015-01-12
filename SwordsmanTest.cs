using ConsoleDrivenBattleGame;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SwordsmanTest
{
    
    
    /// <summary>
    ///This is a test class for getIdTest and is intended
    ///to contain all getIdTest Unit Tests
    ///</summary>
    [TestClass()]
    public class SwordsmanTest
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
        /// A test for Swordsman Constructor
        ///</summary>
        [TestMethod()]
        public void SwordsmanConstructorTest()
        {
            int id = 0;

            Swordsman target = new Swordsman(id);

            Assert.AreEqual(id, target.getId());
        }

        /// <summary>
        /// A test for the To String method in Swordsman
        ///</summary>
        [TestMethod()]
        public void ToStringTest()
        {
            int id = 0;
            Swordsman target = new Swordsman(id);

            Assert.AreEqual("Swordsman 0, NONE, SWORD", target.ToString());
        }
    }
}
