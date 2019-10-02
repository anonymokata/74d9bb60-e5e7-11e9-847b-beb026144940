using System;
using System.Collections.Generic;
using System.Text;

namespace WordSearchLibrary.Search
{
    public class SearchUp : SearchEngine
    {
        private int ColunmPosition { get; set; }
        private int RowPosition { get; set; }
        public SearchUp(int cols, int rows)
        {
            this.colSize = cols;
            this.rowsSize = rows;
        }
        public override bool CheckSearchLimits(int index, string searchValue, string toSearch)
        {
            ColunmPosition = index - (index / this.colSize) * this.colSize;
            if (index / this.colSize == 0)
            {
                ColunmPosition = index;
            }
            RowPosition = (index / this.rowsSize);
            if (RowPosition - searchValue.Length >= 0)
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
            string coordinates = "";
            for (int i = 0; i <= lengthToSearch-1; i++)
            {
                if (i != lengthToSearch - 1)
                {
                    coordinates += ",";
                }
                coordinates += "(" + (ColunmPosition).ToString() + "," + (RowPosition - i).ToString() + ")";
            }
            return coordinates;
        }
    }
}
