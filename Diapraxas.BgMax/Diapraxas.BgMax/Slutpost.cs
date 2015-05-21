namespace Diapraxas.BgMax
{
    /// <summary>
    /// Motsvarar post TK70 i BgMax-filen
    /// </summary>
    public class Slutpost
    {
        public int Betalposter { get; private set; }
        public int Avdragsposter { get; private set; }
        public int Referensposter { get; private set; }
        public int Insättningsposter { get; private set; }

        internal Slutpost(string textrad)
        {
            Betalposter = int.Parse(textrad.Substring(2, 8));
            Avdragsposter = int.Parse(textrad.Substring(10, 8));
            Referensposter = int.Parse(textrad.Substring(18, 8));
            Insättningsposter = int.Parse(textrad.Substring(26, 8));
        }
    }
}