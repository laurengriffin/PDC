namespace PDC_Lauren
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.steve_test_WestonDataSet = new PDC_Lauren.Steve_test_WestonDataSet();
            this.ingredientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ingredientTableAdapter = new PDC_Lauren.Steve_test_WestonDataSetTableAdapters.IngredientTableAdapter();
            this.tableAdapterManager = new PDC_Lauren.Steve_test_WestonDataSetTableAdapters.TableAdapterManager();
            this.ingredientBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.ingredientBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.ingredientDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.steve_test_WestonDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientBindingNavigator)).BeginInit();
            this.ingredientBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // steve_test_WestonDataSet
            // 
            this.steve_test_WestonDataSet.DataSetName = "Steve_test_WestonDataSet";
            this.steve_test_WestonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ingredientBindingSource
            // 
            this.ingredientBindingSource.DataMember = "Ingredient";
            this.ingredientBindingSource.DataSource = this.steve_test_WestonDataSet;
            // 
            // ingredientTableAdapter
            // 
            this.ingredientTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.Active_Formula_DetailTableAdapter = null;
            this.tableAdapterManager.Active_Formula_HeaderTableAdapter = null;
            this.tableAdapterManager.AlarmsTableAdapter = null;
            this.tableAdapterManager.Audit_DetailTableAdapter = null;
            this.tableAdapterManager.Audit_ModuleTableAdapter = null;
            this.tableAdapterManager.Audit_OperationTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Batch_DetailTableAdapter = null;
            this.tableAdapterManager.Batch_HeaderTableAdapter = null;
            this.tableAdapterManager.Batch_ParameterTableAdapter = null;
            this.tableAdapterManager.Batch_To_DividerTableAdapter = null;
            this.tableAdapterManager.Comm_DDETableAdapter = null;
            this.tableAdapterManager.DataModule_InfoTableAdapter = null;
            this.tableAdapterManager.DestinationTableAdapter = null;
            this.tableAdapterManager.Dough_RequestTableAdapter = null;
            this.tableAdapterManager.Formula_Detail_EditTableAdapter = null;
            this.tableAdapterManager.Formula_Detail_TempTableAdapter = null;
            this.tableAdapterManager.Formula_DetailTableAdapter = null;
            this.tableAdapterManager.Formula_HeaderTableAdapter = null;
            this.tableAdapterManager.Formula_ParameterTableAdapter = null;
            this.tableAdapterManager.Formula_StatusTableAdapter = null;
            this.tableAdapterManager.GroupSecurityTableAdapter = null;
            this.tableAdapterManager.IngredientTableAdapter = this.ingredientTableAdapter;
            this.tableAdapterManager.IngrStatusTableAdapter = null;
            this.tableAdapterManager.IngrTypeTableAdapter = null;
            this.tableAdapterManager.Inventory_TransactionTableAdapter = null;
            this.tableAdapterManager.Inventory_TransTypeTableAdapter = null;
            this.tableAdapterManager.LanguageTableAdapter = null;
            this.tableAdapterManager.Location_LotNbr_QueueTableAdapter = null;
            this.tableAdapterManager.LocationTableAdapter = null;
            this.tableAdapterManager.LotNbr_MasterTableAdapter = null;
            this.tableAdapterManager.MultiFactorTableAdapter = null;
            this.tableAdapterManager.OffProd_DetailTableAdapter = null;
            this.tableAdapterManager.OffProd_HeaderTableAdapter = null;
            this.tableAdapterManager.OnProd_Reset_EventsTableAdapter = null;
            this.tableAdapterManager.OnProdTableAdapter = null;
            this.tableAdapterManager.ParameterTableAdapter = null;
            this.tableAdapterManager.PLC_Form_LocationTableAdapter = null;
            this.tableAdapterManager.PrintWeight_Ticket_DetailTableAdapter = null;
            this.tableAdapterManager.PrintWeight_Ticket_HeaderTableAdapter = null;
            this.tableAdapterManager.PrintWeight_Ticket_IngrTableAdapter = null;
            this.tableAdapterManager.Process_WinTableAdapter = null;
            this.tableAdapterManager.ProductTypeTableAdapter = null;
            this.tableAdapterManager.RoutingTableAdapter = null;
            this.tableAdapterManager.ScalesTableAdapter = null;
            this.tableAdapterManager.Scaling_ParameterTableAdapter = null;
            this.tableAdapterManager.SecurityAreaTableAdapter = null;
            this.tableAdapterManager.SecurityDisplayOrderTableAdapter = null;
            this.tableAdapterManager.SupplierTableAdapter = null;
            this.tableAdapterManager.System_SettingsTableAdapter = null;
            this.tableAdapterManager.UnitTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PDC_Lauren.Steve_test_WestonDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Usage_Detail_LotNbrTableAdapter = null;
            this.tableAdapterManager.Usage_DetailTableAdapter = null;
            this.tableAdapterManager.UserGroupTableAdapter = null;
            this.tableAdapterManager.UserProfileTableAdapter = null;
            // 
            // ingredientBindingNavigator
            // 
            this.ingredientBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.ingredientBindingNavigator.BindingSource = this.ingredientBindingSource;
            this.ingredientBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.ingredientBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.ingredientBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.ingredientBindingNavigatorSaveItem});
            this.ingredientBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.ingredientBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.ingredientBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.ingredientBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.ingredientBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.ingredientBindingNavigator.Name = "ingredientBindingNavigator";
            this.ingredientBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.ingredientBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.ingredientBindingNavigator.TabIndex = 0;
            this.ingredientBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // ingredientBindingNavigatorSaveItem
            // 
            this.ingredientBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ingredientBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("ingredientBindingNavigatorSaveItem.Image")));
            this.ingredientBindingNavigatorSaveItem.Name = "ingredientBindingNavigatorSaveItem";
            this.ingredientBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.ingredientBindingNavigatorSaveItem.Text = "Save Data";
            this.ingredientBindingNavigatorSaveItem.Click += new System.EventHandler(this.ingredientBindingNavigatorSaveItem_Click);
            // 
            // ingredientDataGridView
            // 
            this.ingredientDataGridView.AutoGenerateColumns = false;
            this.ingredientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ingredientDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.ingredientDataGridView.DataSource = this.ingredientBindingSource;
            this.ingredientDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ingredientDataGridView.Location = new System.Drawing.Point(0, 25);
            this.ingredientDataGridView.Name = "ingredientDataGridView";
            this.ingredientDataGridView.Size = new System.Drawing.Size(800, 529);
            this.ingredientDataGridView.TabIndex = 1;
            this.ingredientDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ingredientDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IngrCode";
            this.dataGridViewTextBoxColumn1.HeaderText = "IngrCode";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IngrName";
            this.dataGridViewTextBoxColumn2.HeaderText = "IngrName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TypeCode";
            this.dataGridViewTextBoxColumn3.HeaderText = "TypeCode";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "UnitCode";
            this.dataGridViewTextBoxColumn4.HeaderText = "UnitCode";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Absorption";
            this.dataGridViewTextBoxColumn5.HeaderText = "Absorption";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Substitue_IngrCode";
            this.dataGridViewTextBoxColumn6.HeaderText = "Substitue_IngrCode";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "MinScaleWeight";
            this.dataGridViewTextBoxColumn7.HeaderText = "MinScaleWeight";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "UserComment";
            this.dataGridViewTextBoxColumn8.HeaderText = "UserComment";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "RcInfo";
            this.dataGridViewTextBoxColumn9.HeaderText = "RcInfo";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Inventory";
            this.dataGridViewTextBoxColumn10.HeaderText = "Inventory";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "RcInfo2";
            this.dataGridViewTextBoxColumn11.HeaderText = "RcInfo2";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Adjust_Range";
            this.dataGridViewTextBoxColumn12.HeaderText = "Adjust_Range";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 554);
            this.Controls.Add(this.ingredientDataGridView);
            this.Controls.Add(this.ingredientBindingNavigator);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.steve_test_WestonDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientBindingNavigator)).EndInit();
            this.ingredientBindingNavigator.ResumeLayout(false);
            this.ingredientBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Steve_test_WestonDataSet steve_test_WestonDataSet;
        private System.Windows.Forms.BindingSource ingredientBindingSource;
        private Steve_test_WestonDataSetTableAdapters.IngredientTableAdapter ingredientTableAdapter;
        private Steve_test_WestonDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator ingredientBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton ingredientBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView ingredientDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
    }
}