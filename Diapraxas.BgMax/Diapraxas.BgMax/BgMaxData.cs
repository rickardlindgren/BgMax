using System.Collections.Generic;
using Diapraxas.BgMax.Betalposter;

namespace Diapraxas.BgMax
{
    public class BgMaxData
    {
        public TK01Startpost TK01Startpost { get; private set; }
        public TK70Slutpost TK70Slutpost { get; private set; }
        public List<Avsnitt> Avsnitt { get; private set; }

        internal BgMaxData(TK01Startpost tk01Startpost, TK70Slutpost tk07Slutpost, List<Avsnitt> avsnitt)
        {
            TK01Startpost = tk01Startpost;
            TK70Slutpost = tk07Slutpost;
            Avsnitt = avsnitt;
        }
    }
}