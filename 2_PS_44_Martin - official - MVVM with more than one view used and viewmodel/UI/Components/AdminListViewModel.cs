using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using DataLayer.Database;
using DataLayer.Model;
using Welcome.Others;

namespace UI.ViewModels
{
    public class AdminListViewModel : INotifyPropertyChanged
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

        public AdminListViewModel()
        {
        }

        public void FilterByRole(UserRolesEnum role)
        {
            using (var context = new DatabaseContext())
            {
                Students = context.Users.Where(user => user.Role == role).ToList();
            }
        }
    }
}
