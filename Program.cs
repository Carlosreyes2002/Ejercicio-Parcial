using System;

class Program {
    static void Main(string[] args) {
        Console.Write("Ingrese un año: ");
        int year = int.Parse(Console.ReadLine());
        
        if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0) {
            Console.WriteLine("El año {0} es bisiesto.", year);
        } else {
            Console.WriteLine("El año {0} no es bisiesto.", year);
        }
    }
}

