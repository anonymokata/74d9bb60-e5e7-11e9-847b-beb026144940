using System;
using System.Collections.Generic;
using System.Text;

namespace WordSearchLibrary.Search
{
    public class SearchUp : SearchString
    {
        public SearchUp(int cols, int rows)
        {
            this.colSize = cols;
            this.rowsSize = rows;
        }
        public override bool CheckSearchLimits(int index, string searchValue, string toSearch)
        {
            if ((index -((searchValue.Length-1)*this.rowsSize)) > 0)
            {
                return true;
            }
            return false;
        }
        public override string SubStringGet(int index, int length, string toSearch)
        {
            string value = "";
            int limit = index - ((length - 1) * this.rowsSize);
            for (int i = index; i >= limit; i -= this.rowsSize)
            {
                value += toSearch[i].ToString();
            }
            return value;
        }

    }
}
