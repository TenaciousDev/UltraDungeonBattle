using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UltraDungeonBattle;

namespace UltraDungeonBattle
{
    public class ProgramUI
    {
        private readonly PlayerRepo _playerList = new PlayerRepo();
        SixSidedDie attack = new SixSidedDie();
        NineSidedDie defend = new NineSidedDie();
        public void Run()
        {
            //Create the players
            Console.WriteLine("You will need two players for this game. Press any key when ready.");
            Console.ReadKey();
            GameStart();
        }
        private void GameStart()
        {
            Console.Clear();
            Console.WriteLine("Player One, create your player! Press any key to continue.");
            Console.ReadKey();
            Console.Clear();
            Player playerOne = new Player();
            //Player Name
            Console.WriteLine("Choose a name for your player!");
            string inputPOneName = Console.ReadLine();
            playerOne.PlayerName = inputPOneName;
            //Select Race
            Console.WriteLine("Select your player's Race!\n" +
                $"1) {Races.Human}\n" +
                $"2) {Races.Dwarf}\n" +
                $"3) {Races.Elf}");
            string pOneRace = Console.ReadLine();
            switch (pOneRace)
            {
                case "1":
                    playerOne.RaceName = Races.Human;
                    break;
                case "2":
                    playerOne.RaceName = Races.Dwarf;
                    break;
                case "3":
                    playerOne.RaceName = Races.Elf;
                    break;
            }
            //Select Class
            Console.WriteLine("Select your player's Class!\n" +
                $"1) {Classes.Knight}\n" +
                $"2) {Classes.Barbarian}\n" +
                $"3) {Classes.Mage}");
            string pOneClass = Console.ReadLine();
            switch (pOneClass)
            {
                case "1":
                    playerOne.ClassName = Classes.Knight;
                    break;
                case "2":
                    playerOne.ClassName = Classes.Barbarian;
                    break;
                case "3":
                    playerOne.ClassName = Classes.Mage;
                    break;
            }

            //Assign playerOne attack power
            playerOne.Health = _playerList.CalculateHealth(playerOne);
            playerOne.AttackPower = _playerList.CalculateAttackPower(playerOne);
            playerOne.MagicPower = _playerList.CalculateMagicPower(playerOne);
            playerOne.DamageResistance = _playerList.CalculateDamageResistance(playerOne);
            playerOne.MagicResistance = _playerList.CalculateMagicResistance(playerOne);

            //Add playerOne to list holding all Player objects
            _playerList.AddPlayerToDirectory(playerOne);


            //Calculate the base attributes & show Player
            Console.WriteLine($"Congratulations! You have created {playerOne.PlayerName}, the {playerOne.RaceName} {playerOne.ClassName}! \n" +
                "Press any key to continue.");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Each warrior that enters this arena has certain attributes that make them a worthy adversary. \n" +
                "These attributes are Health, Attack Power, Magic Power, Damage Resistance, and Magic Resistance. \n" +
                "You might be wondering what these stats are. Don't worry. You'll figure it out.");
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine($"Your base Health is {playerOne.Health}.");
            Console.WriteLine($"Your base Attack Power is {playerOne.AttackPower}.");
            Console.WriteLine($"Your base Magic Power is {playerOne.MagicPower}.");
            Console.WriteLine($"Your base Damage Resistance is {playerOne.DamageResistance}.");
            Console.WriteLine($"Your base Magic Resistance is {playerOne.MagicResistance}.");
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            Console.WriteLine();
            //Give Player 3 Points to assign to attributes
            Console.WriteLine("You were kind to a traveling wizard, who has granted you three extra points to boost your attributes! \n" +
                "You may use all points in one category, or spread them around as you desire. \n" +
                "You may not assign any extra points to Health. \n" +
                "And be careful not to squander this gift, lest you upset the traveling wizard! \n" +
                "Press any key to continue.");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("Select the number of the category to which you will assign your first point. Points will be assigned one at a time. \n" +
                "1) Attack Power\n" +
                "2) Magic Power \n" +
                "3) Damage Resistance \n" +
                "4) Magic Resistance");
            string pOnePoints = Console.ReadLine();

