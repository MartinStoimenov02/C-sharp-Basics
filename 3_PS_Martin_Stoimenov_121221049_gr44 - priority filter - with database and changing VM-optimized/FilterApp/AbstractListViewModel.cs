using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FilterApp
{
    // Generic Class - using type parameter
    public class AbstractListViewModel<T> : INotifyPropertyChanged
    {
        private ObservableCollection<T> _items;
        public ObservableCollection<T> Items
        {
            get { return _items; }
            set { _items = value; OnPropertyChanged(); }
        }

        private Dictionary<string, List<object>> _filters;
        public Dictionary<string, List<object>> Filters
        {
            get { return _filters; }
            set { _filters = value; OnPropertyChanged(); }
        }

        private T _selectedItem;
        public T SelectedItem
        {
            get { return _selectedItem; }
            set { _selectedItem = value; OnPropertyChanged(); }
        }

        public AbstractListViewModel(List<T> items)
        {
            Items = new ObservableCollection<T>(items);
            GenerateFilters();
        }

        //Взима всички пропъртита на дадения тип и за всеки филтър добавя стойностите от записите на даденото пропърти, които не съществуват
        private void GenerateFilters()
        {
            Filters = new Dictionary<string, List<object>>();
            if (Items.Count > 0)
            {
                var properties = typeof(T).GetProperties();
                foreach (var prop in properties)
                {
                    var filterValues = new List<object>();
                    foreach (var item in Items)
                    {
                        var value = prop.GetValue(item);
                        if (!filterValues.Contains(value))
                            filterValues.Add(value);
                    }
                    Filters.Add(prop.Name, filterValues);
                }
            }
        }

        public List<T> ApplyFilters(ObservableCollection<Filter> Filters, Dictionary<string, object> filterValues)
        {
            // Сортира списъка с филтрите по приоритет
            var sortedFilters = Filters.OrderByDescending(f => f.Priority).ToList();

            foreach (var filter in sortedFilters)
            {
                if (filterValues.ContainsKey(filter.PropertyName))
                {
                    // филтрира списъка с данни по първия приоритетен филтър и го връща
                    var filteredItems = Items.Where(item =>
                    {
                        //проверка дали пропъртито на записите има такава стойност като на филтъра
                        var property = typeof(T).GetProperty(filter.PropertyName);
                        if (property != null)
                        {
                            var value = property.GetValue(item);
                            return value != null && value.Equals(filterValues[filter.PropertyName]);
                        }
                        return false;
                    }).ToList();

                    return filteredItems;
                }
            }
            // ако няма записи, отговарящи на филтрите се връща празен списък
            return new List<T>();
        }


        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}