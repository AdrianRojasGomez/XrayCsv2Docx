namespace WinFormsApp
{
    partial class CSVtoDOCX
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBoxSite = new RichTextBox();
            label6 = new Label();
            label7 = new Label();
            dateTimePicker = new DateTimePicker();
            textBoxEnv = new TextBox();
            textBoxTester = new TextBox();
            textBoxJIRAKey = new TextBox();
            textBoxCredentials = new RichTextBox();
            label8 = new Label();
            checkBoxOpen = new CheckBox();
            btnLoadCSV = new Button();
            btnCreateEvidence = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 31);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 0;
            label1.Text = "Environment";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 81);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 2;
            label2.Text = "Tester Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 127);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 4;
            label3.Text = "Sites URL";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(434, 31);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 6;
            label4.Text = "Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(410, 84);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 8;
            label5.Text = "JIRA Key";
            label5.Click += label5_Click;
            // 
            // textBoxSite
            // 
            textBoxSite.Location = new Point(499, 127);
            textBoxSite.Name = "textBoxSite";
            textBoxSite.Size = new Size(251, 80);
            textBoxSite.TabIndex = 11;
            textBoxSite.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(410, 127);
            label6.Name = "label6";
            label6.Size = new Size(40, 20);
            label6.TabIndex = 10;
            label6.Text = "Sites";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(410, 147);
            label7.Name = "label7";
            label7.Size = new Size(83, 20);
            label7.TabIndex = 12;
            label7.Text = "Credentials";
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(481, 31);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(269, 27);
            dateTimePicker.TabIndex = 13;
            // 
            // textBoxEnv
            // 
            textBoxEnv.Location = new Point(120, 28);
            textBoxEnv.Name = "textBoxEnv";
            textBoxEnv.Size = new Size(269, 27);
            textBoxEnv.TabIndex = 16;
            // 
            // textBoxTester
            // 
            textBoxTester.Location = new Point(120, 78);
            textBoxTester.Name = "textBoxTester";
            textBoxTester.Size = new Size(269, 27);
            textBoxTester.TabIndex = 17;
            // 
            // textBoxJIRAKey
            // 
            textBoxJIRAKey.Location = new Point(481, 84);
            textBoxJIRAKey.Name = "textBoxJIRAKey";
            textBoxJIRAKey.Size = new Size(269, 27);
            textBoxJIRAKey.TabIndex = 18;
            // 
            // textBoxCredentials
            // 
            textBoxCredentials.Location = new Point(120, 127);
            textBoxCredentials.Name = "textBoxCredentials";
            textBoxCredentials.Size = new Size(269, 80);
            textBoxCredentials.TabIndex = 19;
            textBoxCredentials.Text = "";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(24, 242);
            label8.Name = "label8";
            label8.Size = new Size(414, 19);
            label8.TabIndex = 20;
            label8.Text = "Fields are OPTIONAL; you can fill them in the document";
            // 
            // checkBoxOpen
            // 
            checkBoxOpen.AutoSize = true;
            checkBoxOpen.Location = new Point(24, 277);
            checkBoxOpen.Name = "checkBoxOpen";
            checkBoxOpen.Size = new Size(248, 24);
            checkBoxOpen.TabIndex = 21;
            checkBoxOpen.Text = "Open document after conversion";
            checkBoxOpen.UseVisualStyleBackColor = true;
            // 
            // btnLoadCSV
            // 
            btnLoadCSV.Location = new Point(237, 368);
            btnLoadCSV.Name = "btnLoadCSV";
            btnLoadCSV.Size = new Size(152, 70);
            btnLoadCSV.TabIndex = 22;
            btnLoadCSV.Text = "Load CSV";
            btnLoadCSV.UseVisualStyleBackColor = true;
            btnLoadCSV.Click += btnLoadCSV_Click;
            // 
            // btnCreateEvidence
            // 
            btnCreateEvidence.Location = new Point(434, 368);
            btnCreateEvidence.Name = "btnCreateEvidence";
            btnCreateEvidence.Size = new Size(152, 70);
            btnCreateEvidence.TabIndex = 23;
            btnCreateEvidence.Text = "Convert to Evidence Document (.docx)";
            btnCreateEvidence.UseVisualStyleBackColor = true;
            btnCreateEvidence.Click += btnCreateEvidence_Click;
            // 
            // CSVtoDOCX
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCreateEvidence);
            Controls.Add(btnLoadCSV);
            Controls.Add(checkBoxOpen);
            Controls.Add(label8);
            Controls.Add(textBoxCredentials);
            Controls.Add(textBoxJIRAKey);
            Controls.Add(textBoxTester);
            Controls.Add(textBoxEnv);
            Controls.Add(dateTimePicker);
            Controls.Add(label7);
            Controls.Add(textBoxSite);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CSVtoDOCX";
            Text = "Test Steps CSV to DOCX";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private RichTextBox textBoxCredentials;
        private Label label4;
        private Label label5;
        private RichTextBox textBoxSite;
        private Label label6;
        private Label label7;
        private DateTimePicker dateTimePicker;
        private TextBox textBoxEnv;
        private TextBox textBoxTester;
        private TextBox textBoxJIRAKey;
        private Label label8;
        private CheckBox checkBoxOpen;
        private Button btnLoadCSV;
        private Button btnCreateEvidence;
    }
}