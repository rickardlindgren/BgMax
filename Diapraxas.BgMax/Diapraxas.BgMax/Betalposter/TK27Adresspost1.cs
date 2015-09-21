namespace Diapraxas.BgMax.Betalposter
{
    public class TK27Adresspost1 : IBetalpost
    {
        private string t;

        public TK27Adresspost1(string t)
        {
            this.t = t;
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