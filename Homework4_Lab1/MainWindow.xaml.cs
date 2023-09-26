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

namespace Homework4_Lab1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void CalculateFine(object sender, RoutedEventArgs e)
        {
            try
            {
                int speedLimit = int.Parse(SpeedLimitTextBox.Text);
                int yourSpeed = int.Parse(YourSpeedTextBox.Text);

                if (speedLimit < 0 || yourSpeed < 0)
                {
                    StatusLabel.Content = "Speed Limit and Your Speed must be non-negative values.";
                    return;
                }

                int overSpeed = yourSpeed - speedLimit;
                string status;
                Brush color;

                if (overSpeed <= 0)
                {
                    status = "Legal Speed";
                    color = Brushes.Green;
                }
                else if (overSpeed <= 25)
                {
                    status = $"Speeding - No Penalty. Fine: ${60 + 7 * overSpeed}";
                    color = Brushes.Yellow;
                }
                else
                {
                    status = $"Speeding - With Penalty. Fine: ${60 + 7 * overSpeed + 250}";
                    color = Brushes.Red;
                }

                StatusCanvas.Background = color;
                StatusLabel.Content = status;
            }
            catch (FormatException)
            {
                StatusLabel.Content = "Please enter valid numerical values for Speed Limit and Your Speed.";
            }
        }
    }
}
