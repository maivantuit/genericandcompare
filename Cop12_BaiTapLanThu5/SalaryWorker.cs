using System;
using System.Collections.Generic;
using System.Text;

namespace Cop12_BaiTapLanThu5
{
    class SalaryWorker : Employee, IComparable<SalaryWorker>, IComparer<SalaryWorker>
    {
        private double annual, salary;
        public SalaryWorker() { }
        public void Input()            
        {
            base.Input();
            Console.WriteLine("input annual: ");
            annual = Double.Parse(Console.ReadLine());
            Console.WriteLine("input salary: ");
            salary = Double.Parse(Console.ReadLine());
        }
        public override double calcPaidCheck()
        {
            double paidamountofsalaryworker = base.PaidMount;
            paidamountofsalaryworker = annual - salary/12;
            return paidamountofsalaryworker;
        }
        public void Output()
        {
            base.Output();
            Console.WriteLine("{0,-15} {1,-15} {2,-15}\n",annual,salary,calcPaidCheck());
        }
        // sắp xếp lương giảm dần với SalaryWorker               
        public int CompareTo(SalaryWorker other)
        {
            if (this.calcPaidCheck() < other.calcPaidCheck())
            {
                return 1;
            }
            else if(this.calcPaidCheck() > other.calcPaidCheck())
            {
                return -1;
            }
            else
            {
                return 0;
            }
            //continue
        }
        // sắp xếp tên theo Alphabe       
        public int Compare(SalaryWorker x, SalaryWorker y)
        {
            return String.Compare(x.EMPNAME,y.EMPNAME);
        }
    }
}
