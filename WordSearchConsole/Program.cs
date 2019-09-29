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
            WordSearchLibrary.Search.SearchUp searchUp = new WordSearchLibrary.Search.SearchUp(6, 6);
            bool result1 = searchUp.SearchStringResult(9, "IT", "XBFTAF" + "NHJIXX");
            WordSearchLibrary.Search.SearchDown searchDown = new WordSearchLibrary.Search.SearchDown(6, 6);
            string result = searchDown.SubStringGet(3, 2, "XBFIAF" + "NHJTXX");
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
