using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace monke_sym
{
    /// <summary>
    /// Interaction logic for GetStarted.xaml
    /// </summary>
    public partial class GetStarted : Window
    {
        public GetStarted()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var Name = MonkeyName.Text;
            MonkeyName.Clear();
            GetStarted modalWindow = new GetStarted();
            modalWindow.Close();
            Console.WriteLine($"Monkey name {Name}");
            Setup setup = new Setup(Name);
            setup.ShowDialog();

        }
    }
}
