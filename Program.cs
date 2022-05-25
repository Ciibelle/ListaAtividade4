using System;

namespace Atividade4
{
    class Program
    {
        static void Main(string[] args)
        {
            double gc = 31.5;  
            double fh = 0;
            
            fh = (9*gc+160)/5;
            Console.WriteLine($"A conversão dessa temperatura para Fahrenheit é: {fh}");  
        }
    }
}