            for (int i = 0; i < 3; i++)
            {
                switch (pOnePoints)
                {
                    case "1":
                        string name1 = playerOne.PlayerName;
                        playerOne.AttackPower = _playerList.PlusOneToAttackPower(name1, playerOne);
                        Console.WriteLine($"Your base Attack Power has increased to {playerOne.AttackPower}!");
                        break;
                    case "2":
                        string name2 = playerOne.PlayerName;
                        playerOne.MagicPower = _playerList.PlusOneToMagicPower(name2, playerOne);
                        Console.WriteLine($"Your base Magic Power has increased to {playerOne.MagicPower}!");
                        break;
                    case "3":
                        string name3 = playerOne.PlayerName;
                        playerOne.DamageResistance = _playerList.PlusOneToDamageResistance(name3, playerOne);
                        Console.WriteLine($"Your base Damage Resistance has increased to {playerOne.DamageResistance}!");
                        break;
                    case "4":
                        string name4 = playerOne.PlayerName;
                        playerOne.MagicResistance = _playerList.PlusOneToMagicResistance(name4, playerOne);
                        Console.WriteLine($"Your base Magic Resistance has increased to {playerOne.MagicResistance}!");
                        break;
                    default:
                        Console.WriteLine("You selected an invalid option, and have squandered one of your points. The wizard advises you to be more careful in the future.");
                        break;
                }
                if (i < 2)
                {
                    Console.WriteLine("Make your next choice.");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine($"{playerOne.PlayerName} is complete!");
                }
                pOnePoints = Console.ReadLine();
                continue;
            }
            Console.WriteLine();
            Console.WriteLine("Player Two, create your player! Press any key to continue.");
            Console.ReadKey();
            Console.Clear();

            Player playerTwo = new Player();
            //Player Name
            Console.WriteLine("Choose a name for your player!");
            string inputPTwoName = Console.ReadLine();
            playerTwo.PlayerName = inputPTwoName;
            //Select Race
            Console.WriteLine("Select your player's Race!\n" +
                $"1) {Races.Human}\n" +
                $"2) {Races.Dwarf}\n" +
                $"3) {Races.Elf}");
            string pTwoRace = Console.ReadLine();
            switch (pTwoRace)
            {
                case "1":
                    playerTwo.RaceName = Races.Human;
                    break;
                case "2":
                    playerTwo.RaceName = Races.Dwarf;
                    break;
                case "3":
                    playerTwo.RaceName = Races.Elf;
                    break;
            }
            //Select Class
            Console.WriteLine("Select your player's Class!\n" +
                $"1) {Classes.Knight}\n" +
                $"2) {Classes.Barbarian}\n" +
                $"3) {Classes.Mage}");
            string pTwoClass = Console.ReadLine();
            switch (pTwoClass)
            {
                case "1":
                    playerTwo.ClassName = Classes.Knight;
                    break;
                case "2":
                    playerTwo.ClassName = Classes.Barbarian;
                    break;
                case "3":
                    playerTwo.ClassName = Classes.Mage;
                    break;
            }

            //Assign playerTwo stats
            playerTwo.Health = _playerList.CalculateHealth(playerTwo);
            playerTwo.AttackPower = _playerList.CalculateAttackPower(playerTwo);
            playerTwo.MagicPower = _playerList.CalculateMagicPower(playerTwo);
            playerTwo.DamageResistance = _playerList.CalculateDamageResistance(playerTwo);
            playerTwo.MagicResistance = _playerList.CalculateMagicResistance(playerTwo);

            //Add playerTwo to list holding all Player objects
            _playerList.AddPlayerToDirectory(playerTwo);


            //Calculate the base attributes & show Player
            Console.WriteLine($"Congratulations! You have created {playerTwo.PlayerName}, the {playerTwo.RaceName} {playerTwo.ClassName}! \n" +
                "Press any key to continue.");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Each warrior that enters this arena has certain attributes that make them a worthy adversary. \n" +
                "These attributes are Health, Attack Power, Magic Power, Damage Resistance, and Magic Resistance. \n" +
                "You might be wondering what these stats are. Don't worry. You'll figure it out.");
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine($"Your base Health is {playerTwo.Health}.");
            Console.WriteLine($"Your base Attack Power is {playerTwo.AttackPower}.");
            Console.WriteLine($"Your base Magic Power is {playerTwo.MagicPower}.");
            Console.WriteLine($"Your base Damage Resistance is {playerTwo.DamageResistance}.");
            Console.WriteLine($"Your base Magic Resistance is {playerTwo.MagicResistance}.");
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            Console.WriteLine();
            //Give Player 3 Points to assign to attributes
            Console.WriteLine("You were kind to a traveling wizard, who has granted you three extra points to boost your attributes! \n" +
                "You may use all points in one category, or spread them around as you desire. \n" +
                "You may not assign any extra points to Health. \n" +
                "And be careful not to squander this gift, lest you upset the traveling wizard! \n" +
                "Press any key to continue.");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("Select the number of the category to which you will assign your first point. Points will be assigned one at a time. \n" +
                "1) Attack Power\n" +
                "2) Magic Power \n" +
                "3) Damage Resistance \n" +
                "4) Magic Resistance");
            string pTwoPoints = Console.ReadLine();

