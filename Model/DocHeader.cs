using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class DocHeader
    {
        public string Environment { get; set; }
        public DateTime Date { get; set; }
        public string Site { get; set; }
        public string Credentials { get; set; }
        public string Tester { get; set; }
        public string Notes { get; set; }

    }
}
