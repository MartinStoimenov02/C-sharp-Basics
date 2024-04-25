using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Welcome.ViewModel;

namespace Welcome.View
{
    public class UserView
    {
        UserViewModel _viewModel;

        public UserView(UserViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public void Display()
        {
            Console.WriteLine("Welcome");
            Console.WriteLine("User: "+_viewModel.Name);
            Console.WriteLine("Role: " + _viewModel.Role);
            Console.WriteLine("Faculty Number: " + _viewModel.FacNum);
            Console.WriteLine("Email: "+_viewModel.Email);
        }

        public void DisplayAtOneRow()
        {
            Console.WriteLine("Welcome " + _viewModel.Name + " with role: " + _viewModel.Role + 
                " and faculty Number: " + _viewModel.FacNum + " and Email: " + _viewModel.Email);
        }

        public void DisplayError()
        {
            throw new Exception("user error");
        }
    }
}
