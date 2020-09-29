using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace UltraDungeonBattle
{
    public class PlayerRepo
    {
        protected readonly List<Player> _playerDirectory = new List<Player>();
        //Setup Methods
        //Add Player to Directory
        public void AddPlayerToDirectory(Player newPlayer)
        {
            _playerDirectory.Add(newPlayer);
        }
        //Call a Player object by user-assigned name
        public Player GetPlayerByName(string playerName)
        {
            foreach (Player singlePlayer in _playerDirectory)
            {
                if (singlePlayer.PlayerName.ToLower() == playerName.ToLower())
                {
                    return singlePlayer;
                }
            }
            Console.WriteLine("Nope try again");
            return null;
        }
        //Test when we were creating PlusOne methods, right?
        public bool UpdatePlayerAttributes(string playerName, Player newAttribute)
        {
            Player oldAttribute = GetPlayerByName(playerName);
            if (oldAttribute != null)
            {
                oldAttribute.Health = newAttribute.Health;
                oldAttribute.AttackPower = newAttribute.AttackPower;
                oldAttribute.MagicPower = newAttribute.MagicPower;
                oldAttribute.DamageResistance = newAttribute.DamageResistance;
                oldAttribute.MagicResistance = newAttribute.MagicResistance;

                return true;
            }
            else
            {
                return false;
            }
        }
        //Methods to calculate initial stats based on Race/Class combos
        public double CalculateHealth(Player thisPlayer)
        {
            if (thisPlayer.RaceName == Races.Human && thisPlayer.ClassName == Classes.Knight)
            {
                return 159;
            }
            else if (thisPlayer.RaceName == Races.Human && thisPlayer.ClassName == Classes.Barbarian)
            {
                return 162;
            }
            else if (thisPlayer.RaceName == Races.Human && thisPlayer.ClassName == Classes.Mage)
            {
                return 153;
            }
            else if (thisPlayer.RaceName == Races.Dwarf && thisPlayer.ClassName == Classes.Knight)
            {
                return 156;
            }
            else if (thisPlayer.RaceName == Races.Dwarf && thisPlayer.ClassName == Classes.Barbarian)
            {
                return 159;
            }
            else if (thisPlayer.RaceName == Races.Dwarf && thisPlayer.ClassName == Classes.Mage)
            {
                return 150;
            }
            else if (thisPlayer.RaceName == Races.Elf && thisPlayer.ClassName == Classes.Knight)
            {
                return 162;
            }
            else if (thisPlayer.RaceName == Races.Elf && thisPlayer.ClassName == Classes.Barbarian)
            {
                return 165;
            }
            else if (thisPlayer.RaceName == Races.Elf && thisPlayer.ClassName == Classes.Mage)
            {
                return 156;
            }
            else
            {
                return 9;
            }
        }
        public double CalculateAttackPower(Player thisPlayer)
        {
            if (thisPlayer.RaceName == Races.Human && thisPlayer.ClassName == Classes.Knight)
            {
                return 21;
            }
            else if (thisPlayer.RaceName == Races.Human && thisPlayer.ClassName == Classes.Barbarian)
            {
                return 18;
            }
            else if (thisPlayer.RaceName == Races.Human && thisPlayer.ClassName == Classes.Mage)
            {
                return 12;
            }
            else if (thisPlayer.RaceName == Races.Dwarf && thisPlayer.ClassName == Classes.Knight)
            {
                return 18;
            }
            else if (thisPlayer.RaceName == Races.Dwarf && thisPlayer.ClassName == Classes.Barbarian)
            {
                return 15;
            }
            else if (thisPlayer.RaceName == Races.Dwarf && thisPlayer.ClassName == Classes.Mage)
            {
                return 9;
            }
            else if (thisPlayer.RaceName == Races.Elf && thisPlayer.ClassName == Classes.Knight)
            {
                return 18;
            }
            else if (thisPlayer.RaceName == Races.Elf && thisPlayer.ClassName == Classes.Barbarian)
            {
                return 15;
            }
            else if (thisPlayer.RaceName == Races.Elf && thisPlayer.ClassName == Classes.Mage)
            {
                return 9;
            }
            else
            {
                return 9;
            }
        }
        public double CalculateMagicPower(Player thisPlayer)
        {
            if (thisPlayer.RaceName == Races.Human && thisPlayer.ClassName == Classes.Knight)
            {
                return 9;
            }
            else if (thisPlayer.RaceName == Races.Human && thisPlayer.ClassName == Classes.Barbarian)
            {
                return 9;
            }
            else if (thisPlayer.RaceName == Races.Human && thisPlayer.ClassName == Classes.Mage)
            {
                return 18;
            }
            else if (thisPlayer.RaceName == Races.Dwarf && thisPlayer.ClassName == Classes.Knight)
            {
                return 9;
            }
            else if (thisPlayer.RaceName == Races.Dwarf && thisPlayer.ClassName == Classes.Barbarian)
            {
                return 9;
            }
            else if (thisPlayer.RaceName == Races.Dwarf && thisPlayer.ClassName == Classes.Mage)
            {
                return 18;
            }
            else if (thisPlayer.RaceName == Races.Elf && thisPlayer.ClassName == Classes.Knight)
            {
                return 12;
            }
            else if (thisPlayer.RaceName == Races.Elf && thisPlayer.ClassName == Classes.Barbarian)
            {
                return 12;
            }
            else if (thisPlayer.RaceName == Races.Elf && thisPlayer.ClassName == Classes.Mage)
            {
                return 21;
            }
            else
            {
                return 9;
            }
        }
        public double CalculateDamageResistance(Player thisPlayer)
        {
            if (thisPlayer.RaceName == Races.Human && thisPlayer.ClassName == Classes.Knight)
            {
                return 9;
            }
            else if (thisPlayer.RaceName == Races.Human && thisPlayer.ClassName == Classes.Barbarian)
            {
                return 12;
            }
            else if (thisPlayer.RaceName == Races.Human && thisPlayer.ClassName == Classes.Mage)
            {
                return 12;
            }
            else if (thisPlayer.RaceName == Races.Dwarf && thisPlayer.ClassName == Classes.Knight)
            {
                return 15;
            }
            else if (thisPlayer.RaceName == Races.Dwarf && thisPlayer.ClassName == Classes.Barbarian)
            {
                return 18;
            }
            else if (thisPlayer.RaceName == Races.Dwarf && thisPlayer.ClassName == Classes.Mage)
            {
                return 18;
            }
            else if (thisPlayer.RaceName == Races.Elf && thisPlayer.ClassName == Classes.Knight)
            {
                return 9;
            }
            else if (thisPlayer.RaceName == Races.Elf && thisPlayer.ClassName == Classes.Barbarian)
            {
                return 12;
            }
            else if (thisPlayer.RaceName == Races.Elf && thisPlayer.ClassName == Classes.Mage)
            {
                return 12;
            }
            else
            {
                return 9;
            }
        }
        public double CalculateMagicResistance(Player thisPlayer)
        {
            if (thisPlayer.RaceName == Races.Human && thisPlayer.ClassName == Classes.Knight)
            {
                return 15;
            }
            else if (thisPlayer.RaceName == Races.Human && thisPlayer.ClassName == Classes.Barbarian)
            {
                return 12;
            }
            else if (thisPlayer.RaceName == Races.Human && thisPlayer.ClassName == Classes.Mage)
            {
                return 18;
            }
            else if (thisPlayer.RaceName == Races.Dwarf && thisPlayer.ClassName == Classes.Knight)
            {
                return 15;
            }
            else if (thisPlayer.RaceName == Races.Dwarf && thisPlayer.ClassName == Classes.Barbarian)
            {
                return 12;
            }
            else if (thisPlayer.RaceName == Races.Dwarf && thisPlayer.ClassName == Classes.Mage)
            {
                return 18;
            }
            else if (thisPlayer.RaceName == Races.Elf && thisPlayer.ClassName == Classes.Knight)
            {
                return 12;
            }
            else if (thisPlayer.RaceName == Races.Elf && thisPlayer.ClassName == Classes.Barbarian)
            {
                return 9;
            }
            else if (thisPlayer.RaceName == Races.Elf && thisPlayer.ClassName == Classes.Mage)
            {
                return 15;
            }
            else
            {
                return 9;
            }
        }
        //Methods to add a point to an attribute (except health, which can only be depleted)
        public double PlusOneToAttackPower(string playerName, Player newAttribute)
        {
            Player oldAttribute = GetPlayerByName(playerName);
            oldAttribute.AttackPower = newAttribute.AttackPower;
            newAttribute.AttackPower++;
            return newAttribute.AttackPower;
        }
        public double PlusOneToMagicPower(string playerName, Player newAttribute)
        {
            Player oldAttribute = GetPlayerByName(playerName);
            oldAttribute.MagicPower = newAttribute.MagicPower;
            newAttribute.MagicPower++;
            return newAttribute.MagicPower;
        }
        public double PlusOneToDamageResistance(string playerName, Player newAttribute)
        {
            Player oldAttribute = GetPlayerByName(playerName);
            oldAttribute.DamageResistance = newAttribute.DamageResistance;
            newAttribute.DamageResistance++;
            return newAttribute.DamageResistance;
        }
        public double PlusOneToMagicResistance(string playerName, Player newAttribute)
        {
            Player oldAttribute = GetPlayerByName(playerName);
            oldAttribute.MagicResistance = newAttribute.MagicResistance;
            newAttribute.MagicResistance++;
            return newAttribute.MagicResistance;
        }
        //Gameplay Methods
        //Player attacks other player
        //Cast Spell
        public double AttackWithMagic(string playerName, Player modPower)
        {
            //new up attack die
            SixSidedDie AttackSix = new SixSidedDie();
            //get player by name
            Player attacker = GetPlayerByName(playerName);
            //get attacking player magic power
            attacker.MagicPower = modPower.MagicPower;
            //roll six-sided attack die
            double n = AttackSix.Roll();
            switch (n)
            {
                case 1:
                    double a = .0;
                    double r = modPower.MagicPower * a;

                    return r;
                case 2:
                    a = .2;
                    r = modPower.MagicPower * a;
                    return r;
                case 3:
                    a = .4;
                    r = modPower.MagicPower * a;
                    return r;
                case 4:
                    a = .6;
                    r = modPower.MagicPower * a;
                    return r;
                case 5:
                    a = .8;
                    r = modPower.MagicPower * a;
                    return r;
                case 6:
                    a = 1;
                    r = modPower.MagicPower * a;
                    return r;
            }
            return n;
        }
        //Attack w/ Weapon
        public double AttackWithWeapon(string playerName, Player modPower)
        {
            //new up attack die
            SixSidedDie AttackSix = new SixSidedDie();
            //get player by name
            Player attacker = GetPlayerByName(playerName);
            //get attacking player magic power
            attacker.AttackPower = modPower.AttackPower;
            //roll six-sided attack die
            double n = AttackSix.Roll();
            switch (n)
            {
                case 1:
                    double a = .0;
                    double r = modPower.AttackPower * a;

                    return r;
                case 2:
                    a = .2;
                    r = modPower.AttackPower * a;
                    return r;
                case 3:
                    a = .4;
                    r = modPower.AttackPower * a;
                    return r;
                case 4:
                    a = .6;
                    r = modPower.AttackPower * a;
                    return r;
                case 5:
                    a = .8;
                    r = modPower.AttackPower * a;
                    return r;
                case 6:
                    a = 1;
                    r = modPower.AttackPower * a;
                    return r;
            }
            return n;
        }
        //Player defends against other player
        //Defend Against Magic
        public double DefendAgainstMagic(string playerName, Player modDefense)
        {
            //new up attack die
            NineSidedDie DefendNine = new NineSidedDie();
            //get player by name
            Player attacker = GetPlayerByName(playerName);
            //get attacking player magic power
            attacker.MagicResistance = modDefense.MagicResistance;
            //use math to generate final double
            double n = DefendNine.Roll();
            switch (n)
            {
                case 1:
                    double a = .0;
                    double r = modDefense.MagicResistance * a;

                    return r;
                case 2:
                    a = .13;
                    r = modDefense.MagicResistance * a;
                    return r;
                case 3:
                    a = .25;
                    r = modDefense.MagicResistance * a;
                    return r;
                case 4:
                    a = .38;
                    r = modDefense.MagicResistance * a;
                    return r;
                case 5:
                    a = .5;
                    r = modDefense.MagicResistance * a;
                    return r;
                case 6:
                    a = .63;
                    r = modDefense.MagicResistance * a;
                    return r;
                case 7:
                    a = .75;
                    r = modDefense.MagicResistance * a;
                    return r;
                case 8:
                    a = .88;
                    r = modDefense.MagicResistance * a;
                    return r;
                case 9:
                    a = 1;
                    r = modDefense.MagicResistance * a;
                    return r;

            }
            return n;
        }
        //Defend Against Weapon
        public double DefendAgainstWeapon(string playerName, Player modDefense)
        {
            //new up attack die
            NineSidedDie DefendNine = new NineSidedDie();
            //get player by name
            Player defender = GetPlayerByName(playerName);
            //get attacking player magic power
            defender.DamageResistance = modDefense.DamageResistance;
            //use math to generate final double
            double n = DefendNine.Roll();
            switch (n)
            {
                case 1:
                    double a = .0;
                    double r = modDefense.DamageResistance * a;

                    return r;
                case 2:
                    a = .13;
                    r = modDefense.DamageResistance * a;
                    return r;
                case 3:
                    a = .25;
                    r = modDefense.DamageResistance * a;
                    return r;
                case 4:
                    a = .38;
                    r = modDefense.DamageResistance * a;
                    return r;
                case 5:
                    a = .5;
                    r = modDefense.DamageResistance * a;
                    return r;
                case 6:
                    a = .63;
                    r = modDefense.DamageResistance * a;
                    return r;
                case 7:
                    a = .75;
                    r = modDefense.DamageResistance * a;
                    return r;
                case 8:
                    a = .88;
                    r = modDefense.DamageResistance * a;
                    return r;
                case 9:
                    a = 1;
                    r = modDefense.DamageResistance * a;
                    return r;
            }
            return n;
        }
        //Attack vs Defense
        public double CombatWeapon(string attackerName, string defenderName)
        {
            Player attacker = GetPlayerByName(attackerName);
            Player defender = GetPlayerByName(defenderName);
            double a = AttackWithWeapon(attackerName, attacker);
            double d = DefendAgainstWeapon(defenderName, defender);
            if (a > d)
            {
                return a - d;
            }
            else
            {
                return 0;
            }
        }
        public double CombatMagic(string attackerName, string defenderName)
        {
            Player attacker = GetPlayerByName(attackerName);
            Player defender = GetPlayerByName(defenderName);
            double a = AttackWithMagic(attackerName, attacker);
            double d = DefendAgainstMagic(defenderName, defender);
            double r;
            if (a > d)
            {
                r = a - d;
            }
            else
            {
                r = 0;
            }
            return r;
        }
        public double WeaponDamageToHealth(string attackerName, string defenderName, Player modHealth)
        {
            Player oldHealth = GetPlayerByName(attackerName);
            oldHealth.Health = modHealth.Health;
            modHealth.Health = modHealth.Health - CombatWeapon(attackerName, defenderName);
            return modHealth.Health;
        }
        public double MagicDamageToHealth(string attackerName, string defenderName, Player modHealth)
        {
            Player oldHealth = GetPlayerByName(attackerName);
            oldHealth.Health = modHealth.Health;
            modHealth.Health = modHealth.Health - CombatMagic(attackerName, defenderName);
            return modHealth.Health;
        }

        //players taking turns
        public void ArenaBattle(Player playerOne, Player playerTwo)
        {
            playerOne.IsTurn = true; //playerOne starts first
            playerTwo.IsTurn = false;
            int round = 0;
            int roundLimit = 5;
            while (playerOne.IsAlive != false && playerTwo.IsAlive != false && round < roundLimit)
            {
                round++; //starts a new round
                Console.WriteLine($"Round {round}. Battle!");
                Console.WriteLine();
                if (playerOne.IsTurn) //if it's player one's turn
                {
                    Player attacker = playerOne;
                    Player defender = playerTwo;
                    Console.WriteLine($"{attacker.PlayerName}, choose your attack!\n" +
                        "1) Use weapon\n" +
                        "2) Cast magic");
                    string attackType = Console.ReadLine();
                    switch (attackType)
                    {
                        case "1":
                            WeaponDamageToHealth(attacker.PlayerName, defender.PlayerName, defender);
                            Console.WriteLine($"{attacker.PlayerName} has dealt {defender.PlayerName} a blow! {defender.PlayerName} has {defender.Health} remaining!");
                            break;
                        case "2":
                            MagicDamageToHealth(attacker.PlayerName, defender.PlayerName, defender);
                            Console.WriteLine($"{attacker.PlayerName} has cast magic at {defender.PlayerName}! {defender.PlayerName} has {defender.Health} remaining!");
                            break;
                        default:
                            Console.WriteLine("The wizard previously cautioned you against selecting invalid options. You forfeit your turn as a lesson in situational awareness.");
                            break;
                    }
                    Console.WriteLine($"It is now {defender.PlayerName}'s turn.");
                    defender.IsTurn = true;
                    attacker.IsTurn = false;
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadKey();

                }
                else if (playerTwo.IsTurn) //if it's player two's turn
                {
                    Player attacker = playerTwo;
                    Player defender = playerOne;
                    Console.WriteLine($"{attacker.PlayerName}, choose your attack!\n" +
                        "1) Use weapon\n" +
                        "2) Cast magic");
                    string attackType = Console.ReadLine();
                    switch (attackType)
                    {
                        case "1":
                            WeaponDamageToHealth(attacker.PlayerName, defender.PlayerName, defender);
                            Console.WriteLine($"{attacker.PlayerName} has dealt {defender.PlayerName} a blow! {defender.PlayerName} has {defender.Health} remaining!");
                            break;
                        case "2":
                            MagicDamageToHealth(attacker.PlayerName, defender.PlayerName, defender);
                            Console.WriteLine($"{attacker.PlayerName} has cast magic at {defender.PlayerName}! {defender.PlayerName} has {defender.Health} remaining!");
                            break;
                        default:
                            Console.WriteLine("The wizard previously cautioned you against selecting invalid options. You forfeit your turn as a lesson in situational awareness.");
                            break;
                    }
                    Console.WriteLine($"It is now {defender.PlayerName}'s turn.");
                    defender.IsTurn = true;
                    attacker.IsTurn = false;
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadKey();
                }
                playerTwo.IsTurn = true;
                playerOne.IsTurn = false;
            }
        }
    }
}
