using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace UD02_Ejercicio05
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            textoTextBlock.Foreground = Brushes.Blue;
        }

        private void colorRadioBoton_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)azulRadioBoton.IsChecked)
                textoTextBlock.Foreground = Brushes.Blue;
            else
                textoTextBlock.Foreground = (bool)rojoRadioBoton.IsChecked ?
                                                Brushes.Red :
                                                Brushes.Green;
        }

        private void textoTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            textoTextBlock.Text = textoTextBox.Text;
            textoTextBlock.FontSize = 20;
            textoTextBlock.TextAlignment = TextAlignment.Center;
        }

        private void EstiloTextoCheckBox_Checked(object sender, RoutedEventArgs e)
        {

            if ((bool)negritaCheckBox.IsChecked && (bool)cursivaCheckBox.IsChecked)
            {
                textoTextBlock.FontStyle = FontStyles.Italic;
                textoTextBlock.FontWeight = FontWeights.Bold;
            }
            else if ((bool)negritaCheckBox.IsChecked)
                textoTextBlock.FontWeight = FontWeights.Bold;
            else
                textoTextBlock.FontStyle = FontStyles.Italic;

        }

        private void EstiloTextoCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            if (!(bool)negritaCheckBox.IsChecked && !(bool)cursivaCheckBox.IsChecked)
            {
                textoTextBlock.FontStyle = FontStyles.Normal;
                textoTextBlock.FontWeight = FontWeights.Normal;
            }
            else if (!(bool)negritaCheckBox.IsChecked)
                textoTextBlock.FontWeight = FontWeights.Normal;
            else
                textoTextBlock.FontStyle = FontStyles.Normal;
        }
    }
}
