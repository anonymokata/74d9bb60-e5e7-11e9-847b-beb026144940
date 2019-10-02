using System;
using System.Collections.Generic;
using System.Text;

namespace WordSearchLibrary.Search
{
    public class SearchForward : SearchEngine
    {
        public SearchForward(int cols, int rows)
        {
            this.colSize = cols;
            this.rowsSize = rows;
        }
        public override bool CheckSearchLimits(int index, string searchValue, string toSearch)
        {
            int colunmPosition = index - ((index / this.colSize) * this.colSize);
            if (index / this.colSize == 0)
            {
                colunmPosition = index;
            }
            if (colunmPosition + searchValue.Length <= this.colSize)
            {
                return true;
            }
            return false;
        }
        public override string SearchStringResult(int index, string searchValue, string toSearch)
        {
            if (CheckSearchLimits(index, searchValue, toSearch))
            {
                string value = toSearch.Substring(index, searchValue.Length);
                if (value.Contains(searchValue))
                {
                    string coordinates = CalculateCorrdinates(index, searchValue.Length);
                    return searchValue + ": " + coordinates; ;
                }
            }
            return "";
        }
        public override string CalculateCorrdinates(int Offset, int lengthToSearch)
        {
            int row = (Offset / this.rowsSize);
            int col = 0;
            if (Offset >= this.colSize)
            {
                col = Offset - row * this.colSize;
            }
            else
            {
                col = Offset;
            }
            string coordinates = "";
            for (int i = 0; i < lengthToSearch; i++)
            {
                if (i != 0)
                {
                    coordinates += ",";
                }
                coordinates += "(" + (i + col).ToString() + "," + row.ToString() + ")";
            }
            return coordinates;
        }
    }
}
