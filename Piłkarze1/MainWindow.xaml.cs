using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.ComponentModel;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Piłkarze1
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string imie;
        public string nazwisko;
        public double waga;
        public double wzrost;
        public int l;
        public int i;
        public MainWindow()
        {
            InitializeComponent();
        }
        private bool JestNiePusty(Kontrolka kt)
        {
            if (kt.tekst.Trim() == "")
            {
                kt.error("Pole nie może być puste!");
                return false;
            }
            kt.error("");
            return true;
        }
        private void Dodaj_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                imie = Pole_imie.tekst.ToString();
                nazwisko = Pole_nazwisko.tekst.ToString();
                waga = Double.Parse(Pole_waga.tekst.ToString());
                wzrost = Double.Parse(Pole_wzrost.tekst.ToString());
                if (JestNiePusty(Pole_imie) & JestNiePusty(Pole_nazwisko) & JestNiePusty(Pole_wzrost) & JestNiePusty(Pole_waga))
                {
                    if (Pozycje.Text.ToString() != "")
                    {
                        Piłkarz p = new Piłkarz(imie, nazwisko, waga, wzrost, (Pozycje)Pozycje.SelectedIndex);
                        listBoxPilkarze.Items.Add(p);
                        l = listBoxPilkarze.Items.Count;
                        MessageBox.Show("Dodano gracza", "UWAGA!");
                        Pole_imie.tekst = "";
                        Pole_nazwisko.tekst = "";
                        Pole_wzrost.tekst = "";
                        Pole_waga.tekst = "";
                        Pozycje.Text = "";

                    }
                    else
                    {
                        MessageBox.Show("Nie wybrano pozycji");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Podano błędne dane");
            }    
        }

        private void Usuń_Click(object sender, RoutedEventArgs e)
        {
            if (l > 0)
            {
                if (listBoxPilkarze.SelectedIndex > -1)
                {
                    listBoxPilkarze.Items.RemoveAt(listBoxPilkarze.SelectedIndex);
                    l = l - 1;
                }
                else
                {
                    MessageBox.Show("Nie wybrano piłkarza", "BŁĄD");
                }
            }
            else
            {
                MessageBox.Show("Brak piłkarzy do usunięcia", "BŁĄD");
            }
        }

        private void Modyfikacja_Click(object sender, RoutedEventArgs e)
        {
            if(listBoxPilkarze.SelectedIndex >-1)
            {
                try
                {
                    var nowy = new Piłkarz(listBoxPilkarze.SelectedItem as Piłkarz);
                    nowy.imie = Pole_imie.tekst;
                    nowy.nazwisko = Pole_nazwisko.tekst;
                    nowy.waga = Double.Parse(Pole_waga.tekst.ToString());
                    nowy.wzrost = Double.Parse(Pole_wzrost.tekst.ToString());
                    nowy.pozycje = (Pozycje)Pozycje.SelectedIndex;
                    listBoxPilkarze.Items[listBoxPilkarze.SelectedIndex] = nowy;
                }
                catch
                {
                    MessageBox.Show("Podano błędne dane", "BŁĄD");
                }

            }
            else
            {
                MessageBox.Show("Nie wybrano piłkarza", "BŁĄD");
            }
        }

        private void listBoxPilkarze_Wybor(object sender, SelectionChangedEventArgs e)
        {
            if(listBoxPilkarze.SelectedIndex > -1)
            {
                var aktualny_wybor = listBoxPilkarze.SelectedItem as Piłkarz;
                Pole_imie.tekst = aktualny_wybor.imie;
                Pole_nazwisko.tekst = aktualny_wybor.nazwisko;
                Pole_waga.tekst = aktualny_wybor.waga.ToString();
                Pole_wzrost.tekst = aktualny_wybor.wzrost.ToString();
                Pozycje.SelectedIndex = (int)aktualny_wybor.pozycje;
            }
        }

   
    }

}
