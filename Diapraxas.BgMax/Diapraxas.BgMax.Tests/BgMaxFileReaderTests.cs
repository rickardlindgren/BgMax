using System.IO;
using System.Linq;
using NUnit.Framework;
using Should;

namespace Diapraxas.BgMax
{
    [TestFixture]
    public class BgMaxFileReaderTests
    {
        [Test]
        [ExpectedException(typeof(FileNotFoundException))]
        public void Throws_exception_when_file_not_found()
        {
            var sut = new BgMaxFileReader();
            sut.ReadFile("notFound.txt");
        }

        [Test]
        public void Can_read_all_rows_with_valid_transaktionskod_from_file()
        {
            var sut = new BgMaxFileReader();
            var result = sut.ReadFile("testdata\\validTransaktionskoder.txt");
            result.Count().ShouldEqual(11);
        }

        [Test]
        public void Can_read_all_rows_with_valid_transaktionskod_from_file2()
        {
            var sut = new BgMaxFileReader();
            var result = sut.ReadFile2("testdata\\bankgiroinbetalningar_exempelfil_avtal-om-ocr-kontroll_checksiffra_langd_sv.txt");
            result.Count().ShouldEqual(11);
        }

        [Test]
        public void Can_skip_invalid_rows()
        {
            var sut = new BgMaxFileReader();
            var result = sut.ReadFile("testdata\\someInvalidTransaktionskoder.txt");
            result.Count().ShouldEqual(3);
        }


    }
}