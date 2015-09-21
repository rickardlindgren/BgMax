namespace Diapraxas.BgMax.Betalposter
{
    class TK28Adresspost2 : IBetalpost
    {
        private string t;

        public TK28Adresspost2(string t)
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