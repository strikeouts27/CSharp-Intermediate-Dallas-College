using static System.Console;
delegate void GreeetingHandler(string s);
class Greeting2
{
    public static void Hello(string s)
    {
        WriteLine("Hello, {0}!", s);
    }

    public static void Goodbye(string s)
    {
        WriteLine("goodbye, {0}!", s);
    }
    static void Main()
    {   // first we create the delegate variables containers. 
        GreeetingHandler firstDel, secondDel;
        // next we create the delegate objects and call the hello method. 
        firstDel = new GreeetingHandler(Hello);
        secondDel = new GreeetingHandler(Hello);
        
        // we call the greet method with the delegates. 
        GreetMethod(firstDel, "Cathy");
        GreetMethod(secondDel, "Bob");
    }

    public static void GreetMethod(GreeetingHandler gd,  string name)
    {
        WriteLine("the greeting is:");
        gd(name); 
    }
}