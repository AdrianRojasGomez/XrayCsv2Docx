using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Infrastructure;
using Domain;


namespace WindowsFormsApp
{
    public partial class CSVtoDOC : Form
    {
        public CSVtoDOC()
        {
            InitializeComponent();
        }

        private void convert_Click(object sender, EventArgs e)
        {
            try
            {
                ActionReader reader = new ActionReader();
                reader.ReadActions(@"C:\Users\Jackelin\Documents\XrayCsv2Docx\example.csv");

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
