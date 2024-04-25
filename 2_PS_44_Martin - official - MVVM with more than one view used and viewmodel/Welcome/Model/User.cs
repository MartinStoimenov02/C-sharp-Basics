using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Welcome.Others;

namespace Welcome.Model
{
    public class User
    {
        private string password;
        public virtual int Id { get; set; } // The virtual keyword is used to modify a method, property, indexer, or event declaration and allow for it to be overridden in a derived class.
        public string Name { get; set; }
        public string Password { get {
                return password;
            }
            set {
                password = EncryptPassword(value);
            }
        }
        public string FacNum { get; set; }
        public string Email { get; set; }
        public UserRolesEnum Role { get; set; }
        public DateTime? expiresDate { get; set; }

        //public User(string name, string password, UserRolesEnum role, string facNum, string email)
        //{
            //Name = name;
            //Password = EncryptPassword(password);
            //Role = role;
            //FacNum = facNum;
            //Email = email;
        //}

        private string EncryptPassword(string password)
        {
            try
            {
                byte[] encData_byte = new byte[password.Length];
                encData_byte = System.Text.Encoding.UTF8.GetBytes(password);
                string encodedData = Convert.ToBase64String(encData_byte); //Converts an array of 8-bit unsigned integers to its equivalent string representation that is encoded with base-64 digits.
                return encodedData;
            }
            catch (Exception ex)
            {
                throw new Exception("Error in base64Encode" + ex.Message);
            }
        }

        public string DecryptPassword(string encryptedPassword)
        {
            System.Text.UTF8Encoding encoder = new System.Text.UTF8Encoding();
            System.Text.Decoder utf8Decode = encoder.GetDecoder();
            byte[] todecode_byte = Convert.FromBase64String(encryptedPassword);
            int charCount = utf8Decode.GetCharCount(todecode_byte, 0, todecode_byte.Length);
            char[] decoded_char = new char[charCount];
            utf8Decode.GetChars(todecode_byte, 0, todecode_byte.Length, decoded_char, 0);
            string result = new String(decoded_char);
            return result;
        }
    }
}
