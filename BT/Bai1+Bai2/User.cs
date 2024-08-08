using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Bai1_Bai2
{
    public class User
    {
        public string _emailUser { get; set; }
        public string _passWord { get; set; }

        public User(string email, string password)
        {
            _emailUser = email;
            _passWord = password;
        }
  /*       @"^[^\s@]+@[^\s@]+\.[^\s@]+$ */
        public void Login()
        {
            bool hasUppercase = Regex.IsMatch(_passWord, @"[A-Z]");
            bool hasLowercase = Regex.IsMatch(_passWord, @"[a-z]");
            bool hasDigit = Regex.IsMatch(_passWord, @"\d");
            bool hasSpecialChar = Regex.IsMatch(_passWord, @"[!@#$%^&*~]");
            bool isLengthValid = _passWord.Length >= 6;

            if (!Regex.IsMatch(_emailUser, @"^[^\s@]+@[^\s@]+\.[^\s@]+$"))
            {
                Console.WriteLine("Password khong hop le!");
            }

            if (hasUppercase && hasLowercase & hasDigit & hasSpecialChar & isLengthValid)
            {
                var ranDom = GenerateOTP(6);
                Console.WriteLine(ranDom);
            }
            else {
                Console.WriteLine("Password khong hop le!");
                if (!hasUppercase) Console.WriteLine("Password phai co 1 ki tu viet hoa!");
                if (!hasLowercase) Console.WriteLine("Password phai co 1 ki tu viet thuong!");
                if (!hasDigit) Console.WriteLine("Password phai co it 1 so!"); 
                if (!hasSpecialChar) Console.WriteLine("Password phai co it 1 ki tu dac biet!");
                if (!isLengthValid) Console.WriteLine("Password phai co do dai it nhat la 6!");
            }

           

        }

        public string GenerateOTP(int length)
        {
            const string chars = "0123456789";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
