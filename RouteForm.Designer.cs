
namespace CityBus_CursVar12
{
    partial class RouteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RouteForm));
            System.Windows.Forms.Label numberLabel;
            System.Windows.Forms.Label literalLabel;
            System.Windows.Forms.Label nameLabel;
            this.cityBus_CursVar12DataSet = new CityBus_CursVar12.CityBus_CursVar12DataSet();
            this.routeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.routeTableAdapter = new CityBus_CursVar12.CityBus_CursVar12DataSetTableAdapters.RouteTableAdapter();
            this.tableAdapterManager = new CityBus_CursVar12.CityBus_CursVar12DataSetTableAdapters.TableAdapterManager();
            this.routeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.routeBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.literalTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.busInRouteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.busInRouteTableAdapter = new CityBus_CursVar12.CityBus_CursVar12DataSetTableAdapters.BusInRouteTableAdapter();
            this.busInRouteDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stationInRouteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stationInRouteTableAdapter = new CityBus_CursVar12.CityBus_CursVar12DataSetTableAdapters.StationInRouteTableAdapter();
            this.stationInRouteDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            numberLabel = new System.Windows.Forms.Label();
            literalLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cityBus_CursVar12DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.routeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.routeBindingNavigator)).BeginInit();
            this.routeBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.busInRouteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.busInRouteDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationInRouteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationInRouteDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cityBus_CursVar12DataSet
            // 
            this.cityBus_CursVar12DataSet.DataSetName = "CityBus_CursVar12DataSet";
            this.cityBus_CursVar12DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // routeBindingSource
            // 
            this.routeBindingSource.DataMember = "Route";
            this.routeBindingSource.DataSource = this.cityBus_CursVar12DataSet;
            // 
            // routeTableAdapter
            // 
            this.routeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BusInRouteTableAdapter = this.busInRouteTableAdapter;
            this.tableAdapterManager.BusTableAdapter = null;
            this.tableAdapterManager.CarManufacturerTableAdapter = null;
            this.tableAdapterManager.CarModelTableAdapter = null;
            this.tableAdapterManager.RouteTableAdapter = this.routeTableAdapter;
            this.tableAdapterManager.StationInRouteTableAdapter = this.stationInRouteTableAdapter;
            this.tableAdapterManager.StationTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CityBus_CursVar12.CityBus_CursVar12DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = null;
            // 
            // routeBindingNavigator
            // 
            this.routeBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.routeBindingNavigator.BindingSource = this.routeBindingSource;
            this.routeBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.routeBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.routeBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.routeBindingNavigatorSaveItem});
            this.routeBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.routeBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.routeBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.routeBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.routeBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.routeBindingNavigator.Name = "routeBindingNavigator";
            this.routeBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.routeBindingNavigator.Size = new System.Drawing.Size(843, 25);
            this.routeBindingNavigator.TabIndex = 0;
            this.routeBindingNavigator.Text = "bindingNavigator1";
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
            // routeBindingNavigatorSaveItem
            // 
            this.routeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.routeBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("routeBindingNavigatorSaveItem.Image")));
            this.routeBindingNavigatorSaveItem.Name = "routeBindingNavigatorSaveItem";
            this.routeBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.routeBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.routeBindingNavigatorSaveItem.Click += new System.EventHandler(this.routeBindingNavigatorSaveItem_Click);
            // 
            // numberLabel
            // 
            numberLabel.AutoSize = true;
            numberLabel.Location = new System.Drawing.Point(86, 62);
            numberLabel.Name = "numberLabel";
            numberLabel.Size = new System.Drawing.Size(47, 13);
            numberLabel.TabIndex = 1;
            numberLabel.Text = "Number:";
            // 
            // numberTextBox
            // 
            this.numberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.routeBindingSource, "Number", true));
            this.numberTextBox.Location = new System.Drawing.Point(139, 59);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(100, 20);
            this.numberTextBox.TabIndex = 2;
            // 
            // literalLabel
            // 
            literalLabel.AutoSize = true;
            literalLabel.Location = new System.Drawing.Point(263, 65);
            literalLabel.Name = "literalLabel";
            literalLabel.Size = new System.Drawing.Size(38, 13);
            literalLabel.TabIndex = 3;
            literalLabel.Text = "Literal:";
            // 
            // literalTextBox
            // 
            this.literalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.routeBindingSource, "Literal", true));
            this.literalTextBox.Location = new System.Drawing.Point(307, 62);
            this.literalTextBox.Name = "literalTextBox";
            this.literalTextBox.Size = new System.Drawing.Size(100, 20);
            this.literalTextBox.TabIndex = 4;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(469, 65);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 5;
            nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.routeBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(524, 62);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 6;
            // 
            // busInRouteBindingSource
            // 
            this.busInRouteBindingSource.DataMember = "FK_BusInRoute_Route";
            this.busInRouteBindingSource.DataSource = this.routeBindingSource;
            // 
            // busInRouteTableAdapter
            // 
            this.busInRouteTableAdapter.ClearBeforeFill = true;
            // 
            // busInRouteDataGridView
            // 
            this.busInRouteDataGridView.AutoGenerateColumns = false;
            this.busInRouteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.busInRouteDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.busInRouteDataGridView.DataSource = this.busInRouteBindingSource;
            this.busInRouteDataGridView.Location = new System.Drawing.Point(34, 128);
            this.busInRouteDataGridView.Name = "busInRouteDataGridView";
            this.busInRouteDataGridView.Size = new System.Drawing.Size(314, 244);
            this.busInRouteDataGridView.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "BusId";
            this.dataGridViewTextBoxColumn2.HeaderText = "BusId";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "RouteId";
            this.dataGridViewTextBoxColumn3.HeaderText = "RouteId";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "StartTime";
            this.dataGridViewTextBoxColumn4.HeaderText = "StartTime";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // stationInRouteBindingSource
            // 
            this.stationInRouteBindingSource.DataMember = "FK_StationInRoute_Route";
            this.stationInRouteBindingSource.DataSource = this.routeBindingSource;
            // 
            // stationInRouteTableAdapter
            // 
            this.stationInRouteTableAdapter.ClearBeforeFill = true;
            // 
            // stationInRouteDataGridView
            // 
            this.stationInRouteDataGridView.AutoGenerateColumns = false;
            this.stationInRouteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stationInRouteDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.stationInRouteDataGridView.DataSource = this.stationInRouteBindingSource;
            this.stationInRouteDataGridView.Location = new System.Drawing.Point(459, 116);
            this.stationInRouteDataGridView.Name = "stationInRouteDataGridView";
            this.stationInRouteDataGridView.Size = new System.Drawing.Size(329, 244);
            this.stationInRouteDataGridView.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn5.HeaderText = "Id";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "RouteId";
            this.dataGridViewTextBoxColumn6.HeaderText = "RouteId";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "StationId";
            this.dataGridViewTextBoxColumn7.HeaderText = "StationId";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "RouteIndex";
            this.dataGridViewTextBoxColumn8.HeaderText = "RouteIndex";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "TimeFromRouteStart";
            this.dataGridViewTextBoxColumn9.HeaderText = "TimeFromRouteStart";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // RouteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 486);
            this.Controls.Add(this.stationInRouteDataGridView);
            this.Controls.Add(this.busInRouteDataGridView);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(literalLabel);
            this.Controls.Add(this.literalTextBox);
            this.Controls.Add(numberLabel);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(this.routeBindingNavigator);
            this.Name = "RouteForm";
            this.Text = "RouteForm";
            this.Load += new System.EventHandler(this.RouteForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cityBus_CursVar12DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.routeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.routeBindingNavigator)).EndInit();
            this.routeBindingNavigator.ResumeLayout(false);
            this.routeBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.busInRouteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.busInRouteDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationInRouteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationInRouteDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CityBus_CursVar12DataSet cityBus_CursVar12DataSet;
        private System.Windows.Forms.BindingSource routeBindingSource;
        private CityBus_CursVar12DataSetTableAdapters.RouteTableAdapter routeTableAdapter;
        private CityBus_CursVar12DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator routeBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton routeBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox numberTextBox;
        private CityBus_CursVar12DataSetTableAdapters.BusInRouteTableAdapter busInRouteTableAdapter;
        private System.Windows.Forms.TextBox literalTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.BindingSource busInRouteBindingSource;
        private CityBus_CursVar12DataSetTableAdapters.StationInRouteTableAdapter stationInRouteTableAdapter;
        private System.Windows.Forms.DataGridView busInRouteDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.BindingSource stationInRouteBindingSource;
        private System.Windows.Forms.DataGridView stationInRouteDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    }
}