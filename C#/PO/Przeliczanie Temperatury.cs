using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

class Temperatury
{
    public static void Main()
    {
        int wybor;
        double C, F;
        Console.WriteLine("Przelicznie temperatury z C na F");
        Console.WriteLine("Wybierz\n 1. Celsius na Farenchuj\n 2. Farenchuj na Celsius");
        wybor = int.Parse(Console.ReadLine());

        switch (wybor)
        {
            case 1:
                C = Double.Parse(Console.ReadLine());
                F = (C * 9 / 5) + 32;
                Console.WriteLine(F);
                break;
            case 2:
                F = Double.Parse(Console.ReadLine());
                C = (F-32)*5/9;
                Console.WriteLine(C);
                break;
            default:
                wybor = 0;
                Console.WriteLine("Nope :)");
                break;
        }

       

    }
}