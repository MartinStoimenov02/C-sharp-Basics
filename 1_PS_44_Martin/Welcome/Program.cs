using System.Data;
using Welcome.Model;
using Welcome.Others;
using Welcome.View;
using Welcome.ViewModel;

namespace Welcome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            User user = new User(){
                Name = "Test", 
                Password = "123", 
                Role = UserRolesEnum.ANONYMOUS, 
                FacNum = "12345", 
                Email = "email@example.com" 
            };
            UserViewModel userViewModel = new UserViewModel(user);
            UserView userView = new UserView(userViewModel);
            userView.Display();
            userView.DisplayAtOneRow();
            Console.ReadKey();
        }
    }
}