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
    public partial class MenuForm : Form
    {

        bool isAdmin;

        public MenuForm(bool isAdmin = false)
        {
            this.isAdmin = isAdmin;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BusForm bf = new BusForm(this.isAdmin);
            bf.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BusInRouteForm brf = new BusInRouteForm(this.isAdmin);
            brf.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CarManufacturerForm cmf = new CarManufacturerForm(this.isAdmin);
            cmf.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CarModelForm cmf = new CarModelForm(this.isAdmin);
            cmf.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RouteForm rf = new RouteForm(this.isAdmin);
            rf.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            StationForm sf = new StationForm(this.isAdmin);
            sf.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            StationInRouteForm srf = new StationInRouteForm(this.isAdmin);
            srf.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            BusView bv = new BusView();
            bv.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            RouteStationsView rsv = new RouteStationsView();
            rsv.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            RouteBuses rb = new RouteBuses();
            rb.Show();
        }
    }
}
