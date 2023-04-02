

int Calcular(int opcion = 0)

{
    Console.WriteLine();
    Console.WriteLine("<-----CALCULADORA ORTODOXA INFOTEP----->");
    Console.WriteLine();

    Console.WriteLine("   QUE OPERACION MATEMATICA DESEA USTED REALIZAR?");
    Console.WriteLine();
    Console.WriteLine("   MENU: ");
    Console.WriteLine();
    Console.WriteLine("   Para sumar elija el '1', para restar elija el '2', para multiplicar elija el '3', para dividir elija el '4' ");
   
    Console.WriteLine();
    opcion = int.Parse(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            Console.WriteLine("     HAZ ELEJIDO SUMAR. AHORA DIME CUALES NUMEROS QUIERES SUMAR");
            Console.WriteLine();

            break;

        case 2:
            Console.WriteLine("     HAZ ELEJIDO RESTAR. AHORA DIME CUALES NUMEROS QUIERES RESTAR");
            break;

        case 3:
            Console.WriteLine("     HAZ ELEJIDO MULTIPLICARAR. AHORA DIME CUALES NUMEROS QUIERES MULTIPLICAR");
            break;

        case 4:
            Console.WriteLine("     HAZ ELEJIDO DIVIDIR. AHORA DIME CUALES NUMEROS QUIERES DIVIDIR");
            break;



        default:
            Console.WriteLine("     ESTA OPCION NO ES VALIDA");
            break;


    }

    return opcion;
}

int cion = Calcular();
Console.WriteLine();



Console.WriteLine();

double suma = 1;
double sumando = 0;
string entrada = "";

if(cion== 1)
{

    Console.WriteLine();
  
    while(suma != 0)
    {
      
        Console.WriteLine("  Digita el siguiente numero o ESCRIBE 'b' PARA VOLVER AL MENU");
        Console.WriteLine();
       
         entrada = Console.ReadLine();
        if (entrada != "b")
        {
            suma = double.Parse(entrada);
            if (suma != 0)
                sumando += suma;
        }
        else
        {
            Calcular();
            sumando = 0;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"   EL RESULTADO DE LA SUMA ES {sumando}");
}




double resta = 1;
double resulresta = 0;

if (cion == 2)
{
 
    Console.WriteLine();

    while (resta != 0)
    {
        Console.WriteLine("  Digita el siguiente numero o ESCRIBE 'b' PARA VOLVER AL MENU");
        Console.WriteLine();

        entrada = Console.ReadLine();

        if (entrada != "b")
        {
            resta = double.Parse(entrada);
            if (resta != 0)
                resulresta += resta;
        }
        else
        {
            Calcular();
            resulresta = 0;
        }
  

    }
    Console.WriteLine();
    Console.WriteLine($"   EL RESULTADO DE LA RESTA ES {resulresta}");
}



double multiplicar = 1;
double resulMultiplicar = 0;

if (cion == 3)
{


    Console.WriteLine();

    while (multiplicar != 0)
    {


        Console.WriteLine("  Digita el siguiente numero o ESCRIBE 'b' PARA VOLVER AL MENU");
        Console.WriteLine();

        entrada = Console.ReadLine();

        if (entrada != "b")
        {
            multiplicar = double.Parse(entrada);
            if (multiplicar != 0)
                resulMultiplicar += multiplicar;
        }
        else
        {
            Calcular();
            resulMultiplicar = 0;
        }

      
        if (resulMultiplicar == 0) resulMultiplicar += multiplicar; 
        else if (multiplicar != 0) resulMultiplicar *= multiplicar;



    }
    Console.WriteLine();
    Console.WriteLine($"   EL RESULTADO DE LA MULTIPLICACION ES {resulMultiplicar}");
}



double divide = 1;
double cociente = 0;

if (cion == 4)
{

    //Console.WriteLine("     PARA VOLVER AL MENU DE OPCIONES elija el '0' ");
    //int menuOpciones = int.Parse(Console.ReadLine());
    //if (menuOpciones == 0)
    //    Calcular();

    Console.WriteLine();

    while (divide != 0)
    {
        // if(suma  1) Console.WriteLine("Digita el primer numero");
        Console.WriteLine("  Digita el siguiente numero");
        divide = double.Parse(Console.ReadLine());
        if (cociente == 0) cociente += divide;
        else if (divide != 0)
            cociente /= divide ;

    }
    Console.WriteLine();
    Console.WriteLine($"   EL RESULTADO DE LA DIVISION ES {cociente}");
}
