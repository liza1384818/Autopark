using System;
using System.Linq;
using System.Windows.Forms;

namespace AutoparkClassicDesktop.Ui.EntityForms
{ 
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.RegisterEvents();
        }

        private void RegisterEvents()
        {
            this.MdiChildActivate += (object o, EventArgs e) 
                => this.toolStripStatusLabel.Text = this.ActiveMdiChild == null ? this.Text : this.ActiveMdiChild.Text;

            this.aboutToolStripMenuItem.Click += (object o, EventArgs e)
                => new Dialogs.Etc.AboutForm().ShowDialog(this);

            this.driversToolStripMenuItem.Click += (object o, EventArgs e) 
                => new EntityForms.DriversForm { MdiParent = this }.Show();
            

            this.addDriverToolStripMenuItem.Click += (object o, EventArgs e)
                =>
            {
                var result = new Dialogs.AddDriverDialog().ShowDialog(this);
            };

            this.transportToolStripMenuItem.Click += (object o, EventArgs e)
                => new EntityForms.TransportForm { MdiParent = this }.Show();

            this.transportersToolStripMenuItem.Click += (object o, EventArgs e)
                => new EntityForms.TransportersForm { MdiParent = this }.Show();

            this.маршрутыToolStripMenuItem.Click += (object o, EventArgs e)
                => new EntityForms.TransportersForm { MdiParent = this }.Show();

            this.toolBarToolStripMenuItem.CheckedChanged += (object o, EventArgs e) 
                => this.toolStrip.Visible = toolBarToolStripMenuItem.Checked;

            this.cascadeToolStripMenuItem.Click += (object o, EventArgs e) 
                => this.LayoutMdi(MdiLayout.Cascade);

            this.tileHorizontalToolStripMenuItem.Click += (object o, EventArgs e)
                => this.LayoutMdi(MdiLayout.TileHorizontal);

            this.tileVerticalToolStripMenuItem.Click += (object o, EventArgs e)
                => this.LayoutMdi(MdiLayout.TileVertical);

            this.arrangeIconsToolStripMenuItem.Click += (object o, EventArgs e)
                => this.LayoutMdi(MdiLayout.ArrangeIcons);

            this.closeAllToolStripMenuItem.Click += (object o, EventArgs e)
                => this.MdiChildren.ToList().ForEach(x => x.Close());

           
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
