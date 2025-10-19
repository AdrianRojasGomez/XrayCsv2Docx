using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness
{
    public class ActionReader
    {
        public List<string> ReadActions(string csvPath)
        {
            List<string> actions = new List<string>();

            try
            {
                using (FileStream stream = File.OpenRead(csvPath))
                using (StreamReader streamReader = new StreamReader(stream, Encoding.UTF8, true))
                using (CsvReader csvReader = new CsvReader(streamReader, CultureInfo.InvariantCulture))
                {
                    if (!csvReader.Read() || !csvReader.ReadHeader())
                    {
                        return actions;
                    }

                    while (csvReader.Read())
                    {
                        string value = csvReader.GetField("Action");
                        if (!string.IsNullOrWhiteSpace(value))
                        {
                            actions.Add(value);
                        }
                    }
                }
            }
            catch (Exception)
            {
                return new List<string>() { };
            }

            return actions;
        }
    }
}
