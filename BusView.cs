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
    public partial class BusView : Form
    {
        public BusView()
        {
            InitializeComponent();
            this.busViewDataGridView.Enabled = false;
            this.busViewBindingNavigatorSaveItem.Enabled = false;
            this.bindingNavigatorAddNewItem.Enabled = false;
            this.bindingNavigatorDeleteItem.Enabled = false;
        }

        private void BusView_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: данная строка кода позволяет загрузить данные в таблицу "cityBus_CursVar12DataSet.BusView". При необходимости она может быть перемещена или удалена.
                this.busViewTableAdapter.Fill(this.cityBus_CursVar12DataSet.BusView);
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
