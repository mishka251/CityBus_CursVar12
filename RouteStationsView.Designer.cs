
namespace CityBus_CursVar12
{
    partial class RouteStationsView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RouteStationsView));
            this.cityBus_CursVar12DataSet = new CityBus_CursVar12.CityBus_CursVar12DataSet();
            this.routeStationsViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.routeStationsViewTableAdapter = new CityBus_CursVar12.CityBus_CursVar12DataSetTableAdapters.RouteStationsViewTableAdapter();
            this.tableAdapterManager = new CityBus_CursVar12.CityBus_CursVar12DataSetTableAdapters.TableAdapterManager();
            this.routeStationsViewBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.routeStationsViewBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.routeStationsViewDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.cityBus_CursVar12DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.routeStationsViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.routeStationsViewBindingNavigator)).BeginInit();
            this.routeStationsViewBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.routeStationsViewDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cityBus_CursVar12DataSet
            // 
            this.cityBus_CursVar12DataSet.DataSetName = "CityBus_CursVar12DataSet";
            this.cityBus_CursVar12DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // routeStationsViewBindingSource
            // 
            this.routeStationsViewBindingSource.DataMember = "RouteStationsView";
            this.routeStationsViewBindingSource.DataSource = this.cityBus_CursVar12DataSet;
            // 
            // routeStationsViewTableAdapter
            // 
            this.routeStationsViewTableAdapter.ClearBeforeFill = true;
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
            // routeStationsViewBindingNavigator
            // 
            this.routeStationsViewBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.routeStationsViewBindingNavigator.BindingSource = this.routeStationsViewBindingSource;
            this.routeStationsViewBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.routeStationsViewBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.routeStationsViewBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.routeStationsViewBindingNavigatorSaveItem});
            this.routeStationsViewBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.routeStationsViewBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.routeStationsViewBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.routeStationsViewBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.routeStationsViewBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.routeStationsViewBindingNavigator.Name = "routeStationsViewBindingNavigator";
            this.routeStationsViewBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.routeStationsViewBindingNavigator.Size = new System.Drawing.Size(807, 25);
            this.routeStationsViewBindingNavigator.TabIndex = 0;
            this.routeStationsViewBindingNavigator.Text = "bindingNavigator1";
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
            // routeStationsViewBindingNavigatorSaveItem
            // 
            this.routeStationsViewBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.routeStationsViewBindingNavigatorSaveItem.Enabled = false;
            this.routeStationsViewBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("routeStationsViewBindingNavigatorSaveItem.Image")));
            this.routeStationsViewBindingNavigatorSaveItem.Name = "routeStationsViewBindingNavigatorSaveItem";
            this.routeStationsViewBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 20);
            this.routeStationsViewBindingNavigatorSaveItem.Text = "Сохранить данные";
            // 
            // routeStationsViewDataGridView
            // 
            this.routeStationsViewDataGridView.AutoGenerateColumns = false;
            this.routeStationsViewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.routeStationsViewDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.routeStationsViewDataGridView.DataSource = this.routeStationsViewBindingSource;
            this.routeStationsViewDataGridView.Location = new System.Drawing.Point(54, 66);
            this.routeStationsViewDataGridView.Name = "routeStationsViewDataGridView";
            this.routeStationsViewDataGridView.Size = new System.Drawing.Size(576, 265);
            this.routeStationsViewDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Expr1";
            this.dataGridViewTextBoxColumn2.HeaderText = "Expr1";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TimeFromRouteStart";
            this.dataGridViewTextBoxColumn3.HeaderText = "TimeFromRouteStart";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // RouteStationsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 450);
            this.Controls.Add(this.routeStationsViewDataGridView);
            this.Controls.Add(this.routeStationsViewBindingNavigator);
            this.Name = "RouteStationsView";
            this.Text = "RouteStationsView";
            this.Load += new System.EventHandler(this.RouteStationsView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cityBus_CursVar12DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.routeStationsViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.routeStationsViewBindingNavigator)).EndInit();
            this.routeStationsViewBindingNavigator.ResumeLayout(false);
            this.routeStationsViewBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.routeStationsViewDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CityBus_CursVar12DataSet cityBus_CursVar12DataSet;
        private System.Windows.Forms.BindingSource routeStationsViewBindingSource;
        private CityBus_CursVar12DataSetTableAdapters.RouteStationsViewTableAdapter routeStationsViewTableAdapter;
        private CityBus_CursVar12DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator routeStationsViewBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton routeStationsViewBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView routeStationsViewDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}