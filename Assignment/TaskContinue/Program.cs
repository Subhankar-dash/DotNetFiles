// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Task task = Task.Factory.StartNew(() => {
//    Print1();
//});




//Task task1 = Task.Factory.StartNew(() => {
//    Print2();
//});



int k;

//Task.WaitAll(task,task1);
Parallel.For(0, 10,(k)=>
{
    Console.WriteLine(k);
    Print2(k);
    
});



for (int i = 0; i < 10; i++)
{
    //Print1(i);
    // await task;
    Console.WriteLine(i);
    Print2(i);
    //Thread.Sleep(1);
}

Console.ReadLine();

static async Task Print1(int i)
{
    await Task.Run(() =>
    {
        Console.WriteLine(i);
    }
    );
    //
    //Task.Delay(1000).Wait();
}


static void Print2(int i)
{
    Console.WriteLine(i + 100);
   // Task.Delay(1000).Wait();

}














//static int Call(int i)
//{
//    Thread.Sleep(1000);
//    int j = i;
//    j++;
//    return j;
//}


