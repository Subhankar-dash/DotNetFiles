using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackGroundThreadLINQ;

namespace BackGroundThreadLINQ
{
    public class Linq
    {
        public Linq()
        {
            var employe = new EmployeeCollection();
            var deptmnt = new DepartmentData();

            Console.WriteLine("enter department name to search");
            string DepartmentName = Console.ReadLine();

            var list = from dpm in deptmnt
                       where dpm.DepartmentName == DepartmentName
                       join emp in employe on dpm.DepartmentNo equals emp.DeptNo
                       select new { name = emp.EmpName, salary = emp.Salary };
            var a = list.ToList();

            if (a.Count != 0)
            {
                foreach (var item in list)
                {
                    Console.WriteLine($"employee name is -: {item.name}");
                    Console.WriteLine($"employee salary is {item.salary}");
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Department not exist");
            }
        }
    }
}
