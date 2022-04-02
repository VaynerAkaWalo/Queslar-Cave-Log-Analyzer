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

        #region InfoProperties

        private double totalTime;

        public double TotalTime
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

        private int tilesTraveledOccurred;

        public int TilesTraveledOccurred
        {
            get { return tilesTraveledOccurred; }
            set { tilesTraveledOccurred = value; }
        }

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

        private ulong gold;

        public ulong Gold
        {
            get { return gold; }
            set { gold = value; }
        }

        #region Stats

        private ulong strength;

        public ulong Strength
        {
            get { return strength; }
            set { strength = value; }
        }

        private ulong health;

        public ulong Health
        {
            get { return health; }
            set { health = value; }
        }

        private ulong agility;

        public ulong Agility
        {
            get { return agility; }
            set { agility = value; }
        }

        private ulong dexterity;

        public ulong Dexterity
        {
            get { return dexterity; }
            set { dexterity = value; }
        }



        #endregion

        #region Monster Stats

        private ulong monster_strength;

        public ulong Monster_strenth
        {
            get { return monster_strength; }
            set { monster_strength = value; }
        }

        private ulong monster_health;

        public ulong Monster_health
        {
            get { return monster_health; }
            set { monster_health = value; }
        }

        private ulong monster_agility;

        public ulong Monster_Agility
        {
            get { return monster_agility; }
            set { monster_agility = value; }
        }

        private ulong monster_dexterity;

        public ulong Monster_dexterity
        {
            get { return monster_dexterity; }
            set { monster_dexterity = value; }
        }

        #endregion

        #region Wootz

        private int rare_wootz;

        public int Rare_wootz
        {
            get { return rare_wootz; }
            set { rare_wootz = value; }
        }

        private int epicWootz;

        public int Epic_wootz    
        {
            get { return epicWootz; }
            set { epicWootz = value; }
        }

        private int magical_wootz;

        public int Magical_wootz
        {
            get { return magical_wootz; }
            set { magical_wootz = value; }
        }

        private int unique_wootz;

        public int Unique_wootz
        {
            get { return unique_wootz; }
            set { unique_wootz = value; }
        }

        private int relic_wootz;

        public int Relic_wootz
        {
            get { return relic_wootz; }
            set { relic_wootz = value; }
        }


        #endregion

        #region Materials

        private int frog_toe;

        public int Frog_toe
        {
            get { return frog_toe; }
            set { frog_toe = value; }
        }

        private int dog_tongue;

        public int Dog_tongue
        {
            get { return dog_tongue; }
            set { dog_tongue = value; }
        }

        private int lizard_leg;

        public int Lizard_leg
        {
            get { return lizard_leg; }
            set { lizard_leg = value; }
        }

        private int wolf_tooth;

        public int Wolf_tooth
        {
            get { return wolf_tooth; }
            set { wolf_tooth = value; }
        }


        #endregion

        #region Homested

        #region T1

        private ulong coal;

        public ulong Coal
        {
            get { return coal; }
            set { coal = value; }
        }

        private ulong wheat;

        public ulong Wheat
        {
            get { return wheat; }
            set { wheat = value; }
        }

        private ulong oak;

        public ulong Oak
        {
            get { return oak; }
            set { oak = value; }
        }

        private ulong shrimp;

        public ulong Shrimp
        {
            get { return shrimp; }
            set { shrimp = value; }
        }

        #endregion

        #region T2

        private ulong copper;

        public ulong Copper
        {
            get { return copper; }
            set { copper = value; }
        }

        private ulong dinkel;

        public ulong Dinkel
        {
            get { return dinkel; }
            set { dinkel = value; }
        }

        private ulong willow;

        public ulong Willow
        {
            get { return willow; }
            set { willow = value; }
        }

        private ulong trout;

        public ulong Trout
        {
            get { return trout; }
            set { trout = value; }
        }


        #endregion

        #region T3

        private ulong tin;

        public ulong Tin
        {
            get { return tin; }
            set { tin = value; }
        }

        private ulong khroasan;

        public ulong Khroasan
        {
            get { return khroasan; }
            set { khroasan = value; }
        }

        private ulong teak;

        public ulong Teak
        {
            get { return teak; }
            set { teak = value; }
        }

        private ulong lobster;

        public ulong Lobster
        {
            get { return lobster; }
            set { lobster = value; }
        }

        #endregion

        #region T4

        private ulong silver;

        public ulong Silver
        {
            get { return silver; }
            set { silver = value; }
        }

        private ulong corn;

        public ulong Corn
        {
            get { return corn; }
            set { corn = value; }
        }

        private ulong maple;

        public ulong Maple
        {
            get { return maple; }
            set { maple = value; }
        }

        private ulong bass;

        public ulong Bass
        {
            get { return bass; }
            set { bass = value; }
        }

        #endregion

        #endregion

        #endregion

        #endregion

        public static int Sumint(Regex regex, string log)
        {
            int sum = 0;

            MatchCollection mc = regex.Matches(log);

            for(int i = 0; i < mc.Count; i++)
            {
                if(mc[i].ToString() != "??")
                   sum += int.Parse(mc[i].ToString().Replace(",",""));
            }

            return sum;
        }

        public static ulong Sumulong(Regex regex, string log)
        {
            ulong sum = 0;

            MatchCollection mc = regex.Matches(log);

            for (int i = 0; i < mc.Count; i++)
            {
                if (mc[i].ToString() != "??")
                    sum += ulong.Parse(mc[i].ToString().Replace(",", ""));
            }

            return sum;
        }

        public Report(string log)
        {

            MatchCollection startMC = RegexPattern.startTime.Matches(log);
            MatchCollection endMC = RegexPattern.endTime.Matches(log);

            MatchCollection startingdepthMC = RegexPattern.startingDepth.Matches(log);
            MatchCollection finishingdepthMC = RegexPattern.finishingDepth.Matches(log);


            if(startMC.Count == endMC.Count)
            {
                for(int i = 0; i < startMC.Count; i++)
                {
                    DateTime start = DateTime.Parse(startMC[i].ToString());
                    DateTime end = DateTime.Parse(endMC[i].ToString());

                    TotalTime += (end - start).TotalHours;
                    Caves++;

                }

                if(startingdepthMC.Count == finishingdepthMC.Count)
                {
                    for(int i = 0; i < startingdepthMC.Count; i++)
                    {
                        TotalDepthDiff += int.Parse(finishingdepthMC[i].ToString().Replace(",","")) - int.Parse(startingdepthMC[i].ToString().Replace(",", ""));
                        TotalDepthDiff++;
                    }
                }

                TreasuresFound = Sumint(RegexPattern.treasuresFound, log);

                BossesSlain = Sumint(RegexPattern.bossesSlain, log);

                MonstersSlain = Sumint(RegexPattern.monstersSlain, log);

                TilesTraveled = Sumint(RegexPattern.tilesTraveled, log);

                TilesCleared = Sumint(RegexPattern.tilesCleared, log);

                TilesLooted = Sumint(RegexPattern.tilesLooted, log);



                Diamonds = Sumint(RegexPattern.diamonds, log);

                Gold = Sumulong(RegexPattern.gold, log);
                    
            }
        }

    }
}
