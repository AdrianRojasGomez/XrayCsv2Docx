using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;

namespace Infrastructure
{
    public class ActionReader
    {
        public List<string> ReadActions(string csvPath)
        {
            List<string> actions = new List<string>();

            using (FileStream stream = File.OpenRead(csvPath))
            using (StreamReader streamReader = new StreamReader(stream, Encoding.UTF8, true))
            using (CsvReader csvReader = new CsvReader(streamReader, CultureInfo.InvariantCulture))
            {
                if(!csvReader.Read() || !csvReader.ReadHeader())
                {
                    return actions;
                }

                while (csvReader.Read())
                {
                    string value = csvReader.GetField("Action");
                    if(!string.IsNullOrWhiteSpace(value))
                    {
                        actions.Add(value);
                    }
                }
            }

            return actions;
        }
    }
}
