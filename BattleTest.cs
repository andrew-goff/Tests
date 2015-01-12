using ConsoleDrivenBattleGame;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using EnemyFighters;
using System.Collections.Generic;

namespace Tests
{
    
    
    /// <summary>
    ///This is a test class for BattleTest and is intended
    ///to contain all BattleTest Unit Tests
    ///</summary>
    [TestClass()]
    public class BattleTest
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

        Battle target = new Battle(0);

        /// <summary>
        /// A test for creating the enemy army
        ///</summary>
        [TestMethod()]
        public void createEnemyTest()
        {
            int count = 10;
            List<IFighter> enemy;
            List<IFighter> friend;

            target.create(count, out enemy, out friend);

            Assert.AreEqual(count, enemy.Count);
            Assert.AreEqual(count, friend.Count);
        }

        /// <summary>
        /// A test for creating the friendly army
        ///</summary>
        [TestMethod()]
        public void fightTestEnemyWin()
        {
            int enemyWins;
            int friendlyWins;
            List<IFighter> enemy = new List<IFighter>(2);
            List<IFighter> friend = new List<IFighter>(2);

            enemy.Add(new FriendlyFighter(0, Weapon.SWORD, Magic.NONE));
            friend.Add(new FriendlyFighter(0, Weapon.NONE, Magic.NONE));

            target.fight(enemy, friend, out enemyWins, out friendlyWins);

            Assert.AreEqual(enemyWins, 1);
            Assert.AreEqual(friendlyWins, 0);
        }

        [TestMethod()]
        public void fightTestFriendWin()
        {
            int enemyWins;
            int friendlyWins;
            List<IFighter> enemy = new List<IFighter>(2);
            List<IFighter> friend = new List<IFighter>(2);

            enemy.Add(new FriendlyFighter(0, Weapon.NONE, Magic.NONE));
            friend.Add(new FriendlyFighter(0, Weapon.FIRE, Magic.NONE));

            target.fight(enemy, friend, out enemyWins, out friendlyWins);

            Assert.AreEqual(enemyWins, 0);
            Assert.AreEqual(friendlyWins, 1);
        }

        [TestMethod()]
        public void fightTestDraw()
        {
            int enemyWins;
            int friendlyWins;
            List<IFighter> enemy = new List<IFighter>(2);
            List<IFighter> friend = new List<IFighter>(2);

            friend.Add(new FriendlyFighter(0, Weapon.SWORD, Magic.NONE));
            enemy.Add(new FriendlyFighter(0, Weapon.NONE, Magic.NONE));
            

            friend.Add(new FriendlyFighter(1, Weapon.NONE, Magic.NONE));
            enemy.Add(new FriendlyFighter(1, Weapon.SWORD, Magic.NONE));
            

            target.fight(enemy, friend, out enemyWins, out friendlyWins);

            Assert.AreEqual(enemyWins, 2);
            Assert.AreEqual(friendlyWins, 1);
        }

        /// <summary>
        /// A test for getting the combat results
        /// </summary>
        [TestMethod()]
        public void CombatResultSwordNone()
        {
            int id = 0;

            FriendlyFighter friend = new FriendlyFighter(id, Weapon.NONE, Magic.NONE);
            FriendlyFighter enemy = new FriendlyFighter(id, Weapon.SWORD, Magic.NONE);

            bool result = target.getCombatResult(friend, enemy);

            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void CombatResultNoneSword()
        {
            int id = 0;

            FriendlyFighter friend = new FriendlyFighter(id, Weapon.SWORD, Magic.NONE);
            FriendlyFighter enemy = new FriendlyFighter(id, Weapon.NONE, Magic.NONE);

            bool result = target.getCombatResult(friend, enemy);

            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void CombatResultSwordSword()
        {
            int id = 0;

            FriendlyFighter friend = new FriendlyFighter(id, Weapon.SWORD, Magic.NONE);
            FriendlyFighter enemy = new FriendlyFighter(id, Weapon.SWORD, Magic.NONE);

            bool result = target.getCombatResult(friend, enemy);

            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void CombatResultFireNone()
        {
            int id = 0;

            FriendlyFighter friend = new FriendlyFighter(id, Weapon.NONE, Magic.NONE);
            FriendlyFighter enemy = new FriendlyFighter(id, Weapon.FIRE, Magic.NONE);

            bool result = target.getCombatResult(friend, enemy);

            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void CombatResultNoneFire()
        {
            int id = 0;

            FriendlyFighter friend = new FriendlyFighter(id, Weapon.FIRE, Magic.NONE);
            FriendlyFighter enemy = new FriendlyFighter(id, Weapon.NONE, Magic.NONE);

            bool result = target.getCombatResult(friend, enemy);

            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void CombatResultFireFire()
        {
            int id = 0;

            FriendlyFighter friend = new FriendlyFighter(id, Weapon.FIRE, Magic.NONE);
            FriendlyFighter enemy = new FriendlyFighter(id, Weapon.FIRE, Magic.NONE);

            bool result = target.getCombatResult(friend, enemy);

            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void CombatResultInvisibilityNone()
        {
            int id = 0;

            FriendlyFighter friend = new FriendlyFighter(id, Weapon.NONE, Magic.NONE);
            FriendlyFighter enemy = new FriendlyFighter(id, Weapon.NONE, Magic.INVISIBILITY);

            bool result = target.getCombatResult(friend, enemy);

            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void CombatResultNoneInvisibility()
        {
            int id = 0;

            FriendlyFighter friend = new FriendlyFighter(id, Weapon.NONE, Magic.INVISIBILITY);
            FriendlyFighter enemy = new FriendlyFighter(id, Weapon.NONE, Magic.NONE);

            bool result = target.getCombatResult(friend, enemy);

            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void CombatResultInvisibilityInvisibility()
        {
            int id = 0;

            FriendlyFighter friend = new FriendlyFighter(id, Weapon.NONE, Magic.INVISIBILITY);
            FriendlyFighter enemy = new FriendlyFighter(id, Weapon.NONE, Magic.INVISIBILITY);

            bool result = target.getCombatResult(friend, enemy);

            Assert.IsTrue(result);
        }

        /// <summary>
        /// A test for printing out statistics
        ///</summary>
        [TestMethod()]
        public void statisticsTest()
        {
            List<IFighter> enemy = new List<IFighter>();

            IFighter firstEnemy = new Enemy(1);
            IFighter lastEnemy = new Enemy(2);

            firstEnemy.loose();
            lastEnemy.win();
            enemy.Add(firstEnemy);
            enemy.Add(lastEnemy);
            
            IFighter bestEnemy;
            IFighter worstEnemy;
            
            target.statistics(enemy, out bestEnemy, out worstEnemy);

            Assert.AreEqual(bestEnemy, lastEnemy);
            Assert.AreEqual(worstEnemy, firstEnemy);
        }
    }
}
