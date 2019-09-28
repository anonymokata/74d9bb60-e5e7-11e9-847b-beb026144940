using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordSearchLibrary;

namespace WordSearchTest
{
    [TestClass]
    public class WordSearchTest
    {
        [TestMethod]
        public void NumberOfColumnsMatchNumberOfRowsForSearchTable()
        {
            WordSearch wordSearch = new WordSearch();
            bool result = wordSearch.ColumnsRowsEqual(5, 5);
            Assert.AreEqual(true, result);
        }
    }
}
