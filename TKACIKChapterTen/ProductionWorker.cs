using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TKACIKChapterTen
{
    class ProductionWorker: Employee //the classkeyword derived class: main class
    {
        private int _shiftnumber;
        private double _payrate;

        public ProductionWorker()
        {
            _shiftnumber = 0;
            _payrate = 0;
        }

        public ProductionWorker(string n, int num, int sn, double pr) : base(n, num) //name, number, shiftnumber, payrate : passing from base class
        {
            _shiftnumber = sn; _payrate = pr; 
        }
        //define properties
        public int ShiftNumber
        {
            get { return _shiftnumber; }
            set { _shiftnumber = value; }
        }
        public double PayRate
        {
            get { return _payrate; }
            set { _payrate = value; }
        }
        //define method to display data
        //replace virtual keyword with override keyword
        public override string displayData()
        {
            string line = "";
            line += "\n Employee Name: " + this.Name;
            line += "\n Employee Number: " + this.Number; //It cannot inherit _number, but it can inherit Number, the defined propterty
            line += "\n Employee Shift Number: " + this.ShiftNumber;
            line += "\n Employee Pay Rate: " + this.PayRate;

            return line;
        }
    }
}
