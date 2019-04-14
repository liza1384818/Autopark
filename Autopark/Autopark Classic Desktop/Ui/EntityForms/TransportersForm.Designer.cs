namespace AutoparkClassicDesktop.Ui.EntityForms
{
    partial class TransportersForm
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
            this.containerTable = new System.Windows.Forms.TableLayoutPanel();
            this.transportersGroupBox = new System.Windows.Forms.GroupBox();
            this.tasksGroupBox = new System.Windows.Forms.GroupBox();
            this.gasolineGroupBox = new System.Windows.Forms.GroupBox();
            this.autoparkDataSet = new AutoparkClassicDesktop.Ui.EntityForms.Ui.EntityFormsutoparkClassicDesktop.Data.AutoparkDataSet();
            this.поставщикиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.поставщикиTableAdapter = new AutoparkClassicDesktop.Ui.EntityForms.Ui.EntityFormsutoparkClassicDesktop.Data.AutoparkDataSetTableAdapters.ПоставщикиTableAdapter();
            this.tableAdapterManager = new AutoparkClassicDesktop.Ui.EntityForms.Ui.EntityFormsutoparkClassicDesktop.Data.AutoparkDataSetTableAdapters.TableAdapterManager();
            this.поставщикиDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.заявкиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.заявкиTableAdapter = new AutoparkClassicDesktop.Ui.EntityForms.Ui.EntityFormsutoparkClassicDesktop.Data.AutoparkDataSetTableAdapters.ЗаявкиTableAdapter();
            this.заявкиDataGridView = new System.Windows.Forms.DataGridView();
            this.приход_ГСМBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.приход_ГСМTableAdapter = new AutoparkClassicDesktop.Ui.EntityForms.Ui.EntityFormsutoparkClassicDesktop.Data.AutoparkDataSetTableAdapters.Приход_ГСМTableAdapter();
            this.приход_ГСМDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.containerTable.SuspendLayout();
            this.transportersGroupBox.SuspendLayout();
            this.tasksGroupBox.SuspendLayout();
            this.gasolineGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.autoparkDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикиDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заявкиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заявкиDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.приход_ГСМBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.приход_ГСМDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // containerTable
            // 
            this.containerTable.ColumnCount = 2;
            this.containerTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.containerTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.containerTable.Controls.Add(this.transportersGroupBox, 0, 0);
            this.containerTable.Controls.Add(this.tasksGroupBox, 0, 1);
            this.containerTable.Controls.Add(this.gasolineGroupBox, 1, 1);
            this.containerTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containerTable.Location = new System.Drawing.Point(0, 0);
            this.containerTable.Name = "containerTable";
            this.containerTable.RowCount = 2;
            this.containerTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.containerTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.containerTable.Size = new System.Drawing.Size(800, 450);
            this.containerTable.TabIndex = 0;
            // 
            // transportersGroupBox
            // 
            this.containerTable.SetColumnSpan(this.transportersGroupBox, 2);
            this.transportersGroupBox.Controls.Add(this.поставщикиDataGridView);
            this.transportersGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.transportersGroupBox.Location = new System.Drawing.Point(3, 3);
            this.transportersGroupBox.Name = "transportersGroupBox";
            this.transportersGroupBox.Size = new System.Drawing.Size(794, 309);
            this.transportersGroupBox.TabIndex = 0;
            this.transportersGroupBox.TabStop = false;
            this.transportersGroupBox.Text = "Поставщики";
            // 
            // tasksGroupBox
            // 
            this.tasksGroupBox.Controls.Add(this.заявкиDataGridView);
            this.tasksGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tasksGroupBox.Location = new System.Drawing.Point(3, 318);
            this.tasksGroupBox.Name = "tasksGroupBox";
            this.tasksGroupBox.Size = new System.Drawing.Size(394, 129);
            this.tasksGroupBox.TabIndex = 1;
            this.tasksGroupBox.TabStop = false;
            this.tasksGroupBox.Text = "Заявки";
            // 
            // gasolineGroupBox
            // 
            this.gasolineGroupBox.Controls.Add(this.приход_ГСМDataGridView);
            this.gasolineGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gasolineGroupBox.Location = new System.Drawing.Point(403, 318);
            this.gasolineGroupBox.Name = "gasolineGroupBox";
            this.gasolineGroupBox.Size = new System.Drawing.Size(394, 129);
            this.gasolineGroupBox.TabIndex = 2;
            this.gasolineGroupBox.TabStop = false;
            this.gasolineGroupBox.Text = "Приход ГСМ";
            // 
            // autoparkDataSet
            // 
            this.autoparkDataSet.DataSetName = "AutoparkDataSet";
            this.autoparkDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // поставщикиBindingSource
            // 
            this.поставщикиBindingSource.DataMember = "Поставщики";
            this.поставщикиBindingSource.DataSource = this.autoparkDataSet;
            // 
            // поставщикиTableAdapter
            // 
            this.поставщикиTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = AutoparkClassicDesktop.Ui.EntityForms.Ui.EntityFormsutoparkClassicDesktop.Data.AutoparkDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ГСМTableAdapter = null;
            this.tableAdapterManager.Заправка_техникиTableAdapter = null;
            this.tableAdapterManager.ЗаявкиTableAdapter = this.заявкиTableAdapter;
            this.tableAdapterManager.Картотека_водителейTableAdapter = null;
            this.tableAdapterManager.Категории_вожденияTableAdapter = null;
            this.tableAdapterManager.МаршрутыTableAdapter = null;
            this.tableAdapterManager.ПоставщикиTableAdapter = this.поставщикиTableAdapter;
            this.tableAdapterManager.Право_управленияTableAdapter = null;
            this.tableAdapterManager.Приход_ГСМTableAdapter = this.приход_ГСМTableAdapter;
            this.tableAdapterManager.Путевые_листыTableAdapter = null;
            this.tableAdapterManager.Транспортные_средстваTableAdapter = null;
            // 
            // поставщикиDataGridView
            // 
            this.поставщикиDataGridView.AllowUserToAddRows = false;
            this.поставщикиDataGridView.AllowUserToDeleteRows = false;
            this.поставщикиDataGridView.AutoGenerateColumns = false;
            this.поставщикиDataGridView.BackgroundColor = System.Drawing.SystemColors.Info;
            this.поставщикиDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.поставщикиDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.поставщикиDataGridView.DataSource = this.поставщикиBindingSource;
            this.поставщикиDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.поставщикиDataGridView.Location = new System.Drawing.Point(3, 16);
            this.поставщикиDataGridView.Name = "поставщикиDataGridView";
            this.поставщикиDataGridView.ReadOnly = true;
            this.поставщикиDataGridView.Size = new System.Drawing.Size(788, 290);
            this.поставщикиDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Наименование организации";
            this.dataGridViewTextBoxColumn2.HeaderText = "Наименование организации";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 150;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ОКПО";
            this.dataGridViewTextBoxColumn3.HeaderText = "ОКПО";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 63;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ИНН/КПП";
            this.dataGridViewTextBoxColumn4.HeaderText = "ИНН/КПП";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 84;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Регион";
            this.dataGridViewTextBoxColumn5.HeaderText = "Регион";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 68;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Район";
            this.dataGridViewTextBoxColumn6.HeaderText = "Район";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 63;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Улица";
            this.dataGridViewTextBoxColumn7.HeaderText = "Улица";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 64;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Номер дома";
            this.dataGridViewTextBoxColumn8.HeaderText = "Номер дома";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 95;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Наименование банка";
            this.dataGridViewTextBoxColumn9.HeaderText = "Наименование банка";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 129;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn10.DataPropertyName = "№ расчетного счета";
            this.dataGridViewTextBoxColumn10.HeaderText = "№ расчетного счета";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 123;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn11.DataPropertyName = "№ корреспондентского счета";
            this.dataGridViewTextBoxColumn11.HeaderText = "№ корреспондентского счета";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 167;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn12.DataPropertyName = "БИК банка";
            this.dataGridViewTextBoxColumn12.HeaderText = "БИК банка";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 80;
            // 
            // заявкиBindingSource
            // 
            this.заявкиBindingSource.DataMember = "FK_Заявки_Поставщики";
            this.заявкиBindingSource.DataSource = this.поставщикиBindingSource;
            // 
            // заявкиTableAdapter
            // 
            this.заявкиTableAdapter.ClearBeforeFill = true;
            // 
            // заявкиDataGridView
            // 
            this.заявкиDataGridView.AllowUserToAddRows = false;
            this.заявкиDataGridView.AllowUserToDeleteRows = false;
            this.заявкиDataGridView.AutoGenerateColumns = false;
            this.заявкиDataGridView.BackgroundColor = System.Drawing.Color.Wheat;
            this.заявкиDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.заявкиDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn17});
            this.заявкиDataGridView.DataSource = this.заявкиBindingSource;
            this.заявкиDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.заявкиDataGridView.Location = new System.Drawing.Point(3, 16);
            this.заявкиDataGridView.Name = "заявкиDataGridView";
            this.заявкиDataGridView.ReadOnly = true;
            this.заявкиDataGridView.Size = new System.Drawing.Size(388, 110);
            this.заявкиDataGridView.TabIndex = 0;
            // 
            // приход_ГСМBindingSource
            // 
            this.приход_ГСМBindingSource.DataMember = "FK_Приход ГСМ_Заявка";
            this.приход_ГСМBindingSource.DataSource = this.заявкиBindingSource;
            // 
            // приход_ГСМTableAdapter
            // 
            this.приход_ГСМTableAdapter.ClearBeforeFill = true;
            // 
            // приход_ГСМDataGridView
            // 
            this.приход_ГСМDataGridView.AllowUserToAddRows = false;
            this.приход_ГСМDataGridView.AllowUserToDeleteRows = false;
            this.приход_ГСМDataGridView.AutoGenerateColumns = false;
            this.приход_ГСМDataGridView.BackgroundColor = System.Drawing.Color.Wheat;
            this.приход_ГСМDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.приход_ГСМDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21});
            this.приход_ГСМDataGridView.DataSource = this.приход_ГСМBindingSource;
            this.приход_ГСМDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.приход_ГСМDataGridView.Location = new System.Drawing.Point(3, 16);
            this.приход_ГСМDataGridView.Name = "приход_ГСМDataGridView";
            this.приход_ГСМDataGridView.ReadOnly = true;
            this.приход_ГСМDataGridView.Size = new System.Drawing.Size(388, 110);
            this.приход_ГСМDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn16.DataPropertyName = "№ поставки";
            this.dataGridViewTextBoxColumn16.HeaderText = "№ поставки";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.Width = 93;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn18.DataPropertyName = "Дата поставки";
            this.dataGridViewTextBoxColumn18.HeaderText = "Дата поставки";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            this.dataGridViewTextBoxColumn18.Width = 99;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn19.DataPropertyName = "Количество";
            this.dataGridViewTextBoxColumn19.HeaderText = "Количество";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            this.dataGridViewTextBoxColumn19.Width = 91;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.dataGridViewTextBoxColumn20.DataPropertyName = "Единица измерения";
            this.dataGridViewTextBoxColumn20.HeaderText = "Единица измерения";
            this.dataGridViewTextBoxColumn20.MinimumWidth = 50;
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.ReadOnly = true;
            this.dataGridViewTextBoxColumn20.Width = 50;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn21.DataPropertyName = "ГСМ";
            this.dataGridViewTextBoxColumn21.HeaderText = "ГСМ";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "№ заявки";
            this.dataGridViewTextBoxColumn1.HeaderText = "№ заявки";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 82;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Количество";
            this.dataGridViewTextBoxColumn13.HeaderText = "Количество";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Width = 91;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Единица измерения";
            this.dataGridViewTextBoxColumn14.HeaderText = "Единица измерения";
            this.dataGridViewTextBoxColumn14.MinimumWidth = 80;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Width = 80;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn15.DataPropertyName = "ГСМ";
            this.dataGridViewTextBoxColumn15.HeaderText = "ГСМ";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Width = 54;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Дата";
            this.dataGridViewTextBoxColumn17.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn17.MinimumWidth = 70;
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            // 
            // TransportersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.containerTable);
            this.Name = "TransportersForm";
            this.ShowIcon = false;
            this.Text = "Поставщики";
            this.Load += new System.EventHandler(this.TransportersForm_Load);
            this.containerTable.ResumeLayout(false);
            this.transportersGroupBox.ResumeLayout(false);
            this.tasksGroupBox.ResumeLayout(false);
            this.gasolineGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.autoparkDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикиDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заявкиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заявкиDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.приход_ГСМBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.приход_ГСМDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel containerTable;
        private System.Windows.Forms.GroupBox transportersGroupBox;
        private System.Windows.Forms.GroupBox tasksGroupBox;
        private System.Windows.Forms.GroupBox gasolineGroupBox;
        private Data.AutoparkDataSet autoparkDataSet;
        private System.Windows.Forms.BindingSource поставщикиBindingSource;
        private Data.AutoparkDataSetTableAdapters.ПоставщикиTableAdapter поставщикиTableAdapter;
        private Data.AutoparkDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView поставщикиDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private Data.AutoparkDataSetTableAdapters.ЗаявкиTableAdapter заявкиTableAdapter;
        private System.Windows.Forms.BindingSource заявкиBindingSource;
        private System.Windows.Forms.DataGridView заявкиDataGridView;
        private Data.AutoparkDataSetTableAdapters.Приход_ГСМTableAdapter приход_ГСМTableAdapter;
        private System.Windows.Forms.BindingSource приход_ГСМBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridView приход_ГСМDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
    }
}