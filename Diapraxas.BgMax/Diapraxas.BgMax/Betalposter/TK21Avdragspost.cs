namespace Diapraxas.BgMax.Betalposter
{
    public class TK21Avdragspost : IBetalpost
    {
        private string t;

        public TK21Avdragspost(string t)
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