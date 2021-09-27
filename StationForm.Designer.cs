
namespace CityBus_CursVar12
{
    partial class StationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StationForm));
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label latitudeLabel;
            System.Windows.Forms.Label longitudeLabel;
            this.cityBus_CursVar12DataSet = new CityBus_CursVar12.CityBus_CursVar12DataSet();
            this.stationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stationTableAdapter = new CityBus_CursVar12.CityBus_CursVar12DataSetTableAdapters.StationTableAdapter();
            this.tableAdapterManager = new CityBus_CursVar12.CityBus_CursVar12DataSetTableAdapters.TableAdapterManager();
            this.stationBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.stationBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.latitudeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.longitudeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.stationInRouteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stationInRouteTableAdapter = new CityBus_CursVar12.CityBus_CursVar12DataSetTableAdapters.StationInRouteTableAdapter();
            this.stationInRouteDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            nameLabel = new System.Windows.Forms.Label();
            latitudeLabel = new System.Windows.Forms.Label();
            longitudeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cityBus_CursVar12DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationBindingNavigator)).BeginInit();
            this.stationBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.latitudeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.longitudeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationInRouteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationInRouteDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cityBus_CursVar12DataSet
            // 
            this.cityBus_CursVar12DataSet.DataSetName = "CityBus_CursVar12DataSet";
            this.cityBus_CursVar12DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stationBindingSource
            // 
            this.stationBindingSource.DataMember = "Station";
            this.stationBindingSource.DataSource = this.cityBus_CursVar12DataSet;
            // 
            // stationTableAdapter
            // 
            this.stationTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BusInRouteTableAdapter = null;
            this.tableAdapterManager.BusTableAdapter = null;
            this.tableAdapterManager.CarManufacturerTableAdapter = null;
            this.tableAdapterManager.CarModelTableAdapter = null;
            this.tableAdapterManager.RouteTableAdapter = null;
            this.tableAdapterManager.StationInRouteTableAdapter = this.stationInRouteTableAdapter;
            this.tableAdapterManager.StationTableAdapter = this.stationTableAdapter;
            this.tableAdapterManager.UpdateOrder = CityBus_CursVar12.CityBus_CursVar12DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = null;
            // 
            // stationBindingNavigator
            // 
            this.stationBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.stationBindingNavigator.BindingSource = this.stationBindingSource;
            this.stationBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.stationBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.stationBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.stationBindingNavigatorSaveItem});
            this.stationBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.stationBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.stationBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.stationBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.stationBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.stationBindingNavigator.Name = "stationBindingNavigator";
            this.stationBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.stationBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.stationBindingNavigator.TabIndex = 0;
            this.stationBindingNavigator.Text = "bindingNavigator1";
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
            // stationBindingNavigatorSaveItem
            // 
            this.stationBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stationBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("stationBindingNavigatorSaveItem.Image")));
            this.stationBindingNavigatorSaveItem.Name = "stationBindingNavigatorSaveItem";
            this.stationBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.stationBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.stationBindingNavigatorSaveItem.Click += new System.EventHandler(this.stationBindingNavigatorSaveItem_Click);
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(47, 68);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 1;
            nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stationBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(91, 65);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 2;
            // 
            // latitudeLabel
            // 
            latitudeLabel.AutoSize = true;
            latitudeLabel.Location = new System.Drawing.Point(246, 70);
            latitudeLabel.Name = "latitudeLabel";
            latitudeLabel.Size = new System.Drawing.Size(48, 13);
            latitudeLabel.TabIndex = 3;
            latitudeLabel.Text = "Latitude:";
            // 
            // latitudeNumericUpDown
            // 
            this.latitudeNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.stationBindingSource, "Latitude", true));
            this.latitudeNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            393216});
            this.latitudeNumericUpDown.Location = new System.Drawing.Point(315, 68);
            this.latitudeNumericUpDown.Name = "latitudeNumericUpDown";
            this.latitudeNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.latitudeNumericUpDown.TabIndex = 4;
            // 
            // longitudeLabel
            // 
            longitudeLabel.AutoSize = true;
            longitudeLabel.Location = new System.Drawing.Point(506, 68);
            longitudeLabel.Name = "longitudeLabel";
            longitudeLabel.Size = new System.Drawing.Size(57, 13);
            longitudeLabel.TabIndex = 5;
            longitudeLabel.Text = "Longitude:";
            // 
            // longitudeNumericUpDown
            // 
            this.longitudeNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.stationBindingSource, "Longitude", true));
            this.longitudeNumericUpDown.Location = new System.Drawing.Point(569, 68);
            this.longitudeNumericUpDown.Name = "longitudeNumericUpDown";
            this.longitudeNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.longitudeNumericUpDown.TabIndex = 6;
            // 
            // stationInRouteBindingSource
            // 
            this.stationInRouteBindingSource.DataMember = "FK_StationInRoute_Station";
            this.stationInRouteBindingSource.DataSource = this.stationBindingSource;
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
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.stationInRouteDataGridView.DataSource = this.stationInRouteBindingSource;
            this.stationInRouteDataGridView.Location = new System.Drawing.Point(103, 132);
            this.stationInRouteDataGridView.Name = "stationInRouteDataGridView";
            this.stationInRouteDataGridView.Size = new System.Drawing.Size(550, 220);
            this.stationInRouteDataGridView.TabIndex = 7;
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "RouteId";
            this.dataGridViewTextBoxColumn2.HeaderText = "RouteId";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "StationId";
            this.dataGridViewTextBoxColumn3.HeaderText = "StationId";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "RouteIndex";
            this.dataGridViewTextBoxColumn4.HeaderText = "RouteIndex";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TimeFromRouteStart";
            this.dataGridViewTextBoxColumn5.HeaderText = "TimeFromRouteStart";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // StationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 455);
            this.Controls.Add(this.stationInRouteDataGridView);
            this.Controls.Add(longitudeLabel);
            this.Controls.Add(this.longitudeNumericUpDown);
            this.Controls.Add(latitudeLabel);
            this.Controls.Add(this.latitudeNumericUpDown);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.stationBindingNavigator);
            this.Name = "StationForm";
            this.Text = "StationForm";
            this.Load += new System.EventHandler(this.StationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cityBus_CursVar12DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationBindingNavigator)).EndInit();
            this.stationBindingNavigator.ResumeLayout(false);
            this.stationBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.latitudeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.longitudeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationInRouteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationInRouteDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CityBus_CursVar12DataSet cityBus_CursVar12DataSet;
        private System.Windows.Forms.BindingSource stationBindingSource;
        private CityBus_CursVar12DataSetTableAdapters.StationTableAdapter stationTableAdapter;
        private CityBus_CursVar12DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator stationBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton stationBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox nameTextBox;
        private CityBus_CursVar12DataSetTableAdapters.StationInRouteTableAdapter stationInRouteTableAdapter;
        private System.Windows.Forms.NumericUpDown latitudeNumericUpDown;
        private System.Windows.Forms.NumericUpDown longitudeNumericUpDown;
        private System.Windows.Forms.BindingSource stationInRouteBindingSource;
        private System.Windows.Forms.DataGridView stationInRouteDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}