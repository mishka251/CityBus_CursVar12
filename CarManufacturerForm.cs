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
    public partial class CarManufacturerForm : Form
    {
        bool isAdmin;
        public CarManufacturerForm(bool isAdmin = false)
        {
            this.isAdmin = isAdmin;
            InitializeComponent();
            if (!isAdmin)
            {
                this.nameTextBox.Enabled = false;
                this.bindingNavigatorDeleteItem.Enabled = false;
                this.bindingNavigatorAddNewItem.Enabled = false;
                this.carManufacturerBindingNavigatorSaveItem.Enabled = false;
            }
        }

        private void carManufacturerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.carManufacturerBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.cityBus_CursVar12DataSet);
                MessageBox.Show("Сохранено");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка" + ex.Message);
            }


        }

        private void CarManufacturerForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cityBus_CursVar12DataSet.CarModel". При необходимости она может быть перемещена или удалена.
            this.carModelTableAdapter.Fill(this.cityBus_CursVar12DataSet.CarModel);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cityBus_CursVar12DataSet.CarManufacturer". При необходимости она может быть перемещена или удалена.
            this.carManufacturerTableAdapter.Fill(this.cityBus_CursVar12DataSet.CarManufacturer);

        }
    }
}
