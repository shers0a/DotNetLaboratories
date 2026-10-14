namespace Lab2;
using System;

public class Program
{
    private static bool problem4(int[] arr, int size)
    {
        for (int i = 0; i < size - 1; i++)
        {
            if (Math.Abs(arr[i] % 2) != Math.Abs(arr[i + 1] % 2))
            {
                return true;
            }
        }

        return false;
    }
    private static void readArr(int[] arr, int size)
    {
        for (int i = 0; i < size; i++)
        {
            if(int.TryParse(Console.ReadLine(), out arr[i]) == false)
            {
                throw new FormatException($"Element {i} of the array is not a valid integer.");
            }
        }
    }
    private static int upsideDown(int n)
    {
        int rasturnat = 0;
        do
        {
            rasturnat = rasturnat * 10 + n % 10;
            n /= 10;
        } while (n != 0);

        return rasturnat;
    }
    
    private static bool isPalindrome(int n)
    {
        if (n < 0)
        {
            Console.Write($"Number {n} is negative therefore it is not a palindrome\n");
            return false;
        }
        
        if (n % 10 == n)
        {
            Console.Write($"Number {n} is a palindrome\n");
            return true;
        }

        if (n != upsideDown(n))
            return false;
        
        return true;
    }
    
    public static void Main(string[] args)
    {
        int n ;
        if (int.TryParse(Console.ReadLine(), out n))
        {
            Console.Write($"You introduced the number {n}\n");
        }
        else
        {
            throw new FormatException("n is not a valid integer.");
        }
        //Problema 3

        Console.Write("Problem no. 3:\n");
        if (isPalindrome(n))
        {
            Console.Write($"The number {n} is a palindrome.\n");
        }
        else
        {
            Console.Write($"The number {n} is not a palindrome.\n");
        }
        
        //Problema 4
        
        int[] v = new int[100];
        int size;
        
        if (int.TryParse(Console.ReadLine(), out size))
        {
            Console.Write($"The size of the array is {size}.\n");
        }
        else
        {
            throw new FormatException("The size is not a valid integer.");
        }

        if (size < 1 || size > 100)
        {
            throw new ArgumentException("Size must be in the interval [1,100].\n", nameof(size));
        }
        
        readArr(v, size);

        if (problem4(v, size))
        {
            Console.Write("True.\n");
        }
        else
        {
            Console.Write("Not True.\n");
        }
        
    }
}