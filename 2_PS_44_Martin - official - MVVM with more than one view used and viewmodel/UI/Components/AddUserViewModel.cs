using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using DataLayer.Database;
using DataLayer.Model;
using UI.ViewModels;
using Welcome.Others;

namespace UI.ViewModels
{
    public class AddUserViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        // Properties bound to the View
        public string Name { get; set; }
        public string Password { get; set; }
        public string FacNum { get; set; }
        public string Email { get; set; }
        public string ExpireMonths { get; set; }
        public List<string> Roles { get; } // List of available roles
        public string SelectedRole { get; set; } // Selected role from combobox

        // Command for AddUser button
        public ICommand AddUserCommand { get; private set; }

        public AddUserViewModel()
        {
            // Initialize command
            AddUserCommand = new RelayCommand(AddUser);

            // Set initial values for properties
            SetInitialValues();

            // Populate roles list
            Roles = GetRolesList();
        }

        private void SetInitialValues()
        {
            // Set initial values for text boxes
            Name = "Name";
            Password = "Password";
            FacNum = "Facultity Number";
            Email = "Email";
            ExpireMonths = "12"; // Default expiry months
        }

        private List<string> GetRolesList()
        {
            // Retrieve roles from database or any other source
            return Enum.GetValues(typeof(UserRolesEnum))
            .Cast<UserRolesEnum>()
            .Select(v => v.ToString())
            .ToList();

        }

        private void AddUser(object parameter)
        {
            string message = "";
            try
            {
                // Create a new user object
                DatabaseUser newUser = new DatabaseUser
                {
                    Name = Name,
                    Password = Password,
                    FacNum = FacNum,
                    Email = Email,
                    // Convert ExpireMonths to int if needed
                    expiresDate = DateTime.Now.AddMonths(Convert.ToInt32(ExpireMonths)),
                    Role = (UserRolesEnum)Enum.Parse(typeof(UserRolesEnum), SelectedRole)
                };

                // Add the user object to the database context
                using (var context = new DatabaseContext())
                {
                    context.Users.Add(newUser);
                    context.SaveChanges();
                    message = $"Added new user: {newUser.Name}";
                    LogAction(context, "User Addition", message);

                    // Refresh data on ViewModels
                    var mainWindow = System.Windows.Application.Current.MainWindow as MainWindow;
                    mainWindow?.closePopUp();
                    var studentsListViewModel = mainWindow?.GetStudentsList()?.DataContext as StudentsListViewModel;
                    studentsListViewModel?.RefreshData();
                }
            }
            catch (Exception ex)
            {
                message = ex.Message;
                using (var context = new DatabaseContext())
                    LogAction(context, "error", message);
            }
            finally
            {
                // Refresh UI or perform any necessary actions
                SetTextBoxes();
                System.Windows.MessageBox.Show(message, "Message", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void LogAction(DatabaseContext context, string actionType, string message)
        {
            var logEntry = new LogEntry
            {
                Timestamp = DateTime.Now,
                MessageType = actionType,
                Message = message,
                userName = "Profesor23"
            };

            context.LogEntries.Add(logEntry);
            context.SaveChanges();
        }

        // Implement INotifyPropertyChanged interface
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void SetTextBoxes()
        {
            Name = "Name";
            Password = "Password";
            FacNum = "Facultity Number";
            Email = "Email";
            ExpireMonths = "profile expires in (months)";
        }
    }
}
