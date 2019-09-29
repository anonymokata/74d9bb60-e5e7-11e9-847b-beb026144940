using System;
using System.Collections.Generic;
using System.Text;

namespace WordSearchLibrary
{
    public class CalculateCoordinates
    {
        private int Cols { get; set; }
        private int rows { get; set; }

        public CalculateCoordinates(int columnSize, int rowSize)
        {
            Cols = columnSize;
            rows = rowSize;
        }
        public string CalculateUpCorrdinates(int Offset, int lengthToSearch)
        {
            int row = (Offset / Cols);
            int col = 0;
            if (Offset >= Cols)
            {
                col = Offset - row * Cols;
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
        public string CalculateDownCorrdinates(int Offset, int lengthToSearch)
        {
            int row = (Offset / Cols);
            int col = 0;
            if (Offset >= Cols)
            {
                col = Offset - row * Cols;
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
        public string CalculateReveseCorrdinates(int Offset, int lengthToSearch)
        {
            int row = (Offset / Cols);
            int col = 0;
            if (Offset >= Cols)
            {
                col = Offset - row * Cols;
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
                coordinates += "(" + (i + col).ToString() + "," + row.ToString() + ")";
            }
            return coordinates;
        }
        public string CalculateForwardCorrdinates(int Offset, int lengthToSearch)
        {
            int row = (Offset / Cols);
            int col = 0;
            if (Offset >= Cols)
            {
                col = Offset - row * Cols;
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
        public string CalculateDiagDownLeftToRightCorrdinates(int Offset, int lengthToSearch)
        {
            int row = (Offset / Cols);
            int col = 0;
            if (Offset >= Cols)
            {
                col = Offset - row * Cols;
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
                coordinates += "(" + (col + i).ToString() + "," + (i + row).ToString() + ")";
            }
            return coordinates;
        }
        public string CalculateDiagUpRightToLeftCorrdinates(int Offset, int lengthToSearch)
        {
            int row = (Offset / Cols);
            int col = 0;
            if (Offset >= Cols)
            {
                col = Offset - row * Cols;
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
                coordinates += "(" + (col + i).ToString() + "," + (row + i).ToString() + ")";
            }
            return coordinates;
        }
        public string CalculateDiagDownRightToLeftCorrdinates(int Offset, int lengthToSearch)
        {
            int row = (Offset / Cols);
            int col = 0;
            if (Offset >= Cols)
            {
                col = Offset - row * Cols;
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
                coordinates += "(" + (col - i).ToString() + "," + (i+row).ToString() + ")";
            }
            return coordinates;
        }
        public string CalculateDiagUpLeftToRighCorrdinates(int Offset, int lengthToSearch)
        {
            int row = (Offset / Cols);
            int col = 0;
            if (Offset >= Cols)
            {
                col = Offset - row * Cols;
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
                coordinates += "(" + (col + i).ToString() + "," + (row + i).ToString() + ")";
            }
            return coordinates;
        }
    }
}
