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
    public partial class StationInRouteForm : Form
    {
        bool isAdmin;
        public StationInRouteForm(bool isAdmin = false)
        {
            this.isAdmin = isAdmin;
            InitializeComponent();
            if (!isAdmin)
            {
                this.routeIndexTextBox.Enabled = false;
                this.comboBox1.Enabled = false;
                this.comboBox2.Enabled = false;
                this.timeFromRouteStartMaskedTextBox.Enabled = false;
                this.bindingNavigatorDeleteItem.Enabled = false;
                this.bindingNavigatorAddNewItem.Enabled = false;
                this.stationInRouteBindingNavigatorSaveItem.Enabled = false;
            }
        }

        private void stationInRouteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.stationInRouteBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.cityBus_CursVar12DataSet);
                MessageBox.Show("Сохранено");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка" + ex.Message);
            }
        }

        private void StationInRoute_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cityBus_CursVar12DataSet.Station". При необходимости она может быть перемещена или удалена.
            this.stationTableAdapter.Fill(this.cityBus_CursVar12DataSet.Station);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cityBus_CursVar12DataSet.Route". При необходимости она может быть перемещена или удалена.
            this.routeTableAdapter.Fill(this.cityBus_CursVar12DataSet.Route);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cityBus_CursVar12DataSet.StationInRoute". При необходимости она может быть перемещена или удалена.
            this.stationInRouteTableAdapter.Fill(this.cityBus_CursVar12DataSet.StationInRoute);

        }
    }
}
