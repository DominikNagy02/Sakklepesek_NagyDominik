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
        //Tábla generálása
        private void TablaGeneral()
        {
            //Sorok és oszlopok definiálása
            for (int i = 0; i < 8; i++)
            {
                Tabla.RowDefinitions.Add(new RowDefinition());
                Tabla.ColumnDefinitions.Add(new ColumnDefinition());
            }
            //sor
            for (int i = 0; i < 8; i++)
            {
                //oszlop
                for (int j = 0; j < 8; j++)
                {
                    //Buttonok létrehozása
                    Button gomb = new Button
                    {
                        Content = $"{j + 1}" + $"{i + 1}",
                        Height = 30,
                        Width = 30
                    };
                    Grid.SetColumn(gomb, i);
                    Grid.SetRow(gomb, j);
                    gomb.Click += Helyzet;
                    Tabla.Children.Add(gomb);
                }
            }
        }
        //Bábu helyének kiírása
        private string GombHelye = "11";
        private void Helyzet(object sender, RoutedEventArgs e)
        {
            Button gomb = (Button)sender;
            GombHelye = gomb.Content.ToString();
            HelyKiiras.Content = "Bábu helye: " + GombHelye;
        }
        //Fekete gyalog
        private void FeketeGyalog_Selected(object sender, RoutedEventArgs e)
        {

            int i = new int();
            i = int.Parse(GombHelye);
            if (i > 20)
            {
                HelyKiiras.Content = "Bábu helye: " + i + "\n" + "Lehetséges Lépések: " + $"{i - 10}";
            }
            else
            {
                HelyKiiras.Content = "Bábu helye: " + GombHelye;
            }
        }
        //Fehér gyalog
        private void FeherGyalog_Selected(object sender, RoutedEventArgs e)
        {
            int i = new int();
            i = int.Parse(GombHelye);
            if (i <= 78)
            {
                HelyKiiras.Content = "Bábu helye: " + i + "\n" + "Lehetséges Lépések: " + $"{i + 10}";
            }
            else
            {
                HelyKiiras.Content = "Bábu helye: " + GombHelye;
            }
        }
        //Királynő
        private void KiralyNo_Selected(object sender, RoutedEventArgs e)
        {
            /*
            int i = new int();
            i = int.Parse(GombHelye);
            if (i > 20)
            {
                HelyKiiras.Content = "Bábu helye: " + i + "\n" + "Lehetséges Lépések: " + $"{i - 10}";
            }*/
        }
        //Király
        private void Kiraly_Selected(object sender, RoutedEventArgs e)
        {
            /*
            int i = new int();
            i = int.Parse(GombHelye);
            if (i > 20)
            {
                HelyKiiras.Content = "Bábu helye: " + i + "\n" + "Lehetséges Lépések: " + $"{i - 10}";
            }*/
        }
        //Futó
        private void Futo_Selected(object sender, RoutedEventArgs e)
        {
            /*
            int i = new int();
            i = int.Parse(GombHelye);
            if (i > 20)
            {
                HelyKiiras.Content = "Bábu helye: " + i + "\n" + "Lehetséges Lépések: " + $"{i - 10}";
            }*/
        }
        //Lovag
        private void Lovag_Selected(object sender, RoutedEventArgs e)
        {
            /*
            int i = new int();
            i = int.Parse(GombHelye);
            if (i > 20)
            {
                HelyKiiras.Content = "Bábu helye: " + i + "\n" + "Lehetséges Lépések: " + $"{i - 10}";
            }*/
        }
        //Bástya
        private void Bastya_Selected(object sender, RoutedEventArgs e)
        {
            /*
            int i = new int();
            i = int.Parse(GombHelye);
            int j = new int();
            while (11 <= j && j <= 88)
            {
                if (i > 20)
                    {
                       HelyKiiras.Content = "Bábu helye: " + i + "\n" + "Lehetséges Lépések: " + $"{i}";
                    }
            }*/

        }
    }
}
