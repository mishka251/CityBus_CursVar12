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
    public partial class RouteForm : Form
    {
        bool isAdmin;
        public RouteForm(bool isAdmin = false)
        {
            this.isAdmin = isAdmin;
            InitializeComponent();
            if (!isAdmin)
            {
                this.nameTextBox.Enabled = false;
                this.literalTextBox.Enabled = false;
                this.numberTextBox.Enabled = false;
                this.bindingNavigatorDeleteItem.Enabled = false;
                this.bindingNavigatorAddNewItem.Enabled = false;
                this.routeBindingNavigatorSaveItem.Enabled = false;
            }
        }

        private void routeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
            this.Validate();
            this.routeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cityBus_CursVar12DataSet);
                MessageBox.Show("Сохранено");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка" + ex.Message);
            }
        }

        private void RouteForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cityBus_CursVar12DataSet.StationInRoute". При необходимости она может быть перемещена или удалена.
            this.stationInRouteTableAdapter.Fill(this.cityBus_CursVar12DataSet.StationInRoute);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cityBus_CursVar12DataSet.BusInRoute". При необходимости она может быть перемещена или удалена.
            this.busInRouteTableAdapter.Fill(this.cityBus_CursVar12DataSet.BusInRoute);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cityBus_CursVar12DataSet.Route". При необходимости она может быть перемещена или удалена.
            this.routeTableAdapter.Fill(this.cityBus_CursVar12DataSet.Route);

        }
    }
}
