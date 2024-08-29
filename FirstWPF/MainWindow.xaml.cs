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

namespace FirstWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            windowMain.Background = Brushes.LightPink;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            submitButton.Background = Brushes.Red;


            string birth = birthDate.Text;
            int newBirth = Convert.ToInt32(birthDate);
            string yourName = textName.Text;

            

            if (string.IsNullOrWhiteSpace(yourName) == false)
            {
                MessageBox.Show($"Hi! {yourName}, welcome to my program!");
            }

            if (string.IsNullOrWhiteSpace(yourName) == true)
            {
                MessageBox.Show($"Error. You must enter something");
            }
        }
    }
}