using System;
using System.Collections.Generic;
using System.Text;

namespace WordSearchLibrary.Search
{
    public class SearchUp : SearchEngine
    {
        public SearchUp(int cols, int rows)
        {
            this.colSize = cols;
            this.rowsSize = rows;
        }
        public override bool CheckSearchLimits(int index, string searchValue, string toSearch)
        {
            int rowPosition = (index / this.rowsSize) + 1;
            if (index / this.rowsSize == 0)
            {
                rowPosition = 0;
            }
            if (rowPosition - searchValue.Length >= 0)
            {
                return true;
            }
            return false;
        }
        public override string SearchStringResult(int index, string searchValue, string toSearch)
        {
            if (CheckSearchLimits(index, searchValue, toSearch))
            {
                string value = SubStringGet(index, searchValue.Length, toSearch);
                if (value.Contains(searchValue))
                {
                    string coordinates = CalculateCorrdinates(index, searchValue.Length);
                    return searchValue + ": " + coordinates; ;
                }
            }
            return "";
        }
        public override string SubStringGet(int index, int length, string toSearch)
        {
            string value = "";
            for (int i = index, j=0; j <= length - 1;  i -= this.rowsSize, j++)
            {
                value += toSearch[i].ToString();
            }
            return value;
        }

        public override string CalculateCorrdinates(int Offset, int lengthToSearch)
        {
            int row = (Offset / this.colSize);
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
            for (int i = lengthToSearch - 1; 0 <= i; i--)
            {
                if (i != lengthToSearch - 1)
                {
                    coordinates += ",";
                }
                coordinates += "(" + (col).ToString() + "," + i + ")";
            }
            return coordinates;
        }
    }
}
