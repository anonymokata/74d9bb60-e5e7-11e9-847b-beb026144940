﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WordSearchLibrary.Search
{
    public class SearchForward : SearchEngine
    {
        private int ColunmPosition { get; set; }
        private int RowPosition { get; set; }
        public SearchForward(int cols, int rows)
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
            if (index / this.rowsSize == 0)
            {
                RowPosition = 0;
            }
            if (ColunmPosition + searchValue.Length <= this.colSize)
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
            string coordinates = "";
            for (int i = 0; i < lengthToSearch; i++)
            {
                if (i != 0)
                {
                    coordinates += ",";
                }
                coordinates += "(" + (i + ColunmPosition).ToString() + "," + RowPosition.ToString() + ")";
            }
            return coordinates;
        }
    }
}
