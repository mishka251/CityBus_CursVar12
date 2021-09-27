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
    public partial class CarModelForm : Form
    {
        bool isAdmin;
        public CarModelForm(bool isAdmin = false)
        {
            this.isAdmin = isAdmin;
            InitializeComponent();
            if (!isAdmin)
            {
                this.nameTextBox.Enabled = false;
                this.manufacturerCB.Enabled = false;
                this.bindingNavigatorDeleteItem.Enabled = false;
                this.bindingNavigatorAddNewItem.Enabled = false;
                this.carModelBindingNavigatorSaveItem.Enabled = false;
            }
        }

        private void carModelBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.carModelBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.cityBus_CursVar12DataSet);
                MessageBox.Show("Сохранено");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка" + ex.Message);
            }


        }

        private void CarModelForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cityBus_CursVar12DataSet.CarManufacturer". При необходимости она может быть перемещена или удалена.
            this.carManufacturerTableAdapter.Fill(this.cityBus_CursVar12DataSet.CarManufacturer);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cityBus_CursVar12DataSet.Bus". При необходимости она может быть перемещена или удалена.
            this.busTableAdapter.Fill(this.cityBus_CursVar12DataSet.Bus);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cityBus_CursVar12DataSet.CarModel". При необходимости она может быть перемещена или удалена.
            this.carModelTableAdapter.Fill(this.cityBus_CursVar12DataSet.CarModel);

        }
    }
}
