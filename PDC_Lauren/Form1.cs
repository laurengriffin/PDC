using LibplctagWrapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        public Form1()
        {
            InitializeComponent();
        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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

            if (!WriteCheckBox.Checked)
            {
                Console.WriteLine("reading from PLC");

                // get the data
                var rc = client.ReadTag(tag, 5000);

                if (rc != Libplctag.PLCTAG_STATUS_OK)
                {
                    Console.WriteLine($"ERROR: Unable to read the data! Got error code {rc}: {client.DecodeError(client.GetStatus(tag))}\n");
                    return;
                }

                // print data according to data type
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
                        //case "String":
                        //    Console.WriteLine("data type identified as string");
                        //    // not tested bc unable to find a string data type value on plc
                        //    Console.WriteLine($"data[{i}]={client.ReadTag(tag, (i * tag.ElementSize))}\n");
                        //    MessageBox.Show($"{plcom.tagname}={client.ReadTag(tag, (i * tag.ElementSize))}\n");
                        //    break;
                        default:
                            Console.WriteLine("no data type identified");
                            MessageBox.Show("no data type identified");
                            break;
                    }
                }

            }
            else if (WriteCheckBox.Checked)
            {
                Console.WriteLine("writing to PLC");
            }
            else
            {
                Console.WriteLine("'Write to PLC' checkbox value is unknown. unable to perform any operation.");
                Console.WriteLine("checked? " + WriteCheckBox.Checked);
            }
            
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

    }
}
