﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WordSearchLibrary.Search
{
    public class SearchDown : SearchEngine
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
            int limit = index + ((length - 1) * this.rowsSize);
            for (int i = index; i <= limit; i += this.rowsSize)
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
            for (int i = 0; i < lengthToSearch; i++)
            {
                if (i != 0)
                {
                    coordinates += ",";
                }
                coordinates += "(" + (col).ToString() + "," + (i + row).ToString() + ")";
            }
            return coordinates;
        }
    }
}
