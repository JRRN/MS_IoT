using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Callant;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0xc0a

namespace LCD
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        CharacterLCD lcd = null;
        public MainPage()
        {
            InitializeComponent();
            Unloaded += MainPage_Unloaded;

            lcd = new CharacterLCD();
            lcd.WriteLCD("Welcome MS IoT 2 Plain Concepts!");
        }

        private void MainPage_Unloaded(object sender, RoutedEventArgs e)
        {
            lcd.Dispose();
        }

        private void WriteLCD_Click(object sender, RoutedEventArgs e)
        {
            lcd.WriteLCD(txtWriteLCD.Text);
        }
    }
}
