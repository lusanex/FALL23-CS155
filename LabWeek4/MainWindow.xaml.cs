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

namespace LabWeek4
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
        private void ConvertToPigLatin(object sender, RoutedEventArgs e)
        {
            string name = txtName.Text;
            string[] words = name.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = ConvertWordToPigLatin(words[i]);
            }
            lblResult.Content = string.Join(" ", words);
        }

        private string ConvertWordToPigLatin(string word)
        {
            if (string.IsNullOrEmpty(word)) return word;
            string firstLetter = word.Substring(0, 1).ToLower();
            string restOfWord = word.Substring(1).ToLower();
            string pigLatin = restOfWord + firstLetter + "ay";

            // Capitalize the first letter of the resulting Pig Latin word
            return char.ToUpper(pigLatin[0]) + pigLatin.Substring(1);
        }
    }

}
