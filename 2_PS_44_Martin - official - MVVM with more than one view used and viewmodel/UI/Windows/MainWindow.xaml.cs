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
using UI.Components;

namespace UI
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

        // Method to retrieve reference to StudentsList instance
        public StudentsList GetStudentsList()
        {
            return studentsList;
        }

        public void AddUserView()
        {
            popup.IsOpen = true;
            popup.StaysOpen = true;
        }

        public void closePopUp()
        {
            popup.IsOpen = false;
            popup.StaysOpen = false;
        }
    }
}