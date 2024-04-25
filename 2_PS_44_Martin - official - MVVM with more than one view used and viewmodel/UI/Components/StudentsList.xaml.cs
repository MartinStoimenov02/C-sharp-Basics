// StudentsList.xaml.cs
using System.Windows;
using System.Windows.Controls;
using UI.ViewModels;

namespace UI.Components
{
    public partial class StudentsList : System.Windows.Controls.UserControl
    {
        //StudentsListViewModel use StudentsList view and AdminListView.
        //AdminListView use StudentsListViewModel and AdminListViewModel
        public StudentsList()
        {
            InitializeComponent();
            DataContext = new StudentsListViewModel();
        }
    }
}
