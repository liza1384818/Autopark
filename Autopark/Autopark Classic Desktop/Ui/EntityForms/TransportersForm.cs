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
    public partial class TransportersForm : Form
    {
        public TransportersForm()
        {
            InitializeComponent();
        }

        private void поставщикиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.поставщикиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.autoparkDataSet);

        }

        private void TransportersForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autoparkDataSet.Приход_ГСМ". При необходимости она может быть перемещена или удалена.
            this.приход_ГСМTableAdapter.Fill(this.autoparkDataSet.Приход_ГСМ);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autoparkDataSet.Заявки". При необходимости она может быть перемещена или удалена.
            this.заявкиTableAdapter.Fill(this.autoparkDataSet.Заявки);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autoparkDataSet.Поставщики". При необходимости она может быть перемещена или удалена.
            this.поставщикиTableAdapter.Fill(this.autoparkDataSet.Поставщики);

        }
    }
}
