using DataLayer.Database;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FilterApp
{
    public class CarListViewModel : AbstractListViewModel<Car>, INotifyPropertyChanged
    {
        private AbstractListViewModel<Car> _listViewModel;
        public AbstractListViewModel<Car> ListViewModel
        {
            get { return _listViewModel; }
            set { _listViewModel = value; OnPropertyChanged(); }
        }

        public ObservableCollection<Filter> Filters { get; set; }

        public ICommand ApplyFiltersCommand { get; set; }
        public ICommand ClearFiltersCommand { get; set; }
        public CarListViewModel() : base(new List<Car>())
        {
            LoadCarsFromDatabase();
            ListViewModel = new AbstractListViewModel<Car>(Items.ToList()); // Convert ObservableCollection to List

            Filters = new ObservableCollection<Filter>();
            foreach (var prop in typeof(Car).GetProperties())
            {
                Filters.Add(new Filter { PropertyName = prop.Name, FilterValues = ListViewModel.Filters[prop.Name].ToList() });
            }

            ApplyFiltersCommand = new RelayCommand(ApplyFilters);
            ClearFiltersCommand = new RelayCommand(ClearFilters);
        }

        public void ApplyFilters(object parameter)
        {
            var filterValues = new Dictionary<string, object>();
            var priorities = new Dictionary<string, int>();

            // Взимат се избраните филтри и техните приоритети от view-то
            foreach (var filter in Filters.Where(filter => filter.SelectedValue != null))
            {
                filterValues[filter.PropertyName] = filter.SelectedValue;
                priorities[filter.PropertyName] = filter.Priority;
            }

            //извличат се филтрираните записи от обобщената функция в generic класа
            List<Car> filteredItems = base.ApplyFilters(Filters, filterValues);


            // прави се проверка дали има записи по дадените филтри и се добавят към списъка за показване на view-то, ако няма се поакзват всички записи
            if (filteredItems.Count > 0)
            {
                ListViewModel.Items.Clear();
                foreach (var item in filteredItems)
                {
                    ListViewModel.Items.Add(item);
                }
            }
            else
            {
                ListViewModel = new AbstractListViewModel<Car>(Items.ToList());
            }


            // Приоритета на избраните филтри се активира
            foreach (var filter in Filters)
            {
                if (filterValues.ContainsKey(filter.PropertyName))
                {
                    filter.IsSelected = true;
                    filter.Priority = priorities[filter.PropertyName];
                }
                else
                {
                    filter.IsSelected = false;
                    filter.Priority = 0;
                }
            }

            // обновява броя на приоритетите и съответно цифрите им, според това колко филтъра са добавени
            foreach (var filter in Filters)
            {
                filter.UpdatePriorityOptions(Filters.Where(f => f.IsSelected).ToList());
            }
        }


        private void LoadCarsFromDatabase()
        {
            using (var context = new DatabaseContext())
            {
                foreach (var car in context.Cars.ToList())
                {
                    Items.Add((Car)car);
                }
            }

        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void ClearFilters(object parameter)
        {
            foreach (var filter in Filters)
            {
                filter.SelectedValue = null;
            }
            ApplyFilters(null); // Apply filters after clearing
        }
    }
}
