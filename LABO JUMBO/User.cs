using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABO_JUMBO
{
    internal class User
    {
        public string login;
        string password;
        string name;
        string surname;


        public User(string _login, string _password, string _name, string _surname) 
        {
            login = _login;
            password = _password;
            name = _name;
            surname = _surname;
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3}", 
                login, password, name, surname);
        }

        public string NameAndSurname()
        {
            return string.Format("{0} {1}", name, surname);
        }

        public bool IsPasswordCorrect(string p)
        {
            if (password == p) return true;
            return false;
        }

        static public List<User> LoadAllUsers()
        {
            List<User> users = new List<User>();

            using (StreamReader sr = new StreamReader("users.txt"))
            {
                while (!sr.EndOfStream) 
                {
                    string[] inf = sr.ReadLine().Split(' ');
                    User user = new User(inf[0], inf[1], inf[2], inf[3]);
                    users.Add(user);
                }
            }
            return users;
        }

        static public User LoadUserByLogin(string login)
        {
            List<User> users = User.LoadAllUsers();
            User user = users.Where(x => x.login == login).FirstOrDefault();

            return user;
        }
    }
}
