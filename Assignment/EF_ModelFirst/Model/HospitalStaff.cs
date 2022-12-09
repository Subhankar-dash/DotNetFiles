using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EF_ModelFirst.Model
{
    public class Staff
    {

        
        [Key]
        public int StaffId { get; set; }


        public string Name { get; set; }


        public string StaffCategory { get; set; }


        public string Department { get; set; }
        
        
        public string Education { get; set; }
        
       
        public int Contact { get; set; }
        public int fees { get; set; }
    }
    public class Doctor : Staff
    {
        public int PatienceCount { get; set; }
    }
    public class Nurse : Staff
    {
        public int RoomCount { get; set; }
    }
    public class Technician : Staff
    {
        public int MachineCount { get; set; }
    }
}
