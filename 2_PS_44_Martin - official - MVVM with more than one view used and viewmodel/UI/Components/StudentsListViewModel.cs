// ViewModel за StudentsList
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Input;
using DataLayer.Database;
using DataLayer.Model;
using UI.Components;
using UI.Windows;
using Welcome.Others;

namespace UI.ViewModels
{
    public class StudentsListViewModel : INotifyPropertyChanged
    {
        //StudentsListViewModel use StudentsList view and AdminListView.
        //AdminListView use StudentsListViewModel and AdminListViewModel
        public event PropertyChangedEventHandler PropertyChanged;

        private List<DatabaseUser> _students;

        public List<DatabaseUser> Students
        {
            get => _students;
            set
            {
                _students = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Students)));
            }
        }

        public ICommand AddUserCommand { get; private set; }
        public ICommand OpenAdminListViewCommand { get; private set; }
        public StudentsListViewModel()
        {
            AddUserCommand = new RelayCommand(AddUser_Click);
            OpenAdminListViewCommand = new RelayCommand(OpenAdminListView);
            RefreshData();
        }

        private void OpenAdminListView(object parameter)
        {
            // Open the new view
            AdminListWindow adminListWindow = new AdminListWindow();
            adminListWindow.ShowDialog();
        }

        private void AddUser_Click(object sender)
        {
            MainWindow mainWindow = System.Windows.Application.Current.MainWindow as MainWindow;
            if (mainWindow != null)
            {
                mainWindow.AddUserView();
            }
        }

        public void RefreshData()
        {
            using (var context = new DatabaseContext())
            {
                Students = context.Users.ToList();
            }
        }

        // Функционалност за филтриране на потребителите по роля
        public void FilterByRole(UserRolesEnum role)
        {
            using (var context = new DatabaseContext())
            {
                Students = context.Users.Where(user => user.Role == role).ToList();
            }
        }
    }
}
