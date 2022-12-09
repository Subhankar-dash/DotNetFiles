using System;
using System.Collections.Generic;

namespace CS_Ef_DbFirst2.Models
{
    public partial class Department
    {
        public Department()
        {
            int[] a;
            
            Employees = new HashSet<Employee>();
        }

        public int DeptNo { get; set; }
        public string DeptName { get; set; } = null!;
        public string Location { get; set; } = null!;
        public int Capacity { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
