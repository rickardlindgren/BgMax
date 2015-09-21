namespace Diapraxas.BgMax.Betalposter
{
    class TK29Organisationsnummerpost : IBetalpost
    {
        private string t;

        public TK29Organisationsnummerpost(string t)
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