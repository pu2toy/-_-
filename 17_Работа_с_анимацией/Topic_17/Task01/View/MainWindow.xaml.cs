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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Task01
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Border_MouseEnter(object sender, MouseEventArgs e)
        {
            var border = (Border)sender;

            var marginAnim = new ThicknessAnimation
            {
                To = new Thickness(10),
                Duration = TimeSpan.FromMilliseconds(200)
            };
            border.BeginAnimation(Border.MarginProperty, marginAnim);

            var brush = border.Background as SolidColorBrush;
            if (brush == null)
            {
                brush = new SolidColorBrush(Colors.White);
                border.Background = brush;
            }

            var colorAnim = new ColorAnimation
            {
                To = Colors.LightBlue,
                Duration = TimeSpan.FromMilliseconds(200)
            };

            brush.BeginAnimation(SolidColorBrush.ColorProperty, colorAnim);
        }

        private void Border_Click(object sender, MouseButtonEventArgs e)
        {
            var border = (Border)sender;

            double newHeight = border.Height == 80 ? 140 : 80;

            var anim = new DoubleAnimation
            {
                To = newHeight,
                Duration = TimeSpan.FromMilliseconds(300)
            };

            border.BeginAnimation(Border.HeightProperty, anim);
        }

        private void Border_MouseLeave(object sender, MouseEventArgs e)
        {
            var border = (Border)sender;

            var marginAnim = new ThicknessAnimation
            {
                To = new Thickness(5),
                Duration = TimeSpan.FromMilliseconds(200)
            };
            border.BeginAnimation(Border.MarginProperty, marginAnim);

            var brush = new SolidColorBrush(Colors.LightBlue);
            border.Background = brush;

            var colorAnim = new ColorAnimation
            {
                To = Colors.White,
                Duration = TimeSpan.FromMilliseconds(200)
            };

            brush.BeginAnimation(SolidColorBrush.ColorProperty, colorAnim);
        }
    }
}
