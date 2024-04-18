using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
internal class ProcedimientosCalculadora
{
    public static void sumar(double numUno, double numDos)
    {
        double Resultado = numUno + numDos;
        Console.Write($"El resultado de la suma de {numUno} mas {numDos} es: ");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(Resultado);
    }
    public static void restar(double numUno, double numDos)
    {
        double Resultado = numUno - numDos;
        Console.Write($"El resultado de la resta de {numUno} menos {numDos} es: ");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(Resultado);
    }
    public static void multiplicar(double numUno, double numDos)
    {
        double Resultado = numUno * numDos;
        Console.Write($"El resultado de la multiplicación de {numUno} por {numDos} es: ");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(Resultado);
    }
    public static void dividir(double numUno, double numDos)
    {
        double Resultado = numUno / numDos;
        Console.Write($"El resultado de la división de {numUno} entre {numDos} es: ");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(Resultado);
    }
    public static void errores (int repeticiones)
    {
        for (int i=1; i <= repeticiones; i++)
        {
            Console.Beep();
         }
    }
}