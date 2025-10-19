using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class DocxHeader
    {
        public string Environment { get; set; }
        public string Date { get; set; }
        public string Site { get; set; }
        public string Credentials { get; set; }
        public string TesterName { get; set; }
        public string JiraKey { get; set; }
    }
}
