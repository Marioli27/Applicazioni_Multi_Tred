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

namespace APPThreading
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

        private void Btn_Task_Click(object sender, RoutedEventArgs e)
        {
            //DoWORK();
            Task.Factory.StartNew(DoWORK);

        }

        private void DoWORK()
        {
            for (int i = 0; i <= 1000000; i++)
            {
                for (int j = 0; j <= 1000000; j++)
                {

                }
            }
            Lbl_Risultato.Content = "Finito";
        }

    }
}
