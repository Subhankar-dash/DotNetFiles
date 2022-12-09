using ParallalLoop;
Console.WriteLine("Multi thread");



Data data = new Data();
List<Doctor> DoctorData = data.DoctorData;


Parallel.Invoke(() =>{
    UpdateINSameCollection(DoctorData);
    StoreInAll(DoctorData);
    SalaryslipWrite(DoctorData);
});



// update in same slip
static void UpdateINSameCollection(List<Doctor> DoctorData)
{

    Console.WriteLine("UpdateINSameCollection method called");
    Account account = new Account();

    Parallel.For(0, DoctorData.Count, (item2) =>
    {
        DoctorData[item2].income = account.Getincome(DoctorData[item2].fees, DoctorData[item2].PatienceCount);
        DoctorData[item2].Tax = account.Tax(DoctorData[item2].income);
        DoctorData[item2].HospitalShare = account.HospitalShare(DoctorData[item2].income);
        DoctorData[item2].GrossSalary = account.GrossSalary(DoctorData[item2].income, DoctorData[item2].Tax, DoctorData[item2].HospitalShare);
        Console.WriteLine($"this is UpdateINSameCollection {DoctorData[item2].StaffId}");
    });
    Console.WriteLine("UpdateINSameCollection method ended");
}

// store in master file

static void StoreInAll(List<Doctor> DoctorData)
{
    Console.WriteLine("StoreInAll called");
    Account account = new Account();
    string Path = $@"c:\All.txt";
    FileStream filestream = new FileStream(Path, FileMode.OpenOrCreate);
    StreamWriter streamwrite = new StreamWriter(filestream);

    Parallel.For(0, DoctorData.Count, (item) =>
    {
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

    });
    streamwrite.Close();
    filestream.Close();
    Console.WriteLine("StoreInAll ended");
}
// salaryslip
static void SalaryslipWrite(List<Doctor> DoctorData)
{

    Console.WriteLine("SalaryslipWrite started");

    Account account = new Account();
    DigitToWord toWord = new DigitToWord();

    Parallel.For(0, DoctorData.Count, (item) =>
    {

        string Path = $@"c:\B\{DoctorData[item].StaffId}.txt";


        FileStream filestream = new FileStream(Path, FileMode.OpenOrCreate);
        StreamWriter streamwrite = new StreamWriter(filestream);
        streamwrite.WriteLine("Salary slip ");
        streamwrite.WriteLine();


        int income = account.Getincome(DoctorData[item].fees, DoctorData[item].PatienceCount);
        string incometoword = toWord.Convertion(income).Trim();
        double Tax = account.Tax(income);
        string taxToword = toWord.Convertion(Tax).Trim();
        double HospitalShare = account.HospitalShare(income);
        string hospitalShare = toWord.Convertion(HospitalShare).Trim();
        double GrossSalary = account.GrossSalary(income, Tax, HospitalShare);
        string GrossSalarytpword = toWord.Convertion(GrossSalary).Trim();
        streamwrite.WriteLine();
        streamwrite.WriteLine($"Employee name -: {DoctorData[item].Name}");
        streamwrite.WriteLine($"Income -:{income}  ({incometoword})");
        streamwrite.WriteLine($"Tax -: {Tax} ({taxToword})");
        streamwrite.WriteLine($"Hospital share -: {HospitalShare} ({hospitalShare})");
        streamwrite.WriteLine($"Gross salary - : {GrossSalary} ({GrossSalarytpword})");
        streamwrite.Close();
        filestream.Close();
        Console.WriteLine($"SalaryslipWrite  {DoctorData[item].StaffId}");
    });
    Console.WriteLine("SalaryslipWrite ended");
}