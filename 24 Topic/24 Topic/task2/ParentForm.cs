using System;
using System.Drawing;
using System.Windows.Forms;
using task2;

namespace MdiApplication
{
    public partial class ParentForm : Form
    {
        private int openDocuments = 0;
        private ToolStripStatusLabel spWin;
        private ToolStripStatusLabel spData;

        public ParentForm()
        {
            InitializeComponent();
            InitializeToolStrip();
            InitializeStatusStrip();
            this.IsMdiContainer = true;
            this.Size = new Size(450, 350);
            this.Text = "MDI Application with StatusStrip";

            // Установка текущей даты
            spData.Text = DateTime.Today.ToLongDateString();
        }

        private void InitializeToolStrip()
        {
            // Создаем ToolStrip
            ToolStrip toolStrip = new ToolStrip();

            // Первая кнопка - New
            ToolStripButton newButton = new ToolStripButton("New");
            newButton.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            newButton.Image = CreateSampleImage("N");
            newButton.Tag = "NewDoc";
            newButton.ToolTipText = "Create new document";

            // Разделитель
            ToolStripSeparator separator = new ToolStripSeparator();

            // Вторая кнопка - Cascade
            ToolStripButton cascadeButton = new ToolStripButton("Cascade");
            cascadeButton.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            cascadeButton.Image = CreateSampleImage("C");
            cascadeButton.Tag = "Cascade";
            cascadeButton.ToolTipText = "Windows cascade";

            // Третья кнопка - Tile
            ToolStripButton tileButton = new ToolStripButton("Tile");
            tileButton.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            tileButton.Image = CreateSampleImage("T");
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

        private void InitializeStatusStrip()
        {
            StatusStrip statusStrip = new StatusStrip();

            // Первая панель - информация о расположении окон
            spWin = new ToolStripStatusLabel();
            spWin.Text = "Status";
            spWin.Name = "spWin";
            spWin.Spring = true; // Растягивается для заполнения пространства

            // Вторая панель - дата
            spData = new ToolStripStatusLabel();
            spData.Text = "Data";
            spData.Name = "spData";

            // Добавляем панели на StatusStrip
            statusStrip.Items.Add(spWin);
            statusStrip.Items.Add(spData);

            // Добавляем StatusStrip на форму
            this.Controls.Add(statusStrip);
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
                    spWin.Text = "Windows is cascade";
                    break;
                case "Title":
                    this.LayoutMdi(MdiLayout.TileHorizontal);
                    spWin.Text = "Windows is horizontal";
                    break;
            }
        }
    }
}