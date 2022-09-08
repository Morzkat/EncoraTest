using NUnit.Framework;

namespace EncoraInsperity.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase("abaccadcc", "ccccaaabd")]
        [TestCase("xyzxy", "xxyyz")]
        public void TestInputStringText(string input, string expectedResult)
        {
            var result = Program.SortingOperations(input);
            Assert.AreEqual(result, expectedResult);
        }

        [Test]
        [TestCase("dulgvgzwqg", "gggdlquvwz")]
        [TestCase("gxtjtmtywr", "tttgjmrwxy")]
        [TestCase("hnlnxiupgt", "nnghilptux")]
        [TestCase("gzjotckivp", "cgijkoptvz")]
        [TestCase("dpwwsdptae", "ddppwwaest")]
        [TestCase("pcscpilknb", "ccppbiklns")]
        [TestCase("btvyhhmflf", "ffhhblmtvy")]
        [TestCase("artrtnqxcr", "rrrttacnqx")]
        [TestCase("nrtcmcoadn", "ccnnadmort")]
        [TestCase("fkdsgnekft", "ffkkdegnst")]
        public void FirstTestCaseInput(string input, string expectedResult)
        {
            var result = Program.SortingOperations(input);
            Assert.AreEqual(result, expectedResult);
        }

        [Test]
        [TestCase("wzenwebuau", "eeuuwwabnz")]
        [TestCase("vokfxzynwl", "fklnovwxyz")]
        [TestCase("neldfeyrxk", "eedfklnrxy")]
        [TestCase("wqadfiodgs", "ddafgioqsw")]
        [TestCase("ykiuvzfcbc", "ccbfikuvyz")]
        public void SecondTestCaseInput(string input, string expectedResult)
        {
            var result = Program.SortingOperations(input);
            Assert.AreEqual(result, expectedResult);
        }

        [Test]
        [TestCase("qakmc", "ackmq")]
        [TestCase("rrtbk", "rrbkt")]
        [TestCase("vaixn", "ainvx")]
        [TestCase("wmpnj", "jmnpw")]
        [TestCase("uproi", "iopru")]
        [TestCase("btska", "abkst")]
        [TestCase("ejqwr", "ejqrw")]
        [TestCase("elwlg", "llegw")]
        [TestCase("oaoiy", "ooaiy")]
        [TestCase("hrqkn", "hknqr")]
        public void ThirdTestCaseInput(string input, string expectedResult)
        {
            var result = Program.SortingOperations(input);
            Assert.AreEqual(result, expectedResult);
        }

        [Test]
        [TestCase("pzjim", "ijmpz")]
        [TestCase("njnfq", "nnfjq")]
        [TestCase("xyohs", "hosxy")]
        public void FourthTestCaseInput(string input, string expectedResult)
        {
            var result = Program.SortingOperations(input);
            Assert.AreEqual(result, expectedResult);
        }

        [Test]
        [TestCase("xqycs", "cqsxy")]
        [TestCase("beoax", "abeox")]
        [TestCase("afkso", "afkos")]
        [TestCase("bldit", "bdilt")]
        [TestCase("gwrys", "grswy")]
        public void FifthTestCaseInput(string input, string expectedResult)
        {
            var result = Program.SortingOperations(input);
            Assert.AreEqual(result, expectedResult);
        }
    }
}
