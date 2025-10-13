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
        string csvPath = string.Empty;
        string csvName = string.Empty;

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

        private void LoadCSV_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Select a CSV File";
            dialog.Filter = "CSV Files (*.csv)|*.csv";
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            dialog.Multiselect = false;
            dialog.CheckFileExists = true;
            dialog.CheckPathExists = true;
            dialog.RestoreDirectory = true;

            DialogResult result = dialog.ShowDialog(this);
            if(result == DialogResult.OK)
            {
                csvPath = dialog.FileName;
                csvName = dialog.SafeFileName;
            }

            btnLoadCSV.Enabled = false;
            btnCreateEvidence.Enabled = true;
            btnLoadCSV.Text = csvName + " Loaded";

        }
    }
}
