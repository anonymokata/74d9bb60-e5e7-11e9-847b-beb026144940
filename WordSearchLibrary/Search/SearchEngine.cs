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
            return true;
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

    }
}