            for (int i = 0; i < 3; i++)
            {
                switch (pTwoPoints)
                {
                    case "1":
                        string name1 = playerTwo.PlayerName;
                        playerTwo.AttackPower = _playerList.PlusOneToAttackPower(name1, playerTwo);
                        Console.WriteLine($"Your base Attack Power has increased to {playerTwo.AttackPower}!");
                        break;
                    case "2":
                        string name2 = playerTwo.PlayerName;
                        playerTwo.MagicPower = _playerList.PlusOneToMagicPower(name2, playerTwo);
                        Console.WriteLine($"Your base Magic Power has increased to {playerTwo.MagicPower}!");
                        break;
                    case "3":
                        string name3 = playerTwo.PlayerName;
                        playerTwo.DamageResistance = _playerList.PlusOneToDamageResistance(name3, playerTwo);
                        Console.WriteLine($"Your base Damage Resistance has increased to {playerTwo.DamageResistance}!");
                        break;
                    case "4":
                        string name4 = playerTwo.PlayerName;
                        playerTwo.MagicResistance = _playerList.PlusOneToMagicResistance(name4, playerTwo);
                        Console.WriteLine($"Your base Magic Resistance has increased to {playerTwo.MagicResistance}!");
                        break;
                    default:
                        Console.WriteLine("You selected an invalid option, and have squandered one of your points. The wizard advises you to be more careful in the future.");
                        break;
                }
                if (i < 2)
                {
                    Console.WriteLine("Make your next choice.");
                }
                else
                {
                    Console.WriteLine($"{playerTwo.PlayerName} is complete!");
                }
                pTwoPoints = Console.ReadLine();
                continue;
            }
            Console.Clear();
            Console.WriteLine($"{playerOne.PlayerName} and {playerTwo.PlayerName} enter the arena with {playerOne.Health} Health and {playerTwo.Health} Health!");
            Console.ReadKey();

            //Start the game

            //while (playerOne.IsAlive != false && playerTwo.IsAlive != false)
            //{
                //take turns running the ArenaBattle method
            //}

                        playerOne.IsTurn = true; //playerOne starts first
            playerTwo.IsTurn = false;
            int round = 0;
            int roundLimit = 10;
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
                            _playerList.WeaponDamageToHealth(attacker.PlayerName, defender.PlayerName, defender);
                            Console.WriteLine($"{attacker.PlayerName} has dealt {defender.PlayerName} a blow! {defender.PlayerName} has {defender.Health} health remaining!");
                            break;
                        case "2":
                            _playerList.MagicDamageToHealth(attacker.PlayerName, defender.PlayerName, defender);
                            Console.WriteLine($"{attacker.PlayerName} has cast magic at {defender.PlayerName}! {defender.PlayerName} has {defender.Health} health remaining!");
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
                            _playerList.WeaponDamageToHealth(attacker.PlayerName, defender.PlayerName, defender);
                            Console.WriteLine($"{attacker.PlayerName} has dealt {defender.PlayerName} a blow! {defender.PlayerName} has {defender.Health} health remaining!");
                            break;
                        case "2":
                            _playerList.MagicDamageToHealth(attacker.PlayerName, defender.PlayerName, defender);
                            Console.WriteLine($"{attacker.PlayerName} has cast magic at {defender.PlayerName}! {defender.PlayerName} has {defender.Health} health remaining!");
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
            }
            if (playerOne.IsAlive == false)
            {
                Console.WriteLine($"{playerOne.PlayerName} has perished! {playerTwo.PlayerName} wins!");
            }
            else if (playerTwo.IsAlive == false)
            {
                Console.WriteLine($"{playerTwo.PlayerName} has perished! {playerOne.PlayerName} wins!");
            }
            else
            {
                Console.WriteLine("The High King has put a stop to this fight. He recognizes the valor you both have exhibited here today. Congratulations!");
            }
            Console.WriteLine("Press any key to exit the game.");
            Console.ReadKey();
        }



    }
}
