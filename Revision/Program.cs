namespace Revision;

class Program
{
    static Action Fun01()
    {
        Action action = () => Console.WriteLine("Hello World!");
        return action;
    }
    static void Main(string[] args)
    {
        // Fun01().Invoke();
        // Fun01()();
        
        
        // var action = Fun01();
        // action();
    }
}