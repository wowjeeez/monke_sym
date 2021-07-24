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
        private string gender;
        public Setup(string name)
        {
            InitializeComponent();
            ChooseGender.Text = $"Choose {name}'s gender!";
            RadioButton[] btns = new RadioButton[2];
            btns[0] = Male;
            btns[1] = Female; //scuffed late night C#
            btns[2] = Liberal;
            dynamic btn = Utils.GetCheckedRadioButton(btns);
            if (btn)
            {
                RadioButton castedBtn = btn;
                gender = castedBtn.Name;
            }
        }
    }
}
