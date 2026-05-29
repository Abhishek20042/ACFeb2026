using System.Runtime.InteropServices;

partial class Program
{
    [LibraryImport("native/libprimes.so", EntryPoint = "primes_fetch")]
    internal unsafe static partial void FetchPrimes(ulong start, int count, ulong* selected, delegate*<ulong, bool> selector);

    static bool IsFavorite(ulong p) => (p - 1) % 4 == 0;

    //Span<T> type provides a common abstraction for safely accessing
    //elements of type T in a memory block either allocated on the
    //stack(referred by T*) or on the heap(referred by T[])
    static void PrintNumbers(string title, Span<ulong> source)
    {
        Console.WriteLine(title);
        foreach(ulong num in source)
            Console.WriteLine(num);
    }

    unsafe static void Main(string[] args)
    {
        ulong m = ulong.Parse(args[0]);
        int n = int.Parse(args[1]);
        if(n < 5)
        {
            ulong* primes = stackalloc ulong[n];       
            FetchPrimes(m, n, &primes[0], null);
            PrintNumbers("All primes", new Span<ulong>(primes, n));
        }
        else
        {
            ulong[] primes = new ulong[n];
            //a pointer to any data enclosed in an object/array on the heap
            //can only be initialized using fixed statement to avoid relocation
            //of this data during garbage collection
            fixed(ulong* first = &primes[0])
            {
                FetchPrimes(m, n, first, &IsFavorite);
            }
            PrintNumbers("Favorite primes", new Span<ulong>(primes));
        }
    }
}
