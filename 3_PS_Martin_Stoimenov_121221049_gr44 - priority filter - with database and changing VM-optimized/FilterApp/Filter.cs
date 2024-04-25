using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FilterApp
{
    public class Filter : INotifyPropertyChanged
    {
        private string _propertyName;
        public string PropertyName
        {
            get { return _propertyName; }
            set { _propertyName = value; OnPropertyChanged(); }
        }

        private object _selectedValue;
        public object SelectedValue
        {
            get { return _selectedValue; }
            set { _selectedValue = value; OnPropertyChanged(); }
        }

        private List<object> _filterValues;
        public List<object> FilterValues
        {
            get { return _filterValues; }
            set { _filterValues = value; OnPropertyChanged(); }
        }

        private int _priority;
        public int Priority
        {
            get { return _priority; }
            set { _priority = value; OnPropertyChanged(); }
        }

        private bool _isSelected;
        public bool IsSelected
        {
            get { return _isSelected; }
            set { _isSelected = value; OnPropertyChanged(); }
        }

        private ObservableCollection<int> _priorityOptions;
        public ObservableCollection<int> PriorityOptions
        {
            get { return _priorityOptions; }
            set { _priorityOptions = value; OnPropertyChanged(); }
        }

        public Filter()
        {
            PriorityOptions = new ObservableCollection<int>();
        }

        public void UpdatePriorityOptions(List<Filter> selectedFilters)
        {
            PriorityOptions.Clear();
            for (int i = 1; i <= selectedFilters.Count; i++) //задава се броя на възможните приоритети да е равен на броя на избраните филтри
            {
                PriorityOptions.Add(i);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
