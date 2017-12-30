using System;
using System.Collections.Generic;

namespace Cop12_BaiTapLanThu5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Arrayn = null;
            List<SalaryWorker> listsalary = new List<SalaryWorker>();
            List<HourlyWorker> listhourly = new List<HourlyWorker>();
            int luachon = 0;
            int n;
            do
            {
                Console.WriteLine("-------------------C# assignment homwork 4th ----------------");
                Console.WriteLine("1. Salary Worker");
                Console.WriteLine("2. HourlyWorker");
                Console.WriteLine("3. Exit");
                Console.WriteLine("Please, select item 1 to 3: ");
                luachon = Int32.Parse(Console.ReadLine());
                switch (luachon)
                {
                    case 1:
                        Console.WriteLine("Input number salaryworker: ");
                        n = Int32.Parse(Console.ReadLine());
                        Arrayn = new int[n]; // create n obj to save n empsalaraworker
                        for (int i = 0; i < Arrayn.Length; i++)
                        {
                            Console.WriteLine("input salaryworker number {0}", i + 1);
                            SalaryWorker sw = new SalaryWorker();
                            sw.Input();
                            listsalary.Add(sw);
                        }
                        Console.WriteLine("List SalaryWorker after input: ");
                        Console.WriteLine("\n{0,-15} {1,-15} {2,-15} {3, -15}", "name", "nnual", "salary", "PaidAmount");
                        for (int i = 0; i < listsalary.Count; i++)
                        {
                            listsalary[i].Output();
                        }
                        Console.WriteLine("List SalaryWorker after sort by PaidAmount with decrease : ");
                        listsalary.Sort();
                        Console.WriteLine("\n{0,-15} {1,-15} {2,-15} {3, -15}", "name", "nnual", "salary", "PaidAmount");
                        for (int i = 0; i < listsalary.Count; i++)
                        {
                            listsalary[i].Output();
                        }
                        Console.WriteLine("List SalaryWorker after sort by NameEmployee with alphabe : ");
                        listsalary.Sort(new SalaryWorker());
                        Console.WriteLine("\n{0,-15} {1,-15} {2,-15} {3, -15}", "name", "nnual", "salary", "PaidAmount");
                        for (int i = 0; i < listsalary.Count; i++)
                        {
                            listsalary[i].Output();
                        }
                        break;

                    case 2:
                        Console.WriteLine("Input number hourlyworker: ");
                        n = Int32.Parse(Console.ReadLine());
                        Arrayn = new int[n];
                        for (int i = 0; i < Arrayn.Length; i++)
                        {
                            Console.WriteLine("input hourlyworker number {0}", i + 1);
                            HourlyWorker hl = new HourlyWorker();
                            hl.Input();
                            listhourly.Add(hl);
                        }
                        Console.WriteLine("List HourlyWorker after input: ");
                        Console.WriteLine("\n{0,-15} {1,-15} {2,-15} {3, -15}", "name", "hourlyrate", "hourlyworked", "PaidAmount");
                        for (int i = 0; i < listhourly.Count; i++)
                        {
                            listhourly[i].Output();
                        }
                        Console.WriteLine("List HourlyWorker after sort by PaidAmount with decrease: ");
                        listhourly.Sort();
                        Console.WriteLine("\n{0,-15} {1,-15} {2,-15} {3, -15}", "name", "hourlyrate", "hourlyworked", "PaidAmount");
                        for (int i = 0; i < listhourly.Count; i++)
                        {
                            listhourly[i].Output();
                        }
                        Console.WriteLine("List HourlyWorker after sort with NameEmployee  with alphabe ");
                        listhourly.Sort( new HourlyWorker());
                        Console.WriteLine("\n{0,-15} {1,-15} {2,-15} {3, -15}", "name", "hourlyrate", "hourlyworked", "PaidAmount");
                        for (int i = 0; i < listsalary.Count; i++)
                        {
                            listhourly[i].Output();
                        }
                        break;
                    case 3:
                        {
                            System.Environment.Exit(1);
                        }
                        break;

                }
            } while (luachon != 3);
            Console.ReadLine();
        }
    }
}
