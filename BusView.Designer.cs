
namespace CityBus_CursVar12
{
    partial class BusView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BusView));
            this.cityBus_CursVar12DataSet = new CityBus_CursVar12.CityBus_CursVar12DataSet();
            this.busViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.busViewTableAdapter = new CityBus_CursVar12.CityBus_CursVar12DataSetTableAdapters.BusViewTableAdapter();
            this.tableAdapterManager = new CityBus_CursVar12.CityBus_CursVar12DataSetTableAdapters.TableAdapterManager();
            this.busViewBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.busViewBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.busViewDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.cityBus_CursVar12DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.busViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.busViewBindingNavigator)).BeginInit();
            this.busViewBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.busViewDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cityBus_CursVar12DataSet
            // 
            this.cityBus_CursVar12DataSet.DataSetName = "CityBus_CursVar12DataSet";
            this.cityBus_CursVar12DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // busViewBindingSource
            // 
            this.busViewBindingSource.DataMember = "BusView";
            this.busViewBindingSource.DataSource = this.cityBus_CursVar12DataSet;
            // 
            // busViewTableAdapter
            // 
            this.busViewTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BusInRouteTableAdapter = null;
            this.tableAdapterManager.BusTableAdapter = null;
            this.tableAdapterManager.CarManufacturerTableAdapter = null;
            this.tableAdapterManager.CarModelTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.RouteTableAdapter = null;
            this.tableAdapterManager.StationInRouteTableAdapter = null;
            this.tableAdapterManager.StationTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CityBus_CursVar12.CityBus_CursVar12DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = null;
            // 
            // busViewBindingNavigator
            // 
            this.busViewBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.busViewBindingNavigator.BindingSource = this.busViewBindingSource;
            this.busViewBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.busViewBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.busViewBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.busViewBindingNavigatorSaveItem});
            this.busViewBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.busViewBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.busViewBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.busViewBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.busViewBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.busViewBindingNavigator.Name = "busViewBindingNavigator";
            this.busViewBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.busViewBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.busViewBindingNavigator.TabIndex = 0;
            this.busViewBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 15);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
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
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
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
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // busViewBindingNavigatorSaveItem
            // 
            this.busViewBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.busViewBindingNavigatorSaveItem.Enabled = false;
            this.busViewBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("busViewBindingNavigatorSaveItem.Image")));
            this.busViewBindingNavigatorSaveItem.Name = "busViewBindingNavigatorSaveItem";
            this.busViewBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 20);
            this.busViewBindingNavigatorSaveItem.Text = "Сохранить данные";
            // 
            // busViewDataGridView
            // 
            this.busViewDataGridView.AutoGenerateColumns = false;
            this.busViewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.busViewDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.busViewDataGridView.DataSource = this.busViewBindingSource;
            this.busViewDataGridView.Location = new System.Drawing.Point(56, 57);
            this.busViewDataGridView.Name = "busViewDataGridView";
            this.busViewDataGridView.Size = new System.Drawing.Size(573, 227);
            this.busViewDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Manufacturer";
            this.dataGridViewTextBoxColumn1.HeaderText = "Manufacturer";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Model";
            this.dataGridViewTextBoxColumn2.HeaderText = "Model";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Number";
            this.dataGridViewTextBoxColumn3.HeaderText = "Number";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // BusView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.busViewDataGridView);
            this.Controls.Add(this.busViewBindingNavigator);
            this.Name = "BusView";
            this.Text = "BusView";
            this.Load += new System.EventHandler(this.BusView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cityBus_CursVar12DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.busViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.busViewBindingNavigator)).EndInit();
            this.busViewBindingNavigator.ResumeLayout(false);
            this.busViewBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.busViewDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CityBus_CursVar12DataSet cityBus_CursVar12DataSet;
        private System.Windows.Forms.BindingSource busViewBindingSource;
        private CityBus_CursVar12DataSetTableAdapters.BusViewTableAdapter busViewTableAdapter;
        private CityBus_CursVar12DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator busViewBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton busViewBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView busViewDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}