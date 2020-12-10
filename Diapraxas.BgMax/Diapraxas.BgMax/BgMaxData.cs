using System.Collections.Generic;
using Diapraxas.BgMax.Betalposter;

namespace Diapraxas.BgMax
{
    public class BgMaxData
    {
        public TK01Startpost TK01Startpost { get; private set; }
        public TK70Slutpost TK70Slutpost { get; private set; }
        public List<Avsnitt> Avsnitt { get; private set; }

        internal BgMaxData(TK01Startpost tk01Startpost, TK70Slutpost tk70Slutpost, List<Avsnitt> avsnitt)
        {
            TK01Startpost = tk01Startpost;
            TK70Slutpost = tk70Slutpost;
            Avsnitt = avsnitt;
        }

        public bool IsValid()
        {
            return TK70Slutpost.Insättningsposter == Avsnitt.Count
                   && TK70Slutpost.Betalposter == Avsnitt.Sum(a => a.Betalningar.Count)
                   && Avsnitt.All(a => a.IsValid());
        }
    }
}
