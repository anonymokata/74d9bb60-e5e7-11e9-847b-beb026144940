using System;
using System.Collections.Generic;
using System.Text;

namespace WordSearchLibrary.Search
{
    public class SearchDiagUpRightToLeft : SearchString
    {
        public SearchDiagUpRightToLeft(int cols, int rows)
        {
            this.colSize = cols;
            this.rowsSize = rows;
        }
        public override bool CheckSearchLimits(int index, string searchValue, string toSearch)
        {
            int colunmPosition = (index / this.colSize) * this.colSize - index;
            int rowPosition = (index / this.rowsSize) * this.rowsSize;
            if (colunmPosition - searchValue.Length >= 0)
            {
                return true;
            }
            else if (rowPosition - searchValue.Length >= 0)
            {
                return true;
            }
            return false;
        }
        public override string SubStringGet(int index, int length, string toSearch)
        {
            string value = "";
            int limit = index - ((length - 1) * this.rowsSize) - 1;
            for (int i = index; i >= limit; i -= (this.rowsSize + 1))
            {
                value += toSearch[i].ToString();
            }
            return value;
        }
    }
}
