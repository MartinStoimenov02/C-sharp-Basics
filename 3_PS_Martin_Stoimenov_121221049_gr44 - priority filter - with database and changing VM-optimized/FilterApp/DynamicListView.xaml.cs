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

namespace FilterApp
{
    /// <summary>
    /// Interaction logic for DynamicListView.xaml
    /// </summary>
    public partial class DynamicListView : UserControl
    {
        private List<Type> viewModels = new List<Type> { typeof(CarListViewModel), typeof(TicketListViewModel), typeof(BookListViewModel) };
        private int currentViewModelIndex = 0;
        public DynamicListView()
        {
            InitializeComponent();
            SetViewModel();
        }

        private void SetViewModel()
        {
            DataContext = Activator.CreateInstance(viewModels[currentViewModelIndex]);
        }

        private void ChangeViewModel_Click(object sender, RoutedEventArgs e)
        {
            currentViewModelIndex = (currentViewModelIndex + 1) % viewModels.Count;
            SetViewModel();
        }
    }
}
