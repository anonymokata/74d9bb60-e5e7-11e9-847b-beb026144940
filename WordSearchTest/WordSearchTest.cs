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
            bool result = wordSearch.ColumnsRowsEqual(5, 5);
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void ForwardStringMatchTest()
        {
            WordSearch wordSearch = new WordSearch();
            bool result = wordSearch.ForwardSearchStringsMatch("BOB", "BOB");
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void ReverseStringMatchTest()
        {
            WordSearch wordSearch = new WordSearch();
            bool result = wordSearch.ReverseSearchStringsMatch("FRED", "DERF");
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void UpStringMatchTest()
        {
            WordSearch wordSearch = new WordSearch();
            bool result = wordSearch.UpSearchStringsMatch("FRED", "DERF");
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void DownStringMatchTest()
        {
            WordSearch wordSearch = new WordSearch();
            bool result = wordSearch.DownSearchStringsMatch("Bill", "Bill");
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void DiagUpStringMatchTest()
        {
            WordSearch wordSearch = new WordSearch();
            bool result = wordSearch.DiagUpSearchStringsMatch("Cindy", "Cindy");
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void DiagDownStringMatchTest()
        {
            WordSearch wordSearch = new WordSearch();
            bool result = wordSearch.DiagDownSearchStringsMatch("John", "John");
            Assert.AreEqual(true, result);
        }

    }
}
