//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace TaskOnTax
//{

//    using TaskOnTax;
//Console.WriteLine("Multi thread");



//Data data = new Data();
//    List<Doctor> DoctorData = data.DoctorData;


//    //Parallel.Invoke(() => {
//    //    UpdateINSameCollection(DoctorData);
//    //    StoreInAll(DoctorData);
//    //    SalaryslipWrite(DoctorData);
//    //});
//    Console.WriteLine("1");

//for (int item = 0; item<DoctorData.Count; item++)
//{

//    Task<bool> task = (Task<bool>)Task.Factory.StartNew<Task<bool>>(() =>
//    {
//        var flag = UpdateINSameCollection(DoctorData, item);

//        return flag;

//    }).ContinueWith((t1) =>
//    {
//        StoreInAll(DoctorData, item);

//    }).ContinueWith((t2) =>
//    {
//        SalaryslipWrite(DoctorData, item);
//    });

//    Thread.Sleep(10);
//    Console.WriteLine($"current {item}");
//}

//Console.WriteLine("2");

//// update in same slip

//static async Task<bool> UpdateINSameCollection(List<Doctor> DoctorData, int item)
//{


//    Account account = new Account();

//    await Task<bool>.Run(() =>
//    {

//        DoctorData[item].income = account.Getincome(DoctorData[item].fees, DoctorData[item].PatienceCount);
//        DoctorData[item].Tax = account.Tax(DoctorData[item].income);
//        DoctorData[item].HospitalShare = account.HospitalShare(DoctorData[item].income);
//        DoctorData[item].GrossSalary = account.GrossSalary(DoctorData[item].income, DoctorData[item].Tax, DoctorData[item].HospitalShare);
//        Console.WriteLine($"this is UpdateINSameCollection {DoctorData[item].StaffId}");


//        return true;
//    });

//    // Console.WriteLine("UpdateINSameCollection method ended");

//    return true;

//}

//// store in master file

//static void StoreInAll(List<Doctor> DoctorData, int item)
//{
//    // Console.WriteLine("StoreInAll called");

//    Account account = new Account();
//    string Path = $@"c:\All.txt";

//    if (item == 0)
//    {
//        FileStream filestream = new FileStream(Path, FileMode.OpenOrCreate);
//        StreamWriter streamwrite = new StreamWriter(filestream);


//        streamwrite.WriteLine();
//        streamwrite.WriteLine($"Employee name -: {DoctorData[item].Name}");
//        streamwrite.WriteLine($"Contact {DoctorData[item].Contact}");
//        streamwrite.WriteLine($"Department {DoctorData[item].Department}");
//        streamwrite.WriteLine($"staffid {DoctorData[item].StaffId} ");
//        streamwrite.WriteLine($"Education {DoctorData[item].Education} ");
//        streamwrite.WriteLine($"fees {DoctorData[item].fees} ");
//        streamwrite.WriteLine($"Patience count {DoctorData[item].PatienceCount} ");
//        streamwrite.WriteLine($"Income -:{DoctorData[item].income}  ");
//        streamwrite.WriteLine($"Tax -: {DoctorData[item].Tax}");
//        streamwrite.WriteLine($"Hospital share -: {DoctorData[item].HospitalShare}");
//        streamwrite.WriteLine($"Gross salary - : {DoctorData[item].GrossSalary} ");
//        streamwrite.WriteLine("=============================================================");
//        streamwrite.WriteLine();
//        streamwrite.WriteLine();
//        Console.WriteLine($"StoreInAll {DoctorData[item].StaffId} goes on");

//        streamwrite.Close();
//        filestream.Close();

//    }
//    else
//    {

//        FileStream filestream = new FileStream(Path, FileMode.Append);
//        StreamWriter streamwrite = new StreamWriter(filestream);


//        streamwrite.WriteLine();
//        streamwrite.WriteLine($"Employee name -: {DoctorData[item].Name}");
//        streamwrite.WriteLine($"Contact {DoctorData[item].Contact}");
//        streamwrite.WriteLine($"Department {DoctorData[item].Department}");
//        streamwrite.WriteLine($"staffid {DoctorData[item].StaffId} ");
//        streamwrite.WriteLine($"Education {DoctorData[item].Education} ");
//        streamwrite.WriteLine($"fees {DoctorData[item].fees} ");
//        streamwrite.WriteLine($"Patience count {DoctorData[item].PatienceCount} ");
//        streamwrite.WriteLine($"Income -:{DoctorData[item].income}  ");
//        streamwrite.WriteLine($"Tax -: {DoctorData[item].Tax}");
//        streamwrite.WriteLine($"Hospital share -: {DoctorData[item].HospitalShare}");
//        streamwrite.WriteLine($"Gross salary - : {DoctorData[item].GrossSalary} ");
//        streamwrite.WriteLine("=============================================================");
//        streamwrite.WriteLine();
//        streamwrite.WriteLine();
//        Console.WriteLine($"StoreInAll {DoctorData[item].StaffId} goes on");

//        streamwrite.Close();
//        filestream.Close();
//    }






//    //  Console.WriteLine("StoreInAll ended");
//}
//// salaryslip
//static void SalaryslipWrite(List<Doctor> DoctorData, int item)
//{

//    //  Console.WriteLine("SalaryslipWrite started");

//    Account account = new Account();
//    DigitToWord toWord = new DigitToWord();



//    string Path = $@"c:\B\{DoctorData[item].StaffId}.txt";


//    FileStream filestream = new FileStream(Path, FileMode.OpenOrCreate);
//    StreamWriter streamwrite = new StreamWriter(filestream);
//    streamwrite.WriteLine("Salary slip ");
//    streamwrite.WriteLine();




//    int income = DoctorData[item].income;
//    string incometoword = toWord.Convertion(income).Trim();
//    double Tax = DoctorData[item].Tax;
//    string taxToword = toWord.Convertion(Tax).Trim();
//    double HospitalShare = DoctorData[item].HospitalShare;
//    string hospitalShare = toWord.Convertion(HospitalShare).Trim();
//    double GrossSalary = DoctorData[item].GrossSalary;
//    string GrossSalarytpword = toWord.Convertion(GrossSalary).Trim();
//    streamwrite.WriteLine();
//    streamwrite.WriteLine($"Employee name -: {DoctorData[item].Name}");
//    streamwrite.WriteLine($"Income -:{income}  ({incometoword})");
//    streamwrite.WriteLine($"Tax -: {Tax} ({taxToword})");
//    streamwrite.WriteLine($"Hospital share -: {HospitalShare} ({hospitalShare})");
//    streamwrite.WriteLine($"Gross salary - : {GrossSalary} ({GrossSalarytpword})");
//    streamwrite.Close();
//    filestream.Close();
//    Console.WriteLine($"SalaryslipWrite  {DoctorData[item].StaffId}");


//    streamwrite.Close();
//    filestream.Close();
//    // Console.WriteLine("SalaryslipWrite ended");
//}




//}
