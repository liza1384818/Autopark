using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoparkClassicDesktop.Ui.EntityForms.Ui.EntityFormsutoparkClassicDesktop.Ui.Dialogs
{
    public partial class AddDriverDialog : Form
    {
        public AddDriverDialog()
        {
            InitializeComponent();
        }

        private void OnClickAddDriverButton(object sender, EventArgs e)
        {
            this.Validate();
            this.картотека_водителейBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.autoparkDataSet);

            this.DialogResult = DialogResult.OK;
        }

        private void AddDriverDialog_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autoparkDataSet.Картотека_водителей". При необходимости она может быть перемещена или удалена.
            this.картотека_водителейTableAdapter.Fill(this.autoparkDataSet.Картотека_водителей);

            /*
             *  Открыв эту форму, сразу переходим в режим
             *  добавления новой записи у BindingSource.
             */
            this.картотека_водителейBindingSource.AddNew();
        }
    }
}
