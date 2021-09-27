
namespace CityBus_CursVar12
{
    partial class StationInRouteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StationInRouteForm));
            System.Windows.Forms.Label routeIdLabel;
            System.Windows.Forms.Label stationIdLabel;
            System.Windows.Forms.Label routeIndexLabel;
            System.Windows.Forms.Label timeFromRouteStartLabel;
            this.cityBus_CursVar12DataSet = new CityBus_CursVar12.CityBus_CursVar12DataSet();
            this.stationInRouteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stationInRouteTableAdapter = new CityBus_CursVar12.CityBus_CursVar12DataSetTableAdapters.StationInRouteTableAdapter();
            this.tableAdapterManager = new CityBus_CursVar12.CityBus_CursVar12DataSetTableAdapters.TableAdapterManager();
            this.stationInRouteBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.stationInRouteBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.routeIndexTextBox = new System.Windows.Forms.TextBox();
            this.timeFromRouteStartMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.routeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.routeTableAdapter = new CityBus_CursVar12.CityBus_CursVar12DataSetTableAdapters.RouteTableAdapter();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.stationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stationTableAdapter = new CityBus_CursVar12.CityBus_CursVar12DataSetTableAdapters.StationTableAdapter();
            routeIdLabel = new System.Windows.Forms.Label();
            stationIdLabel = new System.Windows.Forms.Label();
            routeIndexLabel = new System.Windows.Forms.Label();
            timeFromRouteStartLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cityBus_CursVar12DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationInRouteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationInRouteBindingNavigator)).BeginInit();
            this.stationInRouteBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.routeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cityBus_CursVar12DataSet
            // 
            this.cityBus_CursVar12DataSet.DataSetName = "CityBus_CursVar12DataSet";
            this.cityBus_CursVar12DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stationInRouteBindingSource
            // 
            this.stationInRouteBindingSource.DataMember = "StationInRoute";
            this.stationInRouteBindingSource.DataSource = this.cityBus_CursVar12DataSet;
            // 
            // stationInRouteTableAdapter
            // 
            this.stationInRouteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BusInRouteTableAdapter = null;
            this.tableAdapterManager.BusTableAdapter = null;
            this.tableAdapterManager.CarManufacturerTableAdapter = null;
            this.tableAdapterManager.CarModelTableAdapter = null;
            this.tableAdapterManager.RouteTableAdapter = this.routeTableAdapter;
            this.tableAdapterManager.StationInRouteTableAdapter = this.stationInRouteTableAdapter;
            this.tableAdapterManager.StationTableAdapter = this.stationTableAdapter;
            this.tableAdapterManager.UpdateOrder = CityBus_CursVar12.CityBus_CursVar12DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = null;
            // 
            // stationInRouteBindingNavigator
            // 
            this.stationInRouteBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.stationInRouteBindingNavigator.BindingSource = this.stationInRouteBindingSource;
            this.stationInRouteBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.stationInRouteBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.stationInRouteBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.stationInRouteBindingNavigatorSaveItem});
            this.stationInRouteBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.stationInRouteBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.stationInRouteBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.stationInRouteBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.stationInRouteBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.stationInRouteBindingNavigator.Name = "stationInRouteBindingNavigator";
            this.stationInRouteBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.stationInRouteBindingNavigator.Size = new System.Drawing.Size(628, 25);
            this.stationInRouteBindingNavigator.TabIndex = 0;
            this.stationInRouteBindingNavigator.Text = "bindingNavigator1";
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
            // stationInRouteBindingNavigatorSaveItem
            // 
            this.stationInRouteBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stationInRouteBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("stationInRouteBindingNavigatorSaveItem.Image")));
            this.stationInRouteBindingNavigatorSaveItem.Name = "stationInRouteBindingNavigatorSaveItem";
            this.stationInRouteBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.stationInRouteBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.stationInRouteBindingNavigatorSaveItem.Click += new System.EventHandler(this.stationInRouteBindingNavigatorSaveItem_Click);
            // 
            // routeIdLabel
            // 
            routeIdLabel.AutoSize = true;
            routeIdLabel.Location = new System.Drawing.Point(142, 102);
            routeIdLabel.Name = "routeIdLabel";
            routeIdLabel.Size = new System.Drawing.Size(51, 13);
            routeIdLabel.TabIndex = 1;
            routeIdLabel.Text = "Route Id:";
            // 
            // stationIdLabel
            // 
            stationIdLabel.AutoSize = true;
            stationIdLabel.Location = new System.Drawing.Point(138, 144);
            stationIdLabel.Name = "stationIdLabel";
            stationIdLabel.Size = new System.Drawing.Size(55, 13);
            stationIdLabel.TabIndex = 3;
            stationIdLabel.Text = "Station Id:";
            // 
            // routeIndexLabel
            // 
            routeIndexLabel.AutoSize = true;
            routeIndexLabel.Location = new System.Drawing.Point(125, 193);
            routeIndexLabel.Name = "routeIndexLabel";
            routeIndexLabel.Size = new System.Drawing.Size(68, 13);
            routeIndexLabel.TabIndex = 5;
            routeIndexLabel.Text = "Route Index:";
            // 
            // routeIndexTextBox
            // 
            this.routeIndexTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stationInRouteBindingSource, "RouteIndex", true));
            this.routeIndexTextBox.Location = new System.Drawing.Point(199, 190);
            this.routeIndexTextBox.Name = "routeIndexTextBox";
            this.routeIndexTextBox.Size = new System.Drawing.Size(100, 20);
            this.routeIndexTextBox.TabIndex = 6;
            // 
            // timeFromRouteStartLabel
            // 
            timeFromRouteStartLabel.AutoSize = true;
            timeFromRouteStartLabel.Location = new System.Drawing.Point(77, 251);
            timeFromRouteStartLabel.Name = "timeFromRouteStartLabel";
            timeFromRouteStartLabel.Size = new System.Drawing.Size(116, 13);
            timeFromRouteStartLabel.TabIndex = 7;
            timeFromRouteStartLabel.Text = "Time From Route Start:";
            // 
            // timeFromRouteStartMaskedTextBox
            // 
            this.timeFromRouteStartMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stationInRouteBindingSource, "TimeFromRouteStart", true));
            this.timeFromRouteStartMaskedTextBox.Location = new System.Drawing.Point(199, 248);
            this.timeFromRouteStartMaskedTextBox.Mask = "00:00";
            this.timeFromRouteStartMaskedTextBox.Name = "timeFromRouteStartMaskedTextBox";
            this.timeFromRouteStartMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.timeFromRouteStartMaskedTextBox.TabIndex = 8;
            this.timeFromRouteStartMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.stationInRouteBindingSource, "RouteId", true));
            this.comboBox1.DataSource = this.routeBindingSource;
            this.comboBox1.DisplayMember = "Name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(199, 94);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(116, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.ValueMember = "Id";
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
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.stationInRouteBindingSource, "StationId", true));
            this.comboBox2.DataSource = this.stationBindingSource;
            this.comboBox2.DisplayMember = "Name";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(199, 141);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 10;
            this.comboBox2.ValueMember = "Id";
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
            // StationInRoute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 371);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(timeFromRouteStartLabel);
            this.Controls.Add(this.timeFromRouteStartMaskedTextBox);
            this.Controls.Add(routeIndexLabel);
            this.Controls.Add(this.routeIndexTextBox);
            this.Controls.Add(stationIdLabel);
            this.Controls.Add(routeIdLabel);
            this.Controls.Add(this.stationInRouteBindingNavigator);
            this.Name = "StationInRoute";
            this.Text = "StationInRoute";
            this.Load += new System.EventHandler(this.StationInRoute_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cityBus_CursVar12DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationInRouteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationInRouteBindingNavigator)).EndInit();
            this.stationInRouteBindingNavigator.ResumeLayout(false);
            this.stationInRouteBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.routeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CityBus_CursVar12DataSet cityBus_CursVar12DataSet;
        private System.Windows.Forms.BindingSource stationInRouteBindingSource;
        private CityBus_CursVar12DataSetTableAdapters.StationInRouteTableAdapter stationInRouteTableAdapter;
        private CityBus_CursVar12DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator stationInRouteBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton stationInRouteBindingNavigatorSaveItem;
        private CityBus_CursVar12DataSetTableAdapters.RouteTableAdapter routeTableAdapter;
        private System.Windows.Forms.TextBox routeIndexTextBox;
        private System.Windows.Forms.MaskedTextBox timeFromRouteStartMaskedTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource routeBindingSource;
        private CityBus_CursVar12DataSetTableAdapters.StationTableAdapter stationTableAdapter;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource stationBindingSource;
    }
}