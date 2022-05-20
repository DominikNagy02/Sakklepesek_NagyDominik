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
            //Sorok és oszlopok definiálása
            for (int i = 0; i < 8; i++)
            {
                Tabla.RowDefinitions.Add(new RowDefinition());
                Tabla.ColumnDefinitions.Add(new ColumnDefinition());
            }
            //Buttonok létrehozása
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Button gomb = new Button();
                    gomb.Content = $"{j + 1}" + $"{i + 1}";
                    gomb.Height = 30;
                    gomb.Width = 30;
                    Grid.SetColumn(gomb, i);
                    Grid.SetRow(gomb, j);
                    gomb.Click += Helyzet;
                    Tabla.Children.Add(gomb);
                }
            }
        }
        private void Helyzet(object sender, RoutedEventArgs e)
        {
            Button gomb = (Button)sender;
            String GombHelye = gomb.Content.ToString();
            HelyKiiras.Content = "Bábu helye: " + GombHelye;
        }
    }
}
