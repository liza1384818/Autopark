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
    public partial class DriversForm : Form
    {
        public DriversForm()
        {
            InitializeComponent();
        }

        private void картотека_водителейBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.картотека_водителейBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.autoparkDataSet);

        }

        private void DriversForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autoparkDataSet.Маршруты". При необходимости она может быть перемещена или удалена.
            this.маршрутыTableAdapter.Fill(this.autoparkDataSet.Маршруты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autoparkDataSet.Путевые_листы". При необходимости она может быть перемещена или удалена.
            this.путевые_листыTableAdapter.Fill(this.autoparkDataSet.Путевые_листы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autoparkDataSet.Право_управления". При необходимости она может быть перемещена или удалена.
            this.право_управленияTableAdapter.Fill(this.autoparkDataSet.Право_управления);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autoparkDataSet.Картотека_водителей". При необходимости она может быть перемещена или удалена.
            this.картотека_водителейTableAdapter.Fill(this.autoparkDataSet.Картотека_водителей);

        }

        private void filterTextBox_TextChanged(object sender, EventArgs e)
        {
            this.картотека_водителейBindingSource.Filter = $@"Фамилия LIKE '{this.filterTextBox.Text}%'";
        }
    }
}
