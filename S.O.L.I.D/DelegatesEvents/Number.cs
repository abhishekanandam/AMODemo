using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S.O.L.I.D.DelegatesEvents
{
    class Number
    {
        private PrintHelper _printHelper;
        private int _value;


        public int Value
        {
            get { return _value; }
            set { _value = value; }
        }


        public Number(int val)
        {
            _value = val;

            _printHelper = new PrintHelper();

            _printHelper.beforePrintEvent += printHelper_beforePrintEvent;

        }

        private void printHelper_beforePrintEvent(string msg)
        {
            Console.WriteLine("Before Print Helper Event");
        }

        public void PrintMoney()
        {
            _printHelper.PrintMoney(_value);
        }

        public void PrintNumber()
        {
            _printHelper.PrintNumber(_value);
        }

    }
}
