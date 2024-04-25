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
using DataLayer.Database;
using DataLayer.Model;
using UI;

namespace UI.Components
{
    public partial class StudentsList : System.Windows.Controls.UserControl
    {
        public StudentsList()
        {
            InitializeComponent();
            RefreshData();
        }

        public void RefreshData()
        {
            //The using statement ensures the correct use of an IDisposable instance
            using (var context = new DatabaseContext())
            {
                var records = context.Users.ToList();
                students.DataContext = records;
            }
        }

        private void ShowLoggedData_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = Window.GetWindow(this) as MainWindow;
            if (mainWindow != null)
            {
                mainWindow.ShowLoggedDataView();
            }
        }

        private void AddUser_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = Window.GetWindow(this) as MainWindow;
            if (mainWindow != null)
            {
                mainWindow.AddUserView();
            }
        }

    }
}