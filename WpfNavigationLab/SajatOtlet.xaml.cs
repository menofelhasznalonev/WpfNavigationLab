using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfNavigationLab
{
    /// <summary>
    /// Interaction logic for SajatOtlet.xaml
    /// </summary>
    public partial class SajatOtlet : Page
    {
        public SajatOtlet()
        {
            InitializeComponent();
        }

        private void BackClick(object sender, RoutedEventArgs e)

        {

            if (NavigationService.CanGoBack)

            {

                NavigationService.GoBack();

            }

        }

        private void NemErtEgyet(object sender, RoutedEventArgs e)
        {

            ButtonNemErtEgyet.Width -= 50;
            ButtonEgyetert.Width += 50;

        }

        private void Egyetert(object sender, RoutedEventArgs e)
        {
            TextKiiras.Text = "👍👍👍";
        }
    }
}
