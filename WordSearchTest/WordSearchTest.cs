using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordSearchLibrary;

namespace WordSearchTest
{
    [TestClass]
    public class WordSearchTest
    {
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
            string result = searchForward.SearchStringResult(2, "IT", "XBITAF" + "NHJTXX");
            Assert.AreEqual("IT: (2,0),(3,0)", result);

        }
        public void CalculateCorrdinatesSearchForwardTest()
        {
            WordSearchLibrary.Search.SearchForward searchForward = new WordSearchLibrary.Search.SearchForward(6, 6);
            string result = searchForward.CalculateCorrdinates(7, 2);
            Assert.AreEqual("(2,0),(3,0)", result);

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
            string result = searchBack.SearchStringResult(3, "IT", "XBTIAF" + "NHJTXX");
            Assert.AreEqual("IT: (3,0),(2,0)", result);

        }
        [TestMethod]
        public void CalculateCorrdinatesSearchBackTest()
        {
            WordSearchLibrary.Search.SearchBack searchBack = new WordSearchLibrary.Search.SearchBack(6, 6);
            string result = searchBack.CalculateCorrdinates(3, 2);
            Assert.AreEqual("(3,0),(2,0)", result);

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
            string result = searchUp.SearchStringResult(9, "IT", "XBFTAF" + "NHJIXX");
            Assert.AreEqual("IT: (3,1),(3,0)", result);

        }
        [TestMethod]
        public void CalculateCorrdinatestSearchUpTest()
        {
            WordSearchLibrary.Search.SearchUp searchUp = new WordSearchLibrary.Search.SearchUp(6, 6);
            string result = searchUp.CalculateCorrdinates(9, 2);
            Assert.AreEqual("(3,1),(3,0)", result);

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
            string result = searchDown.SearchStringResult(3, "IT", "XBFIAF" + "NHJTXX");
            Assert.AreEqual("IT: (3,0),(3,1)", result);

        }
        [TestMethod]
        public void SubStringGetSearchDownTest()
        {
            WordSearchLibrary.Search.SearchDown searchDown = new WordSearchLibrary.Search.SearchDown(6, 6);
            string result = searchDown.SubStringGet(3, 2, "XBFIAF" + "NHJTXX");
            Assert.AreEqual("IT", result);

        }
        [TestMethod]
        public void CalculateCorrdinatestSearchDownpTest()
        {
            WordSearchLibrary.Search.SearchDown searchDown = new WordSearchLibrary.Search.SearchDown(6, 6);
            string result = searchDown.CalculateCorrdinates(3, 2);
            Assert.AreEqual("(3,0),(3,1)", result);

        }
        public void CheckSearchLimitsSearchDiagDownRightToLeftTest()
        {
            WordSearchLibrary.Search.SearchDiagDownRightToLeft searchDiagDownRightToLeft = new WordSearchLibrary.Search.SearchDiagDownRightToLeft(6, 6);
            bool result = searchDiagDownRightToLeft.CheckSearchLimits(3, "IT", "XBFIAF" + "NHTJXX");
            Assert.AreEqual(true, result);

        }
        [TestMethod]
        public void SearchStringResultSearchDiagDownRightToLeftTest()
        {
            WordSearchLibrary.Search.SearchDiagDownRightToLeft searchDiagDownRightToLeft = new WordSearchLibrary.Search.SearchDiagDownRightToLeft(6, 6);
            string result = searchDiagDownRightToLeft.SearchStringResult(3, "IT", "XBFIAF" + "NHTJXX");
            Assert.AreEqual("IT: (3,0),(2,1)", result);

        }
        [TestMethod]
        public void SubStringGetSearchDiagDownRightToLeftTest()
        {
            WordSearchLibrary.Search.SearchDiagDownRightToLeft searchDiagDownRightToLeft = new WordSearchLibrary.Search.SearchDiagDownRightToLeft(6, 6);
            string result = searchDiagDownRightToLeft.SubStringGet(3, 2, "XBFIAF" + "NHTJXX");
            Assert.AreEqual("IT", result);

        }
        [TestMethod]
        public void CalculateCorrdinatestSearchDiagDownRightToLeftTest()
        {
            WordSearchLibrary.Search.SearchDiagDownRightToLeft searchDiagDownRightToLeft = new WordSearchLibrary.Search.SearchDiagDownRightToLeft(6, 6);
            string result = searchDiagDownRightToLeft.CalculateCorrdinates(3, 2);
            Assert.AreEqual("(3,0),(2,1)", result);

        }
        [TestMethod]
        public void CheckSearchLimitsSearchDiagDownLeftToRightTest()
        {
            WordSearchLibrary.Search.SearchDiagDownLeftToRight searchDiagDownLeftToRight = new WordSearchLibrary.Search.SearchDiagDownLeftToRight(6, 6);
            bool result = searchDiagDownLeftToRight.CheckSearchLimits(2, "IT", "XBIFAF" + "NHJTXX");
            Assert.AreEqual(true, result);

        }
        [TestMethod]
        public void SearchStringResultSearchDiagDownLeftToRighTest()
        {
            WordSearchLibrary.Search.SearchDiagDownLeftToRight searchDiagDownLeftToRight = new WordSearchLibrary.Search.SearchDiagDownLeftToRight(6, 6);
            string result = searchDiagDownLeftToRight.SearchStringResult(2, "IT", "XBIFAF" + "NHJTXX");
            Assert.AreEqual("IT: (2,0),(3,1)", result);

        }
        [TestMethod]
        public void SubStringGetSearchDiagDownLeftToRightTest()
        {
            WordSearchLibrary.Search.SearchDiagDownLeftToRight searchDiagDownLeftToRight = new WordSearchLibrary.Search.SearchDiagDownLeftToRight(6, 6);
            string result = searchDiagDownLeftToRight.SubStringGet(2, 2, "XBIFAF" + "NHJTXX");
            Assert.AreEqual("IT", result);

        }
        [TestMethod]
        public void CalculateCorrdinatestSearchDiagDownLeftToRightTest()
        {
            WordSearchLibrary.Search.SearchDiagDownLeftToRight searchDiagDownLeftToRight = new WordSearchLibrary.Search.SearchDiagDownLeftToRight(6, 6);
            string result = searchDiagDownLeftToRight.CalculateCorrdinates(2, 2);
            Assert.AreEqual("(2,0),(3,1)", result);

        }
        [TestMethod]
        public void CheckSearchLimitsSearchDiagUpLeftToRightTest()
        {
            WordSearchLibrary.Search.SearchDiagUpLeftToRight searchDiagUpLeftToRight = new WordSearchLibrary.Search.SearchDiagUpLeftToRight(6, 6);
            bool result = searchDiagUpLeftToRight.CheckSearchLimits(7, "IT", "XBTFAF" + "NIHJXX");
            Assert.AreEqual(true, result);

        }
        [TestMethod]
        public void SearchStringResultSearchDiagUpLeftToRightTest()
        {
            WordSearchLibrary.Search.SearchDiagUpLeftToRight searchDiagUpLeftToRight = new WordSearchLibrary.Search.SearchDiagUpLeftToRight(6, 6);
            string result = searchDiagUpLeftToRight.SearchStringResult(7, "IT", "XBTFAF" + "NIHJXX");
            Assert.AreEqual("IT: (1,1),(2,0)", result);

        }
        [TestMethod]
        public void SubStringGetSearchDiagUpLeftToRightTest()
        {
            WordSearchLibrary.Search.SearchDiagUpLeftToRight searchDiagUpLeftToRight = new WordSearchLibrary.Search.SearchDiagUpLeftToRight(6, 6);
            string result = searchDiagUpLeftToRight.SubStringGet(7, 2, "XBTFAF" + "NIHJXX");
            Assert.AreEqual("IT", result);

        }
        [TestMethod]
        public void CalculateCorrdinatestSearchDiagUpLeftToRightTest()
        {
            WordSearchLibrary.Search.SearchDiagUpLeftToRight searchDiagUpLeftToRight = new WordSearchLibrary.Search.SearchDiagUpLeftToRight(6, 6);
            string result = searchDiagUpLeftToRight.CalculateCorrdinates(7, 2);
            Assert.AreEqual("(1,1),(2,0)", result);

        }
        [TestMethod]
        public void CheckSearchLimitsSearchDiagUpRightToLeftTest()
        {
            WordSearchLibrary.Search.SearchDiagUpRightToLeft searchDiagUpRightToLeft = new WordSearchLibrary.Search.SearchDiagUpRightToLeft(6, 6);
            bool result = searchDiagUpRightToLeft.CheckSearchLimits(9, "IT", "XBTFAF" + "NHJIXX");
            Assert.AreEqual(true, result);

        }
        [TestMethod]
        public void SearchStringResultSearchDiagUpRightToLeftTest()
        {
            WordSearchLibrary.Search.SearchDiagUpRightToLeft searchDiagUpRightToLeft = new WordSearchLibrary.Search.SearchDiagUpRightToLeft(6, 6);
            string result = searchDiagUpRightToLeft.SearchStringResult(8, "IT", "XTBFAF" + "NHIJXX");
            Assert.AreEqual("IT: (2,1),(1,0)", result);

        }
        [TestMethod]
        public void SubStringGetSearchDiagUpRightToLeftTest()
        {
            WordSearchLibrary.Search.SearchDiagUpRightToLeft searchDiagUpRightToLeft = new WordSearchLibrary.Search.SearchDiagUpRightToLeft(6, 6);
            string result = searchDiagUpRightToLeft.SubStringGet(8, 2, "XTBFAF" + "NHIJXX");
            Assert.AreEqual("IT", result);

        }
        [TestMethod]
        public void CalculateCorrdinatestSearchDiagUpRightToLeftTest()
        {
            WordSearchLibrary.Search.SearchDiagUpRightToLeft searchDiagUpRightToLeft = new WordSearchLibrary.Search.SearchDiagUpRightToLeft(6, 6);
            string result = searchDiagUpRightToLeft.CalculateCorrdinates(8, 2);
            Assert.AreEqual("(2,1),(1,0)", result);

        }
    }
}
