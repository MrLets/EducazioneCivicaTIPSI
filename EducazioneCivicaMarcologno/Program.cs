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
        int sum = 0;
        foreach (char c in s)
        {
            int value = (int)c - 96;
            sum += value;
        }
        int result = sum * n;
        
    }
}
                    
        }


