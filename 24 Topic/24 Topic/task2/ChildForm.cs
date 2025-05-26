using System;
using System.Windows.Forms;

namespace MdiApplication
{
    public partial class ChildForm : Form
    {
        public ChildForm()
        {
            InitializeComponent();
            this.Text = "New Document";
            InitializeContent();
        }

        private void InitializeContent()
        {
            Label label = new Label();
            label.Text = "This is a new document";
            label.Dock = DockStyle.Fill;
            label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Controls.Add(label);
        }
    }
}