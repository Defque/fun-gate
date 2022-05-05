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

namespace managment_atm_wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ButtonYes.Click += ClickYes;
            ButtonNo.Click += ClickNo;
        }

        private void ClickYes(object sender, EventArgs e)
        {
            Hide();
            MessageBox.Show("Мы и не сомневались в этом :)");
            Close();
        }

        private void ClickNo(object sender, EventArgs e)
        {
            Left = new Random().Next(0, Convert.ToInt32(System.Windows.SystemParameters.PrimaryScreenWidth)  - Convert.ToInt32(Width));
            Top = new Random().Next(0, Convert.ToInt32(System.Windows.SystemParameters.PrimaryScreenHeight) - Convert.ToInt32(Height));
        }
    }
}
