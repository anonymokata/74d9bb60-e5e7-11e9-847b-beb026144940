using System;
using System.Collections.Generic;
using System.IO;
using WordSearchLibrary;
using WordSearchLibrary.Operations;
using WordSearchLibrary.Search;

namespace WordSearchLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            SearchOperation searchOperation = new SearchOperation(@"File\WordSearchText.csv");
            if (searchOperation.Error == -1)
            {
            }
            List<SearchEngine> searchEngines = new List<SearchEngine>();
            searchEngines.Add(new SearchForward(searchOperation.rowcnt, searchOperation.cols));
            searchEngines.Add(new SearchBack(searchOperation.rowcnt, searchOperation.cols));
            searchEngines.Add(new SearchDown(searchOperation.rowcnt, searchOperation.cols));
            searchEngines.Add(new SearchUp(searchOperation.rowcnt, searchOperation.cols));
            searchEngines.Add(new SearchDiagUpRightToLeft(searchOperation.rowcnt, searchOperation.cols));
            searchEngines.Add(new SearchDiagUpLeftToRight(searchOperation.rowcnt, searchOperation.cols));
            searchEngines.Add(new SearchDiagDownRightToLeft(searchOperation.rowcnt, searchOperation.cols));
            searchEngines.Add(new SearchDiagDownLeftToRight(searchOperation.rowcnt, searchOperation.cols));
            
            foreach (string value in searchOperation.SearchValuesArray)
            {
                bool found = false;
                for (int i = 0; i!= -1 && !found; ++i)
                {
                    i = SearchEngine.GetIndex(i, value, searchOperation.stringSearchGrid);
                    if (i == -1)
                    {
                        break;
                    }
                    else
                    {
                        found = SearchEngine.RunEngines(searchEngines, i, value, searchOperation.stringSearchGrid);
                    }
                }
            }
        }
    }
}
