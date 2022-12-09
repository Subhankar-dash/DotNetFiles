using CSV;
using System.Globalization;
using CsvHelper;
using CsvHelper.Configuration;
Console.WriteLine("csv");

Data Data = new Data();
List<Doctor> StaffList = Data.DoctorData;
string path = @"c:\staff.csv";

List<string> files = new List<string>();
string str = "aaa";
files.Add(str);

using (var writer = File.AppendText(path))
{
    using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
    {
        csv.WriteRecords(files);
    }
}


Console.WriteLine("done");