namespace AutoparkClassicDesktop.Ui.EntityForms.Ui.EntityFormsutoparkClassicDesktop.Ui.Dialogs
{
    partial class AddDriverDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label фамилияLabel;
            System.Windows.Forms.Label имяLabel;
            System.Windows.Forms.Label отчествоLabel;
            System.Windows.Forms.Label дата_рожденияLabel;
            System.Windows.Forms.Label номер_телефонаLabel;
            System.Windows.Forms.Label дата_получения_правLabel;
            this.фамилияTextBox = new System.Windows.Forms.TextBox();
            this.имяTextBox = new System.Windows.Forms.TextBox();
            this.отчествоTextBox = new System.Windows.Forms.TextBox();
            this.дата_рожденияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.номер_телефонаTextBox = new System.Windows.Forms.TextBox();
            this.дата_получения_правDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.addButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.картотека_водителейBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autoparkDataSet = new AutoparkClassicDesktop.Ui.EntityForms.Ui.EntityFormsutoparkClassicDesktop.Data.AutoparkDataSet();
            this.картотека_водителейTableAdapter = new AutoparkClassicDesktop.Ui.EntityForms.Ui.EntityFormsutoparkClassicDesktop.Data.AutoparkDataSetTableAdapters.Картотека_водителейTableAdapter();
            this.tableAdapterManager = new AutoparkClassicDesktop.Ui.EntityForms.Ui.EntityFormsutoparkClassicDesktop.Data.AutoparkDataSetTableAdapters.TableAdapterManager();
            фамилияLabel = new System.Windows.Forms.Label();
            имяLabel = new System.Windows.Forms.Label();
            отчествоLabel = new System.Windows.Forms.Label();
            дата_рожденияLabel = new System.Windows.Forms.Label();
            номер_телефонаLabel = new System.Windows.Forms.Label();
            дата_получения_правLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.картотека_водителейBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoparkDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // фамилияLabel
            // 
            фамилияLabel.AutoSize = true;
            фамилияLabel.Location = new System.Drawing.Point(13, 15);
            фамилияLabel.Name = "фамилияLabel";
            фамилияLabel.Size = new System.Drawing.Size(59, 13);
            фамилияLabel.TabIndex = 3;
            фамилияLabel.Text = "Фамилия:";
            // 
            // имяLabel
            // 
            имяLabel.AutoSize = true;
            имяLabel.Location = new System.Drawing.Point(13, 41);
            имяLabel.Name = "имяLabel";
            имяLabel.Size = new System.Drawing.Size(32, 13);
            имяLabel.TabIndex = 5;
            имяLabel.Text = "Имя:";
            // 
            // отчествоLabel
            // 
            отчествоLabel.AutoSize = true;
            отчествоLabel.Location = new System.Drawing.Point(13, 67);
            отчествоLabel.Name = "отчествоLabel";
            отчествоLabel.Size = new System.Drawing.Size(57, 13);
            отчествоLabel.TabIndex = 7;
            отчествоLabel.Text = "Отчество:";
            // 
            // дата_рожденияLabel
            // 
            дата_рожденияLabel.AutoSize = true;
            дата_рожденияLabel.Location = new System.Drawing.Point(13, 94);
            дата_рожденияLabel.Name = "дата_рожденияLabel";
            дата_рожденияLabel.Size = new System.Drawing.Size(89, 13);
            дата_рожденияLabel.TabIndex = 9;
            дата_рожденияLabel.Text = "Дата рождения:";
            // 
            // номер_телефонаLabel
            // 
            номер_телефонаLabel.AutoSize = true;
            номер_телефонаLabel.Location = new System.Drawing.Point(13, 119);
            номер_телефонаLabel.Name = "номер_телефонаLabel";
            номер_телефонаLabel.Size = new System.Drawing.Size(96, 13);
            номер_телефонаLabel.TabIndex = 11;
            номер_телефонаLabel.Text = "Номер телефона:";
            // 
            // дата_получения_правLabel
            // 
            дата_получения_правLabel.AutoSize = true;
            дата_получения_правLabel.Location = new System.Drawing.Point(13, 146);
            дата_получения_правLabel.Name = "дата_получения_правLabel";
            дата_получения_правLabel.Size = new System.Drawing.Size(118, 13);
            дата_получения_правLabel.TabIndex = 13;
            дата_получения_правLabel.Text = "Дата получения прав:";
            // 
            // фамилияTextBox
            // 
            this.фамилияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.картотека_водителейBindingSource, "Фамилия", true));
            this.фамилияTextBox.Location = new System.Drawing.Point(137, 12);
            this.фамилияTextBox.Name = "фамилияTextBox";
            this.фамилияTextBox.Size = new System.Drawing.Size(139, 20);
            this.фамилияTextBox.TabIndex = 4;
            // 
            // имяTextBox
            // 
            this.имяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.картотека_водителейBindingSource, "Имя", true));
            this.имяTextBox.Location = new System.Drawing.Point(137, 38);
            this.имяTextBox.Name = "имяTextBox";
            this.имяTextBox.Size = new System.Drawing.Size(139, 20);
            this.имяTextBox.TabIndex = 6;
            // 
            // отчествоTextBox
            // 
            this.отчествоTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.картотека_водителейBindingSource, "Отчество", true));
            this.отчествоTextBox.Location = new System.Drawing.Point(137, 64);
            this.отчествоTextBox.Name = "отчествоTextBox";
            this.отчествоTextBox.Size = new System.Drawing.Size(139, 20);
            this.отчествоTextBox.TabIndex = 8;
            // 
            // дата_рожденияDateTimePicker
            // 
            this.дата_рожденияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.картотека_водителейBindingSource, "Дата рождения", true));
            this.дата_рожденияDateTimePicker.Location = new System.Drawing.Point(137, 90);
            this.дата_рожденияDateTimePicker.Name = "дата_рожденияDateTimePicker";
            this.дата_рожденияDateTimePicker.Size = new System.Drawing.Size(139, 20);
            this.дата_рожденияDateTimePicker.TabIndex = 10;
            // 
            // номер_телефонаTextBox
            // 
            this.номер_телефонаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.картотека_водителейBindingSource, "Номер телефона", true));
            this.номер_телефонаTextBox.Location = new System.Drawing.Point(137, 116);
            this.номер_телефонаTextBox.Name = "номер_телефонаTextBox";
            this.номер_телефонаTextBox.Size = new System.Drawing.Size(139, 20);
            this.номер_телефонаTextBox.TabIndex = 12;
            // 
            // дата_получения_правDateTimePicker
            // 
            this.дата_получения_правDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.картотека_водителейBindingSource, "Дата получения прав", true));
            this.дата_получения_правDateTimePicker.Location = new System.Drawing.Point(137, 142);
            this.дата_получения_правDateTimePicker.Name = "дата_получения_правDateTimePicker";
            this.дата_получения_правDateTimePicker.Size = new System.Drawing.Size(139, 20);
            this.дата_получения_правDateTimePicker.TabIndex = 14;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(16, 168);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(172, 23);
            this.addButton.TabIndex = 15;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.OnClickAddDriverButton);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(194, 168);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(82, 23);
            this.cancelButton.TabIndex = 16;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // картотека_водителейBindingSource
            // 
            this.картотека_водителейBindingSource.DataMember = "Картотека водителей";
            this.картотека_водителейBindingSource.DataSource = this.autoparkDataSet;
            // 
            // autoparkDataSet
            // 
            this.autoparkDataSet.DataSetName = "AutoparkDataSet";
            this.autoparkDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // картотека_водителейTableAdapter
            // 
            this.картотека_водителейTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = AutoparkClassicDesktop.Ui.EntityForms.Ui.EntityFormsutoparkClassicDesktop.Data.AutoparkDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ГСМTableAdapter = null;
            this.tableAdapterManager.Заправка_техникиTableAdapter = null;
            this.tableAdapterManager.ЗаявкиTableAdapter = null;
            this.tableAdapterManager.Картотека_водителейTableAdapter = this.картотека_водителейTableAdapter;
            this.tableAdapterManager.МаршрутыTableAdapter = null;
            this.tableAdapterManager.ПоставщикиTableAdapter = null;
            this.tableAdapterManager.Приход_ГСМTableAdapter = null;
            this.tableAdapterManager.Путевые_листыTableAdapter = null;
            this.tableAdapterManager.Транспортные_средстваTableAdapter = null;
            // 
            // AddDriverDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 198);
            this.ControlBox = false;
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(фамилияLabel);
            this.Controls.Add(this.фамилияTextBox);
            this.Controls.Add(имяLabel);
            this.Controls.Add(this.имяTextBox);
            this.Controls.Add(отчествоLabel);
            this.Controls.Add(this.отчествоTextBox);
            this.Controls.Add(дата_рожденияLabel);
            this.Controls.Add(this.дата_рожденияDateTimePicker);
            this.Controls.Add(номер_телефонаLabel);
            this.Controls.Add(this.номер_телефонаTextBox);
            this.Controls.Add(дата_получения_правLabel);
            this.Controls.Add(this.дата_получения_правDateTimePicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddDriverDialog";
            this.ShowIcon = false;
            this.Text = "Добавление водителя";
            this.Load += new System.EventHandler(this.AddDriverDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.картотека_водителейBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoparkDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Data.AutoparkDataSet autoparkDataSet;
        private System.Windows.Forms.BindingSource картотека_водителейBindingSource;
        private Data.AutoparkDataSetTableAdapters.Картотека_водителейTableAdapter картотека_водителейTableAdapter;
        private Data.AutoparkDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox фамилияTextBox;
        private System.Windows.Forms.TextBox имяTextBox;
        private System.Windows.Forms.TextBox отчествоTextBox;
        private System.Windows.Forms.DateTimePicker дата_рожденияDateTimePicker;
        private System.Windows.Forms.TextBox номер_телефонаTextBox;
        private System.Windows.Forms.DateTimePicker дата_получения_правDateTimePicker;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button cancelButton;
    }
}