namespace Diapraxas.BgMax.Betalposter
{
    public class TK15Insättningspost : IBetalpost
    {
        private string t;

        public TK15Insättningspost(string t)
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