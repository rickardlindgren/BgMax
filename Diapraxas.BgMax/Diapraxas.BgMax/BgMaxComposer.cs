using System.Collections.Generic;
using System.Linq;
using Diapraxas.BgMax.Betalposter;

namespace Diapraxas.BgMax
{
    public static class BgMaxComposer
    {

        public static BgMaxData ComposeFromFile(string path)
        {
            var textrows = new BgMaxFileReader().ReadFile(path);
            var startPost = new TK01Startpost(textrows.First());

            var slutRad = textrows.First(t => t.Substring(0, 2) == "70");
            var slutPost = new TK70Slutpost(slutRad);

            var avdelningsrader = GetAvdelningsrader(textrows);
            var avsnitt = new List<Avsnitt>();
            foreach (var avdelning in avdelningsrader)
            {
                avsnitt.Add(new Avsnitt(avdelning));
            }

            return new BgMaxData(startPost, slutPost, avsnitt);
        }

        private static List<List<string>> GetAvdelningsrader(List<string> textrows)
        {
            var rowlists = new List<List<string>>();
            var rowlist = new List<string>();
            
            foreach (var textrow in textrows)
            {
                if (textrow.StartsWith("05"))
                {
                    rowlist = new List<string>();
                }

                rowlist.Add(textrow);

                if (textrow.StartsWith("15"))
                {
                    rowlists.Add(rowlist);
                }
            }

            return rowlists;
        }
    }
}