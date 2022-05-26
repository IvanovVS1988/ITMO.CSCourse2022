    using System;

    class Utils
    {

        public static void Reverse(ref string s)   //Reverse the string
        {
            string sRev = "";
            for(int k=s.Length-1; k>=0; k--)
            {
                sRev = sRev + s[k];
            }
            s = sRev;
        }
    }
