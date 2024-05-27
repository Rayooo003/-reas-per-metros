//Es una caolección de clases e interfaces fundamentales en C#
using System;

//Clase para crear objetos y definir el tipo de datos y las operaciones disponibles
class TrianguloRectangulo
{
    //Static void es un método que no devuelve ningún valor, Main es el punto de entrada del programa 
    static void Main()
    {
        //Se imprime en la consola el mensaje "Carculadora de área"
        Console.WriteLine("Calculadora de área");

        //Se imprime en la consola una orden para el usuario indiando la opción a elegir 
        Console.WriteLine("Elige una opción:");

        //Se imprime en la consola la opción 1  área del rectángulo
        Console.WriteLine("1. Rectángulo Área");

        //Se imprime en la consola la opción 2 perímetro del triángulo 
        Console.WriteLine("2. Rectángulo Perímetro");

        //Se imprime en la consola la opción 2 área del triángulo 
        Console.WriteLine("3. Triángulo Área");

        //Se imprime en la consola la opción 2 perímetro rectángulo
        Console.WriteLine("4. Triángulo Perímetro");


        //lee la opción elegida por el usuario
        string opcion = Console.ReadLine();

        //Switch es una estructura de control, aquí lo usamos para ejecutar diferentes bloques en base a la opción elegida previamente
        switch (opcion)
        {

            //Si el usuario elige la opción 1 entonces se ejecuta el método CalcularAreaRectangulo para hacer el calculo del área de un rectángulo
            case "1":
                CalcularAreaRectangulo();

                //Break termina la ejección 
                break;

            //Si el usuario elige la opción 4 entonces se ejecuta el método Calcular PerimetroRectangulo para hacer el calculo del perímetro de un rectángulo
            case "2":
                CalculaPerimetroRectangulo();

                //Break termina la ejección 
                break;

            //Si el usuario elige la opción 2 entonces se ejecuta el método CalcularAreaTriangulo para hacer el calculo del área de un triángulo
            case "3":
                CalcularAreaTriangulo();

                //Break termina la ejección 
                break;

            //Si el usuario elige la opción 3 entonces se ejecuta el método CalcularPerimetroTriangulo para hacer el calculo del perímetro de un triángulo
            case "4":
                CalcularPerimetroTriangulo();

                //Break termina la ejección 
                break;

            //Default cómo su nombre lo indica es una opción prederminada en este caso se activa al ingresar una opción distinda de 1 o 2
            default:
                //Imprime en la pantalla  el mansaje "Opción no válida"
                Console.WriteLine("Opción no válida.");

                //Break termina la ejección 
                break;

        }
    }

    //Static void es un método que no devuelve ningún valor, CalcularAreaRectangulo es nombre del siguiente bloque de código a ejecutar
    static void CalcularAreaRectangulo()
    {
        //Imprime en la consola la instrucción de ingresar la medida de la altura
        Console.WriteLine("Ingrese la medida de la altura:");

        //Convert.ToDouble() es un método que convierte la entrada del usuario (que es una cadena de texto) a un número de tipo double.
        double Altura = Convert.ToDouble(Console.ReadLine());

        //Imprime en la consola la instrucción de ingresar la medida de la base
        Console.WriteLine("Ingrese la medida de la base:");

        //Convert.ToDouble() es un método que convierte la entrada del usuario (que es una cadena de texto) a un número de tipo double.
        double Base = Convert.ToDouble(Console.ReadLine());

        //Se establece una igualdad en dónde se expresa la multiplicación de la altura por la base es el área
        double area = Altura * Base;

        //Se imprime enla consola el mensaje "El área del rectángulo es" y el resultado de la operación anterior
        Console.WriteLine($"El área del rectángulo es: {area}");
    }

    static void CalcularAreaTriangulo()
    {
        //Imprime en la consola la instrucción de ingresar la medida de la altura
        Console.WriteLine("Ingrese la medida de la altura:");

        //Convert.ToDouble() es un método que convierte la entrada del usuario (que es una cadena de texto) a un número de tipo double.
        double AlturaT = Convert.ToDouble(Console.ReadLine());

        //Imprime en la consola la instrucción de ingresar la medida de la base
        Console.WriteLine("Ingrese la medida de la base:");

        //Convert.ToDouble() es un método que convierte la entrada del usuario (que es una cadena de texto) a un número de tipo double.
        double BaseT = Convert.ToDouble(Console.ReadLine());

        ///Se establece una igualdad en dónde se expresa la multiplicación de la altura por la base entre dos es el área
        double area = (AlturaT * BaseT) / 2;

        //Se imprime enla consola el mensaje "El área del triángulo es" y el resultado de la operación anterior
        Console.WriteLine($"El área del triángulo es: {area}");

    }
    static void CalculaPerimetroRectangulo()
    {
        //Imprime en la consola la instrucción de ingresar la medida de la altura
        Console.WriteLine("Ingrese la medida de la altura:");

        //Convert.ToDouble() es un método que convierte la entrada del usuario (que es una cadena de texto) a un número de tipo double.
        double Altura = Convert.ToDouble(Console.ReadLine());

        //Imprime en la consola la instrucción de ingresar la medida de la base
        Console.WriteLine("Ingrese la medida de la base:");

        //Convert.ToDouble() es un método que convierte la entrada del usuario (que es una cadena de texto) a un número de tipo double.
        double Base = Convert.ToDouble(Console.ReadLine());

        //Se establece una igualdad en dónde se expresa la multiplicación de la altura por la base es el área
        double perimetro = Altura * 2 + Base * 2;

        //Se imprime enla consola el mensaje "El área del rectángulo es" y el resultado de la operación anterior
        Console.WriteLine($"El perimetro del rectángulo es: {perimetro}");
    }
    static void CalcularPerimetroTriangulo()
    {
        //Imprime en la consola la instrucción de ingresar la medida de la primera cara
        Console.WriteLine("Ingrese la medida de la primera cara:");

        //Convert.ToDouble() es un método que convierte la entrada del usuario (que es una cadena de texto) a un número de tipo double.
        double T1 = Convert.ToDouble(Console.ReadLine());

        //Imprime en la consola la instrucción de ingresar la medida de la segunda cara
        Console.WriteLine("Ingrese la medida de la segunda cara");

        //Convert.ToDouble() es un método que convierte la entrada del usuario (que es una cadena de texto) a un número de tipo double.
        double T2 = Convert.ToDouble(Console.ReadLine());

        //Imprime en la consola la instrucción de ingresar la medida de la tercera cara
        Console.WriteLine("Ingrese la medida de la tercera cara");

        //Convert.ToDouble() es un método que convierte la entrada del usuario (que es una cadena de texto) a un número de tipo double.
        double T3 = Convert.ToDouble(Console.ReadLine());


        ///Se establece una igualdad en dónde se expresa la multiplicación de la altura por la base entre dos es el área
        double perimetro = T1 + T2 + T3;

        //Se imprime enla consola el mensaje "El área del triángulo es" y el resultado de la operación anterior
        Console.WriteLine($"El área del triángulo es: {perimetro}");
    }

}