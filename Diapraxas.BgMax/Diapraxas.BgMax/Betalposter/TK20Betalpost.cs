using System;

namespace Diapraxas.BgMax.Betalposter
{
    public class TK20Betalpost : IBetalpost
    {
        private string t;

        public TK20Betalpost(string t)
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