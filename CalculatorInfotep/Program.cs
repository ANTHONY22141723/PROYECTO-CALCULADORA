

using System.Reflection.Metadata.Ecma335;
string? entradaMinuscula = "";
int opcionValida = 0;

repetir:


int Calcular(int opcion = -1)

    {
    nuevamente:
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine();
        Console.WriteLine("<-----CALCULADORA ORTODOXA INFOTEP----->");
        Console.WriteLine();

        Console.WriteLine("   QUE OPERACION MATEMATICA DESEA USTED REALIZAR?");
        Console.WriteLine();
        Console.WriteLine("   MENU: ");
        Console.WriteLine();
        Console.WriteLine("   Para sumar elija el '1', para restar elija el '2', para multiplicar elija el '3', para dividir elija el '4' ");
        Console.WriteLine("   Escribe 0 '2' veces para salir de la aplicacion ");
        Console.WriteLine();

   
         if (int.TryParse(Console.ReadLine(), out opcion)) opcionValida = opcion;
    else { Console.WriteLine("    -----SOLO SE PERMITEN VALORES NUMERICOS-----"); goto nuevamente; }

    switch (opcion)
        {
          
        case 0:
            Console.WriteLine("    Oprime cualquier tecla para salir ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            
               Environment.Exit(0);

            break;


        case 1:
                Console.WriteLine("     HAZ ELEJIDO LA OPCION: 'SUMAR'. AHORA DIME CUALES NUMEROS QUIERES SUMAR");
                Console.WriteLine();

                break;

            case 2:
                Console.WriteLine("     HAZ ELEJIDO LA OPCION: 'RESTAR' AHORA DIME CUALES NUMEROS QUIERES RESTAR");
                Console.WriteLine();
                break;

            case 3:
                Console.WriteLine("     HAZ ELEJIDO LA OPCION: 'MULTIPLICAR'. AHORA DIME CUALES NUMEROS QUIERES MULTIPLICAR");
                Console.WriteLine();
                break;

            case 4:
                Console.WriteLine("     HAZ ELEJIDO LA OPCION: 'DIVIDIR'. AHORA DIME CUALES NUMEROS QUIERES DIVIDIR");
                Console.WriteLine();
                break;



            default:
                Console.WriteLine("          ESTA OPCION NO ES VALIDA");
                Console.WriteLine();
           
            goto nuevamente;
           // break;
            

            


        }

        return opcion;
    }

    int cion = Calcular();
    Console.WriteLine();



    Console.WriteLine();

    double suma = 1;
    double sumando = 0;
    string? entrada = "";


if (cion == 1)
{

    Console.WriteLine();

    while (entrada != "=")
    {

        Console.WriteLine("  Digita el siguiente numero o ESCRIBE 'v' PARA VOLVER AL MENU. PARA MOSTRAR EL RESULTADO PRESIONA '='");
        Console.WriteLine();

        entrada = Console.ReadLine();
        entradaMinuscula = entrada.ToLower();
        if (entradaMinuscula != "v")
        {
            if (entradaMinuscula != "=")
            {
                //suma = double.Parse(entradaMinuscula);
                if (double.TryParse(entradaMinuscula, out suma)) sumando += suma;
                else Console.WriteLine("                 ------SOLO SE PERMITEN VALORES NUMERICOS-----");
            }

        }

        else
        {
            //Calcular();
            sumando = 0;
            goto repetir;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"   EL RESULTADO DE LA SUMA ES {sumando}");
    Console.WriteLine();
salir:
    Console.WriteLine();
    Console.WriteLine($" DESEAS REALIZAR OTRA OPERACION ?. ESCRIBE 'si' SI LA RESPUESTA ES AFIRMATIVA o ESCRIBE 'salir' PARA TERMINAR EL PROGRAMA");
    Console.WriteLine();


    entrada = Console.ReadLine();

    entradaMinuscula = entrada.ToLower();

    int temp = 0;

    if (int.TryParse(entradaMinuscula, out temp))
    {
        Console.WriteLine("   NO SE ACEPTAN VALORES NUMERICOS ");
        goto salir;
    }
    else
    {
        if (entradaMinuscula == "si") goto repetir;
        else if (entradaMinuscula == "salir")
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("    Oprime cualquier tecla para salir ");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Environment.Exit(0);



        }
        else if (entradaMinuscula != "si" && entradaMinuscula != "salir")
            Console.WriteLine("     Esta opcion no es valida ");
        goto salir;


    }


}





double resta = 1;
    double resulresta = 0;

    if (cion == 2)
    {

        Console.WriteLine();

        while (entrada != "=")
        {
            Console.WriteLine("  Digita el siguiente numero o ESCRIBE 'v' PARA VOLVER AL MENU. PARA MOSTRAR EL RESULTADO PRESIONA '='");
            Console.WriteLine();

            entrada = Console.ReadLine();
            entradaMinuscula = entrada.ToLower();

        if (entradaMinuscula != "v")
            {
                if (entradaMinuscula != "=")
                {
                //resta = double.Parse(entradaMinuscula);
                if (double.TryParse(entradaMinuscula, out resta)) resulresta -= resta;
                else Console.WriteLine("                 ------SOLO SE PERMITEN VALORES NUMERICOS-----");
                }
            }
            else
            {
                Calcular();
                resulresta = 0;
            }


        }
        Console.WriteLine();
        Console.WriteLine($"   EL RESULTADO DE LA RESTA ES {resulresta}");


salir:
    Console.WriteLine();
    Console.WriteLine($" DESEAS REALIZAR OTRA OPERACION ?. ESCRIBE 'si' SI LA RESPUESTA ES AFIRMATIVA o ESCRIBE 'salir' PARA TERMINAR EL PROGRAMA");
    Console.WriteLine();


    entrada = Console.ReadLine();

    entradaMinuscula = entrada.ToLower();

    int temp = 0;

    if (int.TryParse(entradaMinuscula, out temp))
    {
        Console.WriteLine("   NO SE ACEPTAN VALORES NUMERICOS ");
        goto salir;
    }
    else
    {
        if (entradaMinuscula == "si") goto repetir;
        else if (entradaMinuscula == "salir")
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("    Oprime cualquier tecla para salir ");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Environment.Exit(0);



        }
        else if (entradaMinuscula != "si" && entradaMinuscula != "salir")
            Console.WriteLine("     Esta opcion no es valida ");
        goto salir;


    }


}



