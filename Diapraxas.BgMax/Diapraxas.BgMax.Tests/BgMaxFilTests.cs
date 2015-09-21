using Diapraxas.BgMax.Betalposter;
using NUnit.Framework;
using Should;

namespace Diapraxas.BgMax
{
    [TestFixture]
    public class BgMaxFilTests
    {
        [Test]
        public void Can_read_Startpost()
        {
            var startpost = new TK01Startpost("01BGMAX               0120040525173035010331P                                   ");
            startpost.Layoutnamn.ShouldEqual("BGMAX");
            startpost.Version.ShouldEqual(1);
            startpost.Tidsstämpel.ShouldEqual("20040525173035010331");
            startpost.Testmarkering.ShouldEqual("P");
        }

        [Test]
        public void Can_read_Slutpost()
        {
            var slutpost = new TK70Slutpost("7000000008000000010000000900000003");
            slutpost.Betalposter.ShouldEqual(8);
            slutpost.Avdragsposter.ShouldEqual(1);
            slutpost.Referensposter.ShouldEqual(9);
            slutpost.Insättningsposter.ShouldEqual(3);
        }

        [Test]
        public void Can_count_Avsnitt()
        {
            var result = BgMaxComposer.ComposeFromFile("testdata\\bankgiroinbetalningar_exempelfil_avtal-om-ocr-kontroll_checksiffra_langd_sv.txt");
            result.Avsnitt.Count.ShouldEqual(3);
        }

        [Test]
        public void Can_read_everything_in_first_avsnitt()
        {
            var result = BgMaxComposer.ComposeFromFile("testdata\\bankgiroinbetalningar_exempelfil_avtal-om-ocr-kontroll_checksiffra_langd_sv.txt");
            var avsnitt = result.Avsnitt[0];
            avsnitt.Tk05Öppningspost.Mottagarbankgironummer.ShouldEqual("0009912346");
        }

    }
}