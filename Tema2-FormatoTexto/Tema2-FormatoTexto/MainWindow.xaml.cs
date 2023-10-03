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

namespace Tema2_FormatoTexto
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void textoAñadido(object sender, TextChangedEventArgs e)
        {
            textoConFormatoLabel.Content = (sender as TextBox).Text;
        }

        private void negritaChecked(object sender, RoutedEventArgs e) => textoConFormatoLabel.FontWeight = (sender as CheckBox).IsChecked ?? false ? FontWeights.Bold : FontWeights.Normal;

        private void cursivaChecked(object sender, RoutedEventArgs e) => textoConFormatoLabel.FontStyle = (sender as CheckBox).IsChecked ?? false ? FontStyles.Italic : FontStyles.Normal;

        private void colorChecked(object sender, RoutedEventArgs e)
        {
            textoConFormatoLabel.Foreground = (sender as RadioButton).Content switch
            {
                "Azul" => Brushes.Blue,
                "Rojo" => Brushes.Red,
                "Verde" => Brushes.Green
            };
        }

        private void RadioButton_Unchecked(object sender, RoutedEventArgs e)
        {

        }
    }
}
