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

namespace PracticaAreas
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /*
        float dato1 = 0;
        float dato2 = 0;
        float dato3 = 0;
        float resultado = 0;
        */
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void RectanguloClick(object sender, RoutedEventArgs e)
        {
            /*
            dato1 = float.Parse(RectanguloBase.Text);
            dato2 = float.Parse(RectanguloAltura.Text);

           resultado = dato1 * dato2;

            RectanguloArea.Text = resultado.ToString();

            dato1 = 0;
            dato2 = 0;
            resultado = 0;
            */
        }
        /*
        private void TrianguloClick(object sender, RoutedEventArgs e)
        {
            dato1 = float.Parse(TrianguloBase.Text);
            dato2 = float.Parse(TrianguloAltura.Text);

            resultado = (dato1 * dato2)/2;

            TrianguloArea.Text = resultado.ToString();

            dato1 = 0;
            dato2 = 0;
            resultado = 0;
        }

        private void CirculoClick(object sender, RoutedEventArgs e)
        {
            dato1 = float.Parse(CirculoRadio.Text);

            resultado = (dato1*dato1) * 3.14160f;

            CirculoArea.Text = resultado.ToString();

            dato1 = 0;
            resultado = 0;
        }

        private void TrapecioClick(object sender, RoutedEventArgs e)
        {
            dato1 = float.Parse(TrapecioBaseMayor.Text);
            dato2 = float.Parse(TrapecioBaseMenor.Text);
            dato3 = float.Parse(TrapecioAltura.Text);

            resultado = (dato3 * dato1 + dato2)/2;

            TrapecioArea.Text = resultado.ToString();

            dato1 = 0;
            dato2 = 0;
            dato3 = 0;
            resultado = 0;
        }
        */
        private void cbTipoFigura_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            panelConfiguracion.Children.Clear();

            switch (cbTipoFigura.SelectedIndex)
            {
                case 0:
                    panelConfiguracion.Children.Add(new ControlAreaRectangulo());
                    break;
                case 1:

                    break;
                case 2:

                    break;
                case 3:

                    break;
            }
                
        }
    }
}
