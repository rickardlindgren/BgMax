namespace Diapraxas.BgMax
{
    /// <summary>
    /// Motsvarar post TK01 i BgMax-filen
    /// </summary>
    public class Startpost
    {
        public string Layoutnamn { get; private set; }
        public int Version { get; private set; }
        public string Tidsstämpel { get; private set; }
        public string Testmarkering { get; private set; }

        internal Startpost(string textrad)
        {
            Layoutnamn = textrad.Substring(2, 20).Trim();
            Version = int.Parse(textrad.Substring(22, 2));
            Tidsstämpel = textrad.Substring(24, 20).Trim();
            Testmarkering = textrad.Substring(44, 1).Trim();
        }
    }
}