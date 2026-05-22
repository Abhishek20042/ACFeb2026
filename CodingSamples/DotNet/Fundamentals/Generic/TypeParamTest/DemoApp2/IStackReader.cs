namespace DemoApp;

public interface IStackReader<out T>
{
    T Pop();
    bool Empty();
}