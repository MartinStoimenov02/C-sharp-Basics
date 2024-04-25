using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using UI.ViewModels;
using Welcome.Others;

namespace UI.Components
{
    public partial class AdminListView : System.Windows.Controls.UserControl
    {
        //StudentsListViewModel use StudentsList view and AdminListView.
        //AdminListView use StudentsListViewModel and AdminListViewModel
        private readonly StudentsListViewModel _studentsListViewModel;
        private readonly AdminListViewModel _adminListViewModel;

        public AdminListView()
        {
            InitializeComponent();

            // Instantiate the view models
            _studentsListViewModel = new StudentsListViewModel();
            _adminListViewModel = new AdminListViewModel();
            comboBox.SelectedIndex = 0;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
                if (comboBox.SelectedItem.ToString() == "System.Windows.Controls.ComboBoxItem: ADMIN")
                    {
                        DataContext = _studentsListViewModel;
                        _studentsListViewModel.FilterByRole(UserRolesEnum.ADMIN);
                    }
                    else if (comboBox.SelectedItem.ToString() == "System.Windows.Controls.ComboBoxItem: STUDENT")
                    {
                        DataContext = _adminListViewModel;
                        _adminListViewModel.FilterByRole(UserRolesEnum.STUDENT);
                    }
                
        }
    }
}
