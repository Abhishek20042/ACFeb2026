namespace DemoApp;

public class SimpleStack<E>
{
    class Node
    {
        internal E value;
        internal Node below; 

        internal Node Seek(int depth)
        {
            Node n = this;
            for(int i = 0; i < depth; ++i)
                n = n.below;
            return n;
        }
    }

	//an 'enumerator' type exposes Current property 
	//with get accessor and MoveNext() method with
	//bool as return type
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

	//to support standard enumeration(iteration)
	//a type must include a public definition 
	//for GetEnumerator() method which returns
	//an enumerator type
    public Iterator GetEnumerator()
    {
        return new Iterator(this);
    }

    //indexer - it is a parameterized property which accepts
    //a parameter as an index (in [] like an array) to provide
    //access to multiple values controlled by this instance
    public E this[int index]
    {
        get
        {
            return top.Seek(index).value;
        }

        set
        {
            top.Seek(index).value = value;
        }
    }
}
