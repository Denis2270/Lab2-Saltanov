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

namespace WindowSaltanovD
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

        private void OpenFirstWindow(object sender, RoutedEventArgs e)
        {
            var firstWindow = new FirstWindow();
            firstWindow.Show();
        }

        private void OpenSecondWindow(object sender, RoutedEventArgs e)
        {
            var secondWindow = new SecondWindow();
            secondWindow.ShowDialog();
        }

        private void OpenThirdWindow(object sender, RoutedEventArgs e)
        {
            var thirdWindow = new ThirdWindow();
            App.Current.MainWindow = thirdWindow;
            thirdWindow.Show();
            Close();
        }
    }
}