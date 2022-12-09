using Demo;
using System.Threading;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello Demo World!");


DateTime now = new DateTime();
Console.WriteLine(now);
Myclass.Myfunch(5);
Myclass.Myfunch(56);

string a = "a";

//Console.WriteLine(a.GetHashCode());

//Console.WriteLine(a);   

//subhankar sub = new subhankar();
//Console.WriteLine(sub.Create("Hii Subhankar"));

Myclass2 myclass = new Myclass2();

//Myclass2.mymethod();

//Myclass2.mymethod();

//myclass.mymethod2();

Thread t1 = new Thread(myclass.mymethod2);
Thread t2 = new Thread(myclass.mymethod2);
t1.Start();
t1.Join();
t2.Start();
public class Myclass2
{
   public static void mymethod()
    {
        Console.WriteLine("static");
    }
    public void mymethod2()
    {
        Console.WriteLine("non static");
        Thread.Sleep(5000);
        Console.WriteLine("wake up .. go...");
    }
}