using System;

namespace CodingChallenge
{
    class Program
    {
        static void Main(string[] args)
	{
	    FizzBuzz();    
	}

	static void FizzBuzz()
	{
	    for (int i = 1; i <= 100; i++)
            {
	        if(check_fizz(i) || check_buzz(i)){
	            if(check_fizz(i))
	            {
	                Console.Write("fizz");
	            }
	            if(check_buzz(i))
	            {
		        Console.Write("buzz");
	            }
		    Console.WriteLine("");
	        }
	        else
	        {
		    Console.WriteLine(i);
	        }
            }  
        }
        static bool check_fizz(int zahl)
        {
	    if(zahl % 3 == 0)
	    {
	        return true;
	    }
	    return false;
        }
        static bool check_buzz(int zahl)
        {
	    if(zahl % 5 == 0)
	    {
	        return true;
	    }
	    return false;
        }  
     }
}
