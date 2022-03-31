using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Queslar_Cave_Log_Analyzer
{
    internal class Report
    {
        #region Properties

        private int caves;

        public int Caves
        {
            get { return caves; }
            set { caves = value; }
        }

        #region LnfoProperties

        private int totalTime;

        public int TotalTime
        {
            get { return totalTime; }
            set { totalTime = value; }
        }

        private int totalDepthDiff;

        public int TotalDepthDiff
        {
            get { return totalDepthDiff; }
            set { totalDepthDiff = value; }
        }

        private int treasuresFound;

        public int TreasuresFound
        {
            get { return treasuresFound; }
            set { treasuresFound = value; }
        }

        private int bossesSlain;

        public int BossesSlain
        {
            get { return bossesSlain; }
            set { bossesSlain = value; }
        }

        private int monstersSlain;

        public int MonstersSlain
        {
            get { return monstersSlain; }
            set { monstersSlain = value; }
        }

        private int tilesTraveled;

        public int TilesTraveled
        {
            get { return tilesTraveled; }
            set { tilesTraveled = value; }
        }

        private int tilesCleared;

        public int TilesCleared
        {
            get { return tilesCleared; }
            set { tilesCleared = value; }
        }

        private int tilesLooted;

        public int TilesLooted
        {
            get { return tilesLooted; }
            set { tilesLooted = value; }
        }

        private List<string>? caveRarity;

        public List<string>? CaveRarity
        {
            get { return caveRarity; }
            set { caveRarity = value; }
        }

        #endregion

        #region LootProperties

        private int diamonds;
        public int Diamonds
        {
            get { return diamonds; }
            set { diamonds = value; }
        }

        private int gold;

        public int Gold
        {
            get { return gold; }
            set { gold = value; }
        }

        #region Stats

        #endregion

        #region Monster Stats

        #endregion

        #region Wootz
        private int rareWootz;

        public int RareWootz
        {
            get { return rareWootz; }
            set { rareWootz = value; }
        }

        private int epicWootz;

        public int EpicWootz    
        {
            get { return epicWootz; }
            set { epicWootz = value; }
        }

        #endregion

        #region Materials

        #endregion

        #region Homested

        #region T1

        #endregion

        #region T2

        #endregion

        #region T3

        #endregion

        #region T4

        #endregion

        #endregion

        #endregion


        #endregion

        public Report(string log)
        {
            //Console.WriteLine(log);

            MatchCollection startMC = RegexPattern.startTime.Matches(log);
            MatchCollection endMC = RegexPattern.endTime.Matches(log);

            //Caves = startMC.Count;

            for(int i = 0; i < endMC.Count; i++)
            {
                Console.WriteLine($"koniec: {endMC[i]}");
            }

            Console.WriteLine($"MonkaHmm {startMC.Count} {endMC.Count}");
        }

    }
}
