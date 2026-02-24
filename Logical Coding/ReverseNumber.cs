//Reverse a Number
//Logic: Extract last digit and rebuild number.

using System;
class ReverseNumber
{
    static void Main(string[] args)
    {
        int num = 23456;
        int rev = 0;
        
        while(num>0)
        {
            int rem = num%10;
            rev = rev*10 + rem;
            num = num/10;
        }
        
        Console.WriteLine("Reverse is "+rev);
    }
}

//Reverse is 65432
