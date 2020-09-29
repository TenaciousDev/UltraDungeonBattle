using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltraDungeonBattle
{
    public enum Races { Human, Dwarf, Elf }
    public enum Classes { Knight, Barbarian, Mage }
    public class Player
    {
        public List<double> playerStatsT1 = new List<double>();
        public string PlayerName { get; set; }
        public Races RaceName { get; set; }
        public Classes ClassName { get; set; }
        public double Health { get; set; }
        public double AttackPower { get; set; }
        public double MagicPower { get; set; }
        public double DamageResistance { get; set; }
        public double MagicResistance { get; set; }
        public bool IsAlive
        {
            get
            {
                if (Health > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public bool IsTurn { get; set; }

        public Player(string playerName, Races raceName, Classes className)
        {
            PlayerName = playerName;
            RaceName = raceName;
            ClassName = className;
            IsTurn = IsTurn;
        }

        public Player() { }

    }
}
