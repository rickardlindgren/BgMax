using System;

namespace Diapraxas.BgMax.Betalposter
{
    /// <summary>
    /// Motsvarar post TK01 i BgMax-filen
    /// </summary>
    public class TK01Startpost : IBetalpost
    {
        public string Layoutnamn { get; private set; }
        public int Version { get; private set; }
        public string Tidsstämpel { get; private set; }
        public string Testmarkering { get; private set; }

        public bool KanLäggaTillPoster
        {
            get
            {
                return true;
            }
        }

        public TK01Startpost(string textrad)
        {
            Layoutnamn = textrad.Substring(2, 20).Trim();
            Version = int.Parse(textrad.Substring(22, 2));
            Tidsstämpel = textrad.Substring(24, 20).Trim();
            Testmarkering = textrad.Substring(44, 1).Trim();
        }
    }
}