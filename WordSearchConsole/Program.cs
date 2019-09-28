using System;
using WordSearchLibrary;

namespace WordSearchLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            WordSearch wordSearch = new WordSearch();
            CalculateCoordinates coordinates = new CalculateCoordinates(6, 6);
            //string result = coordinates. CalculateForwardCorrdinates(0, 4);
            //string result1 = wordSearch.ReveseOrderOfString("JOHN");
            //string result2 = coordinates.CalculateReveseCorrdinates(7, 4);
            //string result3 = wordSearch.GenerateReverseOutput("JOHN", "XBSDCFNHOJ");
            //string result4 = coordinates.CalculateDownCorrdinates(7, 2);
            //string result5 = coordinates.CalculateUpCorrdinates(7, 2);
            //bool result6 = wordSearch.SearchUpMatch(8, "IT", "XBTDIF" + "NHIJXT");
            //bool result7 = wordSearch.SeachDiagDown(2, "IT", "XBIDCF" + "NHJTXC");
            //int result8 = wordSearch.GetSearchDownUpStringIndex("TI", "XBTDYF" + "NHIJXT");
            //string result9 = wordSearch.GenerateDownOutPut("IT", "XBIDCF" + "NHTJXC");
            string result10 = wordSearch.GenerateUpOutput("IT", "XBTDIF" + "NHIJXT");
        }
    }
}
