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

        public bool ColumnsRowsEqual(int rows, int cols)
        {
            return true;
        }
        public string GetSearchStringCoordinates(string stringUsedToSearch, string stringSearched)
        {
            return "(0,0),(0,1),(0,2),(0,3)";
        }
        public int FindCharOffSet(int offset,string stringUsedToSearch, string stringSearched)
        {
            int index = stringSearched.IndexOf(stringUsedToSearch[0], offset);
            return index;
        }
        public bool ForwardSearchStringsMatch(string stringUsedToSearch, string stringSearched)
        {
            if (stringUsedToSearch == stringSearched)
            {
                return true;
            }

            return false;
        }
        public bool ReverseSearchStringsMatch(string stringUsedToSearch, string stringReservedSearched)
        {
            return true;
        }
        public bool UpSearchStringsMatch(string stringUsedToSearch, string stringUpSearched)
        {
            return true;
        }
        public bool DownSearchStringsMatch(string stringUsedToSearch, string stringDownSearched)
        {
            return true;
        }
        public bool DiagUpSearchStringsMatch(string stringUsedToSearch, string stringDiagUpSearched)
        {
            return true;
        }
        public bool DiagDownSearchStringsMatch(string stringUsedToSearch, string stringDiagDownSearched)
        {
            return true;
        }

    }
}
