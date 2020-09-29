using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UltraDungeonBattle;

namespace UDBattle_Tests
{
    [TestClass]
    public class Setup_Tests
    {
        private PlayerRepo _repo;
        private Player _player;

        [TestInitialize]
        public void Arrange()
        {
            _repo = new PlayerRepo();
            _player = new Player("Bobby",Races.Dwarf,Classes.Mage);
        }
        [TestMethod]
        public void GetPlayerHealth_ShouldReturnCorrectNumber()
        {
            _player.Health = 135;
            _repo.AddPlayerToDirectory(_player);
            Console.WriteLine(_player.Health);
        }

        [TestMethod]
        public void DisplayHumanKnightStats_ShouldShowCorrectStats()
        {
            Player fakePlayer = new Player();
            fakePlayer.PlayerName = "Kevin";
            fakePlayer.RaceName = Races.Human;
            fakePlayer.ClassName = Classes.Knight;

            Console.WriteLine(fakePlayer.PlayerName);
            Console.WriteLine(fakePlayer.RaceName);
            Console.WriteLine(fakePlayer.ClassName);
            Console.WriteLine(fakePlayer.Health);
            Console.WriteLine(fakePlayer.AttackPower);
            Console.WriteLine(fakePlayer.MagicPower);
            Console.WriteLine(fakePlayer.DamageResistance);
            Console.WriteLine(fakePlayer.MagicResistance);
            Console.WriteLine(fakePlayer.IsAlive);

        }
        [TestMethod]
        public void GetPlayerByNameTest_ShouldReturnCorrectName()
        {
/*            _player.PlayerName = "Bobby";
            _player.MagicPower = 51;
*/            _repo.AddPlayerToDirectory(_player);

/*            string p1Name = _player.PlayerName;
*/
            _repo.GetPlayerByName(_player.PlayerName);

            Assert.AreEqual("Bobby", _player.PlayerName);

            Console.WriteLine(_player.PlayerName);

            Console.WriteLine(_player.MagicPower);
        }

