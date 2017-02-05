using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace Diapraxas.BgMax
{
    class BgMaxFileReader
    {
        public List<string> ReadFile(String path)
        {
            List<string> rowList = new List<string>();
            String line;

            StreamReader streamReader = new StreamReader(path, Encoding.GetEncoding("iso-8859-1"));
            while ((line = streamReader.ReadLine()) != null)
            {
                rowList.Add(line);
            }

            return rowList;
        }
    }
}
