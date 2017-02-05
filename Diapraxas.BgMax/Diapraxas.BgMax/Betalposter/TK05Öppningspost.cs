using System;

namespace Diapraxas.BgMax.Betalposter
{
    /// <summary>
    /// Motsvarar post TK05 i BgMax-filen
    /// </summary>
    public class TK05Öppningspost : IBetalpost
    {
        public int Mottagarbankgironummer { get; private set; }
        public int? Mottagarplusgironummer { get; private set; }
        public string Valuta { get; private set; }

        public bool KanLäggaTillPoster
        {
            get
            {
                return true;
            }
        }

        public TK05Öppningspost(string textrad)
        {
            Mottagarbankgironummer = int.Parse(textrad.Substring(2, 10));

            int mottagarplusgironummer;
            if (int.TryParse(textrad.Substring(12, 10), out mottagarplusgironummer))
            {
                Mottagarplusgironummer = mottagarplusgironummer;
            }

            Valuta = textrad.Substring(22, 3).Trim();
        }
    }
}