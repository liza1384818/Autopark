namespace AutoparkClassicDesktop.Ui.EntityForms
{
    partial class RouteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RouteForm));
            this.учет_ГСМDataSet = new AutoparkClassicDesktop.Ui.EntityForms.Ui.EntityFormsutoparkClassicDesktop.Учет_ГСМDataSet();
            this.маршрутыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.маршрутыTableAdapter = new AutoparkClassicDesktop.Ui.EntityForms.Ui.EntityFormsutoparkClassicDesktop.Учет_ГСМDataSetTableAdapters.МаршрутыTableAdapter();
            this.tableAdapterManager = new AutoparkClassicDesktop.Ui.EntityForms.Ui.EntityFormsutoparkClassicDesktop.Учет_ГСМDataSetTableAdapters.TableAdapterManager();
            this.маршрутыBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.маршрутыBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.путевые_листыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.путевые_листыTableAdapter = new AutoparkClassicDesktop.Ui.EntityForms.Ui.EntityFormsutoparkClassicDesktop.Учет_ГСМDataSetTableAdapters.Путевые_листыTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.маршрутыDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.путевые_листыDataGridView = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.учет_ГСМDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.маршрутыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.маршрутыBindingNavigator)).BeginInit();
            this.маршрутыBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.путевые_листыBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.маршрутыDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.путевые_листыDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // учет_ГСМDataSet
            // 
            this.учет_ГСМDataSet.DataSetName = "Учет_ГСМDataSet";
            this.учет_ГСМDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // маршрутыBindingSource
            // 
            this.маршрутыBindingSource.DataMember = "Маршруты";
            this.маршрутыBindingSource.DataSource = this.учет_ГСМDataSet;
            // 
            // маршрутыTableAdapter
            // 
            this.маршрутыTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = AutoparkClassicDesktop.Ui.EntityForms.Ui.EntityFormsutoparkClassicDesktop.Учет_ГСМDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ГСМTableAdapter = null;
            this.tableAdapterManager.Заправка_техникиTableAdapter = null;
            this.tableAdapterManager.ЗаявкиTableAdapter = null;
            this.tableAdapterManager.Картотека_водителейTableAdapter = null;
            this.tableAdapterManager.Категории_вожденияTableAdapter = null;
            this.tableAdapterManager.МаршрутыTableAdapter = this.маршрутыTableAdapter;
            this.tableAdapterManager.ПоставщикиTableAdapter = null;
            this.tableAdapterManager.Право_управленияTableAdapter = null;
            this.tableAdapterManager.Приход_ГСМTableAdapter = null;
            this.tableAdapterManager.Путевые_листыTableAdapter = this.путевые_листыTableAdapter;
            this.tableAdapterManager.Транспортные_средстваTableAdapter = null;
            // 
            // маршрутыBindingNavigator
            // 
            this.маршрутыBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.маршрутыBindingNavigator.BindingSource = this.маршрутыBindingSource;
            this.маршрутыBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.маршрутыBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.маршрутыBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.маршрутыBindingNavigatorSaveItem});
            this.маршрутыBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.маршрутыBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.маршрутыBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.маршрутыBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.маршрутыBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.маршрутыBindingNavigator.Name = "маршрутыBindingNavigator";
            this.маршрутыBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.маршрутыBindingNavigator.Size = new System.Drawing.Size(633, 25);
            this.маршрутыBindingNavigator.TabIndex = 1;
            this.маршрутыBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // маршрутыBindingNavigatorSaveItem
            // 
            this.маршрутыBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.маршрутыBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("маршрутыBindingNavigatorSaveItem.Image")));
            this.маршрутыBindingNavigatorSaveItem.Name = "маршрутыBindingNavigatorSaveItem";
            this.маршрутыBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.маршрутыBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.маршрутыBindingNavigatorSaveItem.Click += new System.EventHandler(this.маршрутыBindingNavigatorSaveItem_Click);
            // 
            // путевые_листыBindingSource
            // 
            this.путевые_листыBindingSource.DataMember = "FK_Путевые листы_Маршруты";
            this.путевые_листыBindingSource.DataSource = this.маршрутыBindingSource;
            // 
            // путевые_листыTableAdapter
            // 
            this.путевые_листыTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.маршрутыDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 135);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Маршруты";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.путевые_листыDataGridView);
            this.groupBox2.Location = new System.Drawing.Point(12, 182);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(612, 180);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Путевые листы";
            // 
            // маршрутыDataGridView
            // 
            this.маршрутыDataGridView.AutoGenerateColumns = false;
            this.маршрутыDataGridView.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.маршрутыDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.маршрутыDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.маршрутыDataGridView.DataSource = this.маршрутыBindingSource;
            this.маршрутыDataGridView.Location = new System.Drawing.Point(6, 19);
            this.маршрутыDataGridView.Name = "маршрутыDataGridView";
            this.маршрутыDataGridView.Size = new System.Drawing.Size(244, 105);
            this.маршрутыDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID маршрута";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID маршрута";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Расстояние/км";
            this.dataGridViewTextBoxColumn2.HeaderText = "Расстояние/км";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // путевые_листыDataGridView
            // 
            this.путевые_листыDataGridView.AutoGenerateColumns = false;
            this.путевые_листыDataGridView.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.путевые_листыDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.путевые_листыDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.путевые_листыDataGridView.DataSource = this.путевые_листыBindingSource;
            this.путевые_листыDataGridView.Location = new System.Drawing.Point(6, 19);
            this.путевые_листыDataGridView.Name = "путевые_листыDataGridView";
            this.путевые_листыDataGridView.Size = new System.Drawing.Size(600, 146);
            this.путевые_листыDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "№ путевого листа";
            this.dataGridViewTextBoxColumn3.HeaderText = "№ путевого листа";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Дата отправления";
            this.dataGridViewTextBoxColumn4.HeaderText = "Дата отправления";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Время выезда";
            this.dataGridViewTextBoxColumn5.HeaderText = "Время выезда";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Время возврата";
            this.dataGridViewTextBoxColumn6.HeaderText = "Время возврата";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Топливо при выезде";
            this.dataGridViewTextBoxColumn7.HeaderText = "Топливо при выезде";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Топливо при возврате";
            this.dataGridViewTextBoxColumn8.HeaderText = "Топливо при возврате";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Масса груза";
            this.dataGridViewTextBoxColumn9.HeaderText = "Масса груза";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Водитель";
            this.dataGridViewTextBoxColumn10.HeaderText = "Водитель";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Маршрут";
            this.dataGridViewTextBoxColumn11.HeaderText = "Маршрут";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Транспортное средство";
            this.dataGridViewTextBoxColumn12.HeaderText = "Транспортное средство";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // RouteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 381);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.маршрутыBindingNavigator);
            this.Name = "RouteForm";
            this.Text = "Управление маршрутами";
            this.Load += new System.EventHandler(this.RouteForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.учет_ГСМDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.маршрутыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.маршрутыBindingNavigator)).EndInit();
            this.маршрутыBindingNavigator.ResumeLayout(false);
            this.маршрутыBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.путевые_листыBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.маршрутыDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.путевые_листыDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Учет_ГСМDataSet учет_ГСМDataSet;
        private System.Windows.Forms.BindingSource маршрутыBindingSource;
        private Учет_ГСМDataSetTableAdapters.МаршрутыTableAdapter маршрутыTableAdapter;
        private Учет_ГСМDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator маршрутыBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton маршрутыBindingNavigatorSaveItem;
        private Учет_ГСМDataSetTableAdapters.Путевые_листыTableAdapter путевые_листыTableAdapter;
        private System.Windows.Forms.BindingSource путевые_листыBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView маршрутыDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView путевые_листыDataGridView;
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
    }
}