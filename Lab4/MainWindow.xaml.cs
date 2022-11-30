using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MediaPlayer player = new MediaPlayer();
        Ellipse el = new Ellipse();
        Line line = new Line();
        Rectangle rect = new Rectangle();
        Polygon book = new Polygon();
        Rectangle bookRect = new Rectangle();


        bool isPause = true;

        public MainWindow()
        {
            InitializeComponent();

        }

        private void Window_MouseDownCard(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }


        private void startSong_Click(object sender, RoutedEventArgs e)
        {

            if (comboBoxVoice.SelectedIndex == 0)
            {
                if (isPause)
                {
                    player.Open(new Uri("../../wav/DmC V - Bury the Light.wav", UriKind.Relative));
                    player.Play();
                    isPause = false;
                    startSong.Content = "Stop";
                    comboBoxVoice.IsEnabled = false;
                }
                else
                {
                    player.Pause();
                    isPause = true;
                    startSong.Content = "Start";
                    comboBoxVoice.IsEnabled = true;
                }

            }
            else if (comboBoxVoice.SelectedIndex == 1)
            {
                if (isPause)
                {
                    player.Open(new Uri("../../wav/Engelbert Humperdinck - A Man Without Love.wav", UriKind.Relative));
                    player.Play();
                    isPause = false;
                    startSong.Content = "Stop";
                    comboBoxVoice.IsEnabled = false;
                }
                else
                {
                    player.Pause();
                    isPause = true;
                    startSong.Content = "Start";
                    comboBoxVoice.IsEnabled = true;
                }

            }
            else if (comboBoxVoice.SelectedIndex == 2)
            {
                if (isPause)
                {
                    player.Open(new Uri("../../wav/Franz Peter Schubert - Ave Maria.wav", UriKind.Relative));
                    player.Play();
                    isPause = false;
                    startSong.Content = "Stop";
                    comboBoxVoice.IsEnabled = false;
                }
                else
                {
                    player.Pause();
                    isPause = true;
                    startSong.Content = "Start";
                    comboBoxVoice.IsEnabled = true;
                }

            }
            else if (comboBoxVoice.SelectedIndex == 3)
            {
                if (isPause)
                {
                    player.Open(new Uri("../../wav/Haddaway - What Is Love.wav", UriKind.Relative));
                    player.Play();
                    isPause = false;
                    startSong.Content = "Stop";
                    comboBoxVoice.IsEnabled = false;
                }
                else
                {
                    player.Pause();
                    isPause = true;
                    startSong.Content = "Start";
                    comboBoxVoice.IsEnabled = true;
                }

            }
            else if (comboBoxVoice.SelectedIndex == 4)
            {
                if (isPause)
                {
                    player.Open(new Uri("../../wav/Kazuma Kiryu - Baka Mitai.wav", UriKind.Relative));
                    player.Play();
                    isPause = false;
                    startSong.Content = "Stop";
                    comboBoxVoice.IsEnabled = false;
                }
                else
                {
                    player.Pause();
                    isPause = true;
                    startSong.Content = "Start";
                    comboBoxVoice.IsEnabled = true;
                }

            }
        }


        private void speedSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            player.SpeedRatio = (double)speedSlider.Value;
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            player.Volume = e.NewValue;
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ShapeRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton radioButtonShape = sender as RadioButton;
            string shapeName = radioButtonShape.Tag.ToString();
            switch (shapeName)
            {
                case "line":
                    Line();
                    break;
                case "circle":
                    Circle();
                    break;
                case "square":
                    Square();
                    break;
            }
        }

        private void ColorRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton radioButtonCol = sender as RadioButton;

            if (radioButtonCol != null)
            {
                string colorName = radioButtonCol.Tag.ToString();
                ColorBrush(colorName);
            }
        }

        private void ColorBrush(string colorName)
        {
            switch (colorName)
            {
                case "black":
                    el.Fill = Brushes.Black;
                    el.Stroke = Brushes.Gray;
                    line.Stroke = Brushes.Black;
                    rect.Fill = Brushes.Black;
                    rect.Stroke = Brushes.Gray;
                    book.Stroke = Brushes.Gray;
                    book.Fill = Brushes.Black;
                    bookRect.Stroke = Brushes.Gray;
                    bookRect.Fill = Brushes.Black;
                    break;
                case "blue":
                    el.Fill = Brushes.Blue;
                    line.Stroke = Brushes.Blue;
                    rect.Fill = Brushes.Blue;
                    book.Fill = Brushes.Blue;
                    bookRect.Fill = Brushes.Blue;
                    break;
                case "green":
                    el.Fill = Brushes.Green;
                    line.Stroke = Brushes.Green;
                    rect.Fill = Brushes.Green;
                    book.Fill = Brushes.Green;
                    bookRect.Fill = Brushes.Green;
                    break;
                case "cyan":
                    el.Fill = Brushes.Cyan;
                    line.Stroke = Brushes.Cyan;
                    rect.Fill = Brushes.Cyan;
                    book.Fill = Brushes.Cyan;
                    bookRect.Fill = Brushes.Cyan;
                    break;
                case "red":
                    el.Fill = Brushes.Red;
                    line.Stroke = Brushes.Red;
                    rect.Fill = Brushes.Red;
                    book.Fill = Brushes.Red;
                    bookRect.Fill = Brushes.Red;
                    break;
                case "magenta":
                    el.Fill = Brushes.Magenta;
                    line.Stroke = Brushes.Magenta;
                    rect.Fill = Brushes.Magenta;
                    book.Fill = Brushes.Magenta;
                    bookRect.Fill = Brushes.Magenta;
                    break;
                case "yellow":
                    el.Fill = Brushes.Yellow;
                    line.Stroke = Brushes.Yellow;
                    rect.Fill = Brushes.Yellow;
                    book.Fill = Brushes.Yellow;
                    bookRect.Fill = Brushes.Yellow;
                    break;
                case "white":
                    el.Fill = Brushes.White;
                    line.Stroke = Brushes.White;
                    rect.Fill = Brushes.White;
                    book.Fill = Brushes.White;
                    bookRect.Fill = Brushes.White;
                    break;
            }
        }

        private void rFigure_Checked(object sender, RoutedEventArgs e)
        {
            Figure();
        }

        private void rFigure_Unchecked(object sender, RoutedEventArgs e)
        {
            DrawingGroup.IsEnabled = true;
        }

        private void Line()
        {
            drawCanvas.Children.Clear();
            if (rPen.IsChecked == true)
            {
                drawCanvas.Children.Clear();
                line.X1 = 10;
                line.Y1 = 150;
                line.X2 = 10;
                line.Y2 = 10;
                line.VerticalAlignment = VerticalAlignment.Center;
                line.HorizontalAlignment = HorizontalAlignment.Center;
                line.StrokeThickness = 2;
                drawCanvas.Children.Add(line);
            }
            else if (rBrush.IsChecked == true)
            {
                drawCanvas.Children.Clear();
                line.X1 = 10;
                line.Y1 = 150;
                line.X2 = 10;
                line.Y2 = 10;
                line.VerticalAlignment = VerticalAlignment.Center;
                line.HorizontalAlignment = HorizontalAlignment.Center;
                line.StrokeThickness = 6;
                drawCanvas.Children.Add(line);
            }
        }

        private void Circle()
        {
            drawCanvas.Children.Clear();
            el.Width = 100;
            el.Height = 100;
            el.VerticalAlignment = VerticalAlignment.Center;
            el.HorizontalAlignment = HorizontalAlignment.Center;
            el.StrokeThickness = 2;
            drawCanvas.Children.Add(el);
        }

        private void Square()
        {
            drawCanvas.Children.Clear();
            rect.Width = 100;
            rect.Height = 100;
            rect.VerticalAlignment = VerticalAlignment.Center;
            rect.HorizontalAlignment = HorizontalAlignment.Center;
            rect.StrokeThickness = 2;
            drawCanvas.Children.Add(rect);
        }

        private void Figure()
        {
            DrawingGroup.IsEnabled = false;
            drawCanvas.Children.Clear();
            PointCollection points = new PointCollection()
            {
                new Point(170,84),
                new Point(130,116),

                new Point(124,122),
                new Point(120,134),
                new Point(120,148),
                new Point(124,158),

                new Point(130,166),
                new Point(238,166),
                new Point(278,136),

                new Point(272,128),
                new Point(268,118),
                new Point(268,104),
                new Point(272,92),

                new Point(278,84),
            };
            book.StrokeThickness = 2;
            book.Points = points;
            drawCanvas.Children.Add(book);
        }
    }
}
