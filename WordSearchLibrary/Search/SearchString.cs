using System;
using System.Collections.Generic;
using System.Text;

namespace WordSearchLibrary
{
    public class SearchString
    {
        public string coordinates;
        public int rowsSize;
        public int colSize;

        public virtual bool CheckSearchLimits(int index, string searchValue, string toSearch)
        {
            return true;
        }
        public virtual bool SearchStringResult(int index, string searchValue, string toSearch)
        {
            return true;
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


    }
}
