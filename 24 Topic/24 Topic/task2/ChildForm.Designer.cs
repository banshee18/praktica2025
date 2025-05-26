namespace MdiApplication
{
    partial class ChildForm
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
            // ChildForm
            // 
            this.ClientSize = new System.Drawing.Size(300, 200);
            this.Name = "ChildForm";
            this.ResumeLayout(false);
        }
    }
}