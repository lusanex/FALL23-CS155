/*Problem Statement: Ask the user to enter the amount of a monthly mortgage payment and the outstanding balance. 
 * Calculate and display the amount of the payment that goes to interest and the amount that goes to principal.
 *
 * Constraints:
 *1) The annual interest rate is fixed at 6.39%.
 * 2) Payments are made monthly, so the interest is only one-twelfth of the annual interest rate.
 * 3) The user's input should be positive numbers, and the monthly payment should be greater than the monthly interest amount.
 *
 */

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

namespace Homework3_Part1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const double ANNUAL_INTEREST_RATE = 0.0639;

        public MainWindow()
        {
            InitializeComponent();
        }
        private void OnCalculateClicked(object sender, RoutedEventArgs e)
        {
            try
            {
                double outstandingBalance = double.Parse(txtOutstandingBalance.Text);

                double annualInterestAmount = outstandingBalance * ANNUAL_INTEREST_RATE;
                double monthlyInterest = annualInterestAmount / 12;

                double monthlyPayment = double.Parse(txtMonthlyPayment.Text);
                double principal = monthlyPayment - monthlyInterest;

                lblInterestAmount.Content = monthlyInterest.ToString("C2");
                lblPrincipalAmount.Content = principal.ToString("C2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter valid numbers.");
            }
        }
    }
}
