using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemoConsolAppDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // FindEvenNos();


            //StringList();

            List<Employee> employees = new List<Employee>() 
            {
                new Employee() {Empno=110,EmpName="Gauri",Sal=10000,Deptno=70},
            new Employee() {Empno=1,EmpName="Sarang",Sal=10000,Deptno=10},
            new Employee() {Empno=2,EmpName="ShriRam",Sal=10000,Deptno=20},
            new Employee() {Empno=3,EmpName="Simran",Sal=24000,Deptno=30},
            new Employee() {Empno=4,EmpName="Siri",Sal=15000,Deptno=10},
            new Employee() {Empno=5,EmpName="Alexa",Sal=10000,Deptno=10},
            new Employee() {Empno=6,EmpName="Kamal",Sal=10000,Deptno=20},
            };

            var empGroupedByDeptno = employees.OrderBy(d1 => d1.Deptno).GroupBy(d => d.Deptno).
                Where(d2 => (d2.Key == 10 || d2.Key==20 || d2.Key==30 || d2.Key==70) && d2.Count() > 1).ToList();


            foreach (var item in empGroupedByDeptno)
            {
                Console.WriteLine("Deptno= " + item.Key);
                foreach (var empdat in item)
                {
                    Console.WriteLine(empdat.Empno);
                    Console.WriteLine(empdat.EmpName);
                    Console.WriteLine(empdat.Sal);
                    Console.WriteLine(empdat.Deptno);
                }
                Console.WriteLine("----------------------------------");
            }




            //3,4 and 6

            //Whose sal is greater than 10k
            //  var empList = employees.Where(e => e.Sal > 10000).Skip(1).Take(2);

            //2,5
            //var empList = employees.Where(e => e.Sal == 10000).Skip(1).Take(4).Skip(1).Take(2);

            //110,1,2,5,6
            //  var empList = employees.Where(e => e.Sal == 10000).OrderByDescending(d => d.Deptno).Skip(1).Take(4).Skip(1).Take(2);

            //employees.Add(new Employee() {Empno=10,EmpName="Rohan",Sal=16000,Deptno=10 });
            //employees.Remove(employees[3]);

            //var empList = from emp in employees
            //              orderby emp.Sal descending
            //              where emp.Sal > 10000
            //              select emp;

            //foreach (Employee emp in empList)
            //{
            //    Console.WriteLine(emp.Empno);
            //    Console.WriteLine(emp.EmpName);
            //    Console.WriteLine(emp.Sal);
            //    Console.WriteLine(emp.Deptno);
            //    Console.WriteLine("----------");
            //}


            //30-1 
            //20-2
            //10=3

            //var empGroupedByDeptno = from emp in employees
            //                         group emp by emp.Deptno into deptGroup
            //                         orderby deptGroup.Key
            //                         select deptGroup;

            //deptGroup
            //    10
            //    Empno = 1,EmpName = "Sarang",Sal = 10000,Deptno = 10



            //    20
            //    30

            //    70
            //    Empno = 110,EmpName = "Gauri",Sal = 10000,Deptno = 70

            //Show all the employees of deptno=10


            //foreach (var item in empGroupedByDeptno)
            //{
            //    Console.WriteLine("Deptno= " + item.Key);
            //    foreach (var empdat in item)
            //    {
            //        Console.WriteLine(empdat.Empno);
            //        Console.WriteLine(empdat.EmpName);
            //        Console.WriteLine(empdat.Sal);
            //        Console.WriteLine(empdat.Deptno);
            //    }
            //    Console.WriteLine("----------------------------------");
            //}














            Console.Read();
        }

        private static void StringList()
        {
            List<string> list = new List<string>();
            list.Add("Hello");
            list.Add("Arti");
            list.Add("Sukirti");
            list.Add("Amey");
            list.Add("Sujay");
            //length of 4 chars
            //var newlist = from names in list
            //              where names.Length == 4
            //              select names;

            var newlist = list.Where(s => s.Length > 4);


            foreach (var name in newlist)
            {
                Console.WriteLine(name);

            }
        }

        private static void FindEvenNos()
        {
            int[] numbers = new int[10] { 1, 3221, 342, 21, 3522, 6, 2, 622, 662, 224 };
            //var ans = from n in numbers
            //          where n % 2 == 0
            //          select n;

            //Method Syntax---IEnumerable/IList---- eager loading
            var ans = numbers.Where(n => n % 2 == 0);


            foreach (int n in ans)
            {
                Console.WriteLine(n);

            }
        }
    }
}
