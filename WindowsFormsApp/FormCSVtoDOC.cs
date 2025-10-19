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
using Data;
using System.IO;
using System.Diagnostics;


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
                reader.ReadActions(csvPath);

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
            if (result == DialogResult.OK)
            {
                csvPath = dialog.FileName;
                csvName = dialog.SafeFileName;
            }

            btnLoadCSV.Enabled = false;
            btnCreateEvidence.Enabled = true;
            btnLoadCSV.Text = csvName + " Loaded";

        }

        private void btnCreateEvidence_Click(object sender, EventArgs e)
        {
            var reader = new ActionReader();
            var actions = reader.ReadActions(csvPath);

            if (actions == null || actions.Count == 0)
            {
                MessageBox.Show("No actions were found in the CSV");
                ResetCSVButton();
                return;
            }

            var header = new DocxHeader()
            {
                Environment = textBoxEnv.Text,
                Date = dateTimePicker.Value.ToShortDateString(),
                Site = textBoxSite.Text,
                Credentials = textBoxCredentials.Text,
                TesterName = textBoxTester.Text,
                JiraKey = textBoxJIRAKey.Text
            };

            var jira = header?.JiraKey?.Trim();
            var title = string.IsNullOrWhiteSpace(jira) ? "CRTEvidence" : $@"{jira} CRTEvidence";

            using (var saveFileDialog = new SaveFileDialog
            {
                Filter = "Word Document (*.docx)|*.docx",
                FileName = title
            })
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var exporter = new ActionExporter();
                    exporter.CreateNumberedListDoc(saveFileDialog.FileName, actions, header, "STEPS");

                    if(checkBoxOpen.Checked && File.Exists(saveFileDialog.FileName))
                    {
                        Process.Start(new ProcessStartInfo
                        {
                            FileName = saveFileDialog.FileName,
                            UseShellExecute = true
                        });
                    }

                    MessageBox.Show("Documento creado correctamente.", "Success...",MessageBoxButtons.OK,MessageBoxIcon.Information);

                    ResetCSVButton();
                }

            }
        }

        private void ResetCSVButton()
        {
            btnLoadCSV.Enabled = true;
            btnCreateEvidence.Enabled = false;
            btnLoadCSV.Text = "Load CSV";
            csvPath = null;
            textBoxJIRAKey.Text = string.Empty;
        }


    }
}
