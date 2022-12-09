Console.WriteLine("Hello, World!");
var bgThread = new Thread(() =>
{
    
        Console.WriteLine($"Is network available? Answer:");
        
    
});
bgThread.IsBackground = true;
bgThread.Start();
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Main thread working...");
    Task.Delay(500);
}
Console.WriteLine("Done");
