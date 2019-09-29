using System;
using System.IO;
using WordSearchLibrary;

namespace WordSearchLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            string SearchGrid = "";
            int cols = 0;
            int rowcnt = 0;
            WordSearch wordSearch = new WordSearch(6,6);
            string result = wordSearch.GenerateDiagDownRightToLefOutPut("IT", "XBIDCF" + "NTHJXC");
            using (var reader = new StreamReader(@"c:\WordSearchText.csv"))
            {
                string SearchValues = reader.ReadLine();
                string[] SearchValuesArray = SearchValues.Split(',');
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    if (rowcnt == 0)
                    {
                        cols = line.Length;
                    }
                    else
                    {
                        ++rowcnt;
                    }
                    string[] values = line.Split(',');
                    SearchGrid += string.Join("", values);
                }
        //        WordSearch wordSearch = new WordSearch(cols, rowcnt);
                foreach(var value in SearchValuesArray)
                {

                }
            }
        }
    }
}
