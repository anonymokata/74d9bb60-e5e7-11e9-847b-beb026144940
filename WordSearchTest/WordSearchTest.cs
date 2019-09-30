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
            WordSearch wordSearch = new WordSearch(6,6);
            var result = wordSearch.ColumnsRowsEqual(5, 5);
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void FindOffSetOfCharInSearchStringTest()
        {
            WordSearch wordSearch = new WordSearch(6, 6);
            var result = wordSearch.FindCharOffSet(0, 'J', "aJohnxxx");
            Assert.AreEqual(1, result);

        }
        [TestMethod]
        public void GetSearchForwardStringIndexTest()
        {
            WordSearch wordSearch = new WordSearch(6, 6);
            var result = wordSearch.GetSearchForwardBackStringIndex("John", "dfJohnxxx");
            Assert.AreEqual(2, result);

        }
        [TestMethod]
        public void GetSearchBackStringIndexTest()
        {
            WordSearch wordSearch = new WordSearch(6, 6);
            var result = wordSearch.GetSearchForwardBackStringIndex("nhoj", "dfnhojxxx");
            Assert.AreEqual(2, result);

        }
        [TestMethod]
        public void GetSearchDownStringIndexTest()
        {
            WordSearch wordSearch = new WordSearch(6, 6);
            var result = wordSearch.GetSearchDownUpStringIndex("IT", "XBIDFF" + "NHTJXT");
            Assert.AreEqual(2, result);

        }
        [TestMethod]
        public void GetSearchReversedDownStringIndexTest()
        {
            WordSearch wordSearch = new WordSearch(6, 6);
            var result = wordSearch.GetSearchDownUpStringIndex("TI", "XBTDYF" + "NHIJXT");
            Assert.AreEqual(2, result);

        }
        [TestMethod]
        public void GetSearchDiagDownStringIndexTest()
        {
            WordSearch wordSearch = new WordSearch(6, 6);
            var result = wordSearch.GetSearchDiagDownUpStringIndex("IT", "XBIDCF" + "NHJTXC");
            Assert.AreEqual(2, result);

        }
        [TestMethod]
        public void GetSearchDiagUpStringIndexTest()
        {
            WordSearch wordSearch = new WordSearch(6, 6);
            var result = wordSearch.GetSearchDiagDownUpStringIndex("TI", "XBTDAF" + "NHJIXT");
            Assert.AreEqual(2, result);

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
            WordSearch wordSearch = new WordSearch(6, 6);
            string result = wordSearch.GenerateForwardOutput("BOB", "XBSDCFGBOB");
            Assert.AreEqual("BOB: (1,1),(2,1),(3,1)", result);

        }
        [TestMethod]
        public void ReveseOrderOfStringTest()
        {
            WordSearch wordSearch = new WordSearch(6, 6);
            string result = wordSearch.ReveseOrderOfString("JOHN");
            Assert.AreEqual("NHOJ", result);
        }
        [TestMethod]
        public void GenerateReverseOutputTest()
        {
            WordSearch wordSearch = new WordSearch(6, 6);
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
            WordSearch wordSearch = new WordSearch(6, 6);
            string result = wordSearch.GenerateDownOutPut("IT", "XBIDCF" + "NHTJXC");
            Assert.AreEqual("IT: (2,0),(2,1)", result);

        }
        [TestMethod]
        public void GenerateUpOutputTest()
        {
            WordSearch wordSearch = new WordSearch(6, 6);
            string result = wordSearch.GenerateUpOutput("IT", "XBTDIF" + "NHIJXT");
            Assert.AreEqual("IT: (2,1),(2,0)", result);

        }
        [TestMethod]
        public void GenerateDiagDownLeftToRightDownOutputTest()
        {
            WordSearch wordSearch = new WordSearch(6, 6);
            string result = wordSearch.GenerateDiagDownLeftToRightOutPut("IT", "IBIDCF" + "NHJTXC");
            Assert.AreEqual("IT: (2,0),(3,1)", result);

        }
        [TestMethod]
        public void GenerateDiagUpRightToLeftOutputTest()
        {
            WordSearch wordSearch = new WordSearch(6, 6);
            string result = wordSearch.GenerateDiagUpRightToLeftOutput("IT", "IBTDIF" + "NHJIXT");
            Assert.AreEqual("IT: (3,1),(2,0)", result);

        }
        [TestMethod]
        public void GenerateDiagDownRightToLeftOutputTest()
        {
            WordSearch wordSearch = new WordSearch(6, 6);
            string result = wordSearch.GenerateDiagDownRightToLefOutPut("IT", "XBIDCF" + "NTHJXC");
            Assert.AreEqual("IT: (2,0),(1,1)", result);

        }
        [TestMethod]
        public void GenerateDiagUpLeftToRightOutputTest()
        {
            WordSearch wordSearch = new WordSearch(6, 6);
            string result = wordSearch.GenerateDiagUpLeftToLRightOutput("IT", "XBTDIF" + "NIHJXT");
            Assert.AreEqual("IT: (1,1),(2,0)", result);

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
        public void CalculateDiagDownLeftToRightCorrdinatesTest()
        {
            CalculateCoordinates coordinates = new CalculateCoordinates(6, 6);
            string result = coordinates.CalculateDiagDownLeftToRightCorrdinates(1, 2);
            Assert.AreEqual("(1,0),(2,1)", result);

        }
        [TestMethod]
        public void CalculateDiagUpRightToLeftCorrdinatesTest()
        {
            CalculateCoordinates coordinates = new CalculateCoordinates(6, 6);
            string result = coordinates.CalculateDiagUpRightToLeftCorrdinates(0, 2);
            Assert.AreEqual("(1,1),(0,0)", result);

        }
        [TestMethod]
        public void CalculateDiagDownRightToLeftCorrdinatesTest()
        {
            CalculateCoordinates coordinates = new CalculateCoordinates(6, 6);
            string result = coordinates.CalculateDiagDownRightToLeftCorrdinates(2, 2);
            Assert.AreEqual("(2,0),(1,1)", result);

        }
        [TestMethod]
        public void CalculateDiagUpLeftToRightCorrdinatesTest()
        {
            CalculateCoordinates coordinates = new CalculateCoordinates(6, 6);
            string result = coordinates.CalculateDiagUpLeftToRighCorrdinates(7, 2);
            Assert.AreEqual("(1,1),(0,0)", result);

        }
        [TestMethod]
        public void SearchUpMatchTest()
        {
            WordSearch wordSearch = new WordSearch(6, 6);
            bool result = wordSearch.SearchUpMatch(8, "IT", "XBTDIF" + "NHIJXT");
            Assert.AreEqual(true, result);

        }
        [TestMethod]
        public void SearchDownMatchTest()
        {
            WordSearch wordSearch = new WordSearch(6,6);
            bool result = wordSearch.SearchDownMatch(2,"IT", "XBIDIF" + "NHTJXT");
            Assert.AreEqual(true, result);

        }

        [TestMethod]
        public void SearchDiagDownRightToLeftMatchTest()
        {
            WordSearch wordSearch = new WordSearch(6, 6);
            bool result = wordSearch.SeachDiagDownRightToLeft(2, "IT", "XBIDCF" + "NHJTXC");
            Assert.AreEqual(true, result);

        }
        [TestMethod]
        public void SearchDiagUpLeftToRightMatchTest()
        {
            WordSearch wordSearch = new WordSearch(6, 6);
            bool result = wordSearch.SeachDiagUpLeftToRight(9, "IT", "XBTDAF" + "NHJIXT");
            Assert.AreEqual(true, result);

        }
        [TestMethod]
        public void GetSearchStringIndexTest()
        {
            WordSearch wordSearch = new WordSearch(6, 6);
            int result = wordSearch.GetSearchStringIndex("IT", "XBTDAF" + "NHJIXT");
            Assert.AreEqual(9, result);

        }
        [TestMethod]
        public void GetPositionOfNextCharInStringTest()
        {
            WordSearch wordSearch = new WordSearch(6, 6);
            WordSearch.GridPosition result = wordSearch.GetPositionOfNextCharInString(0, "IT", "XBTDAF" + "NHJIXT");
            Assert.AreEqual(1, result.LRUpDiag);

        }
        [TestMethod]
        public void CheckSearchLimitsSearchForwardTest()
        {
            WordSearchLibrary.Search.SearchForward searchForward = new WordSearchLibrary.Search.SearchForward(6, 6);
            bool result = searchForward.CheckSearchLimits(2, "IT", "XBITAF" + "NHJTXX");
            Assert.AreEqual(true, result);

        }
        [TestMethod]
        public void SearchStringResultSearchForwardTest()
        {
            WordSearchLibrary.Search.SearchForward searchForward = new WordSearchLibrary.Search.SearchForward(6, 6);
            bool result = searchForward.SearchStringResult(2, "IT", "XBITAF" + "NHJTXX");
            Assert.AreEqual(true, result);

        }
        [TestMethod]
        public void CheckSearchLimitsSearchBackTest()
        {
            WordSearchLibrary.Search.SearchBack searchBack = new WordSearchLibrary.Search.SearchBack(6, 6);
            bool result = searchBack.CheckSearchLimits(3, "IT", "XBTIAF" + "NHJTXX");
            Assert.AreEqual(true, result);

        }
        [TestMethod]
        public void SearchStringResultSearchBackTest()
        {
            WordSearchLibrary.Search.SearchBack searchBack = new WordSearchLibrary.Search.SearchBack(6, 6);
            bool result = searchBack.SearchStringResult(3, "IT", "XBTIAF" + "NHJTXX");
            Assert.AreEqual(true, result);

        }
        [TestMethod]
        public void CheckSearchLimitsSearchUpTest()
        {
            WordSearchLibrary.Search.SearchUp searchUp = new WordSearchLibrary.Search.SearchUp(6, 6);
            bool result = searchUp.CheckSearchLimits(9, "IT", "XBFTAF" + "NHJIXX");
            Assert.AreEqual(true, result);

        }
        [TestMethod]
        public void SearchStringResultSearchUpTest()
        {
            WordSearchLibrary.Search.SearchUp searchUp = new WordSearchLibrary.Search.SearchUp(6, 6);
            bool result = searchUp.SearchStringResult(9, "IT", "XBFTAF" + "NHJIXX");
            Assert.AreEqual(true, result);

        }
        [TestMethod]
        public void SubStringGetSearchUpTest()
        {
            WordSearchLibrary.Search.SearchUp searchUp = new WordSearchLibrary.Search.SearchUp(6, 6);
            string result = searchUp.SubStringGet(9, 2, "XBFTAF" + "NHJIXX");
            Assert.AreEqual("IT", result);

        }
        [TestMethod]
        public void CheckSearchLimitsSearchDownTest()
        {
            WordSearchLibrary.Search.SearchDown searchDown = new WordSearchLibrary.Search.SearchDown(6, 6);
            bool result = searchDown.CheckSearchLimits(3, "IT", "XBFIAF" + "NHJTXX");
            Assert.AreEqual(true, result);

        }
        [TestMethod]
        public void SearchStringResultSearchDownTest()
        {
            WordSearchLibrary.Search.SearchDown searchDown = new WordSearchLibrary.Search.SearchDown(6, 6);
            bool result = searchDown.SearchStringResult(3, "IT", "XBFIAF" + "NHJTXX");
            Assert.AreEqual(true, result);

        }
        [TestMethod]
        public void SubStringGetSearchDownTest()
        {
            WordSearchLibrary.Search.SearchDown searchDown = new WordSearchLibrary.Search.SearchDown(6, 6);
            string result = searchDown.SubStringGet(3, 2, "XBFIAF" + "NHJTXX");
            Assert.AreEqual("IT", result);

        }
        [TestMethod]
        public void CheckSearchLimitsSearchDiagDownRightToLeftTest()
        {
            WordSearchLibrary.Search.SearchDiagDownRightToLeft searchDiagDownRightToLeft = new WordSearchLibrary.Search.SearchDiagDownRightToLeft(6, 6);
            bool result = searchDiagDownRightToLeft.CheckSearchLimits(3, "IT", "XBFIAF" + "NHTJXX");
            Assert.AreEqual(true, result);

        }
        [TestMethod]
        public void SubStringGetSearchDiagDownRightToLeftTest()
        {
            WordSearchLibrary.Search.SearchDiagDownRightToLeft searchDiagDownRightToLeft = new WordSearchLibrary.Search.SearchDiagDownRightToLeft(6, 6);
            string result = searchDiagDownRightToLeft.SubStringGet(3, 2, "XBFIAF" + "NHTJXX");
            Assert.AreEqual("IT", result);

        }
        [TestMethod]
        public void CheckSearchLimitsSearchDiagDownLeftToRightTest()
        {
            WordSearchLibrary.Search.SearchDiagDownLeftToRight searchDiagDownLeftToRight = new WordSearchLibrary.Search.SearchDiagDownLeftToRight(6, 6);
            bool result = searchDiagDownLeftToRight.CheckSearchLimits(2, "IT", "XBIFAF" + "NHJTXX");
            Assert.AreEqual(true, result);

        }
        [TestMethod]
        public void SubStringGetSearchDiagDownLeftToRightTest()
        {
            WordSearchLibrary.Search.SearchDiagDownLeftToRight searchDiagDownLeftToRight = new WordSearchLibrary.Search.SearchDiagDownLeftToRight(6, 6);
            string result = searchDiagDownLeftToRight.SubStringGet(2, 2, "XBIFAF" + "NHJTXX");
            Assert.AreEqual("IT", result);

        }
    }
}
