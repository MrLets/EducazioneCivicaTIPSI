using System;

namespace EducazioneCivicaMarcologno
{

class Program
{
    static void Main(string[] args)
    {
    }
        static string funzioneuno(){

           string s = "ciao";
        int n = 2;
        int product = 1;
        foreach (char c in s)
        {
            int value = (int)c - 96;
            product *= value;
        }
        double result = Math.Ceiling((double)product / n);
        Console.WriteLine(result);
        
    }
}
                    
        }


