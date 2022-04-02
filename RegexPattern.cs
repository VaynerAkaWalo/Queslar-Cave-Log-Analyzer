using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;


namespace Queslar_Cave_Log_Analyzer
{
    internal static class RegexPattern
    {
        public static Regex startTime = new Regex("(?<!-.)[a-z]{3}\\s+[0-9]{1,2}.[0-9]{4}..[0-9:0-9]*", RegexOptions.Singleline | RegexOptions.IgnoreCase);

        public static Regex endTime = new Regex("(?<=-.)[a-z]{3}\\s+[0-9]{1,2}.[0-9]{4}..[0-9:0-9]*", RegexOptions.Singleline | RegexOptions.IgnoreCase);

        public static Regex startingDepth = new Regex("(?<=Starting depth: )[0-9,]+", RegexOptions.Singleline | RegexOptions.IgnoreCase);

        public static Regex finishingDepth = new Regex("(?<=Finishing depth: )[0-9,]+", RegexOptions.Singleline | RegexOptions.IgnoreCase);

        public static Regex treasuresFound = new Regex("(?<=Treasures found: )[0-9,]+", RegexOptions.Singleline | RegexOptions.IgnoreCase);

        public static Regex bossesSlain = new Regex("(?<=Bosses slain: )[0-9,]+", RegexOptions.Singleline | RegexOptions.IgnoreCase);

        public static Regex monstersSlain = new Regex("(?<=Monsters slain: )[0-9,]+", RegexOptions.Singleline | RegexOptions.IgnoreCase);

        public static Regex tilesTraveled = new Regex("(?<=Tiles traveled: )[0-9,]+", RegexOptions.Singleline | RegexOptions.IgnoreCase);

        public static Regex tilesCleared = new Regex("(?<=Tiles cleared: )[0-9,]+", RegexOptions.Singleline | RegexOptions.IgnoreCase);

        public static Regex tilesLooted = new Regex("(?<=Tiles looted: )[0-9,]+", RegexOptions.Singleline | RegexOptions.IgnoreCase);

        public static Regex diamonds = new Regex("(?<=Diamonds: )[0-9,]+", RegexOptions.Singleline | RegexOptions.IgnoreCase);

        public static Regex gold = new Regex("(?<=Shattered Fighter Gold: )[0-9,]+", RegexOptions.Singleline | RegexOptions.IgnoreCase);


        public static Regex monster_strength = new Regex("(?<=Monster.Strength:.)[0-9,]+", RegexOptions.Singleline | RegexOptions.IgnoreCase);

        public static Regex monster_health = new Regex("(?<=Monster.Health:.)[0-9,]+", RegexOptions.Singleline | RegexOptions.IgnoreCase);

        public static Regex monster_agility = new Regex("(?<=Monster.Agility:.)[0-9,]+", RegexOptions.Singleline | RegexOptions.IgnoreCase);

        public static Regex monster_dexterity = new Regex("(?<=Monster.Dexterity:.)[0-9,]+", RegexOptions.Singleline | RegexOptions.IgnoreCase);


        public static Regex strength = new Regex("(?<!Monster.Strength:.)(?<=Strength: )[0-9,]+", RegexOptions.Singleline | RegexOptions.IgnoreCase);

        public static Regex health = new Regex("(?<!Monster.Health:.)(?<=Health: )[0-9,]+", RegexOptions.Singleline | RegexOptions.IgnoreCase);

        public static Regex agility = new Regex("(?<!Monster.Agility:.)(?<=Agility: )[0-9,]+", RegexOptions.Singleline | RegexOptions.IgnoreCase);

        public static Regex dexterity = new Regex("(?<!Monster.Dexterity:.)(?<=Dexterity: )[0-9,]+", RegexOptions.Singleline | RegexOptions.IgnoreCase);
    }
}
