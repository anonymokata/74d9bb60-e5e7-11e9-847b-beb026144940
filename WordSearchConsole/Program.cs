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
        }
    }
}
