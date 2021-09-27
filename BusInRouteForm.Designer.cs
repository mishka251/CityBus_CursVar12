
namespace CityBus_CursVar12
{
    partial class BusInRouteForm
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
            System.Windows.Forms.Label routeIdLabel;
            System.Windows.Forms.Label busIdLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BusInRouteForm));
            System.Windows.Forms.Label startTimeLabel;
            this.cityBus_CursVar12DataSet = new CityBus_CursVar12.CityBus_CursVar12DataSet();
            this.busInRouteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.busInRouteTableAdapter = new CityBus_CursVar12.CityBus_CursVar12DataSetTableAdapters.BusInRouteTableAdapter();
            this.tableAdapterManager = new CityBus_CursVar12.CityBus_CursVar12DataSetTableAdapters.TableAdapterManager();
            this.busTableAdapter = new CityBus_CursVar12.CityBus_CursVar12DataSetTableAdapters.BusTableAdapter();
            this.routeTableAdapter = new CityBus_CursVar12.CityBus_CursVar12DataSetTableAdapters.RouteTableAdapter();
            this.busInRouteBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.busInRouteBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.routeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.busBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.startTimeMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.busIdCB = new System.Windows.Forms.ComboBox();
            this.routeIdCB = new System.Windows.Forms.ComboBox();
            this.busBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.routeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            routeIdLabel = new System.Windows.Forms.Label();
            busIdLabel = new System.Windows.Forms.Label();
            startTimeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cityBus_CursVar12DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.busInRouteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.busInRouteBindingNavigator)).BeginInit();
            this.busInRouteBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.routeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.busBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.busBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.routeBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // routeIdLabel
            // 
            routeIdLabel.AutoSize = true;
            routeIdLabel.Location = new System.Drawing.Point(8, 117);
            routeIdLabel.Name = "routeIdLabel";
            routeIdLabel.Size = new System.Drawing.Size(51, 13);
            routeIdLabel.TabIndex = 1;
            routeIdLabel.Text = "Route Id:";
            // 
            // busIdLabel
            // 
            busIdLabel.AutoSize = true;
            busIdLabel.Location = new System.Drawing.Point(19, 41);
            busIdLabel.Name = "busIdLabel";
            busIdLabel.Size = new System.Drawing.Size(40, 13);
            busIdLabel.TabIndex = 3;
            busIdLabel.Text = "Bus Id:";
            // 
            // cityBus_CursVar12DataSet
            // 
            this.cityBus_CursVar12DataSet.DataSetName = "CityBus_CursVar12DataSet";
            this.cityBus_CursVar12DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // busInRouteBindingSource
            // 
            this.busInRouteBindingSource.DataMember = "BusInRoute";
            this.busInRouteBindingSource.DataSource = this.cityBus_CursVar12DataSet;
            // 
            // busInRouteTableAdapter
            // 
            this.busInRouteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BusInRouteTableAdapter = this.busInRouteTableAdapter;
            this.tableAdapterManager.BusTableAdapter = this.busTableAdapter;
            this.tableAdapterManager.CarManufacturerTableAdapter = null;
            this.tableAdapterManager.CarModelTableAdapter = null;
            this.tableAdapterManager.RouteTableAdapter = this.routeTableAdapter;
            this.tableAdapterManager.StationInRouteTableAdapter = null;
            this.tableAdapterManager.StationTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CityBus_CursVar12.CityBus_CursVar12DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = null;
            // 
            // busTableAdapter
            // 
            this.busTableAdapter.ClearBeforeFill = true;
            // 
            // routeTableAdapter
            // 
            this.routeTableAdapter.ClearBeforeFill = true;
            // 
            // busInRouteBindingNavigator
            // 
            this.busInRouteBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.busInRouteBindingNavigator.BindingSource = this.busInRouteBindingSource;
            this.busInRouteBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.busInRouteBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.busInRouteBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.busInRouteBindingNavigatorSaveItem});
            this.busInRouteBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.busInRouteBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.busInRouteBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.busInRouteBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.busInRouteBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.busInRouteBindingNavigator.Name = "busInRouteBindingNavigator";
            this.busInRouteBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.busInRouteBindingNavigator.Size = new System.Drawing.Size(328, 25);
            this.busInRouteBindingNavigator.TabIndex = 0;
            this.busInRouteBindingNavigator.Text = "bindingNavigator1";
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
            // busInRouteBindingNavigatorSaveItem
            // 
            this.busInRouteBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.busInRouteBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("busInRouteBindingNavigatorSaveItem.Image")));
            this.busInRouteBindingNavigatorSaveItem.Name = "busInRouteBindingNavigatorSaveItem";
            this.busInRouteBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.busInRouteBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.busInRouteBindingNavigatorSaveItem.Click += new System.EventHandler(this.busInRouteBindingNavigatorSaveItem_Click);
            // 
            // routeBindingSource
            // 
            this.routeBindingSource.DataMember = "Route";
            this.routeBindingSource.DataSource = this.cityBus_CursVar12DataSet;
            // 
            // busBindingSource
            // 
            this.busBindingSource.DataMember = "Bus";
            this.busBindingSource.DataSource = this.cityBus_CursVar12DataSet;
            // 
            // startTimeLabel
            // 
            startTimeLabel.AutoSize = true;
            startTimeLabel.Location = new System.Drawing.Point(22, 200);
            startTimeLabel.Name = "startTimeLabel";
            startTimeLabel.Size = new System.Drawing.Size(58, 13);
            startTimeLabel.TabIndex = 5;
            startTimeLabel.Text = "Start Time:";
            // 
            // startTimeMaskedTextBox
            // 
            this.startTimeMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.busInRouteBindingSource, "StartTime", true));
            this.startTimeMaskedTextBox.Location = new System.Drawing.Point(86, 197);
            this.startTimeMaskedTextBox.Mask = "00:00";
            this.startTimeMaskedTextBox.Name = "startTimeMaskedTextBox";
            this.startTimeMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.startTimeMaskedTextBox.TabIndex = 6;
            this.startTimeMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // busIdCB
            // 
            this.busIdCB.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.busInRouteBindingSource, "BusId", true));
            this.busIdCB.DataSource = this.busBindingSource1;
            this.busIdCB.DisplayMember = "Number";
            this.busIdCB.FormattingEnabled = true;
            this.busIdCB.Location = new System.Drawing.Point(86, 41);
            this.busIdCB.Name = "busIdCB";
            this.busIdCB.Size = new System.Drawing.Size(121, 21);
            this.busIdCB.TabIndex = 7;
            this.busIdCB.ValueMember = "Id";
            // 
            // routeIdCB
            // 
            this.routeIdCB.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.busInRouteBindingSource, "RouteId", true));
            this.routeIdCB.DataSource = this.routeBindingSource1;
            this.routeIdCB.DisplayMember = "Name";
            this.routeIdCB.FormattingEnabled = true;
            this.routeIdCB.Location = new System.Drawing.Point(86, 109);
            this.routeIdCB.Name = "routeIdCB";
            this.routeIdCB.Size = new System.Drawing.Size(121, 21);
            this.routeIdCB.TabIndex = 8;
            this.routeIdCB.ValueMember = "Id";
            // 
            // busBindingSource1
            // 
            this.busBindingSource1.DataMember = "Bus";
            this.busBindingSource1.DataSource = this.cityBus_CursVar12DataSet;
            // 
            // routeBindingSource1
            // 
            this.routeBindingSource1.DataMember = "Route";
            this.routeBindingSource1.DataSource = this.cityBus_CursVar12DataSet;
            // 
            // BusInRouteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 261);
            this.Controls.Add(this.routeIdCB);
            this.Controls.Add(this.busIdCB);
            this.Controls.Add(startTimeLabel);
            this.Controls.Add(this.startTimeMaskedTextBox);
            this.Controls.Add(busIdLabel);
            this.Controls.Add(routeIdLabel);
            this.Controls.Add(this.busInRouteBindingNavigator);
            this.Name = "BusInRouteForm";
            this.Text = "BusInRoute";
            this.Load += new System.EventHandler(this.BusInRoute_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cityBus_CursVar12DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.busInRouteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.busInRouteBindingNavigator)).EndInit();
            this.busInRouteBindingNavigator.ResumeLayout(false);
            this.busInRouteBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.routeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.busBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.busBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.routeBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CityBus_CursVar12DataSet cityBus_CursVar12DataSet;
        private System.Windows.Forms.BindingSource busInRouteBindingSource;
        private CityBus_CursVar12DataSetTableAdapters.BusInRouteTableAdapter busInRouteTableAdapter;
        private CityBus_CursVar12DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator busInRouteBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton busInRouteBindingNavigatorSaveItem;
        private CityBus_CursVar12DataSetTableAdapters.BusTableAdapter busTableAdapter;
        private System.Windows.Forms.BindingSource busBindingSource;
        private CityBus_CursVar12DataSetTableAdapters.RouteTableAdapter routeTableAdapter;
        private System.Windows.Forms.BindingSource routeBindingSource;
        private System.Windows.Forms.MaskedTextBox startTimeMaskedTextBox;
        private System.Windows.Forms.ComboBox busIdCB;
        private System.Windows.Forms.BindingSource busBindingSource1;
        private System.Windows.Forms.ComboBox routeIdCB;
        private System.Windows.Forms.BindingSource routeBindingSource1;
    }
}