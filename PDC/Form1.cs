using LibplctagWrapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDC
{
    public partial class Form1 : Form
    {

        private BindingSource bindingSourceList = new BindingSource();
        private SqlDataAdapter listAdapter = new SqlDataAdapter();
        int DataTimeout = 5000;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // hide fields on form
            WriteValueTextBox.Visible = false;
            valToWriteLabel.Visible = false;
            tableNameLabel.Visible = false;
            tableNameComboBox.Visible = false;
            viewButton.Visible = false;
            resetButton.Visible = false;
            toolStripStatusLabel1.Text = "Fill appropriate fields to read from PLC";
            toolStripStatusLabel2.Text = "Fill appropriate fields to access SQL Database";

            // set up tool tips
            // sql
            ToolTip serverNameToolTip = new ToolTip();
            serverNameToolTip.SetToolTip(serverNameLabel, "The name of the SQL Server");
            ToolTip databaseNameToolTip = new ToolTip();
            databaseNameToolTip.SetToolTip(databaseNameLabel, "The name of the Database");
            ToolTip userNameToolTip = new ToolTip();
            userNameToolTip.SetToolTip(userNameLabel, "The username to access the server");
            ToolTip passwordToolTip = new ToolTip();
            passwordToolTip.SetToolTip(passwordLabel, "The password to access the server");
            ToolTip tableNameToolTip = new ToolTip();
            tableNameToolTip.SetToolTip(tableNameLabel, "The name of the table on the database");
            ToolTip loadToolTip = new ToolTip();
            loadToolTip.SetToolTip(loadButton, "Loads the list of tables on the database");
            ToolTip viewToolTip = new ToolTip();
            viewToolTip.SetToolTip(viewButton, "Shows SQL data table");
            ToolTip resetButtonToolTip = new ToolTip();
            resetButtonToolTip.SetToolTip(resetButton, "Click to clear connection and form fields.");

            // plc
            ToolTip ipAddToolTip = new ToolTip();
            ipAddToolTip.SetToolTip(ipAddLabel, "The IP Address to connect to the CPU");
            ToolTip pathToolTip = new ToolTip();
            pathToolTip.SetToolTip(pathLabel, "The path on which the CPU is located");
            ToolTip slotToolTip = new ToolTip();
            slotToolTip.SetToolTip(slotLabel, "If the CPU is on a Backplane: the slot it is located on");
            ToolTip cpuToolTip = new ToolTip();
            cpuToolTip.SetToolTip(cpuTypeLabel, "The type of CPU to connect to");
            ToolTip tagNameToolTip = new ToolTip();
            tagNameToolTip.SetToolTip(tagNameLabel, "The tag name to read/write to");
            ToolTip dataTypeToolTip = new ToolTip();
            dataTypeToolTip.SetToolTip(dataTypeLabel, "The data type of the selected tag value");
            ToolTip elemCountToolTip = new ToolTip();
            elemCountToolTip.SetToolTip(elemCountLabel, "The amount of elements to read/write to for the selected tag");
            ToolTip writeCheckToolTip = new ToolTip();
            writeCheckToolTip.SetToolTip(writeCheckBox, "Select if you would like to write to the CPU");
            ToolTip valToWriteToolTip = new ToolTip();
            valToWriteToolTip.SetToolTip(valToWriteLabel, "The value to write to the CPU");
            ToolTip connectButtonToolTip = new ToolTip();
            connectButtonToolTip.SetToolTip(connectButton, "Click to connect and run read/write on CPU");
        }

        // when connection button is clicked
        private void sqlConnectButton_Click(object sender, EventArgs e)
        {
            // store the table name and open the new form
            try
            {
                SQLCommunication.tableName = tableNameComboBox.Text;
                Form2 form2 = new Form2();
                form2.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR: {ex}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // when sql load button is clicked
        private void loadButton_Click(object sender, EventArgs e)
        {
            // connect to the sql client
            SQLCommunication connection = new SQLCommunication(serverNameTextBox.Text, databaseNameTextBox.Text, userNameTextBox.Text, passwordTextBox.Text);
            using (SqlConnection sqlc = new SqlConnection(SQLCommunication.cs))
            {
                try
                {
                    // open sql connection
                    sqlc.Open();
                    MessageBox.Show("Connection Open", "Connected", MessageBoxButtons.OK, MessageBoxIcon.None);

                    // set up the combo box to list the tables in the database
                    DataTable tablesList = new DataTable();
                    listAdapter.SelectCommand = new SqlCommand("SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES", sqlc);
                    listAdapter.Fill(tablesList);
                    bindingSourceList.DataSource = tablesList;
                    tableNameComboBox.DataSource = bindingSourceList.DataSource;
                    tableNameComboBox.DisplayMember = "TABLE_NAME";
                    tableNameComboBox.ValueMember = "TABLE_NAME";

                    // hide and show respective fields on form
                    tableNameLabel.Visible = true;
                    tableNameComboBox.Visible = true;
                    viewButton.Visible = true;
                    loadButton.Visible = false;
                    resetButton.Visible = true;

                    sqlc.Close();
                }
                catch (Exception err)
                {
                    MessageBox.Show("ERROR: \n" + err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // when the reset button is clicked
        private void resetButton_Click(object sender, EventArgs e)
        {
            WriteValueTextBox.Visible = false;
            valToWriteLabel.Visible = false;
            loadButton.Visible = true;
            tableNameLabel.Visible = false;
            tableNameComboBox.Visible = false;
            viewButton.Visible = false;
            resetButton.Visible = false;

            // clear the form fields
            serverNameTextBox.Text = "";
            databaseNameTextBox.Text = "";
            userNameTextBox.Text = "";
            passwordTextBox.Text = "";
        }

        // show/hide appropriate fields when reading or writing to plc
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            WriteValueTextBox.Visible = !WriteValueTextBox.Visible;
            valToWriteLabel.Visible = !valToWriteLabel.Visible;
            if (WriteValueTextBox.Visible)
            {
                toolStripStatusLabel1.Text = "Fill appropriate fields to write to PLC";
            }
            else
            {
                toolStripStatusLabel1.Text = "Fill appropriate fields to read from PLC";
            }
        }

        // plc connect button
        private void connectButton_Click(object sender, EventArgs e)
        {
            // set up tag and communication with plc
            PLCommunication comm = new PLCommunication(IPAddTextBox.Text.Trim(), (PathComboBox.SelectedIndex + 1).ToString().Trim(),
                   SlotTextBox.Text.Trim(), CpuTypeComboBox.Text.Trim(), TagNameTextBox.Text.Trim(), DataTypeComboBox.Text,
                   Int32.Parse(ElementCountTextBox.Text), writeCheckBox.Checked, WriteValueTextBox.Text);

            // create instance of plc client
            var client = new Libplctag();

            // create the tag
            var tag = new Tag(comm.ipAddress, comm.path, comm.cput, comm.tagname, comm.dtInt, comm.elemCount);
            if (comm.cput != CpuType.LGX)
            {
                tag = new Tag(comm.ipAddress, comm.cput, comm.tagname, comm.dtInt, comm.elemCount);
            }

            // add the tag
            client.AddTag(tag);

            // check that the tag has been added, if it returns pending then retry
            while (client.GetStatus(tag) == Libplctag.PLCTAG_STATUS_PENDING)
            {
                Thread.Sleep(100);
            }

            // if the status is not ok, then handle error
            if (client.GetStatus(tag) != Libplctag.PLCTAG_STATUS_OK)
            {
                MessageBox.Show($"ERROR: Unable to set up tag internal state.\n {client.DecodeError(client.GetStatus(tag))}\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // determine if reading or writing to plc
            if (writeCheckBox.Checked)
            {
                // writing to plc
                switch (DataTypeComboBox.Text)
                {
                    case "Int8":
                        writeInt8Val(tag, client, sbyte.Parse(comm.valToWrite), true);
                        break;
                    case "Int16":
                        writeInt16Val(tag, client, Convert.ToInt16(comm.valToWrite), true);
                        break;
                    case "Int32":
                        writeInt32Val(tag, client, Convert.ToInt32(comm.valToWrite), true);
                        break;
                    case "Float32":
                        writeFloat32Val(tag, client, float.Parse(comm.valToWrite), true);
                        break;
                    case "String":
                        writeStringVal(tag, client, comm.valToWrite, true);
                        break;
                    default:
                        MessageBox.Show("Invalid Data Type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }

                // write the values
                var result = client.WriteTag(tag, DataTimeout);
                if (result != Libplctag.PLCTAG_STATUS_OK)
                {
                    MessageBox.Show($"Error: Unable to read the data. Got error code {result}: {client.DecodeError(result)}\n");
                    return;
                }
            }
            else if (!writeCheckBox.Checked)
            {
                // reading from plc
                var result = client.ReadTag(tag, DataTimeout);
                if (result != Libplctag.PLCTAG_STATUS_OK)
                {
                    MessageBox.Show($"Error: Unable to read the data. Got error code {result}: {client.DecodeError(result)}\n");
                    return;
                }

                switch (DataTypeComboBox.Text)
                {
                    case "Int8":
                        readInt8Val(tag, client);
                        break;
                    case "Int16":
                        readInt16Val(tag, client);
                        break;
                    case "Int32":
                        readInt32Val(tag, client);
                        break;
                    case "Float32":
                        readFloat32Val(tag, client);
                        break;
                    case "String":
                        readStringVal(tag, client);
                        break;
                    default:
                        MessageBox.Show("Invalid Data Type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
            else
            {
                // no defined action: reading/writing
                MessageBox.Show("Error: No defined action.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // close and cleanup resources
            client.Dispose();
            Console.Read();
        }

        private void readInt8Val(Tag tag, Libplctag client)
        {
            var sb = new StringBuilder();
            for (int i = 0; i < tag.ElementCount; i++)
            {
                sb.Append($"{tag.Name} = {client.GetInt8Value(tag, (i * tag.ElementSize))}\n");
            }
            MessageBox.Show(sb.ToString(), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void writeInt8Val(Tag tag, Libplctag client, sbyte value, bool print)
        {
            var sb = new StringBuilder();
            for (int i = 0; i < tag.ElementCount; i++)
            {
                client.SetInt8Value(tag, (i * tag.ElementSize), value);
            }
            if (print)
            {
                readInt8Val(tag, client);
            }
        }

        private void readInt16Val(Tag tag, Libplctag client)
        {
            var sb = new StringBuilder();
            for (int i = 0; i < tag.ElementCount; i++)
            {
                sb.Append($"{tag.Name} = {client.GetInt16Value(tag, (i * tag.ElementSize))}\n");
            }
            MessageBox.Show(sb.ToString(), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void writeInt16Val(Tag tag, Libplctag client, Int16 value, bool print)
        {
            for (int i = 0; i < tag.ElementCount; i++)
            {
                client.SetInt16Value(tag, (i * tag.ElementSize), value);
            }
            if (print)
            {
                readInt16Val(tag, client);
            }
        }

        private void readInt32Val(Tag tag, Libplctag client)
        {
            var sb = new StringBuilder();
            for (int i = 0; i < tag.ElementCount; i++)
            {
                sb.Append($"{tag.Name} = {client.GetInt32Value(tag, (i * tag.ElementSize))}\n");
            }
            MessageBox.Show(sb.ToString(), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void writeInt32Val(Tag tag, Libplctag client, Int32 value, bool print)
        {
            var sb = new StringBuilder();
            for (int i = 0; i < tag.ElementCount; i++)
            {
                client.SetInt32Value(tag, (i * tag.ElementSize), value);
            }
            if (print)
            {
                readInt32Val(tag, client);
            }
        }

        private void readFloat32Val(Tag tag, Libplctag client)
        {
            var sb = new StringBuilder();
            for (int i = 0; i < tag.ElementCount; i++)
            {
                sb.Append($"{tag.Name} = {client.GetFloat32Value(tag, (i * tag.ElementSize))}\n");
            }
            MessageBox.Show(sb.ToString(), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void writeFloat32Val(Tag tag, Libplctag client, float value, bool print)
        {
            var sb = new StringBuilder();
            for (int i = 0; i < tag.ElementCount; i++)
            {
                client.SetFloat32Value(tag, (i * tag.ElementSize), value);
            }
            if (print)
            {
                readFloat32Val(tag, client);
            }
        }

        private void readStringVal(Tag tag, Libplctag client)
        {
            for (int i = 0; i < tag.ElementCount; i++)
            {
                Console.WriteLine($"read element count: {tag.ElementCount}");
                Console.WriteLine($"read iteration {i}");
                byte[] asciiBytes = new byte[tag.ElementSize];
                var sb = new StringBuilder();
                for (int j = 0; j < tag.ElementSize; j++)
                {
                    sb.Append((char)client.GetUint8Value(tag, (i * tag.ElementSize) + j));
                }
                string s = sb.ToString();
                string pattern = "[^ -~]+";
                Regex reg_exp = new Regex(pattern);
                string output = reg_exp.Replace(s, " ");

                MessageBox.Show($"string {i} = {output}");
            }
        }

        private void writeStringVal(Tag tag, Libplctag client, String value, bool print)
        {
            for (int i = 0; i < tag.ElementCount; i++)
            {
                Console.WriteLine($"element count: {tag.ElementCount}");
                Console.WriteLine($"write iteration {i}");
                byte[] asciiBytes = new byte[tag.ElementSize];
                byte[] byteArr = Encoding.ASCII.GetBytes(value);
                for (int j = 0; j < value.Length; j++)
                {
                    asciiBytes[j] = byteArr[j];
                }
                string bytes = "";
                for (int m = 0; m < asciiBytes.Length; m++)
                {
                    bytes += asciiBytes[m] + "\t";
                }
                MessageBox.Show($"asciibytes = {bytes}");
                setStringLength(tag, client, (Int16)value.Length);
                for (int k = 0; k < tag.ElementSize; k++)
                {
                    client.SetUint8Value(tag, (i * tag.ElementSize) + k + 4, asciiBytes[k]);
                }
                if (print)
                {
                    readStringVal(tag, client);
                }
            }
        }

        private void setStringLength(Tag tag, Libplctag client, Int16 valLength)
        {
            client.SetInt16Value(tag, (0 * tag.ElementSize), valLength);
        }

        // unused
        private void tableNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        private void DataTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void WriteValueTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
        private void label12_Click(object sender, EventArgs e)
        {

        }
        private void label13_Click(object sender, EventArgs e)
        {

        }
        private void label14_Click(object sender, EventArgs e)
        {

        }
        private void label11_Click(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
