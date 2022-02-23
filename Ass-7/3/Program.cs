using System;
using System.Diagnostics;
namespace LamdaExpression
{
    public delegate double MaxTwo(double a,double b);
    public class LamdaExp 
    {
        public static void CallAnonymousMethod()
        {
            bool positive = new Func<int, bool>(delegate (int int32) { return int32 > 0; })(-11);
            new Action<bool>(delegate (bool value)
            { 
                Console.WriteLine(value); 
            })(positive);
        }
        public static void CallLambda()
        {
            bool positive = new Func<int, bool>(int32 => int32 > 0)(1);
            new Action<bool>(value => Console.WriteLine(value))(positive);
        }
        static void Main()
        {
            Console.WriteLine("\n1. ANONYMOUS FUNCTION & ACTION DELEGATE WITHOUT LAMBDA EXPRESSION :");
            LamdaExp.CallAnonymousMethod();
            Console.WriteLine("\n2. ANONYMOUS FUNCTION & ACTION DELEGATE WITH LAMBDA EXPRESSION :");
            LamdaExp.CallLambda();
            Console.WriteLine("\n3. DELEGATE WITH LAMBDA EXPRESSION :");
            MaxTwo parse = (double x, double y) => (x > y ? x : y);
            Console.WriteLine("\nMAX(2.4,1.4) = {0}",parse(2.4,1.4));
            Console.WriteLine("\n4. FUCNTION DELEGATE WITH LAMBDA EXPRESSION :");
            Func<double, double, double> f =(x, y) => { if (x > y) return x; return y; };
            double z1 = f(10, 20);
            Console.WriteLine("\nMAX(10,20) = {0}",z1);
            Console.WriteLine("\n5. FUNCTION DELEGATE WITH DIFFERENT LAMBDA EXPRESSION :");
            double z2;
            Func<double, double, double> f2;
            f2 = (x, y) => 
            {
                if (x > y)
                    return x;
                return y;
            };
            z2 = f2(10, 20);
            Console.WriteLine("\nMAX(10,20) = {0}",z2);
            f2 = (x, y) => 
            {
                if (x < y)
                    return x;
                return y;
            };
            z2 = f2(10, 20);
            Console.WriteLine("MIN(10,20) = {0}\n",z2);
        }
    }
}