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
using Welcome.Others;
using DataLayer.Database;
using DataLayer.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Windows.Forms;

namespace UI.Components
{
    /// <summary>
    /// Interaction logic for AddUserView.xaml
    /// </summary>
    public partial class AddUserView : System.Windows.Controls.UserControl
    {
        public AddUserView()
        {
            InitializeComponent();
            var rolesList = Enum.GetValues(typeof(UserRolesEnum))
            .Cast<UserRolesEnum>()
            .Select(v => v.ToString())
            .ToList();

            roleText.ItemsSource = rolesList;
        }

        public void ClosePopUp_CLick(object sender, EventArgs e)
        {
            MainWindow mainWindow = Window.GetWindow(this) as MainWindow;
            if (mainWindow != null)
            {
                mainWindow.closePopUp();
            }
        }

        private void AddUser_Click(object sender, RoutedEventArgs e)
        {
            string message = "";
            try
            {
                // Retrieve values from textboxes and combobox
                string name = nameText.Text;
                string password = passwordText.Text;
                string facNum = facNumText.Text;
                string email = emailText.Text;
                int exp = int.Parse(dateText.Text);
                string selectedRoleString = roleText.SelectedItem as string;

                if (Enum.TryParse(selectedRoleString, out UserRolesEnum selectedRole))
                {
                    // Create a new user object
                    DatabaseUser newUser = new DatabaseUser
                    {
                        Name = name,
                        Password = password,
                        FacNum = facNum,
                        Email = email,
                        expiresDate = DateTime.Now.AddMonths(exp),
                        Role = selectedRole
                    };
                    
                    // Add the user object to the database context
                    using (var context = new DatabaseContext()) // Replace YourDbContext with your actual DbContext class name
                    {
                    
                        context.Users.Add(newUser);
                        context.SaveChanges();
                        message = $"Added new user: {newUser.Name}";
                        LogAction(context, "User Addition", message);
                    }
                }
                else
                {
                    using (var context = new DatabaseContext())
                    {
                        message = "invalid role!";
                        LogAction(context, "Error!", message );
                    }
                        
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
                setTextBoxes();
                MainWindow mainWindow = Window.GetWindow(this) as MainWindow;
                if (mainWindow != null)
                {
                    mainWindow.closePopUp();
                    StudentsList studentsList = mainWindow.GetStudentsList();
                    studentsList?.RefreshData();
                    LoggedDataView loggedData = mainWindow.GetLoggedData();
                    loggedData?.RefreshData();
                }
                System.Windows.MessageBox.Show(message, "Message", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        static void LogAction(DatabaseContext context, string actionType, string message)
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

        private void setTextBoxes()
        {
            nameText.Text = "Name";
            passwordText.Text = "Password";
            facNumText.Text = "Facultity Number";
            emailText.Text = "Email";
            dateText.Text = "profile expires in (months)";
            roleText.SelectedItem = null;
        }
    }
}
