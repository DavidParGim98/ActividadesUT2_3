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

namespace ActividadesUT2_3
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Opacidad(object sender, RoutedEventArgs e)
        {
            if (OpacidadAlta_RadioButton.IsChecked == true)
            {
                img.Opacity = 1;
            }
            if (OpacidadMedia_RadioButton.IsChecked == true)
            {
                img.Opacity = 0.6;
            }
            if (OpacidadBaja_RadioButton.IsChecked == true)
            {
                img.Opacity = 0.3;
            }
        }

        private void Ajuste(object sender, RoutedEventArgs e)
        {
            if (AjusteRelleno_RadioButton.IsChecked == true)
            {
                img.Stretch = Stretch.Fill;
            }
            if (AjusteUniforme_RadioButton.IsChecked == true)
            {
                img.Stretch = Stretch.Uniform;
            }
            if (AjusteRellenoUniforme_RadioButton.IsChecked == true)
            {
                img.Stretch = Stretch.UniformToFill;
            }
            if (AjusteNone_RadioButton.IsChecked == true)
            {
                img.Stretch = Stretch.None;
            }
        }
    }
}
