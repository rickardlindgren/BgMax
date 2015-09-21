using System.Collections.Generic;
using System.Linq;
using Diapraxas.BgMax.Betalposter;

namespace Diapraxas.BgMax
{
    public static class BgMaxComposer
    {

        public static BgMaxData ComposeFromFile(string path)
        {
            var textrows =new BgMaxFileReader().ReadFile(path);
            var rows2 = new BgMaxFileReader().ReadFile2(path);
            var startPost = new TK01Startpost(textrows.First());
            var slutRad = textrows.First(t => t.Substring(0, 2) == "70");
            var slutPost = new TK70Slutpost(slutRad);

            var avdelningsrader = GetAvdelningsrader(null);
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