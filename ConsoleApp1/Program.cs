using System;

class Program
{
    static void Main()
    {
        /*1.	Imprimir los números pares que hay dentro de los 100 primeros números enteros.
         No utilizar la estructura de control "if" para resolver este ejercicio.
         * Utilizamos un bucle 'for' para recorrer únicamente sobre los números pares
        Inicializamos la variable 'i' en 2, ya que es el primer número par
        Continuamos el bucle mientras 'i' sea menor o igual a 100
        Incrementamos el valor de 'i' en 2 en cada iteración para saltar a los números pares*/
        for (int i = 2; i <= 100; i += 2)
        {
            // Imprimimos el valor actual de 'i' en la consola
            Console.WriteLine(i);
        }

        /*2.	Imprimir los números pares que hay dentro de los 100 primeros números enteros. 
         Recorremos los números del 1 al 100*/
        for (int i = 1; i <= 100; i++)
        {
            // Usamos 'if' para comprobar si el número es par
            if (i % 2 == 0) // Un número es par si el residuo al dividirlo entre 2 es 0
            {
                Console.WriteLine(i); // Imprimimos el número si es par
            }
        }

        /*3.	Imprimir los números del 1 al 50:
        a.	Para números divisibles por 3, imprima "Fizz".
        b.	Para números divisibles por 5, imprima "Buzz".
        c.	Para números divisibles por 3 y 5, imprime "FizzBuzz".
        d.	En cualquier otro caso, imprima el número.
        Recorremos los números del 1 al 50*/
        for (int i = 1; i <= 50; i++)
        {
            // Si el número es divisible por 3 y 5, imprimimos "FizzBuzz"
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            // Si el número es divisible solo por 3, imprimimos "Fizz"
            else if (i % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            // Si el número es divisible solo por 5, imprimimos "Buzz"
            else if (i % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            // En cualquier otro caso, imprimimos el número
            else
            {
                Console.WriteLine(i);
            }
            
            /*4.	Imprime los números del 1 al 10 utilizando un bucle " while ".
             */
            int a = 1; // Inicializamos la variable en 1
            // Bucle while: se ejecutará mientras 'i' sea menor o igual a 10
            while (a <= 10)
            {
                Console.WriteLine(a); // Imprimimos el valor actual de 'i'
                a++; // Incrementamos el valor de 'i' en 1
            }

            /*5.	Calcula la suma de los primeros 100 números enteros utilizando un bucle " while ".
             */
            int b = 1; // Inicializamos la variable en 1
            int suma = 0; // Inicializamos la variable para acumular la suma

            // Bucle while: se ejecutará mientras 'i' sea menor o igual a 100
            while (b <= 100)
            {
                suma += b; // Sumamos el valor actual de 'i' a la variable 'suma'
                b++; // Incrementamos el valor de 'i' en 1
            }

            // Imprimimos el resultado final
            Console.WriteLine("La suma de los primeros 100 números enteros es: " + suma);

            /*6.	Imprimir los números pares que hay dentro de los 100 primeros números enteros utilizando un bucle " while ".*/
            int c = 2; // Inicializamos la variable en 2, el primer número par

            // Bucle while: se ejecutará mientras 'i' sea menor o igual a 100
            while (c <= 100)
            {
                Console.WriteLine(c); // Imprimimos el número actual
                c += 2; // Incrementamos en 2 para obtener el siguiente número par
            }
        }

    }
}

