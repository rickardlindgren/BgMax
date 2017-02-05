namespace Diapraxas.BgMax.Betalposter
{
    public class TK15Insättningspost : IBetalpost
    {
        public string Mottagarbankkontonummer { get; private set; }
        public string Betalningsdag { get; private set; }
        public int Insättningslöpnummer { get; private set; }
        public int Insättningsbelopp { get; private set; }
        public string Valuta { get; private set; }
        public int AntalBetalningar { get; private set; }
        public string Insättningstyp { get; private set; }

        public TK15Insättningspost(string textrad)
        {
            Mottagarbankkontonummer = textrad.Substring(2, 35);
            Betalningsdag = textrad.Substring(37, 8);
            Insättningslöpnummer = int.Parse(textrad.Substring(45, 5));
            Insättningsbelopp = int.Parse(textrad.Substring(50, 18));
            Valuta = textrad.Substring(68, 3);
            AntalBetalningar = int.Parse(textrad.Substring(71, 8));
            Insättningstyp = textrad.Substring(79, 1);
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