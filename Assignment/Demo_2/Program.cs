// See https://aka.ms/new-console-template for more information
//Console.WriteLine("diamond problem");

//Parent parent = new Parent();
//parent.mymethod();

//Child1 child1 = new Child1();
//child1.mymethod();
//child1.mymethod2();
//Pig pig = new Pig();
//pig.animalSound();
////pig.sleep();

//Parent parent = new Parent();
//var p1 = parent.GetType;
//var p2 = parent.Equals;
//foreach (var item in p2)
//{

//}
Console.WriteLine();
    

bool status = true;
bool result = status;
status = false;
Console.WriteLine(result);

public abstract class Parent
{
    private void mymethod()
        {
        Console.WriteLine("parent");
         }
    public void mymethod1()
    {
        Console.WriteLine("parent1");
    }
    
}
public sealed class Child1 : Parent
{

    public  override void mymethod()
    {
        Console.WriteLine("child");
    }
    public override void mymethod2()
    {
        Console.WriteLine("child1");
    }
    public void M1(int a)
    {
        return;
    }
    public int m1(int a)
    {
        return 0;
    }
}
public abstract class aa
    {
    
}
abstract class Animal
{
    public Animal()
    {
        Console.WriteLine("ctor");
    }
    
    // Abstract method (does not have a body)
    public abstract void animalSound();
    // Regular method
    public void sleep()
    {
        Console.WriteLine("Zzz");
    }
}

// Derived class (inherit from Animal)
class Pig : Animal
{
    public override void animalSound()
    {
        // The body of animalSound() is provided here
        Console.WriteLine("The pig says: wee wee");
    }
}




public interface mm
{
    public int animalSound();
}

public interface mmm : mm
{
    public int animalSound();
}

public class mmmm : mmm , mm
{
    
}