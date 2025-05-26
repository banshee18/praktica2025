namespace Task7
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">/// true, если управляемые ресурсы должны быть освобождены; иначе false.</param>
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MassiveGridView = new DataGridView();
            FindMaxButton = new Button();
            CountPositiveButton = new Button();
            ResultTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)MassiveGridView).BeginInit();
            SuspendLayout();
            // 
            // MassiveGridView
            // 
            MassiveGridView.AllowUserToOrderColumns = true;
            MassiveGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MassiveGridView.Location = new Point(12, 12);
            MassiveGridView.Name = "MassiveGridView";
            MassiveGridView.RowHeadersWidth = 51;
            MassiveGridView.RowTemplate.Height = 29;
            MassiveGridView.Size = new Size(483, 426);
            MassiveGridView.TabIndex = 0;
            MassiveGridView.CellContentClick += MassiveGridView_CellContentClick;
            // 
            // FindMaxButton
            // 
            FindMaxButton.Location = new Point(513, 119);
            FindMaxButton.Name = "FindMaxButton";
            FindMaxButton.Size = new Size(123, 52);
            FindMaxButton.TabIndex = 1;
            FindMaxButton.Text = "Найти max";
            FindMaxButton.UseVisualStyleBackColor = true;
            // 
            // CountPositiveButton
            // 
            CountPositiveButton.Location = new Point(642, 119);
            CountPositiveButton.Name = "CountPositiveButton";
            CountPositiveButton.Size = new Size(135, 52);
            CountPositiveButton.TabIndex = 2;
            CountPositiveButton.Text = "Посчитать положительные";
            CountPositiveButton.UseVisualStyleBackColor = true;
            // 
            // ResultTextBox
            // 
            ResultTextBox.Location = new Point(513, 14);
            ResultTextBox.Multiline = true;
            ResultTextBox.Name = "ResultTextBox";
            ResultTextBox.Size = new Size(264, 99);
            ResultTextBox.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ResultTextBox);
            Controls.Add(CountPositiveButton);
            Controls.Add(FindMaxButton);
            Controls.Add(MassiveGridView);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)MassiveGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView MassiveGridView;
        private Button FindMaxButton;
        private Button CountPositiveButton;
        private TextBox ResultTextBox;
    }
}
