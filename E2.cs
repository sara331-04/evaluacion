using System;
namespace E2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("examen");

// 1. escribir la sintaxis para definir una funcion
    


// 2. definir un ciclo para imprimir la siguiente secuencia: 2, 4, 6, 9, 12, 15, 19, 23, 27
            for (int i = 2; i <= 27; i++)
            {
                if (i % 2 == 0 || i == 9 || i == 15 || i == 19 || i == 23)
                {
                    Console.WriteLine(i);
                }
            }

// 3. declarar e inicializar 2 variables: inicio, limite. Si el producto de inicio y limite es menor que 8 e inicio es mayor que limite, definir un ciclo descendente de 9 ejecuciones. En cualquier otro caso, definir un ciclo ascendente
            int inicio = 5;
            int limite = 3;
            if (inicio * limite < 8 && inicio > limite)
            {
                for (int i = inicio; i >= limite; i--)
                {
                    Console.WriteLine(i);
                }
            }
// 4. definir e invocar una funcion para determinar si un numero es multiplo de 5. Si el numero es multiplo de 5, devolver true; en caso contrario, false. Imprimir la devolucion utilizando interpolacion
            bool Esmultiplodecinco(int numero)
            {
                return numero % 5 == 0;

            }
            int numero = 10;
            bool resultado = Esmultiplodecinco(numero);
            Console.WriteLine($"El numero {numero} es multiplo de 5: {resultado}");

    
// 5. definir e invocar una funcion vacia para imprimir: "examen: programacion lll", donde "pgrogramacion lll" corresponda a un argumento
            void ImprimirMensaje(string mensaje)
            {
                Console.WriteLine($"examen: {mensaje}");
            }
            ImprimirMensaje("programacion lll");
        }

    }
 }

