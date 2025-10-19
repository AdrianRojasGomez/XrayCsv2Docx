namespace WindowsFormsApp
{
    partial class CSVtoDOC
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLoadCSV = new System.Windows.Forms.Button();
            this.labelEnv = new System.Windows.Forms.Label();
            this.textBoxEnv = new System.Windows.Forms.TextBox();
            this.labelSite = new System.Windows.Forms.Label();
            this.textBoxSite = new System.Windows.Forms.TextBox();
            this.Credentials = new System.Windows.Forms.Label();
            this.textBoxCredentials = new System.Windows.Forms.TextBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.labelTester = new System.Windows.Forms.Label();
            this.textBoxTester = new System.Windows.Forms.TextBox();
            this.btnCreateEvidence = new System.Windows.Forms.Button();
            this.labelJiraKey = new System.Windows.Forms.Label();
            this.textBoxJIRAKey = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnLoadCSV
            // 
            this.btnLoadCSV.Location = new System.Drawing.Point(217, 295);
            this.btnLoadCSV.Name = "btnLoadCSV";
            this.btnLoadCSV.Size = new System.Drawing.Size(130, 50);
            this.btnLoadCSV.TabIndex = 1;
            this.btnLoadCSV.Text = "Load CSV";
            this.btnLoadCSV.UseVisualStyleBackColor = true;
            this.btnLoadCSV.Click += new System.EventHandler(this.LoadCSV_Click);
            // 
            // labelEnv
            // 
            this.labelEnv.AutoSize = true;
            this.labelEnv.Location = new System.Drawing.Point(12, 19);
            this.labelEnv.Name = "labelEnv";
            this.labelEnv.Size = new System.Drawing.Size(81, 16);
            this.labelEnv.TabIndex = 2;
            this.labelEnv.Text = "Environment";
            // 
            // textBoxEnv
            // 
            this.textBoxEnv.Location = new System.Drawing.Point(121, 16);
            this.textBoxEnv.Name = "textBoxEnv";
            this.textBoxEnv.Size = new System.Drawing.Size(149, 22);
            this.textBoxEnv.TabIndex = 3;
            // 
            // labelSite
            // 
            this.labelSite.AutoSize = true;
            this.labelSite.Location = new System.Drawing.Point(324, 103);
            this.labelSite.Name = "labelSite";
            this.labelSite.Size = new System.Drawing.Size(67, 16);
            this.labelSite.TabIndex = 4;
            this.labelSite.Text = "Sites URL";
            // 
            // textBoxSite
            // 
            this.textBoxSite.Location = new System.Drawing.Point(397, 100);
            this.textBoxSite.Multiline = true;
            this.textBoxSite.Name = "textBoxSite";
            this.textBoxSite.Size = new System.Drawing.Size(313, 56);
            this.textBoxSite.TabIndex = 5;
            // 
            // Credentials
            // 
            this.Credentials.AutoSize = true;
            this.Credentials.Location = new System.Drawing.Point(12, 103);
            this.Credentials.Name = "Credentials";
            this.Credentials.Size = new System.Drawing.Size(101, 16);
            this.Credentials.TabIndex = 6;
            this.Credentials.Text = "Site Credentials";
            // 
            // textBoxCredentials
            // 
            this.textBoxCredentials.Location = new System.Drawing.Point(119, 103);
            this.textBoxCredentials.Multiline = true;
            this.textBoxCredentials.Name = "textBoxCredentials";
            this.textBoxCredentials.Size = new System.Drawing.Size(149, 53);
            this.textBoxCredentials.TabIndex = 7;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(324, 22);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(36, 16);
            this.labelDate.TabIndex = 8;
            this.labelDate.Text = "Date";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(397, 19);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(313, 22);
            this.dateTimePicker.TabIndex = 9;
            this.dateTimePicker.Value = new System.DateTime(2025, 10, 11, 8, 1, 41, 0);
            // 
            // labelTester
            // 
            this.labelTester.AutoSize = true;
            this.labelTester.Location = new System.Drawing.Point(12, 62);
            this.labelTester.Name = "labelTester";
            this.labelTester.Size = new System.Drawing.Size(86, 16);
            this.labelTester.TabIndex = 10;
            this.labelTester.Text = "Tester Name";
            // 
            // textBoxTester
            // 
            this.textBoxTester.Location = new System.Drawing.Point(119, 62);
            this.textBoxTester.Name = "textBoxTester";
            this.textBoxTester.Size = new System.Drawing.Size(149, 22);
            this.textBoxTester.TabIndex = 11;
            // 
            // btnCreateEvidence
            // 
            this.btnCreateEvidence.Enabled = false;
            this.btnCreateEvidence.Location = new System.Drawing.Point(353, 295);
            this.btnCreateEvidence.Name = "btnCreateEvidence";
            this.btnCreateEvidence.Size = new System.Drawing.Size(130, 50);
            this.btnCreateEvidence.TabIndex = 12;
            this.btnCreateEvidence.Text = "Create Evidence Document";
            this.btnCreateEvidence.UseVisualStyleBackColor = true;
            this.btnCreateEvidence.Click += new System.EventHandler(this.btnCreateEvidence_Click);
            // 
            // labelJiraKey
            // 
            this.labelJiraKey.AutoSize = true;
            this.labelJiraKey.Location = new System.Drawing.Point(324, 62);
            this.labelJiraKey.Name = "labelJiraKey";
            this.labelJiraKey.Size = new System.Drawing.Size(62, 16);
            this.labelJiraKey.TabIndex = 13;
            this.labelJiraKey.Text = "JIRA Key";
            // 
            // textBoxJIRAKey
            // 
            this.textBoxJIRAKey.Location = new System.Drawing.Point(397, 62);
            this.textBoxJIRAKey.Name = "textBoxJIRAKey";
            this.textBoxJIRAKey.Size = new System.Drawing.Size(149, 22);
            this.textBoxJIRAKey.TabIndex = 14;
            // 
            // CSVtoDOC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 357);
            this.Controls.Add(this.textBoxJIRAKey);
            this.Controls.Add(this.labelJiraKey);
            this.Controls.Add(this.btnCreateEvidence);
            this.Controls.Add(this.textBoxTester);
            this.Controls.Add(this.labelTester);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.textBoxCredentials);
            this.Controls.Add(this.Credentials);
            this.Controls.Add(this.textBoxSite);
            this.Controls.Add(this.labelSite);
            this.Controls.Add(this.textBoxEnv);
            this.Controls.Add(this.labelEnv);
            this.Controls.Add(this.btnLoadCSV);
            this.Name = "CSVtoDOC";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLoadCSV;
        private System.Windows.Forms.Label labelEnv;
        private System.Windows.Forms.TextBox textBoxEnv;
        private System.Windows.Forms.Label labelSite;
        private System.Windows.Forms.TextBox textBoxSite;
        private System.Windows.Forms.Label Credentials;
        private System.Windows.Forms.TextBox textBoxCredentials;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label labelTester;
        private System.Windows.Forms.TextBox textBoxTester;
        private System.Windows.Forms.Button btnCreateEvidence;
        private System.Windows.Forms.Label labelJiraKey;
        private System.Windows.Forms.TextBox textBoxJIRAKey;
    }
}

