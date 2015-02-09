using System.Windows;

namespace Chapter19 {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow {
        public MainWindow() {
            InitializeComponent();
        }

        private void btnHello_Click(object sender, RoutedEventArgs e) {
            lblHello.Content = "Hello WPF!";
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e) {
            Close();
        }
    }
}
