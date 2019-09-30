using System;
using System.Collections.Generic;
using System.Text;

namespace WordSearchLibrary.Search
{
    public class SearchBack : SearchString
    {
        public SearchBack(int cols, int rows)
        {
            this.colSize = cols;
            this.rowsSize = rows;
        }
        public override bool CheckSearchLimits(int index, string searchValue, string toSearch)
        {
            if ((index - searchValue.Length) >= 0)
            {
                return true;
            }
            return false;
        }
        public override bool SearchStringResult(int index, string searchValue, string toSearch)
        {
            if (CheckSearchLimits(index, searchValue, toSearch))
            {
                string value = toSearch.Substring(index - (searchValue.Length-1), searchValue.Length);
                string reverseValue = ReveseOrderOfString(searchValue);
                if (value.Contains(reverseValue))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
