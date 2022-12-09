using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackGroundThreadLINQ
{

    public class Employee
    {
        public int EmpNo { get; set; }
        public string EmpName { get; set; }
        public int DeptNo { get; set; }
        public int Salary { get; set; }
        public string Desgination { get; set; }
    }
    public class Department
    {
        public int DepartmentNo { get; set; }
        public string DepartmentName { get; set; }
        public int DepartmentCapacity { get; set; }
        public string DepartmentLocation { get; set; }
    }
    public class EmployeeCollection : List<Employee>
    {
        public EmployeeCollection()
        {
            Add(new Employee() { EmpNo = 1001, EmpName = "YashodaNandan", DeptNo = 1, Salary = 53000, Desgination = "senior" });
            Add(new Employee() { EmpNo = 1002, EmpName = "DevkiNandan", DeptNo = 4, Salary = 33000, Desgination = "senior" });
            Add(new Employee() { EmpNo = 1003, EmpName = "RadheShyam", DeptNo = 5, Salary = 63000, Desgination = "senior" });
            Add(new Employee() { EmpNo = 1004, EmpName = "Gopal", DeptNo = 7, Salary = 13000, Desgination = "senior" });
            Add(new Employee() { EmpNo = 1005, EmpName = "Govind", DeptNo = 8, Salary = 93000, Desgination = "senior" });
            Add(new Employee() { EmpNo = 1006, EmpName = "Mohan", DeptNo = 11, Salary = 63000, Desgination = "senior" });
            Add(new Employee() { EmpNo = 1007, EmpName = "Madhav", DeptNo = 5, Salary = 23000, Desgination = "senior" });
            Add(new Employee() { EmpNo = 1008, EmpName = "Milind", DeptNo = 2, Salary = 53000, Desgination = "senior" });
            Add(new Employee() { EmpNo = 1009, EmpName = "Vasudev", DeptNo = 3, Salary = 63000, Desgination = "senior" });
            Add(new Employee() { EmpNo = 1010, EmpName = "Shridhar", DeptNo = 6, Salary = 83000, Desgination = "senior" });
            Add(new Employee() { EmpNo = 1011, EmpName = "subhankar", DeptNo = 9, Salary = 58000, Desgination = "junior" });
            Add(new Employee() { EmpNo = 1012, EmpName = "subham", DeptNo = 10, Salary = 53000, Desgination = "junior" });
            Add(new Employee() { EmpNo = 1013, EmpName = "subha", DeptNo = 13, Salary = 67000, Desgination = "junior" });
            Add(new Employee() { EmpNo = 1014, EmpName = "subhu", DeptNo = 12, Salary = 18000, Desgination = "junior" });
            Add(new Employee() { EmpNo = 1015, EmpName = "subhaa", DeptNo = 14, Salary = 83000, Desgination = "junior" });
            Add(new Employee() { EmpNo = 1016, EmpName = "suvankar", DeptNo = 15, Salary = 163000, Desgination = "junior" });
            Add(new Employee() { EmpNo = 1017, EmpName = "subhu", DeptNo = 16, Salary = 43000, Desgination = "junior" });
            Add(new Employee() { EmpNo = 1018, EmpName = "subhashree", DeptNo = 17, Salary = 83000, Desgination = "junior" });
            Add(new Employee() { EmpNo = 1019, EmpName = "subhadeep", DeptNo = 18, Salary = 93000, Desgination = "junior" });
            Add(new Employee() { EmpNo = 1020, EmpName = "subrat", DeptNo = 19, Salary = 73000, Desgination = "junior" });
            Add(new Employee() { EmpNo = 1021, EmpName = "abhinandan", DeptNo = 20, Salary = 53000, Desgination = "Fresher" });
            Add(new Employee() { EmpNo = 1022, EmpName = "amit", DeptNo = 1, Salary = 33000, Desgination = "Fresher" });
            Add(new Employee() { EmpNo = 1023, EmpName = "amit", DeptNo = 2, Salary = 63000, Desgination = "Fresher" });
            Add(new Employee() { EmpNo = 1024, EmpName = "amit", DeptNo = 3, Salary = 13000, Desgination = "Fresher" });
            Add(new Employee() { EmpNo = 1025, EmpName = "marshal", DeptNo = 4, Salary = 93000, Desgination = "Fresher" });
            Add(new Employee() { EmpNo = 1026, EmpName = "suman", DeptNo = 5, Salary = 63000, Desgination = "Fresher" });
            Add(new Employee() { EmpNo = 1027, EmpName = "sudhanshu", DeptNo = 6, Salary = 23000, Desgination = "Fresher" });
            Add(new Employee() { EmpNo = 1028, EmpName = "mitravanu", DeptNo = 7, Salary = 53000, Desgination = "Fresher" });
            Add(new Employee() { EmpNo = 1029, EmpName = "prateek", DeptNo = 8, Salary = 63000, Desgination = "Fresher" });
            Add(new Employee() { EmpNo = 1030, EmpName = "durgaMadhav", DeptNo = 9, Salary = 83000, Desgination = "Fresher" });
            Add(new Employee() { EmpNo = 1031, EmpName = "subhankar", DeptNo = 10, Salary = 58000, Desgination = "Fresher" });
            Add(new Employee() { EmpNo = 1032, EmpName = "gupteshwar", DeptNo = 11, Salary = 53000, Desgination = "Fresher" });
            Add(new Employee() { EmpNo = 1033, EmpName = "rony", DeptNo = 12, Salary = 67000, Desgination = "Fresher" });
            Add(new Employee() { EmpNo = 1034, EmpName = "girija", DeptNo = 13, Salary = 18000, Desgination = "Fresher" });
            Add(new Employee() { EmpNo = 1035, EmpName = "rahul", DeptNo = 14, Salary = 83000, Desgination = "Fresher" });
            Add(new Employee() { EmpNo = 1036, EmpName = "rohit", DeptNo = 15, Salary = 163000, Desgination = "Fresher" });
            Add(new Employee() { EmpNo = 1037, EmpName = "bhagyashree", DeptNo = 16, Salary = 43000, Desgination = "Fresher" });
            Add(new Employee() { EmpNo = 1038, EmpName = "subrat", DeptNo = 17, Salary = 83000, Desgination = "Fresher" });
            Add(new Employee() { EmpNo = 1039, EmpName = "subhadeep", DeptNo = 18, Salary = 93000, Desgination = "Fresher" });
            Add(new Employee() { EmpNo = 1040, EmpName = "sonalisha", DeptNo = 19, Salary = 73000, Desgination = "Fresher" });
            Add(new Employee() { EmpNo = 1041, EmpName = "subhankar", DeptNo = 20, Salary = 158000, Desgination = "Manager" });
            Add(new Employee() { EmpNo = 1042, EmpName = "sonalisha", DeptNo = 11, Salary = 153000, Desgination = "Manager" });
            Add(new Employee() { EmpNo = 1043, EmpName = "sonu", DeptNo = 2, Salary = 267000, Desgination = "Manager" });
            Add(new Employee() { EmpNo = 1044, EmpName = "Ram", DeptNo = 4, Salary = 180000, Desgination = "Manager" });
            Add(new Employee() { EmpNo = 1045, EmpName = "Jagganath", DeptNo = 18, Salary = 183000, Desgination = "Manager" });
            Add(new Employee() { EmpNo = 1046, EmpName = "shiv", DeptNo = 19, Salary = 263000, Desgination = "Manager" });
            Add(new Employee() { EmpNo = 1047, EmpName = "Krishna", DeptNo = 8, Salary = 243000, Desgination = "Manager" });
            Add(new Employee() { EmpNo = 1048, EmpName = "Ganesh", DeptNo = 14, Salary = 183000, Desgination = "Manager" });
            Add(new Employee() { EmpNo = 1049, EmpName = "Parvati", DeptNo = 3, Salary = 193000, Desgination = "Manager" });
            Add(new Employee() { EmpNo = 1050, EmpName = "Hanuman", DeptNo = 9, Salary = 273000, Desgination = "Manager" });


        }
    }
    public class DepartmentData : List<Department>
    {
        public DepartmentData()
        {
            Add(new Department() { DepartmentNo = 1, DepartmentCapacity = 10, DepartmentLocation = "pune", DepartmentName = "IT" });
            Add(new Department() { DepartmentNo = 2, DepartmentCapacity = 15, DepartmentLocation = "pune", DepartmentName = "CTD" });
            Add(new Department() { DepartmentNo = 3, DepartmentCapacity = 100, DepartmentLocation = "delhi", DepartmentName = "ACCTS" });
            Add(new Department() { DepartmentNo = 4, DepartmentCapacity = 50, DepartmentLocation = "mumbai", DepartmentName = "HRD" });
            Add(new Department() { DepartmentNo = 5, DepartmentCapacity = 5, DepartmentLocation = "mumbai", DepartmentName = "SYS" });
            Add(new Department() { DepartmentNo = 6, DepartmentCapacity = 20, DepartmentLocation = "pune", DepartmentName = "Admin" });
            Add(new Department() { DepartmentNo = 7, DepartmentCapacity = 35, DepartmentLocation = "pune", DepartmentName = "L&T" });
            Add(new Department() { DepartmentNo = 8, DepartmentCapacity = 10, DepartmentLocation = "delhi", DepartmentName = "BDA" });
            Add(new Department() { DepartmentNo = 9, DepartmentCapacity = 500, DepartmentLocation = "mumbai", DepartmentName = "HR" });
            Add(new Department() { DepartmentNo = 10, DepartmentCapacity = 45, DepartmentLocation = "mumbai", DepartmentName = "developer" });
            Add(new Department() { DepartmentNo = 11, DepartmentCapacity = 10, DepartmentLocation = "pune", DepartmentName = "dotnet" });
            Add(new Department() { DepartmentNo = 12, DepartmentCapacity = 15, DepartmentLocation = "pune", DepartmentName = "java" });
            Add(new Department() { DepartmentNo = 13, DepartmentCapacity = 107, DepartmentLocation = "delhi", DepartmentName = "angular" });
            Add(new Department() { DepartmentNo = 14, DepartmentCapacity = 48, DepartmentLocation = "mumbai", DepartmentName = "nodejs" });
            Add(new Department() { DepartmentNo = 15, DepartmentCapacity = 22, DepartmentLocation = "mumbai", DepartmentName = "sql" });
            Add(new Department() { DepartmentNo = 16, DepartmentCapacity = 10, DepartmentLocation = "pune", DepartmentName = "data science" });
            Add(new Department() { DepartmentNo = 17, DepartmentCapacity = 35, DepartmentLocation = "pune", DepartmentName = "devOP" });
            Add(new Department() { DepartmentNo = 18, DepartmentCapacity = 27, DepartmentLocation = "delhi", DepartmentName = "python" });
            Add(new Department() { DepartmentNo = 19, DepartmentCapacity = 53, DepartmentLocation = "mumbai", DepartmentName = "Application" });
            Add(new Department() { DepartmentNo = 20, DepartmentCapacity = 44, DepartmentLocation = "mumbai", DepartmentName = "Testing" });
        }
    }

}
