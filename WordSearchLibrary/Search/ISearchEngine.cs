using System;
using System.Collections.Generic;
using System.Text;

namespace WordSearchLibrary.Search
{
    interface ISearchEngine
    {
         string SearchStringResult(int index, string searchValue, string toSearch);
    }
}
