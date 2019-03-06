using System;

namespace String_Calulator_Kata
{
    public class StringCalculator
    {
        public int Add(string v)
        {
            if (v == "")
             return 0;  
            return int.Parse(v);
        }
       
    }
}
