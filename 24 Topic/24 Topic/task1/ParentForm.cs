using System;
using System.Drawing;
using System.Windows.Forms;

namespace MdiApplication
{
    public partial class ParentForm : Form
    {
        private int openDocuments = 0;

        public ParentForm()
        {
            InitializeComponent();
            InitializeToolStrip();
            this.IsMdiContainer = true;
            this.Text = "MDI Application with ToolStrip";
        }

        private void InitializeToolStrip()
        {
            // Создаем ToolStrip
            ToolStrip toolStrip = new ToolStrip();

            // Первая кнопка - New
            ToolStripButton newButton = new ToolStripButton();
            newButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            newButton.Image = CreateSampleImage("N"); // Замените на реальное изображение
            newButton.Tag = "NewDoc";
            newButton.ToolTipText = "Create new document";

            // Разделитель
            ToolStripSeparator separator = new ToolStripSeparator();

            // Вторая кнопка - Cascade
            ToolStripButton cascadeButton = new ToolStripButton();
            cascadeButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            cascadeButton.Image = CreateSampleImage("C"); // Замените на реальное изображение
            cascadeButton.Tag = "Cascade";
            cascadeButton.ToolTipText = "Windows cascade";

            // Третья кнопка - Tile
            ToolStripButton tileButton = new ToolStripButton();
            tileButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tileButton.Image = CreateSampleImage("T"); // Замените на реальное изображение
            tileButton.Tag = "Title";
            tileButton.ToolTipText = "Windows title";

            // Добавляем элементы на ToolStrip
            toolStrip.Items.Add(newButton);
            toolStrip.Items.Add(separator);
            toolStrip.Items.Add(cascadeButton);
            toolStrip.Items.Add(tileButton);

            // Подписываемся на событие
            toolStrip.ItemClicked += ToolStrip_ItemClicked;

            // Добавляем ToolStrip на форму
            this.Controls.Add(toolStrip);
        }

        private Image CreateSampleImage(string text)
        {
            // Создаем временное изображение для примера
            Bitmap bmp = new Bitmap(32, 32);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.LightGray);
                using (Font font = new Font("Arial", 12))
                {
                    g.DrawString(text, font, Brushes.Black, new PointF(5, 5));
                }
            }
            return bmp;
        }

        private void ToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Tag.ToString())
            {
                case "NewDoc":
                    ChildForm newChild = new ChildForm();
                    newChild.MdiParent = this;
                    newChild.Show();
                    newChild.Text = "Document " + (++openDocuments);
                    break;
                case "Cascade":
                    this.LayoutMdi(MdiLayout.Cascade);
                    break;
                case "Title":
                    this.LayoutMdi(MdiLayout.TileHorizontal);
                    break;
            }
        }
    }
}