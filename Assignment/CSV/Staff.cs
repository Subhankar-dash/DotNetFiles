using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using CsvHelper;
using CsvHelper.Configuration;

namespace CSV
{
    public class Staff
    {
        public int StaffId;
        public string? Name;
        public string? StaffCategory;
        public string? Department;
        public string? Education;
        public int Contact;
        public int fees;
        public int income;
        public double Tax;
        public double HospitalShare;
        public double GrossSalary;
    }
    public class Doctor : Staff
    {
        public int PatienceCount;
    }
    public class Nurse : Staff
    {
        public int RoomCount;
    }
    public class Technician : Staff
    {
        public int MachineCount;
    }
}
