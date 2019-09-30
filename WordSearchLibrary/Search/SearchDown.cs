using System;
using System.Collections.Generic;
using System.Text;

namespace WordSearchLibrary.Search
{
    public class SearchDown : SearchString
    {
        public SearchDown(int cols, int rows)
        {
            this.colSize = cols;
            this.rowsSize = rows;
        }
        public override bool CheckSearchLimits(int index, string searchValue, string toSearch)
        {
            int rowPosition = (index / this.rowsSize) * this.rowsSize;
           if (rowPosition + searchValue.Length <= this.rowsSize)
            {
                return true;
            }
            return false;
        }

        public override string SubStringGet(int index, int length, string toSearch)
        {
            string value = "";
            int limit = index + ((length - 1) * this.rowsSize);
            for (int i = index; i <= limit; i += this.rowsSize)
            {
                value += toSearch[i].ToString();
            }
            return value;
        }
    }
}
