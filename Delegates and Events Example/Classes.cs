namespace Delegates_and_Events_Example;

public class ExampleClass
{
    // // defining delegate
    // public delegate void DoSomething(int num);
    //
    // // making an object of the defined delegate
    // // and declaring it as an event
    // public event DoSomething Something;
    
    // // or simply write this line
    // public EventHandler Something;
    
    // or just use action keyword for void method signature
    // action is a delegate with no arguments and return type
    public Action<int> Something;
    
    // making constructor
    public ExampleClass()
    {
        // assigning the delegate an object
        // Something = FunctionOne;
        // // invoking using null propagation
        // Something?.Invoke(123);
        //
        // // repeating
        // Something = FunctionTwo;
        // Something?.Invoke(456);
        
        // // or we can simply make functions subscribe to the service
        // Something += FunctionOne;
        // Something += FunctionTwo;
        //
        // // then invoke just the delegate object
        // Something(69);
        
        // // for eventhandler declaration
        // Something(this, EventArgs.Empty);
        
        // for action, we use normal delegate notation
        Something = FunctionOne;
        Something = FunctionTwo;
    }

    private void FunctionOne(int num)
    {
        Console.WriteLine($"Function One called with value : {num}");
    }
    
    private void FunctionTwo(int num)
    {
        Console.WriteLine($"Function Two called with value : {num}");
    }
}