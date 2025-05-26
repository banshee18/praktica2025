namespace Task1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listWords = new ListBox();
            Changer = new Button();
            Result = new Label();
            SuspendLayout();
            // 
            // listWords
            // 
            listWords.FormattingEnabled = true;
            listWords.ItemHeight = 20;
            listWords.Items.AddRange(new object[] { "Я сова!", "Hello, World!", "А я тут!", "Привет! Моё имя Gustavo, но ты можешь называть меня Gas" });
            listWords.Location = new Point(12, 12);
            listWords.Name = "listWords";
            listWords.Size = new Size(509, 344);
            listWords.TabIndex = 0;
            listWords.SelectedIndexChanged += listWords_SelectedIndexChanged;
            // 
            // Changer
            // 
            Changer.Location = new Point(12, 409);
            Changer.Name = "Changer";
            Changer.Size = new Size(509, 29);
            Changer.TabIndex = 1;
            Changer.Text = "Преобразовать";
            Changer.UseVisualStyleBackColor = true;
            Changer.Click += Changer_Click;
            // 
            // Result
            // 
            Result.AutoSize = true;
            Result.Location = new Point(12, 373);
            Result.Name = "Result";
            Result.Size = new Size(0, 20);
            Result.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(533, 450);
            Controls.Add(Result);
            Controls.Add(Changer);
            Controls.Add(listWords);
            Name = "Form1";
            Text = "Task1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listWords;
        private Button Changer;
        private Label Result;
    }
}
