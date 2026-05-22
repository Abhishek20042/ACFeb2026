namespace DemoApp;

//to support standard enumeration(iteration) a type
//must include a public definition for GetEnumerator()
//method whose return type exposes Current property 
//with get accessor and MoveNext() method which
//return bool
public class SimpleStack<E>
{
    class Node
    {
       internal E value;
       internal Node below; 
    }

    public struct Iterator(SimpleStack<E> source)
    {
        private Node next = source.top;

        public E Current { get; private set; }

        public bool MoveNext()
        {
            if(next != null)
            {
                Current = next.value;
                next = next.below;
                return true;
            }
            return false;
        }
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

    public Iterator GetEnumerator()
    {
        return new Iterator(this);
    }
}
