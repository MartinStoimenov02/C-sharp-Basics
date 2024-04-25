using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Welcome.ViewModel;
using Welcome.Model;
using Welcome.Others;

namespace Welcome.ViewModel
{
    public class UserViewModel
    {
        private User _user { get; set; }
        public string Name
        {
            get { return _user.Name; }
            set { _user.Name = value; }
        }

        public UserRolesEnum Role
        {
            get { return _user.Role; }
            set { _user.Role = value; }
        }

        public string FacNum
        {
            get { return _user.FacNum; }
            set { _user.FacNum = value; }
        }

        public string Email
        {
            get { return _user.Email; }
            set { _user.Email = value; }
        }

        public UserViewModel(User user)
        {
            _user = user;
        }
    }
}
