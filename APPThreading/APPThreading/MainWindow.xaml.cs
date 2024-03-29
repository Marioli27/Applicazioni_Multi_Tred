﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
            for (int i = 0; i <= 100000; i++)
            {
                for (int j = 0; j <= 100000; j++)
                {

                }
            }
            //AggiornaInterfaccia();
            Dispatcher.Invoke(AggiornaInterfaccia);
        }


        private void AggiornaInterfaccia()
        {
            Lbl_Risultato.Content = "Finito";
        }


        private void Btn_Conta_Click(object sender, RoutedEventArgs e)
        {
            //DoCount();
            Task.Factory.StartNew(DoCount);
        }

        private void DoCount()
        {
            for (int i = 0; i <= 1000; i++)
            {
                for (int j = 0; j <= 1000; j++)
                {
                    Dispatcher.Invoke(()=>AggiornaInterfaccia(j));
                    Thread.Sleep(100);
                }
            }
        }

        private void AggiornaInterfaccia(int j)
        {
            Lbl_Conteggio.Content = j.ToString();
        }

    }
}
