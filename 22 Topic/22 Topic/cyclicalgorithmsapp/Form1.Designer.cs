namespace FunctionTabulation
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
            this.lblX0 = new System.Windows.Forms.Label();
            this.lblXk = new System.Windows.Forms.Label();
            this.lblDx = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.txtX0 = new System.Windows.Forms.TextBox();
            this.txtXk = new System.Windows.Forms.TextBox();
            this.txtDx = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(236, 20);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Табулирование функций";
            // 
            // lblX0
            // 
            this.lblX0.AutoSize = true;
            this.lblX0.Location = new System.Drawing.Point(20, 60);
            this.lblX0.Name = "lblX0";
            this.lblX0.Size = new System.Drawing.Size(25, 16);
            this.lblX0.TabIndex = 1;
            this.lblX0.Text = "X0:";
            // 
            // lblXk
            // 
            this.lblXk.AutoSize = true;
            this.lblXk.Location = new System.Drawing.Point(20, 90);
            this.lblXk.Name = "lblXk";
            this.lblXk.Size = new System.Drawing.Size(25, 16);
            this.lblXk.TabIndex = 2;
            this.lblXk.Text = "Xk:";
            // 
            // lblDx
            // 
            this.lblDx.AutoSize = true;
            this.lblDx.Location = new System.Drawing.Point(20, 120);
            this.lblDx.Name = "lblDx";
            this.lblDx.Size = new System.Drawing.Size(26, 16);
            this.lblDx.TabIndex = 3;
            this.lblDx.Text = "Dx:";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(20, 150);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(18, 16);
            this.lblA.TabIndex = 4;
            this.lblA.Text = "b:";
            // 
            // txtX0
            // 
            this.txtX0.Location = new System.Drawing.Point(60, 57);
            this.txtX0.Name = "txtX0";
            this.txtX0.Size = new System.Drawing.Size(100, 22);
            this.txtX0.TabIndex = 5;
            this.txtX0.TextChanged += new System.EventHandler(this.txtX0_TextChanged);
            // 
            // txtXk
            // 
            this.txtXk.Location = new System.Drawing.Point(60, 87);
            this.txtXk.Name = "txtXk";
            this.txtXk.Size = new System.Drawing.Size(100, 22);
            this.txtXk.TabIndex = 6;
            // 
            // txtDx
            // 
            this.txtDx.Location = new System.Drawing.Point(60, 117);
            this.txtDx.Name = "txtDx";
            this.txtDx.Size = new System.Drawing.Size(100, 22);
            this.txtDx.TabIndex = 7;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(60, 147);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 22);
            this.txtB.TabIndex = 8;
            // 
            // txtResults
            // 
            this.txtResults.Location = new System.Drawing.Point(24, 180);
            this.txtResults.Multiline = true;
            this.txtResults.Name = "txtResults";
            this.txtResults.ReadOnly = true;
            this.txtResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResults.Size = new System.Drawing.Size(300, 150);
            this.txtResults.TabIndex = 9;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(24, 340);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(100, 30);
            this.btnCalculate.TabIndex = 10;
            this.btnCalculate.Text = "Вычислить";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(150, 340);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 30);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 380);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtResults);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtDx);
            this.Controls.Add(this.txtXk);
            this.Controls.Add(this.txtX0);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.lblDx);
            this.Controls.Add(this.lblXk);
            this.Controls.Add(this.lblX0);
            this.Controls.Add(this.lblTitle);
            this.Name = "MainForm";
            this.Text = "Табулирование функции";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblX0;
        private System.Windows.Forms.Label lblXk;
        private System.Windows.Forms.Label lblDx;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.TextBox txtX0;
        private System.Windows.Forms.TextBox txtXk;
        private System.Windows.Forms.TextBox txtDx;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtResults;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
    }
}