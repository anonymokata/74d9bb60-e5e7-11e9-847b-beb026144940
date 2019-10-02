using System;
using System.Collections.Generic;
using System.Text;

namespace WordSearchLibrary.Search
{
    public class SearchEngine : ISearchEngine
    {
        public string coordinates;
        public int rowsSize;
        public int colSize;

        public virtual bool CheckSearchLimits(int index, string searchValue, string toSearch)
        {
            int colunmPosition = index - (index / this.colSize) * this.colSize + 1;
            if (index/this.colSize == 0)
            {
                colunmPosition = index;
            }
            int rowPosition = (index / this.rowsSize)+ 1;
            if (index/this.rowsSize == 0)
            {
                rowPosition = 0;
            }
            if ((colunmPosition - searchValue.Length >= 0) &&
                (colunmPosition + searchValue.Length <= this.colSize) &&
                (rowPosition - searchValue.Length >= 0) &&
                (rowPosition + searchValue.Length <= this.rowsSize))
            {
                return true;
            }
            return false;
        }
        public virtual string SubStringGet(int index, int length, string toSearch)
        {
            return "";
        }
        public virtual string SearchStringResult(int index, string searchValue, string toSearch)
        {
            return "";
        }
        public virtual string CalculateCorrdinates(int Offset, int lengthToSearch)
        {
            return "";
        }
        public string ReveseOrderOfString(string stringUsedToSearch)
        {
            string reverseString = "";
            for (int i = stringUsedToSearch.Length - 1; 0 <= i; i--)
            {
                reverseString += stringUsedToSearch[i];
            }
            return reverseString;
        }
        public static int GetIndex(int index, string searchValue, string toSearch)
        {
            int offset = toSearch.IndexOf(searchValue[0], index);
            return offset;
        }

        public static bool RunEngines(List<SearchEngine> searchEngines, int index, string value, string searchGrid)
        {
            foreach (SearchEngine engine in searchEngines)
            {
                string output = engine.SearchStringResult(index, value, searchGrid);
                if (output != "")
                {
                    Console.Write(output + "\n");
                    return true;
                }
            }
            return false;
        }
    }
}
