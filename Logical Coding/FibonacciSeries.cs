//Print Fibonacci series up to n terms.
//Logic: Next number = sum of previous two numbers.

using System;
class FibonacciSeries
{
    static void Main(string[] args)
    {
        int n=5;
        int first=0, second=1, next=0;
        
        Console.Write("Fibonacci series: ");
        for(int i=1; i<=n; i++)
        {
            Console.Write(first+" ");
            
            next = first + second;
            first = second;
            second = next;
        }
    }
}

//Fibonacci series: 0 1 1 2 3 
//time complexity: O(n)
