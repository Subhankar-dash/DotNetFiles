using BackGroundThreadLINQ;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("linq");

var bgThread = new Thread(() =>
{
        Linq linq = new Linq();
});
bgThread.IsBackground = true;
bgThread.Start();
Thread.Sleep(100000);

