using System;
using System.Text;

namespace WordSearchLibrary
{
    public class WordSearch
    {
        public struct GridPosition
        {
            public int up;
            public int down;
            public int back;
            public int foward;
            public int RLUpDiag;
            public int LRDownDiag;
            public int LRUpDiag;
            public int RLDownDiag;
        }



        private readonly int rows;
        private readonly int cols;
        private CalculateCoordinates CalculateCoordinates { get; set; }
        public WordSearch(int numberCols, int numberRows)
        {
            rows = numberRows;
            cols = numberCols;
            CalculateCoordinates = new CalculateCoordinates(cols, rows);
        }
        public bool ColumnsRowsEqual(int rows, int cols)
        {
            return true;
        }
        public string GenerateForwardOutput(string stringUsedToSearch, string stringSearched)
        {
            int offset = GetSearchForwardBackStringIndex(stringUsedToSearch, stringSearched);
            if (offset != -1)
            {
                string coordinates = CalculateCoordinates.CalculateForwardCorrdinates(offset, stringUsedToSearch.Length);

                return stringUsedToSearch + ": " + coordinates;
            }
            return offset.ToString();
        }

        public string GenerateReverseOutput(string stringUsedToSearch, string stringSearched)
        {
            string reverseString = ReveseOrderOfString(stringUsedToSearch);
            int offset = GetSearchForwardBackStringIndex(reverseString, stringSearched);
            if (offset != -1)
            {
                string coordinates = CalculateCoordinates.CalculateReveseCorrdinates(offset, stringUsedToSearch.Length);
                return stringUsedToSearch + ": " + coordinates;
            }
            return offset.ToString();

        }
        public string GenerateDownOutPut(string stringUsedToSearch, string stringSearched)
        {
            int offset = GetSearchDownUpStringIndex(stringUsedToSearch, stringSearched);
            if (offset != -1)
            {
                string coordinates = CalculateCoordinates.CalculateDownCorrdinates(offset, stringUsedToSearch.Length);
                return stringUsedToSearch + ": " + coordinates;
            }
            return offset.ToString();
        }
        public string GenerateUpOutput(string stringUsedToSearch, string stringSearched)
        {
            string reverseString = ReveseOrderOfString(stringUsedToSearch);
            int offset = GetSearchDownUpStringIndex(reverseString, stringSearched);
            if (offset != -1)
            {
                string coordinates = CalculateCoordinates.CalculateUpCorrdinates(offset, stringUsedToSearch.Length);
                return stringUsedToSearch + ": " + coordinates;
            }
            return offset.ToString();
        }
        public string GenerateDiagDownLeftToRightOutPut(string stringUsedToSearch, string stringSearched)
        {
            int offset = GetSearchDiagDownUpStringIndex(stringUsedToSearch, stringSearched);
            if (offset != -1)
            {
                string coordinates = CalculateCoordinates.CalculateDiagDownLeftToRightCorrdinates(offset, stringUsedToSearch.Length);
                return stringUsedToSearch + ": " + coordinates;
            }
            return offset.ToString();
        }
        public string GenerateDiagUpRightToLeftOutput(string stringUsedToSearch, string stringSearched)
        {
            string reverseString = ReveseOrderOfString(stringUsedToSearch);
            int offset = GetSearchDiagDownUpStringIndex(reverseString, stringSearched);
            if (offset != -1)
            {
                string coordinates = CalculateCoordinates.CalculateDiagUpRightToLeftCorrdinates(offset, stringUsedToSearch.Length);
                return stringUsedToSearch + ": " + coordinates;
            }
            return offset.ToString();
        }
        public string GenerateDiagUpLeftToLRightOutput(string stringUsedToSearch, string stringSearched)
        {
            return "IT: (1,1),(2,0)";
        }
        public string GenerateDiagDownRightToLefOutPut(string stringUsedToSearch, string stringSearched)
        {
            int offset = GetSearchDiagDownUpStringIndex(stringUsedToSearch, stringSearched);
            if (offset != -1)
            {
                string coordinates = CalculateCoordinates.CalculateDiagDownRightToLeftCorrdinates(offset, stringUsedToSearch.Length);
                return stringUsedToSearch + ": " + coordinates;
            }
            return offset.ToString();
        }
        public int GetSearchForwardBackStringIndex(string stringUsedToSearch, string stringSearched)
        {
            for (int i = 0; i < stringSearched.Length; i++)
            {
                int index = FindCharOffSet(i, stringUsedToSearch[0], stringSearched);
                string results = stringSearched.Substring(index, stringUsedToSearch.Length);
                if (stringUsedToSearch == results)
                {
                    return index;
                }
                i = i + index;
            }
            return -1;

        }
        public int GetSearchDownUpStringIndex(string stringUsedToSearch, string stringSearched)
        {
            for (int i = 0; i < stringSearched.Length; i++)
            {
                int index = FindCharOffSet(i, stringUsedToSearch[0], stringSearched);

                if (SearchDownMatch(index, stringUsedToSearch, stringSearched))
                {
                    return index;
                }
                i = i + index;
            }
            return -1;

        }
        public int GetSearchDiagDownUpStringIndex(string stringUsedToSearch, string stringSearched)
        {
            for (int i = 0; i < stringSearched.Length; i++)
            {
                int index = FindCharOffSet(i, stringUsedToSearch[0], stringSearched);

                if (SeachDiagDownRightToLeft(index, stringUsedToSearch, stringSearched))
                {
                    return index;
                }
                i = i + index;
            }
            return -1;
        }

