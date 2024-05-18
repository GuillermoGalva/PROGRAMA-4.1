using System;

class Program
{
    static void Main()
    {
        
        Console.WriteLine("¿Cuántos números deseas ingresar?");
        int n = int.Parse(Console.ReadLine());

        
        int contador = 0;

        
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Ingresa el número {i + 1}: ");
            int v = int.Parse(Console.ReadLine());
            int numero = v;

            if (numero >= 1000)
            {
                contador++;
            }
        }

        
        Console.WriteLine($"La cantidad de valores mayores o iguales a 1000 es: {contador}");
    }
}
