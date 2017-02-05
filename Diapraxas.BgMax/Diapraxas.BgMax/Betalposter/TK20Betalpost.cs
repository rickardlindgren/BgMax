using System;

namespace Diapraxas.BgMax.Betalposter
{
    public class TK20Betalpost : IBetalpost
    {
        public string AvsändarBankgironummer { get; private set; }
        public string Referens { get; private set; }
        public float Betalningsbelopp { get; set; }
        public string Referenskod { get; set; }
        public string Betalningskanalkod { get; set; }
        public long BGCLöpnummer { get; set; }
        public string Avibildmarkering { get; set; }

        public TK20Betalpost(string textrad)
        {
            AvsändarBankgironummer = textrad.Substring(2, 10).TrimStart('0');
            Referens = textrad.Substring(12, 25).Trim();
            Betalningsbelopp = float.Parse(textrad.Substring(37, 18)) / 100;
            Referenskod = textrad.Substring(55, 1);
            Betalningskanalkod = textrad.Substring(56, 1);
            BGCLöpnummer = long.Parse(textrad.Substring(57, 12));
            Avibildmarkering = textrad.Substring(69, 1);
        }

        public bool KanLäggaTillPoster
        {
            get
            {
                return false;
            }
        }
    }
}