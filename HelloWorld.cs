using System;

namespace CSharpHelloWorld
{
    class HelloWorld
    {
        static void Main(string[] args)
        {
            //Hola mundo en C#
            Console.WriteLine("Hello, C#!");

            // Variables y tipos de datos
            string myString = "Esto es una cadena de texto en C#";
            myString = "Cambio de valor de la cadena";
            Console.WriteLine(myString);

            int myInt = 42;
            myInt = myInt + 8; // Suma 8 al valor original
            Console.WriteLine("El valor de myInt es: " + myInt);

            float myFloat = 3.14f;
            Console.WriteLine("El valor de myFloat es: " + myFloat);

            double myDouble = 3.14;
            Console.WriteLine("El valor de myDouble es: " + myDouble);

            bool myBool = true;
            Console.WriteLine("El valor de myBool es: " + myBool);

            var myVar = "Variable de tipo var";
            Console.WriteLine("El valor de myVar es: " + myVar);

            Console.WriteLine($"El valor de myInt es: {myInt}, el valor de myFloat es: {myFloat}, y el valor de myDouble es: {myDouble}");

            const int myConst = 100;
            Console.WriteLine("El valor de myConst es: " + myConst);

            //Estructuras 

            var myArray = new string[] { "Elemento1", "Elemento2", "Elemento3" };
            Console.WriteLine(myArray[0]);

            myArray[1] = "NuevoElemento2";
            Console.WriteLine(myArray[1]);

            var myDictionary = new Dictionary<string, int>
            {
                { "Clave1", 1 },
                { "Clave2", 2 },
                { "Clave3", 3 }
            };

            Console.WriteLine("Valor asociado a Clave1: " + myDictionary["Clave1"]);
            myDictionary["Clave2"] = 20; // Cambia el valor asociado a Clave2
            Console.WriteLine("Nuevo valor asociado a Clave2: " + myDictionary["Clave2"]);

            var mySet = new HashSet<string> { "ElementoA", "ElementoB", "ElementoC" };

            var myTuple = ("PrimerElemento", 42, true);
            Console.WriteLine(myTuple);


            //Bucles

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Bucle for, iteración: " + i);
            }

            foreach (var item in myArray)
            {
                Console.WriteLine("Bucle foreach, elemento: " + item);
            }

            foreach (var kvp in myDictionary)
            {
                Console.WriteLine($"Clave: {kvp.Key}, Valor: {kvp.Value}");
            }

            foreach (var item in mySet)
            {
                Console.WriteLine("Bucle foreach en Set, elemento: " + item);
            }

            foreach (var item in myTuple.GetType().GetFields())
            {
                Console.WriteLine("Bucle foreach en Tuple, elemento: " + item.GetValue(myTuple));
            }

            while (myInt < 50)
            {
                Console.WriteLine("Bucle while, myInt es: " + myInt);
                myInt++;
            }


            //Flujos de control y Funciones

            if (myInt == 50 && myBool == true)
            {
                Console.WriteLine("myInt es igual a 50");
            }
            else if (myInt > 50 || myBool == false)
            {
                Console.WriteLine("myInt es mayor que 50");
            }
            else
            {
                Console.WriteLine("myInt es menor que 50");
            }

            PrintMessage();
            FuncionRecogerMensaje("¡Hola desde una función en C#!");

            int resultado = Sumar(10, 20);
            Console.WriteLine("El resultado de la suma es: " + resultado);

            //llamado de clase
            var myClass = new MiClase("Juan", 30);
            Console.WriteLine($"{myClass.Nombre} tiene {myClass.Edad} años.");
        }

        static void PrintMessage()
        {
            Console.WriteLine("My first C# function!");
        }

        static void FuncionRecogerMensaje(string mensaje)
        {
            Console.WriteLine("Mensaje recibido: " + mensaje);
        }

        static int Sumar(int a, int b)
        {
            return a + b;
        }

        //Clases
        class MiClase
        {
            public string Nombre { get; set; }
            public int Edad { get; set; }

            public MiClase(string nombre, int edad)
            {
                Nombre = nombre;
                Edad = edad;
            }

            // public void MostrarInformacion()
            // {
            //     Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad}");
            // }
        }
    }
}


