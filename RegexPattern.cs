using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;


namespace Queslar_Cave_Log_Analyzer
{
    internal static class RegexPattern
    {
        public static Regex startTime = new Regex("(?<!-.)[a-z]{3}\\s+[0-9]{1,2}.[0-9]{4}..[0-9:0-9]*", RegexOptions.Singleline | RegexOptions.IgnoreCase);

        public static Regex endTime = new Regex("-\\s?[a-z]{3}\\s+[0-9]{1,2}.[0-9]{4}..[0-9:0-9]*", RegexOptions.Singleline | RegexOptions.IgnoreCase);
    }
}
