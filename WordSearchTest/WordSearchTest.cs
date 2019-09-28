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
        public void FindOffSetOfCharInSearchStringTest()
        {
            WordSearch wordSearch = new WordSearch();
            var result = wordSearch.FindCharOffSet(0, 'J', "aJohnxxx");
            Assert.AreEqual(1, result);

        }
        [TestMethod]
        public void GetSearchForwardStringIndexTest()
        {
            WordSearch wordSearch = new WordSearch();
            var result = wordSearch.GetSearchForwardBackStringIndex("John", "dfJohnxxx");
            Assert.AreEqual(2, result);

        }
        [TestMethod]
        public void GetSearchBackStringIndexTest()
        {
            WordSearch wordSearch = new WordSearch();
            var result = wordSearch.GetSearchForwardBackStringIndex("nhoj", "dfnhojxxx");
            Assert.AreEqual(2, result);

        }
        [TestMethod]
        public void GetSearchDownStringIndexTest()
        {
            WordSearch wordSearch = new WordSearch();
            var result = wordSearch.GetSearchDownUpStringIndex("IT", "XBIDFF" + "NHTJXT");
            Assert.AreEqual(2, result);

        }
        [TestMethod]
        public void GetSearchReversedDownStringIndexTest()
        {
            WordSearch wordSearch = new WordSearch();
            var result = wordSearch.GetSearchDownUpStringIndex("TI", "XBTDYF" + "NHIJXT");
            Assert.AreEqual(2, result);

        }
        [TestMethod]
        public void GetSearchDiagDownStringIndexTest()
        {
            WordSearch wordSearch = new WordSearch();
            var result = wordSearch.GetSearchDiagDownStringIndex("IT", "XBIDCF" + "NHJTXC");
            Assert.AreEqual(2, result);

        }
        [TestMethod]
        public void GetSearchDiagUpStringIndexTest()
        {
            WordSearch wordSearch = new WordSearch();
            var result = wordSearch.GetSearchDiagUpStringIndex("IT", "XBTDAF" + "NHJIXT");
            Assert.AreEqual(9, result);

        }
        [TestMethod]
        public void CalculateForwardCorrdinatesTest()
        {
            CalculateCoordinates coordinates = new CalculateCoordinates(6, 6);
            string result = coordinates.CalculateForwardCorrdinates(7, 4);
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
            CalculateCoordinates coordinates = new CalculateCoordinates(6, 6);
            string result = coordinates.CalculateReveseCorrdinates(7, 4);
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
        public void GenerateUpOutputTest()
        {
            WordSearch wordSearch = new WordSearch();
            string result = wordSearch.GenerateUpOutput("IT", "IBTDIF" + "NHIJXT");
            Assert.AreEqual("JOHN: (0,0),(0,1)", result);

        }
        [TestMethod]
        public void GenerateDiagDownOutputTest()
        {
            WordSearch wordSearch = new WordSearch();
            string result = wordSearch.GenerateDiagDownOutPut("IT", "IBIDCF" + "NHJTXC");
            Assert.AreEqual("IT: (2,0),(3,1)", result);

        }
        [TestMethod]
        public void GenerateDiagUpOutputTest()
        {
            WordSearch wordSearch = new WordSearch();
            string result = wordSearch.GenerateDiagUpOutput("IT", "IBTDIF" + "NHJIXT");
            Assert.AreEqual("IT: (3,1),(2,0)", result);

        }
        [TestMethod]
        public void CalculateDownCorrdinatesTest()
        {
            CalculateCoordinates coordinates = new CalculateCoordinates(6, 6);
            string result = coordinates.CalculateDownCorrdinates(7, 2);
            Assert.AreEqual("(1,1),(1,2)", result);

        }
        [TestMethod]
        public void CalculateUpCorrdinatesTest()
        {
            CalculateCoordinates coordinates = new CalculateCoordinates(6, 6);
            string result = coordinates.CalculateUpCorrdinates(7, 2);
            Assert.AreEqual("(1,1),(1,0)", result);

        }
        [TestMethod]
        public void CalculateDiagDownCorrdinatesTest()
        {
            CalculateCoordinates coordinates = new CalculateCoordinates(6, 6);
            string result = coordinates.CalculateDiagDownCorrdinates(7, 2);
            Assert.AreEqual("(1,1),(2,2)", result);

        }
        [TestMethod]
        public void CalculateDiagUpCorrdinatesTest()
        {
            CalculateCoordinates coordinates = new CalculateCoordinates(6, 6);
            string result = coordinates.CalculateDiagUpCorrdinates(7, 2);
            Assert.AreEqual("(1,1),(0,0)", result);

        }
        [TestMethod]
        public void SearchUpMatchTest()
        {
            WordSearch wordSearch = new WordSearch();
            bool result = wordSearch.SearchUpMatch(8, "IT", "XBTDIF" + "NHIJXT");
            Assert.AreEqual(true, result);

        }
        [TestMethod]
        public void SearchDownMatchTest()
        {
            WordSearch wordSearch = new WordSearch();
            bool result = wordSearch.SearchDownMatch(2,"IT", "XBIDIF" + "NHTJXT");
            Assert.AreEqual(true, result);

        }

        [TestMethod]
        public void SearchDiagDownMatchTest()
        {
            WordSearch wordSearch = new WordSearch();
            bool result = wordSearch.SeachDiagDown(2, "IT", "XBIDCF" + "NHJTXC");
            Assert.AreEqual(true, result);

        }
        [TestMethod]
        public void SearchDiagUpMatchTest()
        {
            WordSearch wordSearch = new WordSearch();
            bool result = wordSearch.SeachDiagUp(9, "IT", "XBTDAF" + "NHJIXT");
            Assert.AreEqual(true, result);

        }

    }
}
