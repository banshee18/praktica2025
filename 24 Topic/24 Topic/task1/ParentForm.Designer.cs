namespace MdiApplication
{
    partial class ParentForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ParentForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "ParentForm";
            this.ResumeLayout(false);
        }
    }
}