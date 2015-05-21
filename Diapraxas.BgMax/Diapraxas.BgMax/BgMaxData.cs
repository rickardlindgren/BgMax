using System.Collections.Generic;

namespace Diapraxas.BgMax
{
    public class BgMaxData
    {
        public Startpost Startpost { get; private set; }
        public Slutpost Slutpost { get; private set; }
        public List<Avsnitt> Avsnitt { get; private set; }

        internal BgMaxData(Startpost startpost, Slutpost slutpost, List<Avsnitt> avsnitt)
        {
            Startpost = startpost;
            Slutpost = slutpost;
            Avsnitt = avsnitt;
        }
    }
}