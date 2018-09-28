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
        
        float dato1 = 0;
        float dato2 = 0;
        float dato3 = 0;
        float resultado = 0;
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void cbTipoFigura_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            panelConfiguracion.Children.Clear();

            switch (cbTipoFigura.SelectedIndex)
            {
                case 0:
                    panelConfiguracion.Children.Add(new ControlAreaRectangulo());
                    break;
                case 1:
                    panelConfiguracion.Children.Add(new ControlAreaTriangulo());
                    break;
                case 2:
                    panelConfiguracion.Children.Add(new ControlAreaCirculo());
                    break;
                case 3:
                    panelConfiguracion.Children.Add(new ControlAreaTrapecio());
                    break;
            }
            AreaResultado.Text = "0.0";
        }
        private void CalcularClick(object sender, RoutedEventArgs e)
        {
            switch (cbTipoFigura.SelectedIndex)

            {
                case 0: 
                    var controlAreaRectangulo = (ControlAreaRectangulo)panelConfiguracion.Children[0];

                    dato1 = float.Parse(controlAreaRectangulo.RectanguloBase.Text);
                    dato2 = float.Parse(controlAreaRectangulo.RectanguloAltura.Text);

                    resultado = dato1 * dato2;
                    break;
                case 1: 
                    var controlAreaTriangulo = (ControlAreaTriangulo)panelConfiguracion.Children[0];
                    dato1 = float.Parse(controlAreaTriangulo.TrianguloBase.Text);
                    dato2 = float.Parse(controlAreaTriangulo.TrianguloAltura.Text);

                    resultado = (dato1 * dato2) / 2;
                    break;
                case 2:
                    var controlAreaCirculo = (ControlAreaCirculo)panelConfiguracion.Children[0];
                    dato1 = float.Parse(controlAreaCirculo.CirculoRadio.Text);

                    resultado = (dato1 * dato1) * 3.14160f;
                    break;
                case 3:
                    var controlAreaTrapecio = (ControlAreaTrapecio)panelConfiguracion.Children[0];
                    dato1 = float.Parse(controlAreaTrapecio.TrapecioBaseMayor.Text);
                    dato2 = float.Parse(controlAreaTrapecio.TrapecioBaseMenor.Text);
                    dato3 = float.Parse(controlAreaTrapecio.TrapecioAltura.Text);

                    resultado = (dato3 * dato1 + dato2) / 2;
                    break;
            }

            AreaResultado.Text = resultado.ToString();

            dato1 = 0;
            dato2 = 0;
            dato3 = 0;
            resultado = 0;
        }

    }
}
