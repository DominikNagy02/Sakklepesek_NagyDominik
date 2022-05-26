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
        int Kivalasztott = 0;
        int i;
        private void Helyzet(object sender, RoutedEventArgs e)
        {
            Button gomb = (Button)sender;
            GombHelye = gomb.Content.ToString();
            HelyKiiras.Text = "Bábu helye: " + GombHelye;

            //Fekete Gyalog
            if (Kivalasztott == 1)
            {
                i = int.Parse(GombHelye);
                if (i > 20)
                {
                    HelyKiiras.Text = "Bábu helye: " + i + "\n" + "Lehetséges Lépések: " + $"{i - 10}";
                }
                else
                {
                    HelyKiiras.Text = "Bábu helye: " + GombHelye;
                }
            }

            //Feher Gyalog
            if (Kivalasztott == 2)
            {
                i = int.Parse(GombHelye);
                if (i <= 78)
                {
                    HelyKiiras.Text = "Bábu helye: " + i + "\n" + "Lehetséges Lépések: " + $"{i + 10}";
                }
                else
                {
                    HelyKiiras.Text = "Bábu helye: " + GombHelye;
                }
            }
            //Királynő
            if (Kivalasztott == 3)
            {
                List<int> Helyek = new List<int>();

                //Balra fel
                i = int.Parse(GombHelye);
                int j = i;
                j = j - 11;
                while (j > 10 && j < 89)
                {
                    if (j > 10 && j < 89 && j != 19 && j != 20 && j != 29 && j != 30 && j != 39 && j != 40 && j != 49 && j != 50 && j != 59 && j != 60 && j != 69 && j != 70 && j != 79 && j != 80)
                    {
                        Helyek.Add(j);
                        j = j - 11;

                    }
                    else
                        j = j + i;
                }

                //Fel
                i = int.Parse(GombHelye);
                j = i;
                j = j - 10;
                while (j > 10 && j < 89)
                {
                    if (j > 10 && j < 89 && j != 19 && j != 20 && j != 29 && j != 30 && j != 39 && j != 40 && j != 49 && j != 50 && j != 59 && j != 60 && j != 69 && j != 70 && j != 79 && j != 80)
                    {
                        Helyek.Add(j);
                        j = j - 10;

                    }
                    else
                        j = j + 1;
                }

                //Jobbra fel
                i = int.Parse(GombHelye);
                j = i;
                j = j - 9;
                while (j > 10 && j < 89)
                {
                    if (j > 10 && j < 89 && j != 19 && j != 20 && j != 29 && j != 30 && j != 39 && j != 40 && j != 49 && j != 50 && j != 59 && j != 60 && j != 69 && j != 70 && j != 79 && j != 80)
                    {
                        Helyek.Add(j);
                        j = j - 9;

                    }
                    else
                        j = j + i;
                }

                //Balra
                i = int.Parse(GombHelye);
                j = i;
                j = j - 1;
                while (j > 10 && j < 89)
                {
                    if (j > 10 && j < 89 && j != 19 && j != 20 && j != 29 && j != 30 && j != 39 && j != 40 && j != 49 && j != 50 && j != 59 && j != 60 && j != 69 && j != 70 && j != 79 && j != 80)
                    {
                        Helyek.Add(j);
                        j = j - 1;

                    }
                    else
                        j = j - i;
                }

                //Jobbra
                i = int.Parse(GombHelye);
                j = i;
                j = j + 1;
                while (j > 10 && j < 89)
                {
                    if (j > 10 && j < 89 && j != 19 && j != 20 && j != 29 && j != 30 && j != 39 && j != 40 && j != 49 && j != 50 && j != 59 && j != 60 && j != 69 && j != 70 && j != 79 && j != 80)
                    {
                        Helyek.Add(j);
                        j = j + 1;

                    }
                    else
                        j = j - i;
                }

                //Balra le
                i = int.Parse(GombHelye);
                j = i;
                j = j + 9;
                while (j > 10 && j < 89)
                {
                    if (j > 10 && j < 89 && j != 19 && j != 20 && j != 29 && j != 30 && j != 39 && j != 40 && j != 49 && j != 50 && j != 59 && j != 60 && j != 69 && j != 70 && j != 79 && j != 80)
                    {
                        Helyek.Add(j);
                        j = j + 9;

                    }
                    else
                        j = j + i;
                }

                //Le
                i = int.Parse(GombHelye);
                j = i;
                j = j + 10;
                while (j > 10 && j < 89)
                {
                    if (j > 10 && j < 89 && j != 19 && j != 20 && j != 29 && j != 30 && j != 39 && j != 40 && j != 49 && j != 50 && j != 59 && j != 60 && j != 69 && j != 70 && j != 79 && j != 80)
                    {
                        Helyek.Add(j);
                        j = j + 10;

                    }
                    else
                        j = j + 1;
                }

                //Jobbra le
                i = int.Parse(GombHelye);
                j = i;
                j = j + 11;
                while (j > 10 && j < 89)
                {
                    if (j > 10 && j < 89 && j != 19 && j != 20 && j != 29 && j != 30 && j != 39 && j != 40 && j != 49 && j != 50 && j != 59 && j != 60 && j != 69 && j != 70 && j != 79 && j != 80)
                    {
                        Helyek.Add(j);
                        j = j + 11;

                    }
                    else
                        j = j + i;
                }

                //Sorrendbe állítás és Megegyezők eltüntetése
                Helyek.Sort();
                /*for (int i = 0; i < Helyek.Count - 1; i++)
                {
                    if (Helyek[i] == Helyek[i + 1])
                    {
                        Helyek.RemoveAt(i);
                    }
                }*/


                //Kiiratas
                HelyKiiras.Text = "Bábu helye: " + i + "\n" + "Lehetséges Lépések: ";
                for (int k = 0; k < 10; k++)
                {

                    HelyKiiras.Text += Helyek[k] + ", ";
                }
                HelyKiiras.Text += "\n";
                if (Helyek.Count > 26)
                {
                    for (int k = 10; k < 26; k++)
                    {

                        HelyKiiras.Text += Helyek[k] + ", ";
                    }
                    HelyKiiras.Text += "\n";
                    for (int k = 26; k < Helyek.Count - 1; k++)
                    {

                        HelyKiiras.Text += Helyek[k] + ", ";
                    }

                }
                else
                {
                    for (int k = 10; k < Helyek.Count; k++)
                    {

                        HelyKiiras.Text += Helyek[k] + ", ";
                    }
                }
                HelyKiiras.Text += Helyek.Last().ToString();


                //Király
                if (Kivalasztott == 4)
                {

                }


                //Futó
                if (Kivalasztott == 5)
                {

                }


                //Lovag
                if (Kivalasztott == 6)
                {

                }


                //Bástya
                if (Kivalasztott == 7)
                {

                }
            }
        }
        //Fekete gyalog
        private void FeketeGyalog_Selected(object sender, RoutedEventArgs e)
        {
            Kivalasztott = 1;
        }
        //Fehér gyalog
        private void FeherGyalog_Selected(object sender, RoutedEventArgs e)
        {
            Kivalasztott = 2;
        }
        //Királynő
        private void KiralyNo_Selected(object sender, RoutedEventArgs e)
        {
            Kivalasztott = 3;
        }
        //Király
        private void Kiraly_Selected(object sender, RoutedEventArgs e)
        {
            Kivalasztott = 4;
        }
        //Futó
        private void Futo_Selected(object sender, RoutedEventArgs e)
        {
            Kivalasztott = 5;
        }
        //Lovag
        private void Lovag_Selected(object sender, RoutedEventArgs e)
        {
            Kivalasztott = 6;
        }
        //Bástya
        private void Bastya_Selected(object sender, RoutedEventArgs e)
        {
            Kivalasztott = 7;
        }
    }
}