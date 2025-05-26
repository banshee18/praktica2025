namespace LabWork2
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblY1 = new System.Windows.Forms.Label();
            this.lblY2 = new System.Windows.Forms.Label();
            this.lblZ = new System.Windows.Forms.Label();
            this.txtY1 = new System.Windows.Forms.TextBox();
            this.txtY2 = new System.Windows.Forms.TextBox();
            this.txtZ = new System.Windows.Forms.TextBox();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnHappiness = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(274, 20);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "p = (min(f(x), y) - max(y, z)) / 2";
            // 
            // lblY1
            // 
            this.lblY1.AutoSize = true;
            this.lblY1.Location = new System.Drawing.Point(20, 60);
            this.lblY1.Name = "lblY1";
            this.lblY1.Size = new System.Drawing.Size(26, 16);
            this.lblY1.TabIndex = 1;
            this.lblY1.Text = "Y1:";
            // 
            // lblY2
            // 
            this.lblY2.AutoSize = true;
            this.lblY2.Location = new System.Drawing.Point(20, 90);
            this.lblY2.Name = "lblY2";
            this.lblY2.Size = new System.Drawing.Size(26, 16);
            this.lblY2.TabIndex = 2;
            this.lblY2.Text = "Y2:";
            // 
            // lblZ
            // 
            this.lblZ.AutoSize = true;
            this.lblZ.Location = new System.Drawing.Point(20, 120);
            this.lblZ.Name = "lblZ";
            this.lblZ.Size = new System.Drawing.Size(18, 16);
            this.lblZ.TabIndex = 3;
            this.lblZ.Text = "Z:";
            // 
            // txtY1
            // 
            this.txtY1.Location = new System.Drawing.Point(60, 57);
            this.txtY1.Name = "txtY1";
            this.txtY1.ReadOnly = true;
            this.txtY1.Size = new System.Drawing.Size(100, 22);
            this.txtY1.TabIndex = 4;
            this.txtY1.Text = "5";
            // 
            // txtY2
            // 
            this.txtY2.Location = new System.Drawing.Point(60, 87);
            this.txtY2.Name = "txtY2";
            this.txtY2.ReadOnly = true;
            this.txtY2.Size = new System.Drawing.Size(100, 22);
            this.txtY2.TabIndex = 5;
            this.txtY2.Text = "3";
            // 
            // txtZ
            // 
            this.txtZ.Location = new System.Drawing.Point(60, 117);
            this.txtZ.Name = "txtZ";
            this.txtZ.ReadOnly = true;
            this.txtZ.Size = new System.Drawing.Size(100, 22);
            this.txtZ.TabIndex = 6;
            this.txtZ.Text = "0.5";
            // 
            // txtResults
            // 
            this.txtResults.Location = new System.Drawing.Point(24, 160);
            this.txtResults.Multiline = true;
            this.txtResults.Name = "txtResults";
            this.txtResults.ReadOnly = true;
            this.txtResults.Size = new System.Drawing.Size(300, 120);
            this.txtResults.TabIndex = 7;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(24, 300);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 30);
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "Пуск";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnHappiness
            // 
            this.btnHappiness.Location = new System.Drawing.Point(150, 300);
            this.btnHappiness.Name = "btnHappiness";
            this.btnHappiness.Size = new System.Drawing.Size(100, 30);
            this.btnHappiness.TabIndex = 9;
            this.btnHappiness.Text = "Очистить";
            this.btnHappiness.UseVisualStyleBackColor = true;
            this.btnHappiness.Click += new System.EventHandler(this.btnHappiness_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 350);
            this.Controls.Add(this.btnHappiness);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtResults);
            this.Controls.Add(this.txtZ);
            this.Controls.Add(this.txtY2);
            this.Controls.Add(this.txtY1);
            this.Controls.Add(this.lblZ);
            this.Controls.Add(this.lblY2);
            this.Controls.Add(this.lblY1);
            this.Controls.Add(this.lblTitle);
            this.Name = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblY1;
        private System.Windows.Forms.Label lblY2;
        private System.Windows.Forms.Label lblZ;
        private System.Windows.Forms.TextBox txtY1;
        private System.Windows.Forms.TextBox txtY2;
        private System.Windows.Forms.TextBox txtZ;
        private System.Windows.Forms.TextBox txtResults;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnHappiness;
    }
}