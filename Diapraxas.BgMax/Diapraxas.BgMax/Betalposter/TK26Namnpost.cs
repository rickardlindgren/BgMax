using System;

namespace Diapraxas.BgMax.Betalposter
{
    class TK26Namnpost : IBetalpost
    {
        private string t;

        public TK26Namnpost(string t)
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