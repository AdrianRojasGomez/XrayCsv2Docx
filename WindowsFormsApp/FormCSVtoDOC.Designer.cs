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
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxOpen = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLoadCSV
            // 
            this.btnLoadCSV.Location = new System.Drawing.Point(244, 332);
            this.btnLoadCSV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLoadCSV.Name = "btnLoadCSV";
            this.btnLoadCSV.Size = new System.Drawing.Size(146, 56);
            this.btnLoadCSV.TabIndex = 1;
            this.btnLoadCSV.Text = "Load CSV";
            this.btnLoadCSV.UseVisualStyleBackColor = true;
            this.btnLoadCSV.Click += new System.EventHandler(this.LoadCSV_Click);
            // 
            // labelEnv
            // 
            this.labelEnv.AutoSize = true;
            this.labelEnv.Location = new System.Drawing.Point(14, 22);
            this.labelEnv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEnv.Name = "labelEnv";
            this.labelEnv.Size = new System.Drawing.Size(91, 18);
            this.labelEnv.TabIndex = 2;
            this.labelEnv.Text = "Environment";
            // 
            // textBoxEnv
            // 
            this.textBoxEnv.Location = new System.Drawing.Point(136, 18);
            this.textBoxEnv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxEnv.Name = "textBoxEnv";
            this.textBoxEnv.Size = new System.Drawing.Size(167, 24);
            this.textBoxEnv.TabIndex = 3;
            // 
            // labelSite
            // 
            this.labelSite.AutoSize = true;
            this.labelSite.Location = new System.Drawing.Point(364, 116);
            this.labelSite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSite.Name = "labelSite";
            this.labelSite.Size = new System.Drawing.Size(75, 18);
            this.labelSite.TabIndex = 4;
            this.labelSite.Text = "Sites URL";
            // 
            // textBoxSite
            // 
            this.textBoxSite.Location = new System.Drawing.Point(446, 112);
            this.textBoxSite.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxSite.Multiline = true;
            this.textBoxSite.Name = "textBoxSite";
            this.textBoxSite.Size = new System.Drawing.Size(351, 62);
            this.textBoxSite.TabIndex = 5;
            // 
            // Credentials
            // 
            this.Credentials.AutoSize = true;
            this.Credentials.Location = new System.Drawing.Point(14, 116);
            this.Credentials.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Credentials.Name = "Credentials";
            this.Credentials.Size = new System.Drawing.Size(111, 18);
            this.Credentials.TabIndex = 6;
            this.Credentials.Text = "Site Credentials";
            // 
            // textBoxCredentials
            // 
            this.textBoxCredentials.Location = new System.Drawing.Point(134, 116);
            this.textBoxCredentials.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxCredentials.Multiline = true;
            this.textBoxCredentials.Name = "textBoxCredentials";
            this.textBoxCredentials.Size = new System.Drawing.Size(167, 59);
            this.textBoxCredentials.TabIndex = 7;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(364, 25);
            this.labelDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(39, 18);
            this.labelDate.TabIndex = 8;
            this.labelDate.Text = "Date";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(446, 22);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(351, 24);
            this.dateTimePicker.TabIndex = 9;
            this.dateTimePicker.Value = new System.DateTime(2025, 10, 11, 8, 1, 41, 0);
            // 
            // labelTester
            // 
            this.labelTester.AutoSize = true;
            this.labelTester.Location = new System.Drawing.Point(14, 70);
            this.labelTester.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTester.Name = "labelTester";
            this.labelTester.Size = new System.Drawing.Size(94, 18);
            this.labelTester.TabIndex = 10;
            this.labelTester.Text = "Tester Name";
            // 
            // textBoxTester
            // 
            this.textBoxTester.Location = new System.Drawing.Point(134, 70);
            this.textBoxTester.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxTester.Name = "textBoxTester";
            this.textBoxTester.Size = new System.Drawing.Size(167, 24);
            this.textBoxTester.TabIndex = 11;
            // 
            // btnCreateEvidence
            // 
            this.btnCreateEvidence.Enabled = false;
            this.btnCreateEvidence.Location = new System.Drawing.Point(397, 332);
            this.btnCreateEvidence.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreateEvidence.Name = "btnCreateEvidence";
            this.btnCreateEvidence.Size = new System.Drawing.Size(146, 56);
            this.btnCreateEvidence.TabIndex = 12;
            this.btnCreateEvidence.Text = "Create Evidence Document";
            this.btnCreateEvidence.UseVisualStyleBackColor = true;
            this.btnCreateEvidence.Click += new System.EventHandler(this.btnCreateEvidence_Click);
            // 
            // labelJiraKey
            // 
            this.labelJiraKey.AutoSize = true;
            this.labelJiraKey.Location = new System.Drawing.Point(364, 70);
            this.labelJiraKey.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelJiraKey.Name = "labelJiraKey";
            this.labelJiraKey.Size = new System.Drawing.Size(68, 18);
            this.labelJiraKey.TabIndex = 13;
            this.labelJiraKey.Text = "JIRA Key";
            // 
            // textBoxJIRAKey
            // 
            this.textBoxJIRAKey.Location = new System.Drawing.Point(446, 70);
            this.textBoxJIRAKey.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxJIRAKey.Name = "textBoxJIRAKey";
            this.textBoxJIRAKey.Size = new System.Drawing.Size(167, 24);
            this.textBoxJIRAKey.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 230);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "No fields are required; you can fill them in the document.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // checkBoxOpen
            // 
            this.checkBoxOpen.AutoSize = true;
            this.checkBoxOpen.Location = new System.Drawing.Point(134, 265);
            this.checkBoxOpen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxOpen.Name = "checkBoxOpen";
            this.checkBoxOpen.Size = new System.Drawing.Size(164, 22);
            this.checkBoxOpen.TabIndex = 16;
            this.checkBoxOpen.Text = "Open on completion";
            this.checkBoxOpen.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 194);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 18);
            this.label2.TabIndex = 17;
            // 
            // CSVtoDOC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 401);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBoxOpen);
            this.Controls.Add(this.label1);
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
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CSVtoDOC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JIRA Csv2Docx";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxOpen;
        private System.Windows.Forms.Label label2;
    }
}

