namespace Diapraxas.BgMax.Betalposter
{
    public class TK28Adresspost2 : IBetalpost
    {
        public string Ortsadress { get; private set; }
        public string Land { get; private set; }
        public string Landkod { get; private set; }

        public TK28Adresspost2(string textrad)
        {
            Ortsadress = textrad.Substring(2, 35).Trim();
            Land = textrad.Substring(37, 35).Trim();
            Landkod = textrad.Substring(72, 2).Trim();
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
