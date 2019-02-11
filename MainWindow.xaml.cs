//Morghan 185301IPO Area calculator
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


namespace _185301IPO
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

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            double Length;
            double Width;
            double area;
            double.TryParse(txtLength.Text, out Length);
            double.TryParse(txtWidth.Text, out Width);
            //Attempted to add a random element cause I was bored I think I need to import somthing in order to make it work otherwise the code works
            area = Length * Width;
            lblOutput.Content = "The area is: " + area.ToString("#0.0");
        }
    }
}
