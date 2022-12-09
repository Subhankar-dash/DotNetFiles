using TaskOnTax;

Console.WriteLine("Multi thread");



Data data = new Data();
List<Doctor> DoctorData = data.DoctorData;

Tax tax = new Tax();


Console.WriteLine("start main thread");

for (int item = 0; item < DoctorData.Count; item++)
{

    Task task = Task.Factory.StartNew(() =>
    {
        tax.UpdateINSameCollection(DoctorData, item);

      //  Task.WaitAll();

    }).ContinueWith((t1) =>
    {
        tax.StoreInAll(DoctorData,item);

        tax.SalaryslipWrite(DoctorData, item);

    });

    Task.WaitAll(task);


    //Thread.Sleep(10);
    Console.WriteLine($"current {item}");
}

Console.WriteLine("end main thread");

