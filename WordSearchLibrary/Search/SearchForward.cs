using System;
using System.Collections.Generic;
using System.Text;

namespace WordSearchLibrary.Search
{
    public class SearchForward : SearchString
    {
        public SearchForward(int cols, int rows)
        {
            this.colSize = cols;
            this.rowsSize = rows;
        }
        public override bool CheckSearchLimits(int index, string searchValue, string toSearch)
        {
            if ((index + searchValue.Length) >= toSearch.Length)
            {
                return false;
            }
            else if((index + searchValue.Length) > this.rowsSize)
            {
                return false;
            }
            return true;
        }
        public override bool SearchStringResult(int index, string searchValue, string toSearch)
        {
            if (CheckSearchLimits(index, searchValue, toSearch))
            {
                string value = toSearch.Substring(index, searchValue.Length);
                if (value.Contains(searchValue))
                {
                    return true;
                }
            }
            return false;
        }
   }
}
