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

namespace Homework6_Lab1
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
        private void CalculateClick(object sender, RoutedEventArgs e)
        {
            try
            {
                double leftHandValue = double.Parse(txtLeft.Text);
                double rightHandValue = double.Parse(txtRight.Text);

                if (listBoxOperator.SelectedItem == null)
                {
                    MessageBox.Show("Please select an operator.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                string operation = ((ListBoxItem)listBoxOperator.SelectedItem).Content.ToString();
                double result = PerformCalculation(leftHandValue, rightHandValue, operation);

                txtResult.Text = "Result: " + result.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numbers.", "Input Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Cannot divide by zero.", "Calculation Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private double PerformCalculation(double lhs, double rhs, string operation)
        {
            return operation switch
            {
                "+" => lhs + rhs,
                "-" => lhs - rhs,
                "*" => lhs * rhs,
                "/" => lhs / rhs,
                "%" => lhs % rhs,
                _ => throw new InvalidOperationException("Invalid operator")
            };
        }
    }
}
