﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Queslar_Cave_Log_Analyzer
{
    internal class Program
    {
        static string version = "ALPHA";


        public static void Main()
        {
            Console.Clear();
            Console.WriteLine($" \\\\\\ Queslar Cave Log Analyzer {version} ///\n\n");

            Console.WriteLine("Please paste your cave logs here: (after paste click enter 2 times!!)");
            StringBuilder logs = new StringBuilder();
            string readed = string.Empty;
            while ((readed = Console.ReadLine()) != "")
            {
                logs.AppendLine(readed);
            }


            Console.Clear();
            Console.WriteLine($" \\\\\\ Queslar Cave Log Analyzer {version} ///\n\n");


            Report rep = new Report(logs.ToString());

            Console.WriteLine($"caves: {rep.Caves}, Total time in hours: {rep.TotalTime}");

            Console.WriteLine($"diamonds: {rep.Diamonds}, Gold: {rep.Gold}");

            Console.WriteLine($"diamonds/h: {rep.Diamonds / rep.TotalTime}, gold/h: {rep.Gold / rep.TotalTime}");

            Console.WriteLine($"diamonds/day: {rep.Diamonds / rep.TotalTime * 24}, gold/day: {rep.Gold / rep.TotalTime * 24}");
        }
    }
}
