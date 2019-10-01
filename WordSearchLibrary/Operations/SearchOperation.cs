using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace WordSearchLibrary.Operations
{
    public class SearchOperation
    {
        public string stringSearchGrid = "";
        public string[] SearchValuesArray;
        
        public int rowcnt = 0;
        public int cols = 0;
        public int Error { get; set; }
        public  SearchOperation(string fileName)
        {  // 
            Error = 0;
            if (LoadFile(fileName) == -1)
            {
               Error = -1;
            }
        }

        private int LoadFile(string fileName)
        {
            int rows;
            using (var reader = new StreamReader(fileName))
            {
                string SearchValues = reader.ReadLine();
                SearchValuesArray = SearchValues.Split(',');
                rows = GetSearchGridString(reader);
            }
            return rows;
        }
        private int GetSearchGridString(StreamReader reader)
        {
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (rowcnt == 0)
                {
                    string tmpLine = line;
                    string[] stringColArray = line.Split(',');
                    cols = string.Join("", stringColArray).Length;
                }
                ++rowcnt;
                string[] values = line.Split(',');
                stringSearchGrid += string.Join("", values);
            }
            if (rowcnt == cols)
            {
                return rowcnt;
            }
            else
            {
                return -1;
            }
        }
    }
}
