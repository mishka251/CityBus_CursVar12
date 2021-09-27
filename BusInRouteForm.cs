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
    public partial class BusInRouteForm : Form
    {
        bool isAdmin;
        public BusInRouteForm(bool isAdmin = false)
        {
            this.isAdmin = isAdmin;
            InitializeComponent();
            if (!isAdmin)
            {
                this.busIdCB.Enabled = false;
                this.routeIdCB.Enabled = false;
                this.startTimeMaskedTextBox.Enabled = false;
                this.bindingNavigatorAddNewItem.Enabled = false;
                this.bindingNavigatorDeleteItem.Enabled = false;
            }
        }

        private void busInRouteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.busInRouteBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.cityBus_CursVar12DataSet);
                MessageBox.Show("Сохранено");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }


        }

        private void BusInRoute_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cityBus_CursVar12DataSet.Route". При необходимости она может быть перемещена или удалена.
            this.routeTableAdapter.Fill(this.cityBus_CursVar12DataSet.Route);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cityBus_CursVar12DataSet.Bus". При необходимости она может быть перемещена или удалена.
            this.busTableAdapter.Fill(this.cityBus_CursVar12DataSet.Bus);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cityBus_CursVar12DataSet.BusInRoute". При необходимости она может быть перемещена или удалена.
            this.busInRouteTableAdapter.Fill(this.cityBus_CursVar12DataSet.BusInRoute);

        }
    }
}
