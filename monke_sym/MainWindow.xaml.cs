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

namespace monke_sym
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
        private void GetStarted(object Sender, RoutedEventArgs e)
        {
            Console.WriteLine("Getting started");
            GetStarted modalWindow = new GetStarted();
            modalWindow.ShowDialog();

        }
    }

    public class Utils
    {
        public static dynamic GetCheckedRadioButton(RadioButton[] buttons) 
        {
            foreach (RadioButton btn in buttons)
            {
                if (btn.IsChecked == true)
                {
                    return btn;
                }
            }

            return false;
        }
    }
}