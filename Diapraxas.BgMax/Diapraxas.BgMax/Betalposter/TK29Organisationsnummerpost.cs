namespace Diapraxas.BgMax.Betalposter
{
    public class TK29Organisationsnummerpost : IBetalpost
    {
        public string Organisationsnummer { get; private set; }
        public TK29Organisationsnummerpost(string textrad)
        {
            Organisationsnummer = textrad.Substring(2, 12).TrimStart('0');
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