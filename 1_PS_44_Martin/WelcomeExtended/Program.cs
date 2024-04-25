using System.Data;
using Welcome.Others;
using Welcome.ViewModel;
using Welcome.View;
using Welcome.Model;
using static WelcomeExtended.Others.Delegates;
using System.Xml.Linq;
using WelcomeExtended.Loggers;
using Microsoft.Extensions.Logging;
using WelcomeExtended.Data;
using WelcomeExtended.Helpers;


namespace WelcomeExtended
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                UserData userData = new UserData();

                User studentUser = new User()
                {
                    Name = "Student",
                    Password = "123",
                    Role = UserRolesEnum.STUDENT,
                    FacNum = "0000",
                    Email = "student1@email.com"
                };

                User student2 = new User()
                {
                    Name = "Student2",
                    Password = "123",
                    Role = UserRolesEnum.STUDENT,
                    FacNum = "00001",
                    Email = "student2@email.com"
                };

                User teacher1 = new User()
                {
                    Name = "Teacher",
                    Password = "1234",
                    Role = UserRolesEnum.PROFESSOR,
                    FacNum = "",
                    Email = "teacher1@email.com"
                };

                User admin1 = new User()
                {
                    Name = "Admin",
                    Password = "12345",
                    Role = UserRolesEnum.ADMIN,
                    FacNum = "",
                    Email = "admin1@email.com"
                };

                userData.AddUser(studentUser);
                userData.AddUser(student2);
                userData.AddUser(teacher1);
                userData.AddUser(admin1);
                Console.Write("username:");
                string username = Console.ReadLine();
                Console.Write("password:");
                string password = Console.ReadLine();
                //Console.ReadKey();


                string errorMessage;
                if (userData.ValidateCredentials(username, password, out errorMessage)) //this userData parameter allows to call this method from UserHelper class, by userData object
                {
                    User user = userData.GetUser(username, password);
                    Console.WriteLine("Login Successfuly");
                    Console.WriteLine(user.toString());
                    var loginSuccessFilePath = "C:\\Users\\Marty\\Downloads\\login_success.txt";
                    var loggerSuccess = new FileLoggerSuccessLogin(loginSuccessFilePath);
                    if (errorMessage == "")
                    {
                        loggerSuccess.LogInformation($"user {user.Name} login succesfully!");
                    }
                }
                else
                {
                    Console.WriteLine("Login Denied: "+ errorMessage);
                    var loginDeniedFilePath = "C:\\Users\\Marty\\Downloads\\login_error.txt";
                    var loggerError = new FileLoggerDeniedLogin(loginDeniedFilePath);
                    loggerError.LogError(errorMessage);
                }
            }
            catch (Exception e)
            {
                var log = new ActionOnError(Log); //call Log method from class Delegates, using ActionOnError method.
                log(e.Message); //then pass the error message parameter to the Log method
                var logFilePath = "C:\\Users\\Marty\\Downloads\\my_log.txt";
                var logger = new FileLogger(logFilePath);
                logger.LogError(e.Message);
            }
            finally
            {
                // Console.WriteLine("Executed in any case!");
            }
        }

        static void Log(string message)
        {

            Console.WriteLine(message);
        }

    }
}