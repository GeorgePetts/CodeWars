using System;

namespace ProdFib
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ProdFib.productFib(447577));
        }
    }
    public class ProdFib
    {
        public static ulong[] productFib(ulong prod)
        {
            ulong NMinus2 = 0;
            ulong NMinus1 = 1;
            ulong MaxNMinus2 = Convert.ToUInt64(Math.Sqrt(prod));
            ulong prodSum;
            ulong prodTest = 0;

            if (NMinus1 * NMinus2 == prod)
            {
                ulong[] result1= { NMinus2, NMinus1, 1};
                return result1;
            }
            while (NMinus2 < MaxNMinus2 && prodTest < prod)
            {
                prodSum = NMinus2 + NMinus1;
                NMinus2 = NMinus1;
                NMinus1 = prodSum;


                prodTest = NMinus1 * NMinus2;
                if (prodTest == prod)
                {
                    ulong[] result2 = { NMinus2, NMinus1, 1 };
                     return result2;
                }
            }
            ulong[] result = { NMinus2, NMinus1, 0 };
            return result;
        }
    }
}