double multiplicar = 1;
    double resulMultiplicar = 0;

    if (cion == 3)
    {


        Console.WriteLine();

        while (entrada != "=")
        {


            Console.WriteLine("  Digita el siguiente numero o ESCRIBE 'v' PARA VOLVER AL MENU. PARA MOSTRAR EL RESULTADO PRESIONA '='");
            Console.WriteLine();

            entrada = Console.ReadLine();
            entradaMinuscula = entrada.ToLower();

        if (entradaMinuscula != "v")
            {
                if (entradaMinuscula != "=")
                {
                // multiplicar = double.Parse(entradaMinuscula);
                if (double.TryParse(entradaMinuscula, out multiplicar));
                else Console.WriteLine("                 ------SOLO SE PERMITEN VALORES NUMERICOS-----");

                if (resulMultiplicar == 0) resulMultiplicar += multiplicar;
                    else if (multiplicar != 0) resulMultiplicar *= multiplicar;
                }
            }
            else
            {
                Calcular();
                resulMultiplicar = 0;
            }


        }
        Console.WriteLine();
        Console.WriteLine($"   EL RESULTADO DE LA MULTIPLICACION ES {resulMultiplicar}");

salir:
    Console.WriteLine();
    Console.WriteLine($" DESEAS REALIZAR OTRA OPERACION ?. ESCRIBE 'si' SI LA RESPUESTA ES AFIRMATIVA o ESCRIBE 'salir' PARA TERMINAR EL PROGRAMA");
    Console.WriteLine();


    entrada = Console.ReadLine();

    entradaMinuscula = entrada.ToLower();

    int temp = 0;

    if (int.TryParse(entradaMinuscula, out temp))
    {
        Console.WriteLine("   NO SE ACEPTAN VALORES NUMERICOS ");
        goto salir;
    }
    else
    {
        if (entradaMinuscula == "si") goto repetir;
        else if (entradaMinuscula == "salir")
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("    Oprime cualquier tecla para salir ");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Environment.Exit(0);



        }
        else if (entradaMinuscula != "si" && entradaMinuscula != "salir")
            Console.WriteLine("     Esta opcion no es valida ");
        goto salir;


    }


}



double divide = 1;
    double cociente = 0;

    if (cion == 4)
    {

        Console.WriteLine();

        while (entrada != "=")
        {

            Console.WriteLine("  Digita el siguiente numero o ESCRIBE 'v' PARA VOLVER AL MENU. PARA MOSTRAR EL RESULTADO PRESIONA '=' ");
            Console.WriteLine();

            entrada = Console.ReadLine();
            entradaMinuscula = entrada.ToLower();
        if (entradaMinuscula != "v")
            {
                if (entradaMinuscula != "=")
                {
                // divide = double.Parse(entradaMinuscula);
                if (double.TryParse(entradaMinuscula, out divide)) ;
                else Console.WriteLine("                 ------SOLO SE PERMITEN VALORES NUMERICOS-----");
                if (cociente == 0) cociente += divide;
                    else if (divide != 0)
                        cociente /= divide;

                }
            }
            else
            {
                Calcular();
                cociente = 0;
            }

        }
        Console.WriteLine();
        Console.WriteLine($"   EL RESULTADO DE LA DIVISION ES {cociente}");
    salir:
    Console.WriteLine();
    Console.WriteLine($" DESEAS REALIZAR OTRA OPERACION ?. ESCRIBE 'si' SI LA RESPUESTA ES AFIRMATIVA o ESCRIBE 'salir' PARA TERMINAR EL PROGRAMA");
    Console.WriteLine();

    
        entrada = Console.ReadLine();
      
        entradaMinuscula = entrada.ToLower();

    int temp = 0;

    if (int.TryParse(entradaMinuscula, out temp))
    {
        Console.WriteLine("   NO SE ACEPTAN VALORES NUMERICOS ");
        goto salir;
    }
    else
    {
        if (entradaMinuscula == "si") goto repetir;
        else if (entradaMinuscula == "salir")
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("    Oprime cualquier tecla para salir ");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Environment.Exit(0);



        }
        else if(entradaMinuscula != "si" && entradaMinuscula != "salir")
            Console.WriteLine("     Esta opcion no es valida ");
        goto salir;


    }




}
