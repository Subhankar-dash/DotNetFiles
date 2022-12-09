using MultiThread;
Console.WriteLine("Multi thread");

Data data = new Data();
List<Doctor> DoctorData = data.DoctorData;




Thread t1 = new Thread(new ThreadStart(() => { UpdateINSameCollection(DoctorData); }));
Thread t2 = new Thread(new ThreadStart(() => { StoreInAll(DoctorData); }));
Thread t3 = new Thread(new ThreadStart(() => { SalaryslipWrite(DoctorData); }));
t1.Start();
t2.Start();
t3.Start();

// update in same slip
static void UpdateINSameCollection(List<Doctor> DoctorData)
{

    Console.WriteLine("UpdateINSameCollection method called");
    Account account = new Account();

    foreach (var item in DoctorData)
    {
        item.income = account.Getincome(item.fees, item.PatienceCount);
        item.Tax = account.Tax(item.income);
        item.HospitalShare = account.HospitalShare(item.income);
        item.GrossSalary = account.GrossSalary(item.income, item.Tax, item.HospitalShare);
        Console.WriteLine($"this is UpdateINSameCollection {item.StaffId}");
    }
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

    foreach (var item in DoctorData)
    {
        streamwrite.WriteLine();
        streamwrite.WriteLine($"Employee name -: {item.Name}");
        streamwrite.WriteLine($"Contact {item.Contact}");
        streamwrite.WriteLine($"Department {item.Department}");
        streamwrite.WriteLine($"staffid {item.StaffId} ");
        streamwrite.WriteLine($"Education {item.Education} ");
        streamwrite.WriteLine($"fees {item.fees} ");
        streamwrite.WriteLine($"Patience count {item.PatienceCount} ");
        streamwrite.WriteLine($"Income -:{item.income}  ");
        streamwrite.WriteLine($"Tax -: {item.Tax}");
        streamwrite.WriteLine($"Hospital share -: {item.HospitalShare}");
        streamwrite.WriteLine($"Gross salary - : {item.GrossSalary} ");
        streamwrite.WriteLine("=============================================================");
        streamwrite.WriteLine();
        streamwrite.WriteLine();
        Console.WriteLine($"StoreInAll {item.StaffId} goes on");

    }
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

    foreach (var item in DoctorData)
    {

        string Path = $@"c:\B\{item.StaffId}.txt";


        FileStream filestream = new FileStream(Path, FileMode.OpenOrCreate);
        StreamWriter streamwrite = new StreamWriter(filestream);
        streamwrite.WriteLine("Salary slip ");
        streamwrite.WriteLine();


        int income = account.Getincome(item.fees, item.PatienceCount);
        string incometoword = toWord.Convertion(income).Trim();
        double Tax = account.Tax(income);
        string taxToword = toWord.Convertion(Tax).Trim();
        double HospitalShare = account.HospitalShare(income);
        string hospitalShare = toWord.Convertion(HospitalShare).Trim();
        double GrossSalary = account.GrossSalary(income, Tax, HospitalShare);
        string GrossSalarytpword = toWord.Convertion(GrossSalary).Trim();
        streamwrite.WriteLine();
        streamwrite.WriteLine($"Employee name -: {item.Name}");
        streamwrite.WriteLine($"Income -:{income}  ({incometoword})");
        streamwrite.WriteLine($"Tax -: {Tax} ({taxToword})");
        streamwrite.WriteLine($"Hospital share -: {HospitalShare} ({hospitalShare})");
        streamwrite.WriteLine($"Gross salary - : {GrossSalary} ({GrossSalarytpword})");
        streamwrite.Close();
        filestream.Close();
        Console.WriteLine($"SalaryslipWrite  {item.StaffId}");
    }
    Console.WriteLine("SalaryslipWrite ended");
}