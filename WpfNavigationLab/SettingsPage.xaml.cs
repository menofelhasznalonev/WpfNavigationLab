
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;


namespace WpfNavigationLab
{
    /// <summary>
    /// Interaction logic for SettingsPage.xaml
    /// </summary>
    public partial class SettingsPage : Page
    {
        public SettingsPage()
        {
            InitializeComponent();
        }

        private void SotetMod(object sender, RoutedEventArgs e)
        {
            if (CheckDarkMode.IsChecked == true)
            {
                Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#111122"));
                CheckDarkMode.Foreground  = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#F8FAFC"));
                TextBeallitasok.Foreground  = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#F8FAFC"));

            }
            else
            {
                Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#F8FAFC"));
                CheckDarkMode.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#000000"));
                TextBeallitasok.Foreground  = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#000000"));
            }
        }

        private void BackClick(object sender, RoutedEventArgs e)

        {

            if (NavigationService.CanGoBack)

            {

                NavigationService.GoBack();

            }

        }
    }
}
