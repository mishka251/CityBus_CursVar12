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
    public partial class BusForm : Form
    {
        bool isAdmin;
        public BusForm(bool isAdmin = false)
        {
            this.isAdmin = isAdmin;
            InitializeComponent();
            if (!isAdmin)
            {
                this.modelIdComboBox.Enabled = false;
                this.numberMaskedTextBox.Enabled = false;
                this.busBindingNavigatorSaveItem.Enabled = false;
                this.bindingNavigatorAddNewItem.Enabled = false;
                this.bindingNavigatorDeleteItem.Enabled = false;
            }
        }

        private void busBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.busBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.cityBus_CursVar12DataSet);
                MessageBox.Show("Сохранено");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }

        }

        private void Bus_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cityBus_CursVar12DataSet.CarModel". При необходимости она может быть перемещена или удалена.
            this.carModelTableAdapter.Fill(this.cityBus_CursVar12DataSet.CarModel);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cityBus_CursVar12DataSet.Bus". При необходимости она может быть перемещена или удалена.
            try
            {
                this.busTableAdapter.Fill(this.cityBus_CursVar12DataSet.Bus);
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
