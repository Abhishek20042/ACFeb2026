namespace DemoApp;

//defining an open generic type with type-parameter E
public class SimpleStack<E> : IStackReader<E>
{
    //nested class cannot refer non-static members of outer class
    class Node
    {
       internal E value;
       internal Node below; 
    }

    private Node top;

    public void Push(E item)
    {
        top = new Node { value = item, below = top };
    }

    public E Pop()
    {
        var node = top;
        top = top.below;
        return node.value;
    }

    public bool Empty()
    {
        return top is null;
    }
}
