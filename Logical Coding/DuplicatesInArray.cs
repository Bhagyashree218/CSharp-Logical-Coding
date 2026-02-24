// Find Duplicate Elements in Array
//Logic:Compare each element with every other element.

using System;
class DuplicatesInArray
{
    static void Main(string[] args)
    {
        int[] arr = {11,22,33,44,22,55,77,11,33,22,33,33,33};
        
        Console.Write("Duplicates: ");
        
        for(int i=0; i<arr.Length; i++)
        {
            bool isDuplicate = false;
            
            // Check if already appeared before
            for(int k=0; k<i; k++)
            {
                if(arr[i]==arr[k])
                {
                    isDuplicate = true;
                    break;
                }
            }
            
            if(isDuplicate)
                continue;
            
            // Check if appears later
            for(int j=i+1; j<arr.Length; j++)
            {
                if(arr[i]==arr[j])
                {
                    Console.Write(arr[i]+"  ");
                    break;
                }
            }
        }
    }
}

//Duplicates: 11  22  33  
//Time Complexity: Outer loop=n, Inner loops→n Total = O(n²)
