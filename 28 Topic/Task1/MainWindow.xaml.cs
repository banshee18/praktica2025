using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Task1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += (s, e) => DrawShapes(drawingCanvas);
        }

        public void DrawShapes(Canvas canvas)
        {
            // Треугольник
            var triangle = new Polygon
            {
                Points = new PointCollection { new Point(50, 0), new Point(0, 100), new Point(100, 100) },
                Stroke = Brushes.Black
            };
            Canvas.SetTop(triangle, 10);
            Canvas.SetLeft(triangle, 10);
            canvas.Children.Add(triangle);

            // Эллипс
            var ellipse = new Ellipse
            {
                Width = 100,
                Height = 50,
                Stroke = Brushes.Black
            };
            Canvas.SetTop(ellipse, 120);
            Canvas.SetLeft(ellipse, 10);
            canvas.Children.Add(ellipse);

            // Закрашенный круг
            var filledCircle = new Ellipse
            {
                Width = 100,
                Height = 100,
                Fill = Brushes.Blue
            };
            Canvas.SetTop(filledCircle, 200);
            Canvas.SetLeft(filledCircle, 10);
            canvas.Children.Add(filledCircle);

            // Закрашенный прямоугольник
            var filledRectangle = new Rectangle
            {
                Width = 100,
                Height = 50,
                Fill = Brushes.Green
            };
            Canvas.SetTop(filledRectangle, 320);
            Canvas.SetLeft(filledRectangle, 10);
            canvas.Children.Add(filledRectangle);

            // Сектор (используем Path и PathFigure)
            var path = new Path { Fill = Brushes.Red };
            var figure = new PathFigure { StartPoint = new Point(100, 100) };
            figure.Segments.Add(new LineSegment(new Point(200, 100), true));
            figure.Segments.Add(new ArcSegment(new Point(150, 50), new Size(50, 50), 0, false, SweepDirection.Clockwise, true));
            figure.Segments.Add(new LineSegment(new Point(100, 100), true));
            path.Data = new PathGeometry(new[] { figure });
            Canvas.SetTop(path, 400);
            Canvas.SetLeft(path, 10);
            canvas.Children.Add(path);


            // Фигура: Три концентрических круга
            for (int i = 0; i < 3; i++)
            {
                var circle = new Ellipse
                {
                    Width = 100 + i * 20,
                    Height = 100 + i * 20,
                    Stroke = Brushes.Black,
                    StrokeThickness = 2
                };
                Canvas.SetTop(circle, 50 - i * 10); // Центрирование
                Canvas.SetLeft(circle, 50 - i * 10 + 200); // Смещение вправо
                canvas.Children.Add(circle);
            }

            // Фигура: Серия из семи квадратов
            for (int i = 0; i < 7; i++)
            {
                var square = new Rectangle
                {
                    Width = 30,
                    Height = 50,
                    Stroke = Brushes.Black,
                    StrokeThickness = 2
                };
                Canvas.SetTop(square, 150 + i * 35);
                Canvas.SetLeft(square, 10 + i * 15 + 400); // Смещение вправо
                canvas.Children.Add(square);
            }

            // Фигура: Шахматная доска 8x8
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    var square = new Rectangle
                    {
                        Width = 20,
                        Height = 20,
                        Fill = (i + j) % 2 == 0 ? Brushes.Black : Brushes.White
                    };
                    Canvas.SetTop(square, 300 + i * 20);
                    Canvas.SetLeft(square, 10 + j * 20 + 200); // Смещение вправо
                    canvas.Children.Add(square);
                }
            }
        }
    }
}
