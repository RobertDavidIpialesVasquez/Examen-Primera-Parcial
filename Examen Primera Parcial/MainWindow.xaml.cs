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

namespace Examen_Primera_Parcial
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int color =1;
        public MainWindow()

        {

            InitializeComponent();
        }

        private void Cambiar_Click(object sender, RoutedEventArgs e)
        {
            bandera.Fill = Brushes.Transparent;

            if (color % 2 == 0)
            {

                amarillo.Fill = Brushes.Red;
                azul.Fill = Brushes.Blue;
                rojo.Fill = Brushes.Yellow;
            }
            else
            {
                celeste.Fill = Brushes.SkyBlue;
                blanco.Fill = Brushes.White;
                celeste2.Fill = Brushes.SkyBlue;
                circulo.Fill = Brushes.Yellow;
            }

            color++;
        }
    }
}

        

    

