using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Task4
{
    public partial class MainWindow : Window
    {
        private Random random = new Random();

        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += (s, e) => CreateButton();
        }

        private void CreateButton()
        {
            Button button = new Button();
            button.Content = "Наведите курсор на меня";
            button.Width = 100; // Установите ширину кнопки
            button.Height = 50; // Установите высоту кнопки
            button.MouseEnter += Button_MouseEnter;
            button.Click += Button_Click;

            // Установите случайные координаты для кнопки
            Canvas.SetLeft(button, random.Next(0, (int)(MainCanvas.ActualWidth - button.Width)));
            Canvas.SetTop(button, random.Next(0, (int)(MainCanvas.ActualHeight - button.Height)));

            MainCanvas.Children.Add(button); // Предполагается, что у вас есть Canvas с именем MainCanvas
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            CreateButton();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            MainCanvas.Children.Remove(button);
        }
    }
}