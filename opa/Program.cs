using System;

namespace opa
{
    class Program
    {
        static void Main(string[] args)
        {
            // VARIABLES DEL RANGO
            long d, a;
            // PREGUNTAS DE LOS RANGOS
            Console.WriteLine("ingrese desde que numero quiere ver los numeros perfectos");
            a = Convert.ToInt64(Console.ReadLine());
            if (a<2)
            {
                a = 2;
            }
            Console.WriteLine("ingrese desde que numero quiere ver los numeros perfectos");
            d = Convert.ToInt64(Console.ReadLine());
            // CICLO DE INICIO Y FIN DE COMPARACION
            for (long i = a; i <= d; i++)
            {
                // VARIABLE DONDE VAMOS A HACER LA OPERACION DE SUMA Y COMPARACION
                long b = 0;
                // CICLO DE OPERACION Y COMPARACION
                for (long j = 1; j  <= decimal.Truncate(i / 2); j++)
                {
                    // CONDICIONAL DEL RESIDUO
                    if (i%j == 0)
                    {
                        b=b+j;
                    }
                }
                // COMPARACION FINAL Y MENSAJE DE SALIDA
                if (b == i)
                {
                    Console.WriteLine("el numero "+i+" es perfecto");
                }
            }
            //PRESIONAR PARA CERRAR EL PROGRAMA
            Console.ReadKey();
        }
    }
}
