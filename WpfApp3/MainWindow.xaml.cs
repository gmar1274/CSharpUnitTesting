using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace WpfApp3
{//Gabe martinez  
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
          
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
             

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string text = this.textBox.Text;
            this.testEscapeKeys(text);
        }
        public void testEscapeKeys(string text)
        {
            var regexItem = new Regex("^[a-zA-Z0-9 ]*$");

            if (regexItem.IsMatch(text))
            {
       
                this.textBox.Text = "";
                throw new Exception("Escape keys found");
            }

        }
    }
}