        [TestMethod]
        public void TestAttackWithWeapon()
        {
            _player.AttackPower = 16;
            _repo.AddPlayerToDirectory(_player);

            Console.WriteLine(_repo.AttackWithWeapon(_player.PlayerName, _player));
            Console.WriteLine(_player.PlayerName);
            Console.WriteLine(_player.AttackPower);
        }
        [TestMethod]
        public void TestDefendAgainstMagic()
        {
            _player.MagicResistance = 15;
            _repo.AddPlayerToDirectory(_player);

            Console.WriteLine(_repo.DefendAgainstMagic(_player.PlayerName, _player));
            Console.WriteLine(_player.PlayerName);
            Console.WriteLine(_player.MagicResistance);
        }
        [TestMethod]
        public void TestDefendAgainstWeapon()
        {
            _player.DamageResistance = 18;
            _repo.AddPlayerToDirectory(_player);

            Console.WriteLine(_repo.DefendAgainstWeapon(_player.PlayerName, _player));
            Console.WriteLine(_player.PlayerName);
            Console.WriteLine(_player.DamageResistance);
        }
        [TestMethod]
        public void TestWeaponDamagetoHealth()
        {
            Player attacker = new Player("Dave", Races.Human, Classes.Knight);
            Player defender = new Player("Steve-O", Races.Dwarf, Classes.Mage);

            attacker.AttackPower = 21;
            defender.DamageResistance = 9;
            defender.Health = 100;

            _repo.AddPlayerToDirectory(attacker);
            _repo.AddPlayerToDirectory(defender);

            Console.WriteLine($"{attacker.PlayerName} starts with attack of {attacker.AttackPower}.");
            Console.WriteLine($"{attacker.PlayerName} rolls, and now has attack value of {_repo.AttackWithWeapon(attacker.PlayerName, attacker)}.");
            Console.WriteLine();
            Console.WriteLine($"{defender.PlayerName} starts with defense of {defender.DamageResistance}.");
            Console.WriteLine($"{defender.PlayerName} rolls, and now has defense value of {_repo.DefendAgainstWeapon(defender.PlayerName, defender)}.");
            Console.WriteLine();

            Console.WriteLine(_repo.CombatWeapon(attacker.PlayerName,  defender.PlayerName));
            Console.WriteLine();
            Console.WriteLine(_repo.WeaponDamageToHealth(attacker.PlayerName, defender.PlayerName, defender));
            //next iteration
            Thread.Sleep(1000);
            Console.WriteLine($"{attacker.PlayerName} starts with attack of {attacker.AttackPower}.");
            Console.WriteLine($"{attacker.PlayerName} rolls, and now has attack value of {_repo.AttackWithWeapon(attacker.PlayerName, attacker)}.");
            Console.WriteLine();
            Console.WriteLine($"{defender.PlayerName} starts with defense of {defender.DamageResistance}.");
            Console.WriteLine($"{defender.PlayerName} rolls, and now has defense value of {_repo.DefendAgainstWeapon(defender.PlayerName, defender)}.");
            Console.WriteLine();

            Console.WriteLine(_repo.CombatWeapon(attacker.PlayerName, defender.PlayerName));
            Console.WriteLine();
            Console.WriteLine(_repo.WeaponDamageToHealth(attacker.PlayerName, defender.PlayerName, defender));
            //Next Iteration
            Thread.Sleep(1000);

            Console.WriteLine($"{attacker.PlayerName} starts with attack of {attacker.AttackPower}.");
            Console.WriteLine($"{attacker.PlayerName} rolls, and now has attack value of {_repo.AttackWithWeapon(attacker.PlayerName, attacker)}.");
            Console.WriteLine();
            Console.WriteLine($"{defender.PlayerName} starts with defense of {defender.DamageResistance}.");
            Console.WriteLine($"{defender.PlayerName} rolls, and now has defense value of {_repo.DefendAgainstWeapon(defender.PlayerName, defender)}.");
            Console.WriteLine();

            Console.WriteLine(_repo.CombatWeapon(attacker.PlayerName, defender.PlayerName));
            Console.WriteLine();
            Console.WriteLine(_repo.WeaponDamageToHealth(attacker.PlayerName, defender.PlayerName, defender));



        }
        [TestMethod]
        public void TestCombatMagic()
        {
            Player attacker = new Player("Dave", Races.Human, Classes.Knight);
            Player defender = new Player("Steve-O", Races.Dwarf, Classes.Mage);

            attacker.MagicPower = 21;
            defender.MagicResistance = 9;

            _repo.AddPlayerToDirectory(attacker);
            _repo.AddPlayerToDirectory(defender);

            Console.WriteLine(attacker.PlayerName);
            Console.WriteLine(attacker.MagicPower);
            Console.WriteLine(_repo.AttackWithMagic (attacker.PlayerName, attacker));
            Console.WriteLine();
            Console.WriteLine(defender.PlayerName);
            Console.WriteLine(defender.MagicResistance);
            Console.WriteLine(_repo.DefendAgainstMagic(defender.PlayerName, defender));
            Console.WriteLine();

            Console.WriteLine(_repo.CombatMagic(attacker.PlayerName, defender.PlayerName));

        }
        [TestMethod]
        public void TestMagicDamagetoHealth()
        {
            Player attacker = new Player("Dave", Races.Human, Classes.Knight);
            Player defender = new Player("Steve-O", Races.Dwarf, Classes.Mage);

            attacker.MagicPower = 21;
            defender.MagicResistance = 9;
            defender.Health = 100;

            _repo.AddPlayerToDirectory(attacker);
            _repo.AddPlayerToDirectory(defender);

            Console.WriteLine($"{attacker.PlayerName} starts with attack of {attacker.MagicPower}.");
            Console.WriteLine($"{attacker.PlayerName} rolls, and now has attack value of {_repo.AttackWithMagic(attacker.PlayerName, attacker)}.");
            Console.WriteLine();
            Console.WriteLine($"{defender.PlayerName} starts with defense of {defender.MagicResistance}.");
            Console.WriteLine($"{defender.PlayerName} rolls, and now has defense value of {_repo.DefendAgainstMagic(defender.PlayerName, defender)}.");
            Console.WriteLine();

            Console.WriteLine(_repo.CombatMagic(attacker.PlayerName, defender.PlayerName));
            Console.WriteLine();
            Console.WriteLine(_repo.MagicDamageToHealth(attacker.PlayerName, defender.PlayerName, defender));
            Thread.Sleep(1000);
            //next iteration
            Console.WriteLine($"{attacker.PlayerName} starts with attack of {attacker.MagicPower}.");
            Console.WriteLine($"{attacker.PlayerName} rolls, and now has attack value of {_repo.AttackWithMagic(attacker.PlayerName, attacker)}.");
            Console.WriteLine();
            Console.WriteLine($"{defender.PlayerName} starts with defense of {defender.MagicResistance}.");
            Console.WriteLine($"{defender.PlayerName} rolls, and now has defense value of {_repo.DefendAgainstMagic(defender.PlayerName, defender)}.");
            Console.WriteLine();

            Console.WriteLine(_repo.CombatMagic(attacker.PlayerName, defender.PlayerName));
            Console.WriteLine();
            Console.WriteLine(_repo.MagicDamageToHealth(attacker.PlayerName, defender.PlayerName, defender));
            Thread.Sleep(1000);
            //next iteration
            Console.WriteLine($"{attacker.PlayerName} starts with attack of {attacker.MagicPower}.");
            Console.WriteLine($"{attacker.PlayerName} rolls, and now has attack value of {_repo.AttackWithMagic(attacker.PlayerName, attacker)}.");
            Console.WriteLine();
            Console.WriteLine($"{defender.PlayerName} starts with defense of {defender.MagicResistance}.");
            Console.WriteLine($"{defender.PlayerName} rolls, and now has defense value of {_repo.DefendAgainstMagic(defender.PlayerName, defender)}.");
            Console.WriteLine();

            Console.WriteLine(_repo.CombatMagic(attacker.PlayerName, defender.PlayerName));
            Console.WriteLine();
            Console.WriteLine(_repo.MagicDamageToHealth(attacker.PlayerName, defender.PlayerName, defender));
            Thread.Sleep(1000);
            //next iteration

        }

    }
}
