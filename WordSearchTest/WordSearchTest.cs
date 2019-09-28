using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordSearchLibrary;

namespace WordSearchTest
{
    [TestClass]
    public class WordSearchTest
    {
     
        [TestMethod]
        public void NumberOfColumnsMatchNumberOfRowsForSearchTableTest()
        {
            WordSearch wordSearch = new WordSearch();
            var result = wordSearch.ColumnsRowsEqual(5, 5);
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void ForwardStringMatchTest()
        {
            WordSearch wordSearch = new WordSearch();
            var result = wordSearch.ForwardSearchStringsMatch("BOB", "BOB");
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void FindOffSetOfCharInSearchStringTest()
        {
            WordSearch wordSearch = new WordSearch();
            var result = wordSearch.FindCharOffSet(0, 'J', "aJohnxxx");
            Assert.AreEqual(1, result);

        }
        [TestMethod]
        public void GetSearchStringIndexTest()
        {
            WordSearch wordSearch = new WordSearch();
            var result = wordSearch.GetSearchStringIndex("John", "dfJohnxxx");
            Assert.AreEqual(2, result);

        }
        [TestMethod]
        public void CalculateForwardCorrdinatesTest()
        {
            WordSearch wordSearch = new WordSearch();
            string result = wordSearch.CalculateForwardCorrdinates(7, 4);
            Assert.AreEqual("(1,1),(2,1),(3,1),(4,1)", result);

        }
        [TestMethod]
        public void GenerateForwardOutputTest()
        {
            WordSearch wordSearch = new WordSearch();
            string result = wordSearch.GenerateForwardOutput("BOB", "XBSDCFGBOB");
            Assert.AreEqual("BOB: (1,1),(2,1),(3,1)", result);

        }
        [TestMethod]
        public void ReveseOrderOfStringTest()
        {
            WordSearch wordSearch = new WordSearch();
            string result = wordSearch.ReveseOrderOfString("JOHN");
            Assert.AreEqual("NHOJ", result);
        }
        [TestMethod]
        public void GenerateReverseOutputTest()
        {
            WordSearch wordSearch = new WordSearch();
            string result = wordSearch.GenerateReverseOutput("JOHN", "XBSDCF" + "NHOJDJ");
            Assert.AreEqual("JOHN: (3,1),(2,1),(1,1),(0,1)", result);

        }
        [TestMethod]
        public void CalculateReveseCorrdinatesTest()
        {
            WordSearch wordSearch = new WordSearch();
            string result = wordSearch.CalculateReveseCorrdinates(7, 4);
            Assert.AreEqual("(4,1),(3,1),(2,1),(1,1)", result);

        }
        [TestMethod]
        public void GenerateDownOutputTest()
        {
            WordSearch wordSearch = new WordSearch();
            string result = wordSearch.GenerateDownOutPut("IT", "IBIDCF" + "NHTJXC");
            Assert.AreEqual("JOHN: (2,0),(2,1)", result);

        }
        [TestMethod]
        public void CalculateDownCorrdinatesTest()
        {
            WordSearch wordSearch = new WordSearch();
            string result = wordSearch.CalculateDownCorrdinates(7, 2);
            Assert.AreEqual("(1,1),(1,2)", result);

        }
        [TestMethod]
        public void GenerateUpOutputTest()
        {
            WordSearch wordSearch = new WordSearch();
            string result = wordSearch.GenerateUpOutput("IT", "IBTDIF" + "NHIJXT");
            Assert.AreEqual("JOHN: (0,0),(0,1)", result);

        }
        [TestMethod]
        public void CalculateUpCorrdinatesTest()
        {
            WordSearch wordSearch = new WordSearch();
            string result = wordSearch.CalculateUpCorrdinates(7, 2);
            Assert.AreEqual("(1,1),(1,0)", result);

        }
        [TestMethod]
        public void CalculateDiagDownCorrdinatesTest()
        {
            WordSearch wordSearch = new WordSearch();
            string result = wordSearch.CalculateDiagDownCorrdinates(7, 2);
            Assert.AreEqual("(1,1),(2,2)", result);

        }
        [TestMethod]
        public void CalculateDiagUpCorrdinatesTest()
        {
            WordSearch wordSearch = new WordSearch();
            string result = wordSearch.CalculateDiagUpCorrdinates(7, 2);
            Assert.AreEqual("(1,1),(0,0)", result);

        }
    }
}
