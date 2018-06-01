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
                    //SqlCommand updateCommand = new SqlCommand($"UPDATE {SQLCommunication.tableName} SET inventory=@Inventory where ingrCode=@IngrCode", sqlc);
                    //updateCommand.Parameters.AddWithValue("@Inventory", 3);
                    //updateCommand.Parameters.AddWithValue("@IngrCode", "RIC 30");
                    //int rowsAffected = updateCommand.ExecuteNonQuery();
                    //if (rowsAffected == 1)
                    //{
                    //    MessageBox.Show("Information Updated", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //}


                    string strQuery = string.Empty;
                    //DataTable dtUpdated = (DataTable)dataGridView1.DataSource;
                    SqlCommand objCmd = new SqlCommand();

                    // get the modified rows by filtering on their rowstate
                    DataTable dtChanges = gridTable.GetChanges(DataRowState.Modified);
                    if (dtChanges != null)
                    {
                        // for the update query to update the rows
                        objCmd.Connection = sqlc;
                        for (int i = 0; i < dtChanges.Rows.Count; i++)
                        {
                            strQuery = $"UPDATE {SQLCommunication.tableName} SET ";

                            // loop through the columns
                            Console.WriteLine($"number of colums: {dtChanges.Columns.Count}");
                            for (int j = 0; j < dtChanges.Columns.Count; j++)
                            {
                                if (j != dtChanges.Columns.Count - 1)
                                {
                                    strQuery += $"{dtChanges.Columns[j]} = '" + dtChanges.Rows[i][$"{dtChanges.Columns[j]}"].ToString() + "',";
                                }
                                else
                                {
                                    strQuery += $"{dtChanges.Columns[j]} = '" + dtChanges.Rows[i][$"{dtChanges.Columns[j]}"].ToString() + "' "; 
                                }
                                //Console.WriteLine($"col[{j}]: {dtChanges.Columns[j]}");
                            }
                            //strQuery += $"WHERE {gridTable.Columns[0]} = '" + gridTable.Columns[0].ToString() + "'";
                            strQuery += $"WHERE {gridTable.Columns[0]} = '" + gridTable.Rows[i][$"{gridTable.Columns[0]}"].ToString() + "'";
                        }

                        // find the key
                        //Console.WriteLine($"number of keys: {}");
                        //for (int i = 0; i < gridTable.PrimaryKey.length; i++)
                        //{
                            //Console.WriteLine($"The Key: {gridTable.PrimaryKey[i]}");
                        //}
                        Console.WriteLine($"Query String:\n{strQuery}");
                        objCmd.CommandText = strQuery;
                        objCmd.ExecuteNonQuery();
                        MessageBox.Show("Information Updated", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    sqlc.Close();
                    dtChanges = null;
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
