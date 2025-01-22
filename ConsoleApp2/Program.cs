using System;

class Program
{
    static void Main()
    {
        /*1. Escribe un programa que evalúe si un número ingresado por el usuario es positivo, negativo o cero.
        Solicitar al usuario que ingrese un número*/
        Console.Write("Verificaremos si su número es positivo, negativo o cero. Ingresa un número: ");
        string input1 = Console.ReadLine(); // Leer la entrada del usuario
        double numero;

        // Intentamos convertir la entrada a un número
        if (double.TryParse(input1, out numero))
        {
            // Evaluamos si el número es positivo, negativo o cero
            if (numero > 0)
            {
                Console.WriteLine("El número es positivo.");
            }
            else if (numero < 0)
            {
                Console.WriteLine("El número es negativo.");
            }
            else
            {
                Console.WriteLine("El número es cero.");
            }
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor, ingresa un número válido.");
        }

        // 2. Solicitar al usuario que ingrese una calificación
        Console.Write("Verificaremos si aprueba o reprueba. Ingresa tu calificación (0 - 100): ");
        string input2 = Console.ReadLine(); // Leer la entrada del usuario
        int calificacion;

        // Intentamos convertir la entrada a un número entero
        if (int.TryParse(input2, out calificacion))
        {
            // Verificamos si la calificación está dentro del rango válido
            if (calificacion >= 0 && calificacion <= 100)
            {
                // Evaluamos si está aprobado o reprobado
                if (calificacion >= 60)
                {
                    Console.WriteLine("Aprobado");
                }
                else
                {
                    Console.WriteLine("Reprobado");
                }
            }
            else
            {
                Console.WriteLine("Por favor, ingresa una calificación entre 0 y 100.");
            }
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor, ingresa un número válido.");
        }

        /*3. Desarrolla un programa que pida al usuario ingrese un número y luego determine en qué rango se encuentra (por ejemplo: "Menor que 10", "Entre 10 y 20", "Mayor que 20") 
        Solicitar al usuario que ingrese un número*/
        Console.Write("Verificaremos en que rango esta su número. Ingresa un número: ");
        string input3 = Console.ReadLine(); // Leer la entrada del usuario
        double nume;

        // Intentamos convertir la entrada a un número
        if (double.TryParse(input3, out nume))
        {
            // Determinar el rango en el que se encuentra el número
            if (nume < 10)
            {
                Console.WriteLine("El número es menor que 10.");
            }
            else if (nume >= 10 && nume <= 20)
            {
                Console.WriteLine("El número está entre 10 y 20.");
            }
            else // Caso donde el número es mayor que 20
            {
                Console.WriteLine("El número es mayor que 20.");
            }
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor, ingresa un número válido.");
        }

        /*4. Escribe un programa que solicite al usuario ingresar un número del 1 al 7 y luego muestre el día de la semana correspondiente (por ejemplo: 1 para "Lunes", 2 para "Martes", etc.) 
        Solicitar al usuario que ingrese un número del 1 al 7*/
        Console.Write("Ingresa un número del 1 al 7 para obtener el día de la semana: ");
        string input4 = Console.ReadLine(); // Leer la entrada del usuario
        int num;

        // Intentamos convertir la entrada a un número entero
        if (int.TryParse(input4, out num))
        {
            // Determinar el día de la semana según el número ingresado
            switch (num)
            {
                case 1:
                    Console.WriteLine("Lunes");
                    break;
                case 2:
                    Console.WriteLine("Martes");
                    break;
                case 3:
                    Console.WriteLine("Miércoles");
                    break;
                case 4:
                    Console.WriteLine("Jueves");
                    break;
                case 5:
                    Console.WriteLine("Viernes");
                    break;
                case 6:
                    Console.WriteLine("Sábado");
                    break;
                case 7:
                    Console.WriteLine("Domingo");
                    break;
                default:
                    // Mensaje si el número está fuera del rango permitido
                    Console.WriteLine("Por favor, ingresa un número entre 1 y 7.");
                    break;
            }
        }
        else
        {
            // Mensaje si la entrada no es válida
            Console.WriteLine("Entrada inválida. Por favor, ingresa un número válido.");
        }

        /*5.	Ingresar 2 números y luego un carácter indicando la operación a realizar (+, -, *, /) y reportar el resultado de la operación utilizando la sentencia switch.
        Solicitar al usuario que ingrese el primer número*/
        Console.Write("Ahora realizaremos una operación. Ingresa el primer número: ");
        double numero1 = Convert.ToDouble(Console.ReadLine());

        // Solicitar al usuario que ingrese el segundo número
        Console.Write("Ingresa el segundo número: ");
        double numero2 = Convert.ToDouble(Console.ReadLine());

        // Solicitar al usuario que ingrese la operación a realizar
        Console.Write("Ingresa la operación (+, -, *, /): ");
        char operacion = Console.ReadKey().KeyChar; // Leer un solo carácter
        Console.WriteLine(); // Para mover el cursor a la siguiente línea

        // Realizar la operación correspondiente con switch
        double resultado = 0;
        bool operacionValida = true;

        switch (operacion)
        {
            case '+':
                resultado = numero1 + numero2;
                break;
            case '-':
                resultado = numero1 - numero2;
                break;
            case '*':
                resultado = numero1 * numero2;
                break;
            case '/':
                // Verificar que no se divida entre cero
                if (numero2 != 0)
                {
                    resultado = numero1 / numero2;
                }
                else
                {
                    Console.WriteLine("Error: No se puede dividir entre cero.");
                    operacionValida = false;
                }
                break;
            default:
                Console.WriteLine("Operación inválida.");
                operacionValida = false;
                break;
        }

        // Mostrar el resultado si la operación es válida
        if (operacionValida)
        {
            Console.WriteLine($"El resultado de {numero1} {operacion} {numero2} es: {resultado}");
        }
    }
}

