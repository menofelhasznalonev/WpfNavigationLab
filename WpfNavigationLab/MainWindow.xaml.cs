using System.Windows;


namespace WpfNavigationLab

{

    public partial class MainWindow : Window

    {

        public MainWindow()

        {

            InitializeComponent();


            // Induláskor a főoldal jelenjen meg.

            mainFrame.Navigate(new HomePage());

        }


        private void Home_Click(object sender, RoutedEventArgs e)

        {

            mainFrame.Navigate(new HomePage());

        }


        private void Profile_Click(object sender, RoutedEventArgs e)

        {

            mainFrame.Navigate(new ProfilePage());

        }


        private void OpenWindow_Click(object sender, RoutedEventArgs e)

        {

            InfoWindow infoWindow = new InfoWindow();


            infoWindow.Show();

        }


        private void OpenDialog_Click(object sender, RoutedEventArgs e)

        {

            InfoWindow infoWindow = new InfoWindow();


            infoWindow.ShowDialog();

        }

        private void OpenSettings_Click(object sender, RoutedEventArgs e)

        {

            mainFrame.Navigate(new SettingsPage());

        }

    }

}