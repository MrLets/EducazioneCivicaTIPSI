using System;

namespace EducazioneCivicaMarcologno
{

class Program
{
    static void Main(string[] args)
    {
    }
        static string funzioneuno(){
            
        Console.WriteLine("Inserisci una stringa:");
        string s = Console.ReadLine();
        Console.WriteLine("Inserisci un numero:");
        int n = int.Parse(Console.ReadLine());
        string result = "";
        foreach (char c in s)
        {
            if (char.IsLetter(c))
            {
                char newChar = (char)(c + n);
                if (char.IsUpper(c) && newChar > 'Z' || char.IsLower(c) && newChar > 'z')
                {
                    newChar = (char)(newChar - 26);
                }
                result += newChar;
            }
            else
            {
                result += c;
            }
        }
        Console.WriteLine(result);
                    
        }
}
}
