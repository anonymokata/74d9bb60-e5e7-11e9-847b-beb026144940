using System;
using System.Text;

namespace WordSearchLibrary
{
    public class WordSearch
    {
        private string[] stringUseToSeach = { "BOB", "FRED", "RICH", "JOHN", "TED","DAN"};
        private string stringToSearch = "RBOBWG" +
                                        "IBDERF" +
                                        "CBOBWN" +
                                        "HBDBWH" +
                                        "AEOAWO" +
                                        "TBOBNJ";
        private readonly int rows = 6;
        private readonly int cols = 6;
        private CalculateCoordinates CalculateCoordinates { get; set; }
        public WordSearch()
        {
            CalculateCoordinates = new CalculateCoordinates(cols, rows);
        }
        public bool ColumnsRowsEqual(int rows, int cols)
        {
            return true;
        }
        public string GenerateForwardOutput(string stringUsedToSearch, string stringSearched)
        {
            int offset = GetSearchForwardBackStringIndex(stringUsedToSearch, stringSearched);
            string   coordinates = CalculateCoordinates.CalculateForwardCorrdinates(offset, stringUsedToSearch.Length);

            return stringUsedToSearch + ": " + coordinates;
        }

        public string GenerateReverseOutput(string stringUsedToSearch, string stringSearched)
        {
            string reverseString = ReveseOrderOfString(stringUsedToSearch);
            int offset = GetSearchForwardBackStringIndex(reverseString, stringSearched);
            string coordinates = CalculateCoordinates.CalculateReveseCorrdinates(offset, stringUsedToSearch.Length);
            return stringUsedToSearch + ": " + coordinates;

        }
        public string GenerateDownOutPut(string stringUsedToSearch, string stringSearched)
        {
            return "";
        }
        public string GenerateUpOutput(string stringUsedToSearch, string stringSearched)
        {
            return "";
        }
        public string GenerateDiagDownOutPut(string stringUsedToSearch, string stringSearched)
        {
            return "";
        }
        public string GenerateDiagUpOutput(string stringUsedToSearch, string stringSearched)
        {
            return "";
        }

        public int GetSearchForwardBackStringIndex(string stringUsedToSearch, string stringSearched)
        {
            for (int  i=0; i < stringSearched.Length; i++)
            {
                int index = FindCharOffSet(i, stringUsedToSearch[0], stringSearched);
                string results = stringSearched.Substring(index, stringUsedToSearch.Length);
                if (stringUsedToSearch == results){
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

                string results = stringSearched.Substring(index, stringUsedToSearch.Length);
                if (stringUsedToSearch == results)
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
        public bool SeachDiagDown(int index, string stringUsedToSearch, string stringSearched)
        {
            //int row = (index / cols);
            //int col = 0;
            //if (index >= cols)
            //{
            //    col = index - row * cols;
            //}
            //else
            //{
            //    col = index;
            //}
            int offset = 0;
            for (int i = 0; i < stringUsedToSearch.Length; i++)
            {
                if (i != 0)
                {
                    offset = index + (rows * i)+1;
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
        public bool SeachDiagUp(int index, string stringUsedToSearch, string stringSearched)
        {
            return true;
        }
        public string ReveseOrderOfString(string stringUsedToSearch)
        {
            string reverseString = "";
            for(int i= stringUsedToSearch.Length-1; 0 <= i; i--)
            {
                reverseString += stringUsedToSearch[i];
            }
            return reverseString;
        }
        public int FindCharOffSet(int offset,char charUsedToSearch, string stringSearched)
        {
            int index = stringSearched.IndexOf(charUsedToSearch, offset);
            return index;
        }

    }
}
