using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_2_v3
{
    class Person
    {
        private string _firstName; 
        private string _lastName; 
        private System.DateTime _dateOfBirth; 

        public Person(string name, string lname, DateTime dob)
        {
            if (name.Trim().Length > 0) //Удаляет все начальные и конечные символы пробела из текущей строки.
                _firstName = name;
            else
                _firstName = "Иван";
            if (lname.Trim().Length > 0)
                _lastName = lname;
            else
                _lastName = "Иванов";
            if (dob.Year > 1900)
                _dateOfBirth = dob;
            else
                _dateOfBirth = new DateTime(2000, 1, 1);
        }

        public Person()
        {
            _firstName = "Дмитрий";
            _lastName = "Цицульников";
            _dateOfBirth = new DateTime(2000, 06, 29);
        }

        
        public string FirstName
        {
            get
            {
                return _firstName;
            }

            set
            {
                _firstName = value;
            }

        }
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }

        }
        public DateTime DateOfBirth
        {
            get
            {
                return _dateOfBirth;

            }
            set
            {
                _dateOfBirth = value;
            }

        }

        private int YearOfBirth
        {
            get
            {
                return _dateOfBirth.Year;
            }

            set
            {
                _dateOfBirth = new DateTime(value, _dateOfBirth.Month, _dateOfBirth.Day);
            }
        }
        public string ToFullString() //это для главного квадратного колобка
        {
            return "Имя: " + _firstName + "\n" +
                   "Фамилия: " + _lastName + "\n" +
                   "Дата рождения: " + _dateOfBirth.ToLongDateString();
        }

        public string ToShortString() //а это для меня
        {
            return "Имя: " + _firstName + "\n" +
                "Фамилия: " + _lastName + "\n" +
                "Дата рождения: " + _dateOfBirth.ToLongDateString();
        }

    }

}