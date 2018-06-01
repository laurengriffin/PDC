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
        
        private BindingSource bindingSourceGrid = new BindingSource();
        private SqlDataAdapter gridAdapter = new SqlDataAdapter();
        DataTable gridTable = new DataTable();

        public Form2()
        {
            InitializeComponent();          
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            using (SqlConnection sqlc = new SqlConnection(SQLCommunication.cs))
            {
                //string tName = SQLCommunication.tableName;
                MessageBox.Show($"Table name is {SQLCommunication.tableName}");
                gridAdapter.SelectCommand = new SqlCommand($"SELECT * FROM {SQLCommunication.tableName}", sqlc);
                gridAdapter.Fill(gridTable);
                bindingSourceGrid.DataSource = gridTable;
                dataGridView1.DataSource = bindingSourceGrid.DataSource;

                // resize the DataGridView to fit content
                dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {       
            try
            {
                using (SqlConnection sqlc = new SqlConnection(SQLCommunication.cs))
                {
                    sqlc.Open();
                    // create the update command
                    SqlCommand updateCommand = new SqlCommand($"UPDATE {SQLCommunication.tableName} SET inventory=@Inventory where ingrCode=@IngrCode", sqlc);
                    updateCommand.Parameters.AddWithValue("@Inventory", 3);
                    updateCommand.Parameters.AddWithValue("@IngrCode", "RIC 30");
                    int rowsAffected = updateCommand.ExecuteNonQuery();
                    if (rowsAffected == 1)
                    {
                        MessageBox.Show("Information Updated", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    sqlc.Close();
                    //gridAdapter.UpdateCommand = updateCommand;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tableNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
