namespace Diapraxas.BgMax.Betalposter
{
    public class TK23Extrareferensnummerpost : IBetalpost
    {
        private string t;

        public TK23Extrareferensnummerpost(string t)
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