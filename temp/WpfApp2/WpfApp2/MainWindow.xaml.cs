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

namespace WpfApp2
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddStudentWindow window = new();
            window.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var database = ApplicationModel.Instance.Database;
            MessageBoxButton button = MessageBoxButton.YesNo;
            MessageBoxImage icon = MessageBoxImage.Warning;
            MessageBoxResult result;

            result = MessageBox.Show("Quieres guardar?", "AddStudent", button, icon, MessageBoxResult.Yes);
            if (result == MessageBoxResult.Yes)
            {
                int numStd = int.Parse(numStudent.Text);
                database.RemoveStudent(database.Students[numStd - 1]);
                numStudent.Text = numStd.ToString();
                numStd -= 1;
                Close();
            }
        }
    }
}
