using System;
using System.Collections.Generic;
using System.Text;

namespace WordSearchLibrary
{
    public class SearchEngine
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


    }
}
