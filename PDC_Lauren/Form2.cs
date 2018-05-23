using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDC_Lauren
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void ingredientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ingredientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.steve_test_WestonDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'steve_test_WestonDataSet.Ingredient' table. You can move, or remove it, as needed.
            this.ingredientTableAdapter.Fill(this.steve_test_WestonDataSet.Ingredient);

        }

        private void ingredientDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
