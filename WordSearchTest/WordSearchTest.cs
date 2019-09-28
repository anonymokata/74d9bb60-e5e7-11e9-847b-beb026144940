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

    }
}
