using System.Collections.Generic;
using Diapraxas.BgMax.Betalposter;

namespace Diapraxas.BgMax
{
    public class Avsnitt
    {
        public TK05Öppningspost Tk05Öppningspost { get; set; }
        public TK15Insättningspost Tk15Insättningspost { get; set; }
        public List<Betalning> Betalningar { get; set; }

        public Avsnitt(List<string> avdelning)
        {
            var rowlists = new List<List<string>>();
            var rowlist = new List<string>();

            foreach (string textrad in avdelning)
            {
                if (textrad.StartsWith("05"))
                {
                    Tk05Öppningspost = new TK05Öppningspost(textrad);
                    continue;
                }

                if (textrad.StartsWith("15"))
                {
                    Tk15Insättningspost = new TK15Insättningspost(textrad);
                    continue;
                } 

                if (textrad.StartsWith("20") && rowlist.Count > 1)
                {
                    rowlists.Add(rowlist);
                    rowlist = new List<string>();
                }

                rowlist.Add(textrad);
            }

            rowlists.Add(rowlist);

            Betalningar = GetBetalningar(rowlists);
        }

        public bool IsValid()
        {
            return Tk15Insättningspost.AntalBetalningar == Betalningar.Count
                   && Tk15Insättningspost.Insättningsbelopp == Betalningar.Sum(b => b.Tk20Betalpost.Betalningsbelopp);
        }

        private List<Betalning> GetBetalningar(List<List<string>> avdelningsrader)
        {
            List<Betalning> betalningar = new List<Betalning>();

            foreach (var avdelning in avdelningsrader)
            {
                Betalning betalning = new Betalning(avdelning);
                betalningar.Add(betalning);
            }

            return betalningar;
        }
    }
}
