// See https://aka.ms/new-console-template for more information
using System;
using System.Globalization;

Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine("          CALCULADORA          ");
Console.ResetColor();
Console.WriteLine();

int resOpcionEnt;

//Menú de opciones
Console.WriteLine("Selecciona una opción:");
Console.WriteLine("    1. Suma");
Console.WriteLine("    2. Resta");
Console.WriteLine("    3. Multiplicación");
Console.WriteLine("    4. División");
Console.Write("Escribe el número de la opción que deseas: ");
    string? resOpcion = Console.ReadLine();
    int.TryParse(resOpcion, out resOpcionEnt);


//Validar selección
if (resOpcionEnt != 1 && resOpcionEnt != 2 && resOpcionEnt != 3 && resOpcionEnt != 4)
{
    Console.ForegroundColor = ConsoleColor.Red;
    ProcedimientosCalculadora.errores(5);
    Console.WriteLine();
    Console.WriteLine("        xxxxxx NO ES UN VALOR VÁLIDO xxxxxx         ");
}
else
{
    Console.WriteLine();


    //Agregar valores
    Console.Write("Escribe el primer valor: ");
    double numUno;
    double.TryParse(Console.ReadLine(), out numUno);

    Console.Write("Escribe el segundo valor: ");
    double numDos;
    double.TryParse(Console.ReadLine(), out numDos);


    Console.WriteLine();
    Console.WriteLine();


    switch (resOpcionEnt)
    {
        case 1:
            Console.ForegroundColor= ConsoleColor.DarkCyan;
            Console.WriteLine("********SUMA********");
            Console.ResetColor();   
            ProcedimientosCalculadora.sumar(numUno, numDos);
            break;

        case 2:
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("********RESTA********");
            Console.ResetColor();
            ProcedimientosCalculadora.restar(numUno, numDos);
            break;

        case 3:
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("********MULTIPLICACIÓN********");
            Console.ResetColor();
            ProcedimientosCalculadora.multiplicar(numUno, numDos);
            break;

        case 4:
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("********DIVISIÓN********");
            Console.ResetColor();
            ProcedimientosCalculadora.dividir(numUno, numDos);
            break;

    }
}
Console.WriteLine();
Console.WriteLine();
Console.ResetColor();



///////Borrador 1 - Procedimiento IF/////////
//
//if (resOpcionEnt == 1)
//{
//    Console.WriteLine("********SUMA********");
//    ProcedimientosCalculadora.sumar(numUno, numDos);
//    //int ResultadoSum = numUno + numDos;
//    //Console.WriteLine($"El resultado de la suma de {numUno} más {numDos} es:");
//    //Console.ForegroundColor = ConsoleColor.Green;
//    //Console.Write(ResultadoSum);
//}
//else if (resOpcionEnt == 2)
//{
//    Console.WriteLine("********Resta********");
//    ProcedimientosCalculadora.restar(numUno, numDos);
//    //  int ResultadoRes = numUno - numDos;
//    //Console.WriteLine($"El resultado de la resta de {numUno} menos {numDos} es:");
//    //Console.ForegroundColor = ConsoleColor.Green;
//    //Console.Write(ResultadoRes);
//}
//else if (resOpcionEnt == 3)
//{
//    Console.WriteLine("********Multiplicación********");
//    ProcedimientosCalculadora.multiplicar(numUno, numDos);
//    //int ResultadoMul = numUno * numDos;
//    //Console.WriteLine($"El resultado de la multiplicación de {numUno} por {numDos} es:");
//    //Console.ForegroundColor = ConsoleColor.Green;
//    //Console.Write(ResultadoMul);
//}  
//else if (resOpcionEnt == 4)
//{
//    Console.WriteLine("********División********");
//    ProcedimientosCalculadora.dividir(numUno, numDos);
//    //int ResultadoDiv = numUno / numDos;
//    //Console.WriteLine($"El resultado de la división de {numUno} entre {numDos} es:");
//    //Console.ForegroundColor = ConsoleColor.Green;
//    //Console.Write(ResultadoDiv);
//}

