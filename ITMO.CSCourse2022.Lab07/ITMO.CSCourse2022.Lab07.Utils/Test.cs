using System;
using System.Collections.Generic;

    public class Test
    {
        public static void Main()
        {
            string message;
            message=Console.ReadLine();
            Utils.Reverse(ref message);
            Console.WriteLine(message);     
        }
}
