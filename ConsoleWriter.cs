using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Queslar_Cave_Log_Analyzer
{
    internal class ConsoleWriter
    {

        const string numberFormat = "#,##0.##";
        const int padding = 18;
        const int headerPadding = 18;

        private readonly Action<string> _outputProvider;

        public ConsoleWriter(Action<string> outputProvider)
        {
            _outputProvider = outputProvider;
        }

        public void PrintResult(string header, ulong item, double totalTime)
        {
            _outputProvider($"| {header.PadRight(headerPadding)} | Total: {item.ToString(numberFormat).PadLeft(padding)} | Per hour: {(item / totalTime).ToString(numberFormat).PadLeft(padding)} | Per day: {(item / totalTime * 24).ToString(numberFormat).PadLeft(padding)} | ");
        }

        public void PrintLine()
        {
            int _length = 2 + headerPadding + 10 + padding + 13 + padding + 12 + padding + 2;
            StringBuilder line = new StringBuilder();
            line.Append('-', _length);
            _outputProvider(line.ToString());
        }

    }
}
