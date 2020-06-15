using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TKACIKChapterTen
{
    class Employee
    {
        private string _name;
        private int _number;

        //Define constructors
        public Employee()
        {
            _name = ""; _number = 0;
        }

        //parameterized
        public Employee(string n, int num)
        {
            _name = n; _number = num;
        }
        //define properties
        //two backing fields so two uh... things

        public string Name
        {
            get { return _name; }
            set { _name = value; }

        }
        public int Number
        {
            get { return _number; }
            set { _number = value; }
        } 

        //define method to display data for overriding and stuff
        public virtual string displayData()
        {
            string line = "";
            line += "\n Employee Name: " + this.Name;
            line += "\n Employee Number: " + this._number;
            return line;
        }

    }
}
