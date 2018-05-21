namespace PDC_Lauren
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.DataTypeComboBox = new System.Windows.Forms.ComboBox();
            this.CpuTypeComboBox = new System.Windows.Forms.ComboBox();
            this.PathComboBox = new System.Windows.Forms.ComboBox();
            this.WriteValueTextBox = new System.Windows.Forms.TextBox();
            this.ElementCountTextBox = new System.Windows.Forms.TextBox();
            this.TagNameTextBox = new System.Windows.Forms.TextBox();
            this.SlotTextBox = new System.Windows.Forms.TextBox();
            this.IPAddTextBox = new System.Windows.Forms.TextBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.WriteCheckBox = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DataTypeComboBox);
            this.tabPage1.Controls.Add(this.CpuTypeComboBox);
            this.tabPage1.Controls.Add(this.PathComboBox);
            this.tabPage1.Controls.Add(this.WriteValueTextBox);
            this.tabPage1.Controls.Add(this.ElementCountTextBox);
            this.tabPage1.Controls.Add(this.TagNameTextBox);
            this.tabPage1.Controls.Add(this.SlotTextBox);
            this.tabPage1.Controls.Add(this.IPAddTextBox);
            this.tabPage1.Controls.Add(this.connectButton);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.WriteCheckBox);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "RSLinx";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // DataTypeComboBox
            // 
            this.DataTypeComboBox.FormattingEnabled = true;
            this.DataTypeComboBox.Items.AddRange(new object[] {
            "Int16",
            "Int8",
            "Int32",
            "Float32"});
            this.DataTypeComboBox.Location = new System.Drawing.Point(266, 233);
            this.DataTypeComboBox.Name = "DataTypeComboBox";
            this.DataTypeComboBox.Size = new System.Drawing.Size(358, 21);
            this.DataTypeComboBox.TabIndex = 18;
            // 
            // CpuTypeComboBox
            // 
            this.CpuTypeComboBox.FormattingEnabled = true;
            this.CpuTypeComboBox.Items.AddRange(new object[] {
            "LGX",
            "SLC",
            "PLC5"});
            this.CpuTypeComboBox.Location = new System.Drawing.Point(266, 168);
            this.CpuTypeComboBox.Name = "CpuTypeComboBox";
            this.CpuTypeComboBox.Size = new System.Drawing.Size(358, 21);
            this.CpuTypeComboBox.TabIndex = 17;
            // 
            // PathComboBox
            // 
            this.PathComboBox.FormattingEnabled = true;
            this.PathComboBox.Items.AddRange(new object[] {
            "Backplane",
            "Control Net/Ethernet, DH+ Channel A, DH+ Channel B",
            "Serial"});
            this.PathComboBox.Location = new System.Drawing.Point(266, 103);
            this.PathComboBox.Name = "PathComboBox";
            this.PathComboBox.Size = new System.Drawing.Size(358, 21);
            this.PathComboBox.TabIndex = 16;
            // 
            // WriteValueTextBox
            // 
            this.WriteValueTextBox.Location = new System.Drawing.Point(266, 325);
            this.WriteValueTextBox.Name = "WriteValueTextBox";
            this.WriteValueTextBox.Size = new System.Drawing.Size(359, 20);
            this.WriteValueTextBox.TabIndex = 15;
            // 
            // ElementCountTextBox
            // 
            this.ElementCountTextBox.Location = new System.Drawing.Point(266, 266);
            this.ElementCountTextBox.Name = "ElementCountTextBox";
            this.ElementCountTextBox.Size = new System.Drawing.Size(359, 20);
            this.ElementCountTextBox.TabIndex = 14;
            // 
            // TagNameTextBox
            // 
            this.TagNameTextBox.Location = new System.Drawing.Point(266, 201);
            this.TagNameTextBox.Name = "TagNameTextBox";
            this.TagNameTextBox.Size = new System.Drawing.Size(359, 20);
            this.TagNameTextBox.TabIndex = 13;
            // 
            // SlotTextBox
            // 
            this.SlotTextBox.Location = new System.Drawing.Point(266, 136);
            this.SlotTextBox.Name = "SlotTextBox";
            this.SlotTextBox.Size = new System.Drawing.Size(359, 20);
            this.SlotTextBox.TabIndex = 12;
            // 
            // IPAddTextBox
            // 
            this.IPAddTextBox.Location = new System.Drawing.Point(266, 71);
            this.IPAddTextBox.Name = "IPAddTextBox";
            this.IPAddTextBox.Size = new System.Drawing.Size(359, 20);
            this.IPAddTextBox.TabIndex = 11;
            // 
            // connectButton
            // 
            this.connectButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.connectButton.Location = new System.Drawing.Point(644, 350);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(120, 35);
            this.connectButton.TabIndex = 10;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(170, 332);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Value to Write";
            // 
            // WriteCheckBox
            // 
            this.WriteCheckBox.AutoSize = true;
            this.WriteCheckBox.Location = new System.Drawing.Point(158, 312);
            this.WriteCheckBox.Name = "WriteCheckBox";
            this.WriteCheckBox.Size = new System.Drawing.Size(86, 17);
            this.WriteCheckBox.TabIndex = 8;
            this.WriteCheckBox.Text = "Write to PLC";
            this.WriteCheckBox.UseVisualStyleBackColor = true;
            this.WriteCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(187, 241);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Data Type";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(191, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Cpu Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(219, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Slot";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(215, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Path";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Element Count";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(187, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tag Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "IP Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(361, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "RSLinx";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "SQL";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "PDC";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox WriteCheckBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.ComboBox DataTypeComboBox;
        private System.Windows.Forms.ComboBox CpuTypeComboBox;
        private System.Windows.Forms.ComboBox PathComboBox;
        private System.Windows.Forms.TextBox WriteValueTextBox;
        private System.Windows.Forms.TextBox ElementCountTextBox;
        private System.Windows.Forms.TextBox TagNameTextBox;
        private System.Windows.Forms.TextBox SlotTextBox;
        private System.Windows.Forms.TextBox IPAddTextBox;
    }
}

