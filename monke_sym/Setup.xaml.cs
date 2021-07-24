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
    /// Interaction logic for Setup.xaml
    /// </summary>
    public partial class Setup : Window
    {
        private string moneyName;
        public Setup(string name)
        {
            moneyName = name;
            InitializeComponent();
            ChooseGender.Text = $"Choose {name}'s gender!";

        }
    }
}
