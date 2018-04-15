using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2._5
{
    class User
    {
        string login;
        string name;
        string surname;
        uint age;
        DateTime Date;
        public User()
        {
            login = "admin";
            name = "admin";
            surname = "surname";
            age = 0;
            Date = new DateTime(1998, 4, 29);
        }
        public User(int year, int month, int day)
        {
            Date = new DateTime(year, month, day);
        }
        public string Login
        {
            get
            {
                return login;
            }
            set
            {
                login = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                surname = value;
            }
        }
        public uint Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        public DateTime fullDate
        {
            get
            {
                return Date;
            }
            set
            {
                Date = value;
            }
        }
    }
}
