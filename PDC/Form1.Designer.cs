namespace PDC
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.DataTypeComboBox = new System.Windows.Forms.ComboBox();
            this.CpuTypeComboBox = new System.Windows.Forms.ComboBox();
            this.PathComboBox = new System.Windows.Forms.ComboBox();
            this.WriteValueTextBox = new System.Windows.Forms.TextBox();
            this.ElementCountTextBox = new System.Windows.Forms.TextBox();
            this.TagNameTextBox = new System.Windows.Forms.TextBox();
            this.SlotTextBox = new System.Windows.Forms.TextBox();
            this.IPAddTextBox = new System.Windows.Forms.TextBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.valToWriteLabel = new System.Windows.Forms.Label();
            this.writeCheckBox = new System.Windows.Forms.CheckBox();
            this.dataTypeLabel = new System.Windows.Forms.Label();
            this.cpuTypeLabel = new System.Windows.Forms.Label();
            this.slotLabel = new System.Windows.Forms.Label();
            this.pathLabel = new System.Windows.Forms.Label();
            this.elemCountLabel = new System.Windows.Forms.Label();
            this.tagNameLabel = new System.Windows.Forms.Label();
            this.ipAddLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.resetButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.tableNameComboBox = new System.Windows.Forms.ComboBox();
            this.tableNameLabel = new System.Windows.Forms.Label();
            this.viewButton = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.databaseNameTextBox = new System.Windows.Forms.TextBox();
            this.serverNameTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.databaseNameLabel = new System.Windows.Forms.Label();
            this.serverNameLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.statusStrip2.SuspendLayout();
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
            this.tabPage1.Controls.Add(this.statusStrip1);
            this.tabPage1.Controls.Add(this.DataTypeComboBox);
            this.tabPage1.Controls.Add(this.CpuTypeComboBox);
            this.tabPage1.Controls.Add(this.PathComboBox);
            this.tabPage1.Controls.Add(this.WriteValueTextBox);
            this.tabPage1.Controls.Add(this.ElementCountTextBox);
            this.tabPage1.Controls.Add(this.TagNameTextBox);
            this.tabPage1.Controls.Add(this.SlotTextBox);
            this.tabPage1.Controls.Add(this.IPAddTextBox);
            this.tabPage1.Controls.Add(this.connectButton);
            this.tabPage1.Controls.Add(this.valToWriteLabel);
            this.tabPage1.Controls.Add(this.writeCheckBox);
            this.tabPage1.Controls.Add(this.dataTypeLabel);
            this.tabPage1.Controls.Add(this.cpuTypeLabel);
            this.tabPage1.Controls.Add(this.slotLabel);
            this.tabPage1.Controls.Add(this.pathLabel);
            this.tabPage1.Controls.Add(this.elemCountLabel);
            this.tabPage1.Controls.Add(this.tagNameLabel);
            this.tabPage1.Controls.Add(this.ipAddLabel);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "PLC";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(3, 399);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(786, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // DataTypeComboBox
            // 
            this.DataTypeComboBox.FormattingEnabled = true;
            this.DataTypeComboBox.Items.AddRange(new object[] {
            "Int8",
            "Int16",
            "Int32",
            "Float32",
            "String"});
            this.DataTypeComboBox.Location = new System.Drawing.Point(266, 233);
            this.DataTypeComboBox.Name = "DataTypeComboBox";
            this.DataTypeComboBox.Size = new System.Drawing.Size(358, 21);
            this.DataTypeComboBox.TabIndex = 5;
            this.DataTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.DataTypeComboBox_SelectedIndexChanged);
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
            this.CpuTypeComboBox.TabIndex = 3;
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
            this.PathComboBox.TabIndex = 1;
            // 
            // WriteValueTextBox
            // 
            this.WriteValueTextBox.Location = new System.Drawing.Point(266, 325);
            this.WriteValueTextBox.Name = "WriteValueTextBox";
            this.WriteValueTextBox.Size = new System.Drawing.Size(359, 20);
            this.WriteValueTextBox.TabIndex = 8;
            this.WriteValueTextBox.TextChanged += new System.EventHandler(this.WriteValueTextBox_TextChanged);
            // 
            // ElementCountTextBox
            // 
            this.ElementCountTextBox.Location = new System.Drawing.Point(266, 266);
            this.ElementCountTextBox.Name = "ElementCountTextBox";
            this.ElementCountTextBox.Size = new System.Drawing.Size(359, 20);
            this.ElementCountTextBox.TabIndex = 6;
            // 
            // TagNameTextBox
            // 
            this.TagNameTextBox.Location = new System.Drawing.Point(266, 201);
            this.TagNameTextBox.Name = "TagNameTextBox";
            this.TagNameTextBox.Size = new System.Drawing.Size(359, 20);
            this.TagNameTextBox.TabIndex = 4;
            // 
            // SlotTextBox
            // 
            this.SlotTextBox.Location = new System.Drawing.Point(266, 136);
            this.SlotTextBox.Name = "SlotTextBox";
            this.SlotTextBox.Size = new System.Drawing.Size(359, 20);
            this.SlotTextBox.TabIndex = 2;
            // 
            // IPAddTextBox
            // 
            this.IPAddTextBox.Location = new System.Drawing.Point(266, 71);
            this.IPAddTextBox.Name = "IPAddTextBox";
            this.IPAddTextBox.Size = new System.Drawing.Size(359, 20);
            this.IPAddTextBox.TabIndex = 0;
            // 
            // connectButton
            // 
            this.connectButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.connectButton.Location = new System.Drawing.Point(644, 350);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(120, 35);
            this.connectButton.TabIndex = 9;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // valToWriteLabel
            // 
            this.valToWriteLabel.AutoSize = true;
            this.valToWriteLabel.Location = new System.Drawing.Point(170, 332);
            this.valToWriteLabel.Name = "valToWriteLabel";
            this.valToWriteLabel.Size = new System.Drawing.Size(74, 13);
            this.valToWriteLabel.TabIndex = 9;
            this.valToWriteLabel.Text = "Value to Write";
            // 
            // writeCheckBox
            // 
            this.writeCheckBox.AutoSize = true;
            this.writeCheckBox.Location = new System.Drawing.Point(158, 312);
            this.writeCheckBox.Name = "writeCheckBox";
            this.writeCheckBox.Size = new System.Drawing.Size(86, 17);
            this.writeCheckBox.TabIndex = 7;
            this.writeCheckBox.Text = "Write to PLC";
            this.writeCheckBox.UseVisualStyleBackColor = true;
            this.writeCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // dataTypeLabel
            // 
            this.dataTypeLabel.AutoSize = true;
            this.dataTypeLabel.Location = new System.Drawing.Point(187, 241);
            this.dataTypeLabel.Name = "dataTypeLabel";
            this.dataTypeLabel.Size = new System.Drawing.Size(57, 13);
            this.dataTypeLabel.TabIndex = 7;
            this.dataTypeLabel.Text = "Data Type";
            // 
            // cpuTypeLabel
            // 
            this.cpuTypeLabel.AutoSize = true;
            this.cpuTypeLabel.Location = new System.Drawing.Point(191, 176);
            this.cpuTypeLabel.Name = "cpuTypeLabel";
            this.cpuTypeLabel.Size = new System.Drawing.Size(53, 13);
            this.cpuTypeLabel.TabIndex = 6;
            this.cpuTypeLabel.Text = "Cpu Type";
            // 
            // slotLabel
            // 
            this.slotLabel.AutoSize = true;
            this.slotLabel.Location = new System.Drawing.Point(219, 143);
            this.slotLabel.Name = "slotLabel";
            this.slotLabel.Size = new System.Drawing.Size(25, 13);
            this.slotLabel.TabIndex = 5;
            this.slotLabel.Text = "Slot";
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Location = new System.Drawing.Point(215, 111);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(29, 13);
            this.pathLabel.TabIndex = 4;
            this.pathLabel.Text = "Path";
            // 
            // elemCountLabel
            // 
            this.elemCountLabel.AutoSize = true;
            this.elemCountLabel.Location = new System.Drawing.Point(168, 273);
            this.elemCountLabel.Name = "elemCountLabel";
            this.elemCountLabel.Size = new System.Drawing.Size(76, 13);
            this.elemCountLabel.TabIndex = 3;
            this.elemCountLabel.Text = "Element Count";
            // 
            // tagNameLabel
            // 
            this.tagNameLabel.AutoSize = true;
            this.tagNameLabel.Location = new System.Drawing.Point(187, 208);
            this.tagNameLabel.Name = "tagNameLabel";
            this.tagNameLabel.Size = new System.Drawing.Size(57, 13);
            this.tagNameLabel.TabIndex = 2;
            this.tagNameLabel.Text = "Tag Name";
            // 
            // ipAddLabel
            // 
            this.ipAddLabel.AutoSize = true;
            this.ipAddLabel.Location = new System.Drawing.Point(186, 78);
            this.ipAddLabel.Name = "ipAddLabel";
            this.ipAddLabel.Size = new System.Drawing.Size(58, 13);
            this.ipAddLabel.TabIndex = 1;
            this.ipAddLabel.Text = "IP Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(361, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "PLC";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.statusStrip2);
            this.tabPage2.Controls.Add(this.resetButton);
            this.tabPage2.Controls.Add(this.loadButton);
            this.tabPage2.Controls.Add(this.tableNameComboBox);
            this.tabPage2.Controls.Add(this.tableNameLabel);
            this.tabPage2.Controls.Add(this.viewButton);
            this.tabPage2.Controls.Add(this.passwordTextBox);
            this.tabPage2.Controls.Add(this.userNameTextBox);
            this.tabPage2.Controls.Add(this.databaseNameTextBox);
            this.tabPage2.Controls.Add(this.serverNameTextBox);
            this.tabPage2.Controls.Add(this.passwordLabel);
            this.tabPage2.Controls.Add(this.userNameLabel);
            this.tabPage2.Controls.Add(this.databaseNameLabel);
            this.tabPage2.Controls.Add(this.serverNameLabel);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "SQL";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // statusStrip2
            // 
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2});
            this.statusStrip2.Location = new System.Drawing.Point(3, 399);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(786, 22);
            this.statusStrip2.TabIndex = 13;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(618, 358);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(135, 23);
            this.resetButton.TabIndex = 12;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(618, 300);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(135, 23);
            this.loadButton.TabIndex = 9;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // tableNameComboBox
            // 
            this.tableNameComboBox.FormattingEnabled = true;
            this.tableNameComboBox.Location = new System.Drawing.Point(297, 262);
            this.tableNameComboBox.Name = "tableNameComboBox";
            this.tableNameComboBox.Size = new System.Drawing.Size(288, 21);
            this.tableNameComboBox.TabIndex = 10;
            this.tableNameComboBox.SelectedIndexChanged += new System.EventHandler(this.tableNameComboBox_SelectedIndexChanged);
            // 
            // tableNameLabel
            // 
            this.tableNameLabel.AutoSize = true;
            this.tableNameLabel.Location = new System.Drawing.Point(226, 266);
            this.tableNameLabel.Name = "tableNameLabel";
            this.tableNameLabel.Size = new System.Drawing.Size(65, 13);
            this.tableNameLabel.TabIndex = 11;
            this.tableNameLabel.Text = "Table Name";
            // 
            // viewButton
            // 
            this.viewButton.Location = new System.Drawing.Point(618, 329);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(135, 23);
            this.viewButton.TabIndex = 11;
            this.viewButton.Text = "View";
            this.viewButton.UseVisualStyleBackColor = true;
            this.viewButton.Click += new System.EventHandler(this.sqlConnectButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(297, 232);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '•';
            this.passwordTextBox.Size = new System.Drawing.Size(288, 20);
            this.passwordTextBox.TabIndex = 8;
            this.passwordTextBox.UseSystemPasswordChar = true;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(297, 202);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(288, 20);
            this.userNameTextBox.TabIndex = 7;
            this.userNameTextBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // databaseNameTextBox
            // 
            this.databaseNameTextBox.Location = new System.Drawing.Point(297, 173);
            this.databaseNameTextBox.Name = "databaseNameTextBox";
            this.databaseNameTextBox.Size = new System.Drawing.Size(288, 20);
            this.databaseNameTextBox.TabIndex = 6;
            this.databaseNameTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // serverNameTextBox
            // 
            this.serverNameTextBox.Location = new System.Drawing.Point(297, 142);
            this.serverNameTextBox.Name = "serverNameTextBox";
            this.serverNameTextBox.Size = new System.Drawing.Size(288, 20);
            this.serverNameTextBox.TabIndex = 5;
            this.serverNameTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(238, 236);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(53, 13);
            this.passwordLabel.TabIndex = 4;
            this.passwordLabel.Text = "Password";
            this.passwordLabel.Click += new System.EventHandler(this.label14_Click);
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(236, 206);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(55, 13);
            this.userNameLabel.TabIndex = 3;
            this.userNameLabel.Text = "Username";
            this.userNameLabel.Click += new System.EventHandler(this.label13_Click);
            // 
            // databaseNameLabel
            // 
            this.databaseNameLabel.AutoSize = true;
            this.databaseNameLabel.Location = new System.Drawing.Point(207, 177);
            this.databaseNameLabel.Name = "databaseNameLabel";
            this.databaseNameLabel.Size = new System.Drawing.Size(84, 13);
            this.databaseNameLabel.TabIndex = 2;
            this.databaseNameLabel.Text = "Database Name";
            this.databaseNameLabel.Click += new System.EventHandler(this.label12_Click);
            // 
            // serverNameLabel
            // 
            this.serverNameLabel.AutoSize = true;
            this.serverNameLabel.Location = new System.Drawing.Point(222, 146);
            this.serverNameLabel.Name = "serverNameLabel";
            this.serverNameLabel.Size = new System.Drawing.Size(69, 13);
            this.serverNameLabel.TabIndex = 1;
            this.serverNameLabel.Text = "Server Name";
            this.serverNameLabel.Click += new System.EventHandler(this.label11_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(373, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 24);
            this.label10.TabIndex = 0;
            this.label10.Text = "SQL";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "PDC";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label ipAddLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tagNameLabel;
        private System.Windows.Forms.Label slotLabel;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.Label elemCountLabel;
        private System.Windows.Forms.Label valToWriteLabel;
        private System.Windows.Forms.CheckBox writeCheckBox;
        private System.Windows.Forms.Label dataTypeLabel;
        private System.Windows.Forms.Label cpuTypeLabel;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.ComboBox DataTypeComboBox;
        private System.Windows.Forms.ComboBox CpuTypeComboBox;
        private System.Windows.Forms.ComboBox PathComboBox;
        private System.Windows.Forms.TextBox WriteValueTextBox;
        private System.Windows.Forms.TextBox ElementCountTextBox;
        private System.Windows.Forms.TextBox TagNameTextBox;
        private System.Windows.Forms.TextBox SlotTextBox;
        private System.Windows.Forms.TextBox IPAddTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.TextBox databaseNameTextBox;
        private System.Windows.Forms.TextBox serverNameTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label databaseNameLabel;
        private System.Windows.Forms.Label serverNameLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button viewButton;
        private System.Windows.Forms.ComboBox tableNameComboBox;
        private System.Windows.Forms.Label tableNameLabel;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
    }
}

