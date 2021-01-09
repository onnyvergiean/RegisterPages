using RegisterPages.Controller;
using RegisterPages.Model;
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

namespace RegisterPages
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, VerificationResponse
    {
        MainWindowController controller;
        public MainWindow()
        {
            InitializeComponent();
            controller = new MainWindowController();
            controller.SubcribeVerificationResult(this);
        }

        private void OnButtonDaftarClicked(object sender, RoutedEventArgs e)
        {
            labelKeteranganEmail.Content = "";
            labelKeteranganWa.Content = "";
            controller.registeringUser(textBoxName.Text, textBoxEmail.Text, textBoxPhoneNumber.Text);
        }

        private void OnCheckboxEmailChecked(object sender, RoutedEventArgs e)
        {
            controller.SubscribeEmailVerification();
        }

        private void OnCheckboxEmailUnchecked(object sender, RoutedEventArgs e)
        {
            controller.UnsubscribeEmailVerification();
        }

        private void OnCheckboxWhatsappUnhecked(object sender, RoutedEventArgs e)
        {
            controller.UnsubscribeWAVerification();
        }

        private void OnCheckboxWhatsappChecked(object sender, RoutedEventArgs e)
        {
            controller.SubscribeWAVerification();
        }

        public void OnWaVerificationSucceed(object source, EventArgs e)
        {
            labelKeteranganWa.Content = "Wa berhasil dikirim";
        }

        public void OnEmailVerificationSucceed(object source, EventArgs e)
        {
            labelKeteranganEmail.Content = "Email berhasil dikirim";
        }
    }
}
