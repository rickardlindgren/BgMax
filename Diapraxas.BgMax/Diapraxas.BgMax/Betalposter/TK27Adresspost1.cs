namespace Diapraxas.BgMax.Betalposter
{
    public class TK27Adresspost1 : IBetalpost
    {
        public string Adress { get; private set; }
        public string Postnummer { get; private set; }
        public TK27Adresspost1(string textrad)
        {
            Adress = textrad.Substring(2, 35).Trim();
            Postnummer = textrad.Substring(37, 9).Trim();
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