using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PDC_Lauren
{
    public partial class Form2 : Form
    {
        private BindingSource bindingSourceList = new BindingSource();
        private BindingSource bindingSourceGrid = new BindingSource();
        private SqlDataAdapter dataAdapter1 = new SqlDataAdapter();
        private SqlDataAdapter dataAdapter2 = new SqlDataAdapter();

        public Form2()
        {
            InitializeComponent();          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // bind the DataGridView to the BindingSource
            // and load data from database
            tableNameComboBox.DataSource = bindingSourceList;
            dataGridView1.DataSource = bindingSourceGrid;
            GetData();
        }

        private void tableNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tableNameComboBox.Text != "System.Data.DataRowView")
            {
                using (SqlConnection sqlc = new SqlConnection(SQLCommunication.cs))
                {
                    DataTable gridTable = new DataTable();
                    dataAdapter2.SelectCommand = new SqlCommand($"SELECT * FROM {tableNameComboBox.Text}", sqlc);
                    dataAdapter2.Fill(gridTable);
                    bindingSourceGrid.DataSource = gridTable;
                    dataGridView1.DataSource = bindingSourceGrid.DataSource;

                    // resize the DataGridView to fit content
                    dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                }
            }
        }

        private void GetData()
        {
            using (SqlConnection sqlc = new SqlConnection(SQLCommunication.cs))
            {
                try
                {
                    sqlc.Open();

                    DataTable tablesTable = new DataTable();
                    dataAdapter1.SelectCommand = new SqlCommand("SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES", sqlc);
                    dataAdapter1.Fill(tablesTable);
                    bindingSourceList.DataSource = tablesTable;
                    tableNameComboBox.DataSource = bindingSourceList.DataSource;
                    tableNameComboBox.DisplayMember = "TABLE_NAME";
                    tableNameComboBox.ValueMember = "TABLE_NAME";

                }
                catch (SqlException sqlexception)
                {
                    MessageBox.Show("Error: " + sqlexception);
                }
            }
        }
    }
}