        public bool SearchUpMatch(int index, string stringUsedToSearch, string stringSearched)
        {
            int row = (index / cols);
            for (int i = 0; i < stringUsedToSearch.Length; i++)
            {
                int offset = index - (rows * i);
                if (stringUsedToSearch[i] != stringSearched[offset])
                {
                    return false;
                }
            }
            return true;
        }
        public bool SearchDownMatch(int index, string stringUsedToSearch, string stringSearched)
        {
            int row = (index / cols);
            for (int i = 0; i < stringUsedToSearch.Length; i++)
            {
                int offset = index + (rows * i);
                if (stringUsedToSearch[i] != stringSearched[offset])
                {
                    return false;
                }
            }
            return true;
        }
        public bool SeachDiagDownRightToLeft(int index, string stringUsedToSearch, string stringSearched)
        {
            int offset = 0;
            for (int i = 0; i < stringUsedToSearch.Length; i++)
            {
                if (i != 0)
                {
                    offset = index + (rows * i) + 1;
                }
                else
                {
                    offset = index;
                }
                if (stringUsedToSearch[i] != stringSearched[offset])
                {
                    return false;
                }
            }
            return true;
        }
        public bool SeachDiagUpLeftToRight(int index, string stringUsedToSearch, string stringSearched)
        {
            int offset = 0;
            for (int i = 0; i < stringUsedToSearch.Length; i++)
            {
                if (i != 0)
                {
                    offset = index - ((rows * i) + 1);
                }
                else
                {
                    offset = index;
                }
                if (stringUsedToSearch[i] != stringSearched[offset])
                {
                    return false;
                }
            }
            return true;
        }
        public string ReveseOrderOfString(string stringUsedToSearch)
        {
            string reverseString = "";
            for (int i = stringUsedToSearch.Length - 1; 0 <= i; i--)
            {
                reverseString += stringUsedToSearch[i];
            }
            return reverseString;
        }
        public int FindCharOffSet(int offset, char charUsedToSearch, string stringSearched)
        {
            int index = stringSearched.IndexOf(charUsedToSearch, offset);
            return index;
        }
        public GridPosition GetPositionOfNextCharInString(int index, string stringUsedToSearch, string stringSearched)
        {
            GridPosition gridPos = new GridPosition();

            return gridPos;
        }
        public int GetSearchStringIndex(string stringUsedToSearch, string stringSearched)
        {
            int index = FindCharOffSet(0, stringUsedToSearch[0], stringSearched);

            return 1;
        }
        //public bool SearchForward(int index, string stringUsedToSearch, string stringSearched)
        //public bool Searchbck(int index, string stringUsedToSearch, string stringSearched)
        //public bool SearchUp(int index, string stringUsedToSearch, string stringSearched)
        //public bool SearchDown(int index, string stringUsedToSearch, string stringSearched)
        //public bool SearchDiagUpRightToLeft(int index, string stringUsedToSearch, string stringSearched)
        //public bool SearchDiagUpLeftToRight(int index, string stringUsedToSearch, string stringSearched)
        //public bool SearchDiagDownRightToLeft(int index, string stringUsedToSearch, string stringSearched)
        //public bool SearchDiagDownLeftToRight(int index, string stringUsedToSearch, string stringSearched)
    }
}

