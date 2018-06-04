using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
                    // open sql connection
                    sqlc.Open();

                    SqlCommand objCmd = new SqlCommand();

                    // find primary keys
                    string keyQuery = "SELECT c.Name AS 'Column_Name' " +
                                        "FROM sys.indexes i " +
                                        "INNER JOIN sys.index_columns ic ON i.object_id = ic.object_id AND i.index_id = ic.index_id " +
                                        "INNER JOIN sys.columns c ON ic.object_id = c.object_id AND ic.column_id = c.column_id " +
                                        "INNER JOIN sys.objects o ON i.object_id = o.object_id " +
                                        "WHERE i.is_primary_key = 1 " +
                                        $"AND o.name = '{SQLCommunication.tableName}'";
                    objCmd.CommandText = keyQuery;
                    objCmd.CommandType = CommandType.Text;
                    objCmd.Connection = sqlc;

                    SqlDataReader reader = objCmd.ExecuteReader();

                    // create string of keys
                    int numKeys = 0;
                    String keyString = "";
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine($"{reader.GetString(0)}");
                            keyString += reader.GetString(0) + ";";
                            numKeys++;
                        }
                    }
                    // string of keys
                    string[] keys = Regex.Split(keyString, ";");
                    for (int i = 0; i < keys.Length-1; i++)
                    {
                        Console.WriteLine($"keys[{i}]: {keys[i]}");
                    }

                    // initialize query string and sqlcommand object
                    string strQuery = string.Empty;

                    // get the modified rows by filtering on their rowstate
                    DataTable dtChanges = gridTable.GetChanges(DataRowState.Modified);
                    if (dtChanges != null)
                    {
                        // for the update query to update the rows
                        for (int i = 0; i < dtChanges.Rows.Count; i++)
                        {
                            strQuery = $"UPDATE {SQLCommunication.tableName} SET ";

                            // loop through the columns
                            Console.WriteLine($"number of colums: {dtChanges.Columns.Count}");
                            for (int j = 0; j < dtChanges.Columns.Count; j++)
                            {

                                int index = Array.IndexOf(keys, $"{dtChanges.Columns[j]}");
                                Console.WriteLine($"index of {dtChanges.Columns[j]}: {index}");
                                if (index < 0)
                                {
                                    if (j != dtChanges.Columns.Count - 1)
                                    {
                                        strQuery += $"{dtChanges.Columns[j]} = '" + dtChanges.Rows[i][$"{dtChanges.Columns[j]}"].ToString() + "',";
                                    }
                                    else
                                    {
                                        strQuery += $"{dtChanges.Columns[j]} = '" + dtChanges.Rows[i][$"{dtChanges.Columns[j]}"].ToString() + "' ";
                                    }
                                }
                            }
                            strQuery += $"WHERE ";
                            for (int k = 0; k < keys.Length-1; k++)
                            {
                                strQuery += $"{gridTable.Columns[keys[k]]} = '" + gridTable.Rows[i][$"{gridTable.Columns[keys[k]]}"].ToString() + "'";
                                if (k != keys.Length-2)
                                {
                                    strQuery += " AND ";
                                }
                            }
                            //strQuery += $"WHERE {gridTable.Columns[0]} = '" + gridTable.Rows[i][$"{gridTable.Columns[0]}"].ToString() + "'";
                        }

                        reader.Close();

                        Console.WriteLine($"Query String:\n{strQuery}");
                        objCmd.CommandText = strQuery;
                        objCmd.ExecuteNonQuery();
                        MessageBox.Show("Information Updated", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    sqlc.Close();
                    dtChanges = null;
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
