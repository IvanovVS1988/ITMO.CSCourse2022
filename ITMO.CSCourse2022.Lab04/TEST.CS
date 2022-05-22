namespace Utils
{
    using System;

    /// <summary>
    ///   This is the test harness
    /// </summary>

    public class Test
    {
        public static void Main()
        {
            int x, y, greater;
            Console.WriteLine("Enter first number:");
            x=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            y = int.Parse(Console.ReadLine());

            //Test Greater method below

            greater = Utils.Greater(x,y);
            Console.WriteLine("The greater value is {0}", greater);

            //Test Swap method below

            Console.WriteLine("Before swap: " + x + "," + y);
            Utils.Swap(ref x,ref y);
            Console.WriteLine("After swap: " + x + "," + y);

            //Test Factorial method below

            bool ok;
            int f;
            Console.WriteLine("Number for factorial:");
            x = int.Parse(Console.ReadLine());
            ok=Utils.Factorial(x, out f);
            if (ok)
                Console.WriteLine("Factorial {0} = {1}", x,f);
            else
                Console.WriteLine("Cannot compute this factorial");
        }
    }
}