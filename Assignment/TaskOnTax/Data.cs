using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskOnTax;

namespace TaskOnTax
{

    public class Data
    {

        public List<Doctor> DoctorData = new List<Doctor>();

        public Data()
        {

            Doctor doctor1 = new Doctor();
            doctor1.StaffId = 1;
            doctor1.Name = "subhankar";
            doctor1.Department = "Heart";
            doctor1.Contact = 2345678;
            doctor1.fees = 1000;
            doctor1.PatienceCount = 10;
            doctor1.StaffCategory = "Doctor";
            doctor1.Education = "mbbs";


            Doctor doctor2 = new Doctor();

            doctor2.StaffId = 2;
            doctor2.Name = "subha";
            doctor2.Department = "Cancer";
            doctor2.Contact = 2345645;
            doctor2.fees = 10000;
            doctor2.PatienceCount = 09;
            doctor2.StaffCategory = "Doctor";
            doctor2.Education = "mbbs";

            Doctor doctor3 = new Doctor();
            doctor3.StaffId = 3;
            doctor3.Name = "sonalisha";
            doctor3.Department = "ENT";
            doctor3.Contact = 2345623;
            doctor3.fees = 9000;
            doctor3.PatienceCount = 10;
            doctor3.StaffCategory = "Doctor";
            doctor3.Education = "mbbs";

            Doctor doctor4 = new Doctor();
            doctor4.StaffId = 4;
            doctor4.Name = "sona";
            doctor4.Department = "Heart";
            doctor4.Contact = 2895678;
            doctor4.fees = 4000;
            doctor4.PatienceCount = 04;
            doctor4.StaffCategory = "Doctor";
            doctor4.Education = "mbbs";

            Doctor doctor5 = new Doctor();
            doctor5.StaffId = 5;
            doctor5.Name = "sonu";
            doctor5.Department = "Cancer";
            doctor5.Contact = 2347778;
            doctor5.fees = 2000;
            doctor5.PatienceCount = 06;
            doctor5.StaffCategory = "Doctor";
            doctor5.Education = "mbbs";

            Doctor doctor6 = new Doctor();
            doctor6.StaffId = 6;
            doctor6.Name = "barsha";
            doctor6.Department = "ENT";
            doctor6.Contact = 2343378;
            doctor6.fees = 1000;
            doctor6.PatienceCount = 04;
            doctor6.StaffCategory = "Doctor";
            doctor6.Education = "mbbs";

            Doctor doctor7 = new Doctor();
            doctor7.StaffId = 7;
            doctor7.Name = "monalisha";
            doctor7.Department = "Heart";
            doctor7.Contact = 2388678;
            doctor7.fees = 4000;
            doctor7.PatienceCount = 03;
            doctor7.StaffCategory = "Doctor";
            doctor7.Education = "mbbs";

            Doctor doctor8 = new Doctor();
            doctor8.StaffId = 8;
            doctor8.Name = "monu";
            doctor8.Department = "Cancer";
            doctor8.Contact = 2347778;
            doctor8.fees = 1000;
            doctor8.PatienceCount = 05;
            doctor8.StaffCategory = "Doctor";
            doctor8.Education = "mbbs";

            Doctor doctor9 = new Doctor();
            doctor9.StaffId = 9;
            doctor9.Name = "mona";
            doctor9.Department = "ENT";
            doctor9.Contact = 2322678;
            doctor9.fees = 7000;
            doctor9.PatienceCount = 04;
            doctor9.StaffCategory = "Doctor";
            doctor9.Education = "mbbs";

            Doctor doctor10 = new Doctor();
            doctor10.StaffId = 10;
            doctor10.Name = "siddharth";
            doctor10.Department = "Heart";
            doctor10.Contact = 2345678;
            doctor10.fees = 1000;
            doctor10.PatienceCount = 10;
            doctor10.StaffCategory = "Doctor";
            doctor10.Education = "mbbs";

            Doctor doctor11 = new Doctor();
            doctor11.StaffId = 11;
            doctor11.Name = "sid";
            doctor11.Department = "Cancer";
            doctor11.Contact = 2348878;
            doctor11.fees = 7000;
            doctor11.PatienceCount = 20;
            doctor11.StaffCategory = "Doctor";
            doctor11.Education = "mbbs";

            Doctor doctor12 = new Doctor();
            doctor12.StaffId = 12;
            doctor12.Name = "snigdha";
            doctor12.Department = "ENT";
            doctor12.Contact = 2344478;
            doctor12.fees = 1000;
            doctor12.PatienceCount = 30;
            doctor12.StaffCategory = "Doctor";
            doctor12.Education = "mbbs";

            Doctor doctor13 = new Doctor();
            doctor13.StaffId = 13;
            doctor13.Name = "bhagyashree";
            doctor13.Department = "Heart";
            doctor13.Contact = 2347658;
            doctor13.fees = 6000;
            doctor13.PatienceCount = 50;
            doctor13.StaffCategory = "Doctor";
            doctor13.Education = "mbbs";

            Doctor doctor14 = new Doctor();
            doctor14.StaffId = 14;
            doctor14.Name = "debasish";
            doctor14.Department = "Cancer";
            doctor14.Contact = 2367678;
            doctor14.fees = 6000;
            doctor14.PatienceCount = 30;
            doctor14.StaffCategory = "Doctor";
            doctor14.Education = "mbbs";

            Doctor doctor15 = new Doctor();
            doctor15.StaffId = 15;
            doctor15.Name = "rohan";
            doctor15.Department = "ENT";
            doctor15.Contact = 2343978;
            doctor15.fees = 8000;
            doctor15.PatienceCount = 90;
            doctor15.StaffCategory = "Doctor";
            doctor15.Education = "mbbs";

            Doctor doctor16 = new Doctor();
            doctor16.StaffId = 16;
            doctor16.Name = "abhijeet";
            doctor16.Department = "Heart";
            doctor16.Contact = 2332178;
            doctor16.fees = 8000;
            doctor16.PatienceCount = 80;
            doctor16.StaffCategory = "Doctor";
            doctor16.Education = "mbbs";

            Doctor doctor17 = new Doctor();
            doctor17.StaffId = 17;
            doctor17.Name = "sai";
            doctor17.Department = "Cancer";
            doctor17.Contact = 2354378;
            doctor17.fees = 9000;
            doctor17.PatienceCount = 90;
            doctor17.StaffCategory = "Doctor";
            doctor17.Education = "mbbs";

            Doctor doctor18 = new Doctor();
            doctor18.StaffId = 18;
            doctor18.Name = "vikas";
            doctor18.Department = "ENT";
            doctor18.Contact = 2345578;
            doctor18.fees = 7000;
            doctor18.PatienceCount = 70;
            doctor18.StaffCategory = "Doctor";
            doctor18.Education = "mbbs";

            Doctor doctor19 = new Doctor();
            doctor19.StaffId = 19;
            doctor19.Name = "saivikas";
            doctor19.Department = "Heart";
            doctor19.Contact = 2765678;
            doctor19.fees = 5000;
            doctor19.PatienceCount = 50;
            doctor19.StaffCategory = "Doctor";
            doctor19.Education = "mbbs";

            Doctor doctor20 = new Doctor();
            doctor20.StaffId = 20;
            doctor20.Name = "satya";
            doctor20.Department = "Cancer";
            doctor20.Contact = 2896678;
            doctor20.fees = 2000;
            doctor20.PatienceCount = 10;
            doctor20.StaffCategory = "Doctor";
            doctor20.Education = "mbbs";

            DoctorData.Add(doctor1);
            DoctorData.Add(doctor2);
            DoctorData.Add(doctor3);
            DoctorData.Add(doctor4);
            DoctorData.Add(doctor5);
            DoctorData.Add(doctor6);
            DoctorData.Add(doctor7);
            DoctorData.Add(doctor8);
            DoctorData.Add(doctor9);
            DoctorData.Add(doctor10);
            DoctorData.Add(doctor11);
            DoctorData.Add(doctor12);
            DoctorData.Add(doctor13);
            DoctorData.Add(doctor14);
            DoctorData.Add(doctor15);
            DoctorData.Add(doctor16);
            DoctorData.Add(doctor17);
            DoctorData.Add(doctor18);
            DoctorData.Add(doctor19);
            DoctorData.Add(doctor20);
        }

    }

}
