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
    public partial class RouteBuses : Form
    {
        public RouteBuses()
        {
            InitializeComponent();
            this.getRouteBusesDataGridView.Enabled = false;
            this.getRouteBusesBindingNavigatorSaveItem.Enabled = false;
            this.bindingNavigatorDeleteItem.Enabled = false;
            this.bindingNavigatorAddNewItem.Enabled = false;
        }

        private void selectRouteBuses()
        {
            if (this.routeCB.SelectedValue == null)
            {
                return;
            }

            try
            {
                int selectedRouteId = (int)this.routeCB.SelectedValue;
                this.getRouteBusesTableAdapter.Fill(this.cityBus_CursVar12DataSet.GetRouteBuses, selectedRouteId);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void RouteBuses_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cityBus_CursVar12DataSet.Route". При необходимости она может быть перемещена или удалена.
            this.routeTableAdapter.Fill(this.cityBus_CursVar12DataSet.Route);
            this.selectRouteBuses();
        }

        private void routeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.selectRouteBuses();
        }
    }
}
