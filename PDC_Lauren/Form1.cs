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
            var ipAddress = IPAddTextBox.Text.Trim();
            Console.WriteLine("IP Address: {0}", ipAddress);
            Boolean isPath = false;
            var path = "";
            // check to see if path is specified
            if (!(string.IsNullOrEmpty(SlotTextBox.Text) && string.IsNullOrEmpty(PathComboBox.Text)))
            {
                // there is a path
                isPath = true;
                path = (PathComboBox.SelectedIndex + 1).ToString().Trim() + "," + SlotTextBox.Text.Trim();
            }
            Console.WriteLine("Path: {0}", path);
            var cType = CpuTypeComboBox.Text.Trim();
            CpuType ct = new CpuType();
            if (cType.Equals("LGX"))
            {
                ct = CpuType.LGX;
            } else if (cType.Equals("SLC"))
            {
                ct = CpuType.SLC;
            } else if (cType.Equals("PLC5"))
            {
                ct = CpuType.PLC5;
            }
            Console.WriteLine("Cpu Type: {0}",  ct);
            var tagName = TagNameTextBox.Text.Trim();
            Console.WriteLine("Tag Name: {0}", tagName);
            //var dType = DataTypeComboBox.Text.Trim();
            //int dType = 0;
            //bool dt = Int32.TryParse(DataTypeComboBox.Text.Trim(), out dType);
            //DataType dt = new DataType();
            int dt = 0;
            if (DataTypeComboBox.SelectedIndex == 0)
            {
                dt = DataType.Int16;
            }
            else if (DataTypeComboBox.SelectedIndex == 1)
            {
                dt = DataType.Int8;
            }
            else if (DataTypeComboBox.SelectedIndex == 2)
            {
                dt = DataType.Int32;
            }
            else if (DataTypeComboBox.SelectedIndex == 3)
            {
                dt = DataType.Float32;
            }
            else if (DataTypeComboBox.SelectedIndex == 4)
            {
                dt = DataType.String;
            }
            Console.WriteLine("Data Type: {0},[{1}]", DataTypeComboBox.Text, dt);
            //int eCount = Int32.Parse(ElementCountTextBox.Text);
            int eCount = 0;
            bool result = Int32.TryParse(ElementCountTextBox.Text, out eCount);
            if (result)
            {
                Console.WriteLine("Element Count: {0}", eCount);
            }
            Console.WriteLine("Write to PLC: {0}", WriteCheckBox.CheckState);
            Console.WriteLine("Value: {0}", WriteValueTextBox.Text);

            // create instance of plc client
            var client = new Libplctag();

            // create the tag
            //var tag = new Tag("65.199.190.237", "1,0", CpuType.LGX, "testreal", DataType.Float32, 1);
            var tag = new Tag("ip address", "path", CpuType.LGX, "nameOfTag", DataType.Float32, 1);
            if (isPath)
            {
                tag = new Tag(ipAddress, path, ct, tagName, dt, eCount);
            }
            else
            {

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

            // get the data
            var rc = client.ReadTag(tag, 5000);

            if (rc != Libplctag.PLCTAG_STATUS_OK)
            {
                Console.WriteLine($"ERROR: Unable to read the data! Got error code {rc}: {client.DecodeError(client.GetStatus(tag))}\n");
                return;
            }

            // print data
            for (int i = 0; i < tag.ElementCount; i++)
            {
                Console.WriteLine($"data[{i}]={client.GetFloat32Value(tag, (i * tag.ElementSize))}\n");
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

        //private void Label1_Click(object sender, EventArgs e)
        //{

        //}

        //private void Label2_Click(object sender, EventArgs e)
        //{

        //}

        //private void label3_Click(object sender, EventArgs e)
        //{

        //}

        //private void label5_Click(object sender, EventArgs e)
        //{

        //}

        //private void label2_Click_1(object sender, EventArgs e)
        //{

        //}

        //private void label6_Click(object sender, EventArgs e)
        //{

        //}

        //private void label5_Click_1(object sender, EventArgs e)
        //{

        //}

        //private void label7_Click(object sender, EventArgs e)
        //{

        //}

        //private void label3_Click_1(object sender, EventArgs e)
        //{

        //}

        //private void label8_Click(object sender, EventArgs e)
        //{

        //}

        //private void label4_Click(object sender, EventArgs e)
        //{

        //}

        //private void label9_Click(object sender, EventArgs e)
        //{

        //}

        //private void label1_Click_1(object sender, EventArgs e)
        //{

        //}

    }
}
