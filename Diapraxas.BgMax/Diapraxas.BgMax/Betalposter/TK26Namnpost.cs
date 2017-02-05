using System;

namespace Diapraxas.BgMax.Betalposter
{
    public class TK26Namnpost : IBetalpost
    {
        public string Betalarnamn { get; set; }
        public string Extranamn { get; set; }
        public TK26Namnpost(string textrad)
        {
            Betalarnamn = textrad.Substring(2, 35).Trim();
            Extranamn = textrad.Substring(37, 35).Trim();
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