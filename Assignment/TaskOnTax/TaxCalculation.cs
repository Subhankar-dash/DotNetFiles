using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOnTax
{
    public class Tax
    {
        // update in same slip
         public void UpdateINSameCollection(List<Doctor> DoctorData, int item)
        {


            Account account = new Account();


            DoctorData[item].income = account.Getincome(DoctorData[item].fees, DoctorData[item].PatienceCount);
            DoctorData[item].Tax = account.Tax(DoctorData[item].income);
            DoctorData[item].HospitalShare = account.HospitalShare(DoctorData[item].income);
            DoctorData[item].GrossSalary = account.GrossSalary(DoctorData[item].income, DoctorData[item].Tax, DoctorData[item].HospitalShare);
            Console.WriteLine($"this is UpdateINSameCollection {DoctorData[item].StaffId}");






        }

        // store in master file

        public async void StoreInAll(List<Doctor> DoctorData, int item)
        {
            // Console.WriteLine("StoreInAll called");

            Account account = new Account();
            string Path = $@"c:\All.txt";

            if (item == 0)
            {
                FileStream filestream = new FileStream(Path, FileMode.OpenOrCreate);
                StreamWriter streamwrite = new StreamWriter(filestream);


                streamwrite.WriteLine();
                streamwrite.WriteLine($"Employee name -: {DoctorData[item].Name}");
                streamwrite.WriteLine($"Contact {DoctorData[item].Contact}");
                streamwrite.WriteLine($"Department {DoctorData[item].Department}");
                streamwrite.WriteLine($"staffid {DoctorData[item].StaffId} ");
                streamwrite.WriteLine($"Education {DoctorData[item].Education} ");
                streamwrite.WriteLine($"fees {DoctorData[item].fees} ");
                streamwrite.WriteLine($"Patience count {DoctorData[item].PatienceCount} ");
                streamwrite.WriteLine($"Income -:{DoctorData[item].income}  ");
                streamwrite.WriteLine($"Tax -: {DoctorData[item].Tax}");
                streamwrite.WriteLine($"Hospital share -: {DoctorData[item].HospitalShare}");
                streamwrite.WriteLine($"Gross salary - : {DoctorData[item].GrossSalary} ");
                streamwrite.WriteLine("=============================================================");
                streamwrite.WriteLine();
                streamwrite.WriteLine();
                Console.WriteLine($"StoreInAll {DoctorData[item].StaffId} goes on");

                streamwrite.Close();
                filestream.Close();

            }
            else
            {

                FileStream filestream = new FileStream(Path, FileMode.Append);
                StreamWriter streamwrite = new StreamWriter(filestream);


                streamwrite.WriteLineAsync();
                streamwrite.WriteLineAsync($"Employee name -: {DoctorData[item].Name}");
                streamwrite.WriteLineAsync($"Contact {DoctorData[item].Contact}");
                streamwrite.WriteLineAsync($"Department {DoctorData[item].Department}");
                streamwrite.WriteLineAsync($"staffid {DoctorData[item].StaffId} ");
                streamwrite.WriteLineAsync($"Education {DoctorData[item].Education} ");
                streamwrite.WriteLineAsync($"fees {DoctorData[item].fees} ");
                streamwrite.WriteLineAsync($"Patience count {DoctorData[item].PatienceCount} ");
                streamwrite.WriteLineAsync($"Income -:{DoctorData[item].income}  ");
                streamwrite.WriteLineAsync($"Tax -: {DoctorData[item].Tax}");
                streamwrite.WriteLineAsync($"Hospital share -: {DoctorData[item].HospitalShare}");
                streamwrite.WriteLineAsync($"Gross salary - : {DoctorData[item].GrossSalary} ");
                streamwrite.WriteLineAsync("=============================================================");
                streamwrite.WriteLineAsync();
                streamwrite.WriteLineAsync();
                Console.WriteLine($"StoreInAll {DoctorData[item].StaffId} goes on");

                streamwrite.Close();
                filestream.Close();
            }






        }
        // salaryslip
        public async void SalaryslipWrite(List<Doctor> DoctorData, int item)
        {


            Account account = new Account();
            DigitToWord toWord = new DigitToWord();



            string Path = $@"c:\B\{DoctorData[item].StaffId}.txt";


            FileStream filestream = new FileStream(Path, FileMode.OpenOrCreate);
            StreamWriter streamwrite = new StreamWriter(filestream);
            streamwrite.WriteLineAsync("Salary slip ");
            streamwrite.WriteLineAsync();




            int income = DoctorData[item].income;
            string incometoword = toWord.Convertion(income).Trim();
            double Tax = DoctorData[item].Tax;
            string taxToword = toWord.Convertion(Tax).Trim();
            double HospitalShare = DoctorData[item].HospitalShare;
            string hospitalShare = toWord.Convertion(HospitalShare).Trim();
            double GrossSalary = DoctorData[item].GrossSalary;
            string GrossSalarytpword = toWord.Convertion(GrossSalary).Trim();
            streamwrite.WriteLineAsync();
            streamwrite.WriteLineAsync($"Employee name -: {DoctorData[item].Name}");
            streamwrite.WriteLineAsync($"Income -:{income}  ({incometoword})");
            streamwrite.WriteLineAsync($"Tax -: {Tax} ({taxToword})");
            streamwrite.WriteLineAsync($"Hospital share -: {HospitalShare} ({hospitalShare})");
            streamwrite.WriteLineAsync($"Gross salary - : {GrossSalary} ({GrossSalarytpword})");
            streamwrite.Close();
            filestream.Close();
            Console.WriteLine($"SalaryslipWrite  {DoctorData[item].StaffId}");


            streamwrite.Close();
            filestream.Close();
        }
    }
}
