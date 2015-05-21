using System.IO;
using NUnit.Framework;
using Should;

namespace Diapraxas.BgMax
{
    [TestFixture]
    public class BgMaxFilTests
    {
        [Test]
        [ExpectedException(typeof(FileNotFoundException))]
        public void Throws_exception_when_file_not_found()
        {
            BgMaxReader.ReadFile("notFound.txt");
        }

        [Test]
        public void Can_read_Startpost()
        {
            var result = BgMaxReader.ReadFile("testdata\\bankgiroinbetalningar_exempelfil_avtal-om-ocr-kontroll_checksiffra_langd_sv.txt");
            result.Startpost.Layoutnamn.ShouldEqual("BGMAX");
            result.Startpost.Version.ShouldEqual(1);
            result.Startpost.Tidsstämpel.ShouldEqual("20040525173035010331");
            result.Startpost.Testmarkering.ShouldEqual("P");
        }

        [Test]
        public void Can_read_Slutpost()
        {
            var result = BgMaxReader.ReadFile("testdata\\bankgiroinbetalningar_exempelfil_avtal-om-ocr-kontroll_checksiffra_langd_sv.txt");
            result.Slutpost.Betalposter.ShouldEqual(8);
            result.Slutpost.Avdragsposter.ShouldEqual(1);
            result.Slutpost.Referensposter.ShouldEqual(9);
            result.Slutpost.Insättningsposter.ShouldEqual(3);
        }

        [Test]
        public void Can_count_Avsnitt()
        {
            var result = BgMaxReader.ReadFile("testdata\\bankgiroinbetalningar_exempelfil_avtal-om-ocr-kontroll_checksiffra_langd_sv.txt");
            result.Avsnitt.Count.ShouldEqual(3);
        }

        [Test]
        public void Can_read_everything_in_first_avsnitt()
        {
            var result = BgMaxReader.ReadFile("testdata\\bankgiroinbetalningar_exempelfil_avtal-om-ocr-kontroll_checksiffra_langd_sv.txt");
            var avsnitt = result.Avsnitt[0];

        }

    }
}