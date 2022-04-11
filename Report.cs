using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace Queslar_Cave_Log_Analyzer
{

    internal class Report
    {
        static ConsoleWriter _outputProvider = new ConsoleWriter(Console.WriteLine);

        #region Properties

        private ulong caves;

        public ulong Caves
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

        private ulong totalDepthDiff;

        public ulong TotalDepthDiff
        {
            get { return totalDepthDiff; }
            set { totalDepthDiff = value; }
        }

        private ulong treasuresFound;

        public ulong TreasuresFound
        {
            get { return treasuresFound; }
            set { treasuresFound = value; }
        }

        private ulong bossesSlain;

        public ulong BossesSlain
        {
            get { return bossesSlain; }
            set { bossesSlain = value; }
        }

        private ulong monstersSlain;

        public ulong MonstersSlain
        {
            get { return monstersSlain; }
            set { monstersSlain = value; }
        }

        private ulong tilesTraveled;

        private ulong tilesTraveledOccurred;

        public ulong TilesTraveledOccurred
        {
            get { return tilesTraveledOccurred; }
            set { tilesTraveledOccurred = value; }
        }

        public ulong TilesTraveled
        {
            get { return tilesTraveled; }
            set { tilesTraveled = value; }
        }

        private ulong tilesCleared;

        public ulong TilesCleared
        {
            get { return tilesCleared; }
            set { tilesCleared = value; }
        }

        private ulong tilesLooted;

        public ulong TilesLooted
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

        private ulong diamonds;
        public ulong Diamonds
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

        public ulong Monster_strength
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

        public ulong Monster_agility
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

        private ulong rare_wootz;

        public ulong Rare_wootz
        {
            get { return rare_wootz; }
            set { rare_wootz = value; }
        }

        private ulong epicWootz;

        public ulong Epic_wootz    
        {
            get { return epicWootz; }
            set { epicWootz = value; }
        }

        private ulong magical_wootz;

        public ulong Magical_wootz
        {
            get { return magical_wootz; }
            set { magical_wootz = value; }
        }

        private ulong unique_wootz;

        public ulong Unique_wootz
        {
            get { return unique_wootz; }
            set { unique_wootz = value; }
        }

        private ulong relic_wootz;

        public ulong Relic_wootz
        {
            get { return relic_wootz; }
            set { relic_wootz = value; }
        }


        #endregion

        #region Materials

        private ulong frog_toe;

        public ulong Frog_toe
        {
            get { return frog_toe; }
            set { frog_toe = value; }
        }

        private ulong dog_tongue;

        public ulong Dog_tongue
        {
            get { return dog_tongue; }
            set { dog_tongue = value; }
        }

        private ulong lizard_leg;

        public ulong Lizard_leg
        {
            get { return lizard_leg; }
            set { lizard_leg = value; }
        }

        private ulong wolf_tooth;

        public ulong Wolf_tooth
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
                        TotalDepthDiff += ulong.Parse(finishingdepthMC[i].ToString().Replace(",","")) - ulong.Parse(startingdepthMC[i].ToString().Replace(",", ""));
                        TotalDepthDiff++;
                    }
                }

                TreasuresFound = Sumulong(RegexPattern.treasuresFound, log);

                BossesSlain = Sumulong(RegexPattern.bossesSlain, log);

                MonstersSlain = Sumulong(RegexPattern.monstersSlain, log);

                TilesTraveled = Sumulong(RegexPattern.tilesTraveled, log);

                TilesCleared = Sumulong(RegexPattern.tilesCleared, log);

                TilesLooted = Sumulong(RegexPattern.tilesLooted, log);



                Diamonds = Sumulong(RegexPattern.diamonds, log);

                Gold = Sumulong(RegexPattern.gold, log);


                Monster_strength = Sumulong(RegexPattern.monster_strength, log);

                Monster_health = Sumulong(RegexPattern.monster_health, log);

                Monster_agility = Sumulong(RegexPattern.monster_agility, log);

                Monster_dexterity = Sumulong(RegexPattern.monster_dexterity, log);


                Strength = Sumulong(RegexPattern.strength, log);

                Health = Sumulong(RegexPattern.health, log);

                Agility = Sumulong(RegexPattern.agility, log);

                Dexterity = Sumulong(RegexPattern.dexterity, log);


                Rare_wootz = Sumulong(RegexPattern.rare_wootz, log);

                Epic_wootz = Sumulong(RegexPattern.epic_wootz, log);

                Magical_wootz = Sumulong(RegexPattern.magical_wootz, log);

                Unique_wootz = Sumulong(RegexPattern.unique_wootz, log);

                Relic_wootz = Sumulong(RegexPattern.relic_wootz, log);


                Frog_toe = Sumulong(RegexPattern.frog_toe, log);

                Dog_tongue = Sumulong(RegexPattern.dog_tongue, log);

                Lizard_leg = Sumulong(RegexPattern.lizard_leg, log);

                Wolf_tooth = Sumulong(RegexPattern.wolf_tooth, log);


                Coal = Sumulong(RegexPattern.coal, log);

                Wheat = Sumulong(RegexPattern.wheat, log);

                Oak = Sumulong(RegexPattern.oak, log);

                Shrimp = Sumulong(RegexPattern.shrimp, log);


                Copper = Sumulong(RegexPattern.copper, log);

                Dinkel = Sumulong(RegexPattern.dinkel, log);

                Willow = Sumulong(RegexPattern.willow, log);

                Trout =  Sumulong(RegexPattern.trout, log);


                Tin = Sumulong(RegexPattern.tin, log);

                Khroasan = Sumulong(RegexPattern.khroasan, log);

                Teak = Sumulong(RegexPattern.teak, log);

                Lobster = Sumulong(RegexPattern.loboster, log);


                Silver = Sumulong(RegexPattern.silver, log);

                Corn = Sumulong(RegexPattern.corn, log);

                Maple = Sumulong(RegexPattern.maple, log);

                Bass = Sumulong(RegexPattern.bass, log);
            }
        }

        public void Print()
        {
            Console.WriteLine($"Caves: {Caves}, Total time in hours: {TotalTime}\n");

            _outputProvider.PrintResult("Diamonds", Diamonds, TotalTime);
            _outputProvider.PrintResult("Shattered Gold", Gold, TotalTime);

            ulong T4s = Silver + Corn + Maple + Bass;
            ulong T3s = Tin + Khroasan + Teak + Lobster;
            ulong T2s = Copper + Dinkel + Willow + Trout;
            ulong T1s = Coal + Wheat + Oak + Shrimp;

            _outputProvider.PrintResult("Homestead t4-s", T4s, TotalTime);
            _outputProvider.PrintResult("Homestead t3-s", T3s, TotalTime);
            _outputProvider.PrintResult("Homestead t2-s", T2s, TotalTime);
            _outputProvider.PrintResult("Homestead t1-s", T1s, TotalTime);

            _outputProvider.PrintResult("Rare Wootz", Rare_wootz, TotalTime);
            _outputProvider.PrintResult("Epic Wootz", Epic_wootz, TotalTime);
            _outputProvider.PrintResult("Magical Wootz", Magical_wootz, TotalTime);
            _outputProvider.PrintResult("Unique Wootz", Unique_wootz, TotalTime);
            _outputProvider.PrintResult("Relic Wootz", Relic_wootz, TotalTime);

            _outputProvider.PrintResult("Strength", Strength, TotalTime);
            _outputProvider.PrintResult("Health", Health, TotalTime);
            _outputProvider.PrintResult("Agility", Agility, TotalTime);
            _outputProvider.PrintResult("Dexterity", Dexterity, TotalTime);

            _outputProvider.PrintResult("Monster Strength", Monster_strength, TotalTime);
            _outputProvider.PrintResult("Monster Health", Monster_health, TotalTime);
            _outputProvider.PrintResult("Monster Agility", Monster_agility, TotalTime);
            _outputProvider.PrintResult("Monster Dexterity", Monster_dexterity, TotalTime);
        }
    }
}
