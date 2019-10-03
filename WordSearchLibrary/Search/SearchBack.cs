using System;
using System.Collections.Generic;
using System.Text;

namespace WordSearchLibrary.Search
{
    public class SearchBack : SearchEngine
    {
        public int ColunmPosition { get; set; }
        public int RowPosition { get; set; }
        public SearchBack(int cols, int rows)
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
            if (ColunmPosition - searchValue.Length >= 0)
            {
                return true;
            }
            return false;
        }
        public override string SearchStringResult(int index, string searchValue, string toSearch)
        {
            if (CheckSearchLimits(index, searchValue, toSearch))
            {
                string value = toSearch.Substring(index - (searchValue.Length-1), searchValue.Length);
                string reverseValue = ReveseOrderOfString(value);
                if (reverseValue.Contains(searchValue))
                {
                    string coordinates = CalculateCorrdinates(index, searchValue.Length);
                    return searchValue + ": " + coordinates; ;
                }
            }
            return "";
        }
        public override string CalculateCorrdinates(int Offset, int lengthToSearch)
        {
            string coordinates = "";
            for (int i = 0; i <= lengthToSearch-1; i++)
            {
                if (i != 0)
                {
                    coordinates += ",";
                }
                coordinates += "(" + (ColunmPosition-i).ToString() + "," + RowPosition.ToString() + ")";
            }
            return coordinates;
        }
    }
}
