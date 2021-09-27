using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CityBus_CursVar12
{
    public partial class StationForm : Form
    {
        bool isAdmin;
        public StationForm(bool isAdmin = false)
        {
            this.isAdmin = isAdmin;
            InitializeComponent();
            if (!isAdmin)
            {
                this.nameTextBox.Enabled = false;
                this.latitudeNumericUpDown.Enabled = false;
                this.longitudeNumericUpDown.Enabled = false;
                this.bindingNavigatorDeleteItem.Enabled = false;
                this.bindingNavigatorAddNewItem.Enabled = false;
                this.stationBindingNavigatorSaveItem.Enabled = false;
            }
        }

        private void stationBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.stationBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.cityBus_CursVar12DataSet);
                MessageBox.Show("Сохранено");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка" + ex.Message);
            }

        }

        private void StationForm_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: данная строка кода позволяет загрузить данные в таблицу "cityBus_CursVar12DataSet.StationInRoute". При необходимости она может быть перемещена или удалена.
                this.stationInRouteTableAdapter.Fill(this.cityBus_CursVar12DataSet.StationInRoute);
                // TODO: данная строка кода позволяет загрузить данные в таблицу "cityBus_CursVar12DataSet.Station". При необходимости она может быть перемещена или удалена.
                this.stationTableAdapter.Fill(this.cityBus_CursVar12DataSet.Station);
            }
            catch (ConstraintException)
            {
                DataRow[] rowErrors = this.cityBus_CursVar12DataSet.Bus.GetErrors();

                System.Diagnostics.Debug.WriteLine("YourDataTable Errors:"
                    + rowErrors.Length);

                for (int i = 0; i < rowErrors.Length; i++)
                {
                    System.Diagnostics.Debug.WriteLine(rowErrors[i].RowError);

                    foreach (DataColumn col in rowErrors[i].GetColumnsInError())
                    {
                        MessageBox.Show(col.ColumnName
                            + ":" + rowErrors[i].GetColumnError(col));
                    }
                }
            }

        }
    }
}
