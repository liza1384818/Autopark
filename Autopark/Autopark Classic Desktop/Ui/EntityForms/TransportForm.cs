using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoparkClassicDesktop.Ui.EntityForms.Ui.EntityFormsutoparkClassicDesktop.Ui.EntityForms
{
    public partial class TransportForm : Form
    {
        public TransportForm()
        {
            InitializeComponent();
        }

        private void транспортные_средстваBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.транспортные_средстваBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.autoparkDataSet);

        }

        private void TransportForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autoparkDataSet.Транспортные_средства". При необходимости она может быть перемещена или удалена.
            this.транспортные_средстваTableAdapter.Fill(this.autoparkDataSet.Транспортные_средства);

        }
    }
}
