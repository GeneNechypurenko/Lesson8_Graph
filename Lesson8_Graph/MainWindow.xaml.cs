using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lesson8_Graph
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Rectangle rectangle = new Rectangle
            {
                Stroke = Brushes.Black,
                StrokeThickness = 2,
                Height = 100,
                Width = 100,
                Fill = Brushes.Red
            };

            Grid.SetColumn(rectangle, 1);
            Grid.SetRow(rectangle, 0);
            grid.Children.Add(rectangle);

            Ellipse ellipse = new Ellipse
            {
                Stroke = Brushes.Black,
                StrokeThickness = 2,
                Height = 100,
                Width = 100,
                Fill = Brushes.Green
            };

            Grid.SetColumn(ellipse, 1);
            Grid.SetRow(ellipse, 1);
            grid.Children.Add(ellipse);

            Polygon polygon = new Polygon
            {
                Stroke = Brushes.Black,
                StrokeThickness = 2,
                Fill = Brushes.Blue
            };

            polygon.Points.Add(new Point(180, 100));
            polygon.Points.Add(new Point(135, 30));
            polygon.Points.Add(new Point(80, 100));

            Grid.SetColumn(polygon, 1);
            Grid.SetRow(polygon, 2);
            grid.Children.Add(polygon);
        }
    }
}