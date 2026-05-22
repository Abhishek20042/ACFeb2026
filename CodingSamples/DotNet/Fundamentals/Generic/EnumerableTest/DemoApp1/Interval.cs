namespace DemoApp;

class Interval(int min, int sec) : IComparable<Interval>
{
    public int Minutes { get; } = min + sec / 60;

    public int Seconds { get; } = sec % 60;

    public int Time()
    {
        return 60 * Minutes + Seconds;
    }

    public override string ToString()
    {
        if(Seconds < 10)
            return Minutes + ":0" + Seconds;
        return Minutes + ":" + Seconds;
    }

    public static Interval operator+(Interval lhs, Interval rhs)
    {
        return new Interval(lhs.Minutes + rhs.Minutes, lhs.Seconds + rhs.Seconds);
    }

    public override int GetHashCode()
    {
        return Minutes + Seconds;
    }

    public override bool Equals(object other)
    {
        if(other is Interval)
        {
            Interval that = (Interval) other; 
            return Minutes == that.Minutes && Seconds == that.Seconds;
        }
        return false;
    }

    public int CompareTo(Interval that)
    {
        return this.Time() - that.Time();
    }

    /*
    public static Interval[] Generate(int count)
    {
        var intervals = new Interval[count];
        for(int i = 0; i < count; ++i)
        {
            int t = Random.Shared.Next(100, 300);
            intervals[i] = new Interval(0, t);
        }
        return intervals;
    }
    */

    //the System.Collections.Generic namespace of BCL includes
    //IEnumerable<T> interface that defines GetEnumerator()
    //method whose return type is IEnumerator<T> which defines
    //Current property and MoveNext() method, a method with
    //IEnumerable<T> or IEnumerator<T> as its return type can
    //use 'yield return' statement to sequentially return multiple
    //values of type T through auto-generated implementation of 
    //the interface specified as its return type
    public static IEnumerable<Interval> Generate(int count)
    {
        for(int i = 0; i < count; ++i)
        {
            int t = Random.Shared.Next(100, 300);
            yield return new Interval(0, t);
        }
    }
}