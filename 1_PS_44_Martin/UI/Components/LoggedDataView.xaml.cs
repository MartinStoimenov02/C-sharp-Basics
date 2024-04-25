using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using DataLayer.Database;
using DataLayer.Model;
using Welcome.Others;
using Welcome.Model;

namespace UI.Components
{
    public partial class LoggedDataView : System.Windows.Controls.UserControl
    {
        public ICommand ShowEventCommand { get; set; }

        public LoggedDataView()
        {
            InitializeComponent();
            RefreshData();
        }

        public void RefreshData()
        {
            var selectedUserName = userNames.SelectedItem;
            List<String> userNamesList = new List<String>();
            List<DataLayer.Model.LogEntry> recordsLogs = new List<DataLayer.Model.LogEntry>();
            using (var context = new DatabaseContext())
            {
                var records = context.LogEntries.Where(log => log.userName == selectedUserName).ToList();
                logs.DataContext = records;
                recordsLogs = context.LogEntries.ToList();
            }

            foreach(var logObj in recordsLogs)
            {
                userNamesList.Add(logObj.userName);
            }

            userNames.ItemsSource = userNamesList;
        }

        public void Refresh_Logs(object sender, SelectionChangedEventArgs e)
        {
            RefreshData();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = Window.GetWindow(this) as MainWindow;
            if (mainWindow != null)
            {
                mainWindow.ShowStudentsList();
            }
        }

        private void DataGridCell_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            // The sender parameter in the event handler represents the object that triggered the event.
            // In this case, it should be the DataGridCell that was double-clicked.
            DataGridCell cell = sender as DataGridCell; //casts the sender object to a DataGridCell
            LogEntry logEntry = (LogEntry)cell.DataContext; // retrieves the DataContext of the DataGridCell
            string message = $"Timestamp: {logEntry.Timestamp}\nMessageType: {logEntry.MessageType}\nMessage: {logEntry.Message}";
            System.Windows.MessageBox.Show(message, "Log Details", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
