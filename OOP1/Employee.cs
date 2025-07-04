﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Employee
    {
        // Attribute
        private int _id;
        private string _name;
        private string _email;
        private string _phone;

        public Employee()
        {

        }
        public Employee(int _id,string _name, string _email, string _phone)
        {
            this._id= _id;
            this._name= _name;
            Email = _email;
            Phone = _phone;
        }

        // Properties
        public int Id
        {
            get { return _id; } // Getter
            set { _id = value; } // Setter
        }
        public string Name
        {
            set { _name = value; }
            get { return _name; }
        }
        public string Email
        {
            get { return _email; } 
            set { _email = value; }
        }
        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        public void PrintInfor()
        {
            Console.WriteLine($"{_id}\t{_name}\t{_email}\t{_phone}");
        }
        public override string ToString()
        {
            string message = $"{_id}\t{_name}\t{_email}\t{_phone}";
            return message;
        }
    }
}
