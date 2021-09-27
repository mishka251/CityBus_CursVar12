
namespace CityBus_CursVar12
{
    partial class CarModelForm
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label manufacturerIdLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarModelForm));
            this.cityBus_CursVar12DataSet = new CityBus_CursVar12.CityBus_CursVar12DataSet();
            this.carModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carModelTableAdapter = new CityBus_CursVar12.CityBus_CursVar12DataSetTableAdapters.CarModelTableAdapter();
            this.tableAdapterManager = new CityBus_CursVar12.CityBus_CursVar12DataSetTableAdapters.TableAdapterManager();
            this.busTableAdapter = new CityBus_CursVar12.CityBus_CursVar12DataSetTableAdapters.BusTableAdapter();
            this.carManufacturerTableAdapter = new CityBus_CursVar12.CityBus_CursVar12DataSetTableAdapters.CarManufacturerTableAdapter();
            this.carModelBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.carModelBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.busBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.busDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturerCB = new System.Windows.Forms.ComboBox();
            this.carManufacturerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            nameLabel = new System.Windows.Forms.Label();
            manufacturerIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cityBus_CursVar12DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carModelBindingNavigator)).BeginInit();
            this.carModelBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.busBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.busDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carManufacturerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(32, 66);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 1;
            nameLabel.Text = "Name:";
            // 
            // manufacturerIdLabel
            // 
            manufacturerIdLabel.AutoSize = true;
            manufacturerIdLabel.Location = new System.Drawing.Point(23, 115);
            manufacturerIdLabel.Name = "manufacturerIdLabel";
            manufacturerIdLabel.Size = new System.Drawing.Size(85, 13);
            manufacturerIdLabel.TabIndex = 3;
            manufacturerIdLabel.Text = "Manufacturer Id:";
            // 
            // cityBus_CursVar12DataSet
            // 
            this.cityBus_CursVar12DataSet.DataSetName = "CityBus_CursVar12DataSet";
            this.cityBus_CursVar12DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carModelBindingSource
            // 
            this.carModelBindingSource.DataMember = "CarModel";
            this.carModelBindingSource.DataSource = this.cityBus_CursVar12DataSet;
            // 
            // carModelTableAdapter
            // 
            this.carModelTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BusInRouteTableAdapter = null;
            this.tableAdapterManager.BusTableAdapter = this.busTableAdapter;
            this.tableAdapterManager.CarManufacturerTableAdapter = this.carManufacturerTableAdapter;
            this.tableAdapterManager.CarModelTableAdapter = this.carModelTableAdapter;
            this.tableAdapterManager.RouteTableAdapter = null;
            this.tableAdapterManager.StationInRouteTableAdapter = null;
            this.tableAdapterManager.StationTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CityBus_CursVar12.CityBus_CursVar12DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = null;
            // 
            // busTableAdapter
            // 
            this.busTableAdapter.ClearBeforeFill = true;
            // 
            // carManufacturerTableAdapter
            // 
            this.carManufacturerTableAdapter.ClearBeforeFill = true;
            // 
            // carModelBindingNavigator
            // 
            this.carModelBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.carModelBindingNavigator.BindingSource = this.carModelBindingSource;
            this.carModelBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.carModelBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.carModelBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.carModelBindingNavigatorSaveItem});
            this.carModelBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.carModelBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.carModelBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.carModelBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.carModelBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.carModelBindingNavigator.Name = "carModelBindingNavigator";
            this.carModelBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.carModelBindingNavigator.Size = new System.Drawing.Size(599, 25);
            this.carModelBindingNavigator.TabIndex = 0;
            this.carModelBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // carModelBindingNavigatorSaveItem
            // 
            this.carModelBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.carModelBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("carModelBindingNavigatorSaveItem.Image")));
            this.carModelBindingNavigatorSaveItem.Name = "carModelBindingNavigatorSaveItem";
            this.carModelBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.carModelBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.carModelBindingNavigatorSaveItem.Click += new System.EventHandler(this.carModelBindingNavigatorSaveItem_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carModelBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(76, 63);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 2;
            // 
            // busBindingSource
            // 
            this.busBindingSource.DataMember = "FK_Bus_CarModel";
            this.busBindingSource.DataSource = this.carModelBindingSource;
            // 
            // busDataGridView
            // 
            this.busDataGridView.AutoGenerateColumns = false;
            this.busDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.busDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.busDataGridView.DataSource = this.busBindingSource;
            this.busDataGridView.Enabled = false;
            this.busDataGridView.Location = new System.Drawing.Point(54, 161);
            this.busDataGridView.Name = "busDataGridView";
            this.busDataGridView.Size = new System.Drawing.Size(424, 178);
            this.busDataGridView.TabIndex = 5;
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Number";
            this.dataGridViewTextBoxColumn2.HeaderText = "Number";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ModelId";
            this.dataGridViewTextBoxColumn3.HeaderText = "ModelId";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // manufacturerCB
            // 
            this.manufacturerCB.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.carModelBindingSource, "ManufacturerId", true));
            this.manufacturerCB.DataSource = this.carManufacturerBindingSource;
            this.manufacturerCB.DisplayMember = "Name";
            this.manufacturerCB.FormattingEnabled = true;
            this.manufacturerCB.Location = new System.Drawing.Point(133, 115);
            this.manufacturerCB.Name = "manufacturerCB";
            this.manufacturerCB.Size = new System.Drawing.Size(131, 21);
            this.manufacturerCB.TabIndex = 6;
            this.manufacturerCB.ValueMember = "Id";
            // 
            // carManufacturerBindingSource
            // 
            this.carManufacturerBindingSource.DataMember = "CarManufacturer";
            this.carManufacturerBindingSource.DataSource = this.cityBus_CursVar12DataSet;
            // 
            // CarModelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 376);
            this.Controls.Add(this.manufacturerCB);
            this.Controls.Add(this.busDataGridView);
            this.Controls.Add(manufacturerIdLabel);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.carModelBindingNavigator);
            this.Name = "CarModelForm";
            this.Text = "CarModelForm";
            this.Load += new System.EventHandler(this.CarModelForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cityBus_CursVar12DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carModelBindingNavigator)).EndInit();
            this.carModelBindingNavigator.ResumeLayout(false);
            this.carModelBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.busBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.busDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carManufacturerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CityBus_CursVar12DataSet cityBus_CursVar12DataSet;
        private System.Windows.Forms.BindingSource carModelBindingSource;
        private CityBus_CursVar12DataSetTableAdapters.CarModelTableAdapter carModelTableAdapter;
        private CityBus_CursVar12DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator carModelBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton carModelBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox nameTextBox;
        private CityBus_CursVar12DataSetTableAdapters.BusTableAdapter busTableAdapter;
        private System.Windows.Forms.BindingSource busBindingSource;
        private CityBus_CursVar12DataSetTableAdapters.CarManufacturerTableAdapter carManufacturerTableAdapter;
        private System.Windows.Forms.DataGridView busDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.ComboBox manufacturerCB;
        private System.Windows.Forms.BindingSource carManufacturerBindingSource;
    }
}