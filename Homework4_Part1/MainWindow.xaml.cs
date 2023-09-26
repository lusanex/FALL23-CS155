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

namespace Homework4_Part1
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
        private void CalculateBMI(object sender, RoutedEventArgs e)
        {
            try
            {
                double weight = double.Parse(WeightTextBox.Text);
                double height = double.Parse(HeightTextBox.Text);

                if (weight <= 0 || height <= 0)
                {
                    ResultLabel.Content = "Weight and Height must be positive values.";
                    return;
                }

                double bmi = (weight * 720) / (height * height);

                string result = $"Your BMI is {bmi:F2}.\n";
                if (bmi < 15)
                {
                    result += "You are below the healthy range.";
                    ResultLabel.Foreground = Brushes.Blue;
                }
                else if (bmi <= 26)
                {
                    result += "You are within the healthy range.";
                    ResultLabel.Foreground = Brushes.Green;
                }
                else
                {
                    result += "You are above the healthy range.";
                    ResultLabel.Foreground = Brushes.Yellow;
                }

                ResultLabel.Content = result;
            }
            catch (FormatException)
            {
                ResultLabel.Content = "Please enter valid numerical values for weight and height.";
            }
        }
    }

}
