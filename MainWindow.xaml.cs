using System.Windows;
using System.Windows.Controls;

namespace ExperimentWithControls
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

        private void numberTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            number.Text = numberTextBox.Text; //This line is copying the text input to the text box to the texblock in the right upper corner
        }

        private void numberTextBox_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e) //Method to accept only numbers in the text box
        {
            e.Handled = !int.TryParse(e.Text, out int result);
        }

        private void smallSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            number.Text = smallSlider.Value.ToString("0");
        }
    }
}
