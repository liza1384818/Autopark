using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoparkClassicDesktop.Ui.EntityForms
{
    public partial class RouteForm : Form
    {
        public RouteForm()
        {
            InitializeComponent();
        }

        private void RouteForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "учет_ГСМDataSet.Путевые_листы". При необходимости она может быть перемещена или удалена.
            this.путевые_листыTableAdapter.Fill(this.учет_ГСМDataSet.Путевые_листы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "учет_ГСМDataSet.Маршруты". При необходимости она может быть перемещена или удалена.
            this.маршрутыTableAdapter.Fill(this.учет_ГСМDataSet.Маршруты);

        }

        private void маршрутыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.маршрутыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.учет_ГСМDataSet);

        }
    }
}
