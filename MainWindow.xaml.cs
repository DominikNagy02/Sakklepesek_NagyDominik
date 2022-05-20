﻿using System;
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

namespace Sakklepesek_NagyDominik
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            TablaGeneral();

        }

        private void TablaGeneral()
        {


            for (int i = 0; i < 8; i++)
            {
                Tabla.RowDefinitions.Add(new RowDefinition());
                Tabla.ColumnDefinitions.Add(new ColumnDefinition());
            }
            for (int i = 0; i < 8; i++)
            {
                for (int j = 1; j < 9; j++)
                {
                    Button y = new Button();
                    y.Content = j + $"{i + 1}";
                    y.Height = 30;
                    y.Width = 30;
                    Grid.SetColumn(y, i);
                    Grid.SetRow(y, j);
                    Tabla.Children.Add(y);

                }
            }
        }
    }
}
