public class HelloWorldService : IHelloWorldService
{
    public string GetHelloWorld()
    {
        return "Hello World!!";
    }

    // public string GetHelloWorld2()
    //{

    // }
}

public interface IHelloWorldService
{
    string GetHelloWorld();
}