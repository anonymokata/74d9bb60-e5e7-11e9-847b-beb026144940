using System;
using WordSearchLibrary;

namespace WordSearchConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            WordSearch wordSearch = new WordSearch();
            string result = wordSearch.CalculateForwardCorrdinates(0, 4);
            string result1 = wordSearch.ReveseOrderOfString("JOHN");
            string result2 = wordSearch.CalculateReveseCorrdinates(7, 4);
            string result3 = wordSearch.GenerateReverseOutput("JOHN", "XBSDCFNHOJ");
            string result4 = wordSearch.CalculateDownCorrdinates(7, 2);
        }
    }
}
