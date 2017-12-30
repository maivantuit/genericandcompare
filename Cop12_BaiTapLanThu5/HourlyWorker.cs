using System;
using System.Collections.Generic;
using System.Text;
namespace Cop12_BaiTapLanThu5
{
    class HourlyWorker : Employee, IComparable<HourlyWorker>, IComparer<HourlyWorker>
    {
        private double hourlyrate, hourlyworked;
        public HourlyWorker()
        {
        }

        public void Input()
        {
            base.Input();
            Console.WriteLine("input hourlyrate: ");
            hourlyrate = Double.Parse(Console.ReadLine());
            Console.WriteLine("input hourlyworked: ");
            hourlyworked = Double.Parse(Console.ReadLine());
        }
        public override double calcPaidCheck()
        {
            double PaidMountofhourlyworker = base.PaidMount;
            PaidMountofhourlyworker = hourlyrate * hourlyworked;
            return PaidMountofhourlyworker;
        }
        public void Output()
        {
            base.Output();
            Console.WriteLine("{0,-15} {1,-15} {2,-15}\n", hourlyrate, hourlyworked, calcPaidCheck());
        }

      
        // sắp xếp lương giảm dần với SalaryWorker               
        public int CompareTo(HourlyWorker other)
        {
            if (this.calcPaidCheck() < other.calcPaidCheck())
            {
                return 1;
            }
            else if (this.calcPaidCheck() > other.calcPaidCheck())
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
        public int Compare(HourlyWorker x, HourlyWorker y)
        {
            return String.Compare(x.EMPNAME, y.EMPNAME);
        }


    }
}
