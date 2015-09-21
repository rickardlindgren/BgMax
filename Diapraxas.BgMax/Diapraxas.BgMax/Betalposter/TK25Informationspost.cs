namespace Diapraxas.BgMax.Betalposter
{
    public class TK25Informationspost : IBetalpost
    {
        private string t;

        public TK25Informationspost(string t)
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