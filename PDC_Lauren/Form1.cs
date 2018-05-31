using LibplctagWrapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDC_Lauren
{
    public partial class Form1 : Form
    {

        private BindingSource bindingSourceList = new BindingSource();
        private SqlDataAdapter listAdapter = new SqlDataAdapter();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // hide fields on form
            WriteValueTextBox.Visible = false;
            label9.Visible = false;
            tableNameLabel.Visible = false;
            tableNameComboBox.Visible = false;
            sqlConnectButton.Visible = false;
            resetButton.Visible = false;
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            // access and format form data
            PLCommunication plcom = new PLCommunication(IPAddTextBox.Text.Trim(), (PathComboBox.SelectedIndex + 1).ToString().Trim(),
                    SlotTextBox.Text.Trim(), CpuTypeComboBox.Text.Trim(), TagNameTextBox.Text.Trim(), DataTypeComboBox.Text,
                    Int32.Parse(ElementCountTextBox.Text), WriteCheckBox.Checked, WriteValueTextBox.Text);

            // create instance of plc client
            var client = new Libplctag();

            // create the tag
            var tag = new Tag("ip address", "path", CpuType.LGX, "nameOfTag", DataType.Float32, 1);
            if (string.IsNullOrEmpty(plcom.path))
            {
                tag = new Tag(plcom.ipAddress, plcom.cput, plcom.tagname, plcom.dtInt, plcom.elemCount);
            }
            else
            {
                tag = new Tag(plcom.ipAddress, plcom.path, plcom.cput, plcom.tagname, plcom.dtInt, plcom.elemCount);
            }

            // add the tag
            client.AddTag(tag);

            // check that connection is successful
            while (client.GetStatus(tag) == Libplctag.PLCTAG_STATUS_PENDING)
            {
                Thread.Sleep(100);
            }
            if (client.GetStatus(tag) != Libplctag.PLCTAG_STATUS_OK)
            {
                Console.WriteLine($"Error setting up tag internal state. Error {client.DecodeError(client.GetStatus(tag))}\n");
                return;
            }

            // get the data from the form
            var rc = client.ReadTag(tag, 5000);
            if (rc != Libplctag.PLCTAG_STATUS_OK)
            {
                Console.WriteLine($"ERROR: Unable to read the data! Got error code {rc}: {client.DecodeError(client.GetStatus(tag))}\n");
                return;
            }

            // determine if reading or writing to plc
            if (!WriteCheckBox.Checked)
            {
                // print data according to data type
                Console.WriteLine("reading from the plc");
                for (int i = 0; i < tag.ElementCount; i++)
                {
                    switch (plcom.dtString)
                    {
                        case "Int16":
                            Console.WriteLine("data type identified as int16");
                            Console.WriteLine($"data[{i}]={client.GetInt16Value(tag, (i * tag.ElementSize))}\n");
                            MessageBox.Show($"{plcom.tagname}={client.GetInt16Value(tag, (i * tag.ElementSize))}\n");
                            break;
                        case "Int8":
                            Console.WriteLine("data type identified as int8");
                            Console.WriteLine($"data[{i}]={client.GetInt8Value(tag, (i * tag.ElementSize))}\n");
                            MessageBox.Show($"{plcom.tagname}={client.GetInt8Value(tag, (i * tag.ElementSize))}\n");
                            break;
                        case "Int32":
                            Console.WriteLine("data type identified as int32");
                            Console.WriteLine($"data[{i}]={client.GetInt32Value(tag, (i * tag.ElementSize))}\n");
                            MessageBox.Show($"{plcom.tagname}={client.GetInt32Value(tag, (i * tag.ElementSize))}\n");
                            break;
                        case "Float32":
                            Console.WriteLine("data type identified as float32");
                            Console.WriteLine($"data[{i}]={client.GetFloat32Value(tag, (i * tag.ElementSize))}\n");
                            MessageBox.Show($"{plcom.tagname}={client.GetFloat32Value(tag, (i * tag.ElementSize))}\n");
                            break;
                        // haven't tested the string data type
                        //case "String":
                            //Console.WriteLine("data type identified as string");
                            // not tested bc unable to find a string data type value on plc
                            //Console.WriteLine($"data[{i}]={client.ReadTag(tag, (i * tag.ElementSize))}\n");
                            //MessageBox.Show($"{plcom.tagname}={client.ReadTag(tag, (i * tag.ElementSize))}\n");
                            //break;
                        default:
                            Console.WriteLine("no data type identified");
                            MessageBox.Show("no data type identified");
                            break;
                    }
                }
            }
            else if (WriteCheckBox.Checked)
            {
                // writing to plc
                Console.WriteLine("writing to PLC");
                for (int i = 0; i < plcom.elemCount; i++)
                {
                    switch (plcom.dtString)
                    {
                        case "Int16":
                            Int16 val0 = Convert.ToInt16(plcom.valToWrite);
                            Console.WriteLine($"Setting element {plcom.tagname} to {val0}\n");
                            client.SetInt16Value(tag, (i * tag.ElementSize), val0);
                            break;
                        case "Int8":
                            sbyte val1 = sbyte.Parse(plcom.valToWrite);
                            Console.WriteLine($"Setting element {plcom.tagname} to {val1}\n");
                            client.SetInt8Value(tag, (i * tag.ElementSize), val1);
                            break;
                        case "Int32":
                            Int32 val2 = Convert.ToInt32(plcom.valToWrite);
                            Console.WriteLine($"Setting element {plcom.tagname} to {val2}\n");
                            client.SetInt32Value(tag, (i * tag.ElementSize), val2);
                            break;
                        case "Float32":
                            float val3 = float.Parse(plcom.valToWrite);
                            Console.WriteLine($"Setting element {plcom.tagname} to {val3}\n");
                            client.SetFloat32Value(tag, (i * tag.ElementSize), val3);
                            break;
                        default:
                            break;
                    }
                }

                rc = client.WriteTag(tag, 5000);

                if (rc != Libplctag.PLCTAG_STATUS_OK)
                {
                    Console.WriteLine($"ERROR: Unable to read the data! Got error code {rc}: {client.DecodeError(rc)}\n");
                    return;
                }

                // print the new value that was written to the tag
                for (int i = 0; i < tag.ElementCount; i++)
                {
                    switch (plcom.dtString)
                    {
                        case "Int16":
                            MessageBox.Show($"data changed\n{plcom.tagname}={client.GetInt16Value(tag, (i * tag.ElementSize))}\n");
                            break;
                        case "Int8":
                            MessageBox.Show($"data changed\n{plcom.tagname}={client.GetInt8Value(tag, (i * tag.ElementSize))}\n");
                            break;
                        case "Int32":
                            MessageBox.Show($"data changed\n{plcom.tagname}={client.GetInt32Value(tag, (i * tag.ElementSize))}\n");
                            break;
                        case "Float32":
                            MessageBox.Show($"data changed\n{plcom.tagname}={client.GetFloat32Value(tag, (i * tag.ElementSize))}\n");
                            break;
                        default:
                            break;
                    }
                    
                }
            }
            else
            {
                // not sure if should read or write to plc
                Console.WriteLine("'Write to PLC' checkbox value is unknown. unable to perform any operation.");
                Console.WriteLine("checked? " + WriteCheckBox.Checked);
            }

            // close and cleanup resources
            client.Dispose();
            Console.Read();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            WriteValueTextBox.Visible = !WriteValueTextBox.Visible;
            label9.Visible = !label9.Visible;
        }

        private void sqlConnectButton_Click(object sender, EventArgs e)
        {
            SQLCommunication.tableName = tableNameComboBox.Text;
            Form2 form2 = new Form2();
            form2.Visible = true;
        }

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
                    MessageBox.Show("connection open");
                    Console.WriteLine("ServerVersion: {0}", sqlc.ServerVersion);
                    Console.WriteLine("State: {0}", sqlc.State);

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
                    sqlConnectButton.Visible = true;
                    loadButton.Visible = false;
                    resetButton.Visible = true;

                    sqlc.Close();
                }
                catch (Exception err)
                {
                    MessageBox.Show("Error: \n" + err);
                }
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            WriteValueTextBox.Visible = false;
            label9.Visible = false;
            loadButton.Visible = true;
            tableNameLabel.Visible = false;
            tableNameComboBox.Visible = false;
            sqlConnectButton.Visible = false;
            resetButton.Visible = false;
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
