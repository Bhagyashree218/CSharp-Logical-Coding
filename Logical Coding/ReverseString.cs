/*This program reverses a given string by iterating from 
the last character to the first. It builds the reversed 
string manually without using built-in string functions.*/
using System;

public class ReverseString
{
    static void Main(string[] args)
    {
        string str = "Programmer";
        string rev = "";
        
        for(int i = str.Length-1; i>=0; i--)
        {
            rev = rev + str[i];
        }
        
        Console.WriteLine("Reversed= "+rev);
    }
}

//Reversed= remmargorP