using System;
using System.Collections.Generic;
using System.Text;

namespace Cop12_BaiTapLanThu5
{
    class Employee
    {
        private string empName;
        private double paidmount;
        public Employee() { }
        public void Input() 
        {
            Console.WriteLine("input name of employee: ");
            empName = Console.ReadLine();
        }
        public void Output()
        {
            Console.Write("{0,-20}", empName);
        }
        public double PaidMount
        {
            set;
            get;
        }
        public string EMPNAME
        {
            set
            {
                this.empName = value;
            }
            get
            {
                return this.empName;
            }
        }        
        public virtual double calcPaidCheck()
        {
            return 0;
        }        
    }
}
