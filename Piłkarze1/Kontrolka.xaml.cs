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

namespace Piłkarze1
{
    /// <summary>
    /// Logika interakcji dla klasy Kontrolka.xaml
    /// </summary>
    public partial class Kontrolka : UserControl
    {
        public Kontrolka()
        {
            InitializeComponent();
        }
        public static Brush MalowanieWszystkich { get; set; }
        public string tekst
        {
            get { return Pole_tekst.Text; }
            set { Pole_tekst.Text = value; }
        }
        public Brush Malowanie
        {
            get { return Obramowanie.BorderBrush; }
            set { Obramowanie.BorderBrush = value; }
        }
        public void error(string errorTekst)
        {
            Pole_tekstu_narzędzia.Text = errorTekst;
            if (errorTekst !="")
            {
                Obramowanie.BorderThickness = new Thickness(1);
                Narzędzia.Visibility = Visibility.Visible;
            }
            else
            {
                Obramowanie.BorderThickness = new Thickness(0);
                Narzędzia.Visibility = Visibility.Hidden;
            }
        }

     
    }
}
