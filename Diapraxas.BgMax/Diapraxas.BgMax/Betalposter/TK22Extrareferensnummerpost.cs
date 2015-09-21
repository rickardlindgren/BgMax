namespace Diapraxas.BgMax.Betalposter
{
    public class TK22Extrareferensnummerpost : IBetalpost
    {
        private string t;

        public TK22Extrareferensnummerpost(string t)
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