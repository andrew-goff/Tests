using ConsoleDrivenBattleGame;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using EnemyFighters;

namespace FriendlyFighterTest
{
    
    
    /// <summary>
    ///This is a test class for FriendlyFighterTest and is intended
    ///to contain all FriendlyFighterTest Unit Tests
    ///</summary>
    [TestClass()]
    public class FriendlyFighterTest
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
        ///A test for getWeapon
        ///</summary>
        [TestMethod()]
        public void getWeaponTest()
        {
            int id = 0;

            FriendlyFighter target = new FriendlyFighter(id, Weapon.FIRE, Magic.NONE);

            Assert.AreEqual(Weapon.FIRE, target.getWeapon());
        }

        /// <summary>
        ///A test for getMagic
        ///</summary>
        [TestMethod()]
        public void getMagicTest()
        {
            int id = 0;
            Weapon pweapon = Weapon.SWORD; // TODO: Initialize to an appropriate value
            Magic pmagic = Magic.INVISIBILITY; // TODO: Initialize to an appropriate value

            FriendlyFighter target = new FriendlyFighter(id, pweapon, pmagic); // TODO: Initialize to an appropriate value
            
            Magic actual = target.getMagic();

            Assert.AreEqual(pmagic, actual);
        }

        /// <summary>
        ///A test for getId
        ///</summary>
        [TestMethod()]
        public void getIdTest()
        {
            int id = 0;
            Weapon pweapon = Weapon.SWORD; // TODO: Initialize to an appropriate value
            Magic pmagic = Magic.NONE; // TODO: Initialize to an appropriate value

            FriendlyFighter target = new FriendlyFighter(id, pweapon, pmagic); // TODO: Initialize to an appropriate value

            int actual;

            actual = target.getId();

            Assert.AreEqual(id, actual);
            
        }

        /// <summary>
        ///A test for FriendlyFighter Constructor
        ///</summary>
        [TestMethod()]
        public void FriendlyFighterConstructorTest()
        {
            int id = 0;
            Weapon pweapon = Weapon.FIRE; // TODO: Initialize to an appropriate value
            Magic pmagic = Magic.INVISIBILITY; // TODO: Initialize to an appropriate value

            FriendlyFighter target = new FriendlyFighter (id, pweapon, pmagic);

            Assert.AreEqual("0, INVISIBILITY, FIRE", target.ToString());
        }

    }
}
