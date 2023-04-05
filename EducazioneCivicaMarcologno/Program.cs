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
        char[] arr = s.ToCharArray();
        for (int i = 0; i < arr.Length; i++)
        {
            char c = arr[i];
            c = (char)(c - n);
            if (c < 'a')
            {
                c = (char)(c + 26);
            }
            arr[i] = c;
        }
        s = new string(arr);
        Console.WriteLine(s);
    }
}
                    
        }


