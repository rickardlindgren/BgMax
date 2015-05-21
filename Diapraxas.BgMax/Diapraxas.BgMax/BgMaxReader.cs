using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Diapraxas.BgMax
{
    public static class BgMaxReader
    {
        public static BgMaxData ReadFile(string path)
        {
            if (!File.Exists(path))
            {
                throw new FileNotFoundException("Hittade inte filen.", path);
            }

            var textrows = File.ReadLines(path, Encoding.Default)
                .Where(l => !string.IsNullOrEmpty(l))
                .ToList();
            var startPost = new Startpost(textrows.First());
            var slutRad = textrows.First(t => t.Substring(0, 2) == "70");
            var slutPost = new Slutpost(slutRad);

            var avdelningsrader = GetAvdelningsrader(textrows);
            var avsnitt = new List<Avsnitt>();
            foreach (var avdelning in avdelningsrader)
            {
                avsnitt.Add(new Avsnitt());
            }

            return new BgMaxData(startPost, slutPost, avsnitt);
        }

        private static List<List<string>> GetAvdelningsrader(List<string> textrows)
        {
            bool isAvdelning = false;
            var rowlists = new List<List<string>>();
            var rowlist = new List<string>();

            foreach (var textrow in textrows)
            {
                if (textrow.StartsWith("05"))
                {
                    isAvdelning = true;
                    rowlist = new List<string>();
                }
                if (textrow.StartsWith("15"))
                {
                    isAvdelning = false;
                    rowlists.Add(rowlist);
                }
            }



            return rowlists;
        }
    }
}