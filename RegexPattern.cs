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
    }
}
