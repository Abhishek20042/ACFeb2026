using System.Runtime.InteropServices;

namespace DemoApp;

class Program
{
    delegate double DepreciationInvoker(int life, int after);

    static void Main(string[] args)
    {
        double p = double.Parse(args[0]);
        int l = int.Parse(args[1]);
        nint lib = NativeLibrary.Load(args[2]);
        nint fn = NativeLibrary.GetExport(lib, "depreciation");
        var depr = Marshal.GetDelegateForFunctionPointer<DepreciationInvoker>(fn);
        for(int n = 1; n < l; ++n)
        {
            double d = depr.Invoke(l, n);
            Console.WriteLine("{0, -4}{1, 16:0.00}", n, p * (1 - d));
        }
        NativeLibrary.Free(lib);
    }
}
