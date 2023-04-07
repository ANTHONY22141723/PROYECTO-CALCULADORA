


// See https://aka.ms/new-console-template for more information

using System.ComponentModel.Design;
using System.Runtime.Intrinsics;

string entrada = "";
string RED = Console.IsOutputRedirected ? "" : "\x1b[91m";
string NORMAL = Console.IsOutputRedirected ? "" : "\x1b[39m";
string GREEN = Console.IsOutputRedirected ? "" : "\x1b[92m";
string YELLOW = Console.IsOutputRedirected ? "" : "\x1b[93m";
string BLUE = Console.IsOutputRedirected ? "" : "\x1b[94m";
string MAGENTA = Console.IsOutputRedirected ? "" : "\x1b[95m";
string CYAN = Console.IsOutputRedirected ? "" : "\x1b[96m";
string GREY = Console.IsOutputRedirected ? "" : "\x1b[97m";
string BOLD = Console.IsOutputRedirected ? "" : "\x1b[1m";
string NOBOLD = Console.IsOutputRedirected ? "" : "\x1b[22m";
string UNDERLINE = Console.IsOutputRedirected ? "" : "\x1b[4m";
string NOUNDERLINE = Console.IsOutputRedirected ? "" : "\x1b[24m";
string REVERSE = Console.IsOutputRedirected ? "" : "\x1b[7m";
string NOREVERSE = Console.IsOutputRedirected ? "" : "\x1b[27m";
string entradaMinuscula = "";
//double suma = 0;
double sumaAcumulada = 0;
string operacion = "";
int contador = 0;
double poteResult = 0;
double exponente = 0;
double basse = 0;

Calculadora();
void RealizarOtraOperacion()
{

    Console.Clear();
    sumaAcumulada = 0;
    entrada = "";
    operacion = "";
    poteResult = 0;
    exponente = 0;
    contador = 0;
    basse = 0;
    Calculadora();
}

//DECLARACION OPCIONES USUARIO
void OpcionesUsuario()
{

    while (operacion != "si" && operacion != "no")
    {

        Console.WriteLine($"                                                 {BLUE}        DESEA REALIZAR OTRA OPERACION ?, 'SI' ES AFIRMATIVO ESCRIBA 'SI' En caso contrario 'NO' para salir del programa{NORMAL} ");

        string otraOperacion = Console.ReadLine();
        operacion = otraOperacion.ToLower();

        if (operacion != "si" && operacion != "no") Console.WriteLine($"{RED} --- Este valor no es valido, intruduce 'si o 'no' ---{NORMAL} ");

    }

    Console.WriteLine();

    if (operacion == "no")
    {
        Console.Clear();
        Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
        Console.WriteLine($"                                {BLUE}     -----------GRACIAS POR UTILIZAR NUESTRA CALCULADORA CIENTIFICA. PRESIONA UNA TECLA PARA SALIR DEL PROGRAMA----------- {NORMAL}");
        Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
        Environment.Exit(0);
        Console.ReadKey();
        Console.WriteLine();

    }

}




void Calculadora()
{
    Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n");
    Console.BackgroundColor = ConsoleColor.Yellow;
    Console.WriteLine($"                               {BLUE}   ----------------------BIENVENIDO A LA CALCULADORA CIENTIFICA DE ' WALLY, RICARDO, KENNETH, Y KAREN '!---------------------- {NORMAL}");
    Console.WriteLine("\n\n\n");

    Console.WriteLine($"                                        {BLUE}                            SELECCIONA UNA OPCION DIGITANDO UN NUMERO POR FAVOR:{NORMAL} \n\n\n");
    Console.WriteLine($"                                                       {BLUE}1. SUMA{NORMAL}                    {BLUE}  2. RESTA{NORMAL}                         {BLUE} 3. MULTIPLICACION{NORMAL}\n ");

    Console.WriteLine($"                                                       {BLUE}4. DIVISION{NORMAL}                {BLUE}  5. RAIZ CUADRADA{NORMAL}                {BLUE}  6. POTENCIA{NORMAL} \n");


    Console.WriteLine($"                                                      {BLUE} 7. PI      {NORMAL}                {BLUE}  8. PORCENTAJE{NORMAL}                     {BLUE}9. REDONDEAR{NORMAL} \n");



    Console.WriteLine($"                                                      {BLUE}10. MODULO{NORMAL}                   {BLUE}11. LOGARITMO BASE DIEZ{NORMAL}           {BLUE}12. LOGARITMO NATURAL{NORMAL}  \n\n\n\n\n\n");

    Console.WriteLine($"                                                                                        {BLUE}15. SALIR{NORMAL}\n");

    string opcion = "";
    opcion = Console.ReadLine();

    switch (opcion)
    {
        case "1":
            Console.WriteLine($"                                                                            {BLUE} 1  Has seleccionado la opcion{MAGENTA} 'SUMA'{NORMAL} ");
            Suma();
            break;

        case "2":
            Console.WriteLine($"                                                                            {BLUE}  2  Has seleccionado la opcion {MAGENTA}'RESTA'{NORMAL} ");
            Restar();
            break;


        case "3":
            Console.WriteLine($"                                                                             {BLUE} 3  Has seleccionado la opcion {MAGENTA}'MULTIPLICAR'{NORMAL} ");
            Multiplicar();
            break;


        case "4":
            Console.WriteLine($"                                                                            {BLUE} 4   Has seleccionado la opcion{MAGENTA} 'DIVIDIR'{NORMAL} ");
            Dividir();
            break;


        case "5":
            Console.WriteLine($"                                                                           {BLUE}  5   Has seleccionado la opcion{MAGENTA} 'RAIZ'{NORMAL} ");
            RaizCuadrada();
            break;

        case "6":
            Console.WriteLine($"                                                                            {BLUE} 6   Has seleccionado la opcion {MAGENTA}'POTENCIA'{NORMAL} ");
            Potencia();
            break;

        case "7":
            Console.WriteLine($"                                                                             {BLUE} 7  Has seleccionado la opcion {MAGENTA}'PI'{NORMAL}");
            PI();
            break;

        case "8":
            Console.WriteLine($"                                                                             {BLUE} 8  Has seleccionado la opcion {MAGENTA}'PORCENTAJE'{NORMAL} ");
            Porcentaje();
            break;

        case "9":
            Console.WriteLine($"                                                                             {BLUE}  9 Has seleccionado la opcion {MAGENTA}'REDONDEAR'{NORMAL} ");
            Redondear();
            break;

        case "10":
            Console.WriteLine($"                                                                            {BLUE}  10  Has seleccionado la opcion {MAGENTA}'MODULO'{NORMAL} ");
            Modulo();
            break;

        case "11":
            Console.WriteLine($"                                                                           {BLUE}  11   Has seleccionado la opcion {MAGENTA}'LOGARITMO BASE DIEZ'{NORMAL} ");
            LogaritmoBaseDiez();
            break;

        case "12":
            Console.WriteLine($"                                                                           {BLUE}  12     Has seleccionado la opcion {MAGENTA}'LOGARITMO NATURAL' {NORMAL}");
            LogaritmoNatural();
            break;



        case "15":
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n");
            Console.WriteLine($"                                                {BLUE}   ------------ SELECCIONASTE LA OPCION{MAGENTA} 'salir'{NORMAL}.{BLUE}  PRESIONA UNA TECLA PARA SALIR DE LA APLICACION.------------{NORMAL} ");

            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
            Environment.Exit(0);
            Console.ReadKey();
            Console.ReadLine();
            break;

        default:
            Console.WriteLine($"                                                                          {RED}       La opcion {opcion} 'no es valida'. Presiona una tecla para volver al menu principal{NORMAL} ");
            Console.ReadKey();
            Console.Clear();
            Calculadora();
            break;


    }

}



//SUMA
void Suma()
{
    double suma = 0;
    Console.WriteLine();

    while (entrada != "=")
    {
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        if (sumaAcumulada > 0) Console.WriteLine($"                                                                                {CYAN}    DAME EL SIGUIENTE NUMERO PARA {MAGENTA}SUMAR, DE LO CONTRARIO OPRIME '=' PARA TERMINAR DE SUMAR{NORMAL}");
        else Console.WriteLine($"                                                                            {CYAN}    DAME EL PRIMER NUMERO PARA{MAGENTA} SUMAR, DE LO CONTRARIO OPRIME '=' PARA TERMINAR DE SUMAR{NORMAL}");
        entrada = Console.ReadLine();
        entradaMinuscula = entrada.ToLower();
        Console.WriteLine($"                                                                                           {BLUE}   {entradaMinuscula}{NORMAL}");

        if (entradaMinuscula != "=")

            if (entradaMinuscula == "volver")
            {
                Console.Clear();
                Calculadora();
            }

        if (double.TryParse(entradaMinuscula, out suma))
        {
            if (suma == 0) Console.WriteLine($"                                                                                               {RED} '{entradaMinuscula}'     Introduce un valor diferente de cero.  PARA VOLVER AL MENU PRINCIPAL ESCRIBE {MAGENTA}'VOLVER'{NORMAL}  ");
            else { sumaAcumulada += suma; contador++; }

        }
        else Console.WriteLine($"                                                                               {RED} '{entradaMinuscula}'  Este valor no es valido, introduce un valor numerico.  PARA VOLVER AL MENU PRINCIPAL ESCRIBE {MAGENTA}'VOLVER'{NORMAL}");

    }

    Console.Clear();
    Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
    Console.WriteLine($"                                                                                    {BLUE}    EL VALOR DE LA SUMA ES{MAGENTA} {sumaAcumulada}{NORMAL}");
    Console.WriteLine("");



    //OPCIONES USUARIO
    OpcionesUsuario();
    if (operacion == "si") RealizarOtraOperacion();


}




//RESTAR
void Restar()
{

    double suma = 0;
    Console.WriteLine();



    int contador = 0;
    while (entrada != "=")
    {

        if (contador > 0) Console.WriteLine($"                                                                       {CYAN}    DAME EL SIGUIENTE NUMERO PARA {MAGENTA}RESTAR, DE LO CONTRARIO OPRIME '=' PARA TERMINAR DE RESTAR{NORMAL}");
        else Console.WriteLine($"                                                                              {CYAN}    DAME EL PRIMER NUMERO PARA{MAGENTA} RESTAR, DE LO CONTRARIO OPRIME '=' PARA TERMINAR DE RESTAR{NORMAL}");

        entrada = Console.ReadLine();
        entradaMinuscula = entrada.ToLower();
        Console.WriteLine($"                                                                                           {BLUE}   {entradaMinuscula}{NORMAL}");
        if (entradaMinuscula != "=")
        {
            if (entradaMinuscula == "volver")
            {
                Console.Clear();
                Calculadora();
            }

            if (double.TryParse(entradaMinuscula, out suma))
            {
                if (suma == 0) Console.WriteLine($"                                                                 {RED} '{entradaMinuscula}'     Introduce un valor diferente de cero.  PARA VOLVER AL MENU PRINCIPAL ESCRIBE {MAGENTA}'VOLVER'{NORMAL}  ");
                else { sumaAcumulada -= suma; contador++; }

            }
            else Console.WriteLine($"                                                                             {RED} '{entradaMinuscula}'  Este valor no es valido, introduce un valor numerico.  PARA VOLVER AL MENU PRINCIPAL ESCRIBE {MAGENTA}'VOLVER'{NORMAL}");


        }

    }



    Console.Clear();
    Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
    Console.WriteLine($"                                                                                           {BLUE}    EL VALOR DE LA RESTA ES{MAGENTA} {sumaAcumulada}{NORMAL}");
    Console.WriteLine("");


    //OPCIONES USUARIO
    OpcionesUsuario();
    if (operacion == "si") RealizarOtraOperacion();
}

//MULTIPLICACION
void Multiplicar()
{
    double suma = 0;
    Console.WriteLine();
    double multiAcumulado = 0;
    int contador = 0;
    while (entrada != "=")
    {

        if (contador > 0) Console.WriteLine($"                                                                       {CYAN}    DAME EL SIGUIENTE NUMERO PARA {MAGENTA}MULTIPLICAR, DE LO CONTRARIO OPRIME '=' PARA TERMINAR DE MULTIPLICAR{NORMAL}");
        else Console.WriteLine($"                                                                              {CYAN}    DAME EL PRIMER NUMERO PARA{MAGENTA} MULTIPLICAR, DE LO CONTRARIO OPRIME '=' PARA TERMINAR DE MULTIPLICAR{NORMAL}");

        entrada = Console.ReadLine();
        entradaMinuscula = entrada.ToLower();
        Console.WriteLine($"                                                                                           {BLUE}   {entradaMinuscula}{NORMAL}");

        if (entradaMinuscula != "=")
        {
            if (entradaMinuscula == "volver")
            {
                Console.Clear();
                Calculadora();
            }

            if (double.TryParse(entradaMinuscula, out suma))
            {
                if (suma == 0) Console.WriteLine($"                                                                {RED} '{entradaMinuscula}'     Introduce un valor diferente de cero.  PARA VOLVER AL MENU PRINCIPAL ESCRIBE {MAGENTA}'VOLVER'{NORMAL}  ");
                if (multiAcumulado == 0) { multiAcumulado = suma; contador++; } else multiAcumulado *= suma;
            }
            else Console.WriteLine($"                                                                                {RED} '{entradaMinuscula}'  Este valor no es valido, introduce un valor numerico.  PARA VOLVER AL MENU PRINCIPAL ESCRIBE {MAGENTA}'VOLVER'{NORMAL}");




        }


    }


    Console.Clear();
    Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
    Console.WriteLine($"                                                                                         {BLUE}    EL VALOR DE LA MULTIPLICACION ES{MAGENTA} {multiAcumulado}{NORMAL}");
    Console.WriteLine("");



    //OPCIONES USUARIO
    OpcionesUsuario();
    if (operacion == "si") RealizarOtraOperacion();
}


//DIVIDIR
void Dividir()
{

    double suma = 0;
    Console.WriteLine();
    double diviiAcumulado = 0;
    int contador = 0;
    while (entrada != "=")
    {

        if (contador > 0) Console.WriteLine($"                                                                      {CYAN}    DAME EL SIGUIENTE NUMERO PARA {MAGENTA}DIVIDIR, DE LO CONTRARIO OPRIME '=' PARA TERMINAR DE DIVIDIR {NORMAL}");
        else Console.WriteLine($"                                                                               {CYAN}    DAME EL PRIMER NUMERO PARA{MAGENTA} DIVIDIR, DE LO CONTRARIO OPRIME '=' PARA TERMINAR DE DIVIDIR{NORMAL}");
        entrada = Console.ReadLine();
        entradaMinuscula = entrada.ToLower();
        Console.WriteLine($"                                                                                           {BLUE}   {entradaMinuscula} {NORMAL}");


        if (entradaMinuscula != "=")
        {
            if (entradaMinuscula == "volver")
            {
                Console.Clear();
                Calculadora();
            }

            if (double.TryParse(entradaMinuscula, out suma))
            {
                if (suma == 0) Console.WriteLine($"                                                                  {RED} '{entradaMinuscula}'     Introduce un valor diferente de cero.  PARA VOLVER AL MENU PRINCIPAL ESCRIBE {MAGENTA}'VOLVER'{NORMAL}  ");
                if (diviiAcumulado == 0) { diviiAcumulado = suma; contador++; } else diviiAcumulado /= suma;
            }
            else Console.WriteLine($"                                                                                   {RED} '{entradaMinuscula}'  Este valor no es valido, introduce un valor numerico.  PARA VOLVER AL MENU PRINCIPAL ESCRIBE {MAGENTA}'VOLVER'{NORMAL}");





        }


    }


    Console.Clear();
    Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
    Console.WriteLine($"                                                                                         {BLUE}    EL VALOR DE LA DIVISION ES{MAGENTA} {diviiAcumulado}{NORMAL}");
    Console.WriteLine("");



    //OPCIONES USUARIO
    OpcionesUsuario();
    if (operacion == "si") RealizarOtraOperacion();
}



void Potencia()
{
    double poteResult = 0;
    double exponente = 0;
    Console.WriteLine();
    double basse = 0;
    int limpiar = 0;

potenccia:
    while (entrada != "=" && contador < 2)
    {


        if (contador == 0)
        {
            Console.WriteLine();
            Console.WriteLine($"                                                                                   {CYAN}A CUAL NUMERO LE BUSCAS LA POTENCIA ?  PARA VOLVER AL MENU PRINCIPAL ESCRIBE 'VOLVER' {NORMAL} ");
            entrada = Console.ReadLine(); entradaMinuscula = entrada.ToLower();

        }



        else if (contador == 1)
        {
            Console.WriteLine();
            Console.WriteLine($"                                                                                 {CYAN}  DIME A QUE POTENCIA LO QUIERES ELEVAR.  PARA VOLVER AL MENU PRINCIPAL ESCRIBE 'VOLVER' {NORMAL} ");
            entrada = Console.ReadLine(); entradaMinuscula = entrada.ToLower();

        }



        if (entradaMinuscula != "=" && basse == 0)
        {
            if (entradaMinuscula == "volver")
            {
                Console.Clear();
                Calculadora();
            }

            if (double.TryParse(entradaMinuscula, out basse))
            {

                if (basse == 0) { Console.WriteLine($"                                                                                     {RED}  Introduce un valor diferente de cero.  PARA VOLVER AL MENU PRINCIPAL ESCRIBE 'VOLVER' {NORMAL} "); goto potenccia; }

                else { contador++; goto potenccia; }


            }
            else { Console.WriteLine($"                                                                                                    {RED}    Este valor no es valido, introduce un valor numerico.  PARA VOLVER AL MENU PRINCIPAL ESCRIBE 'VOLVER' {NORMAL} "); goto potenccia; }

        }


        if (entradaMinuscula != "=" && exponente == 0)
        {
            if (entradaMinuscula == "volver")
            {
                Console.Clear();
                Calculadora();
            }

            if (double.TryParse(entradaMinuscula, out exponente))
            {

                if (exponente == 0) { Console.WriteLine($"                                                                                    {RED}   Introduce un valor diferente de cero.  PARA VOLVER AL MENU PRINCIPAL ESCRIBE 'VOLVER'  {NORMAL}"); goto potenccia; }

                else
                {
                    poteResult = Math.Pow(basse, exponente);
                    contador++;

                }

            }
            else { Console.WriteLine($"                                                                                                        {RED}  Este valor no es valido, introduce un valor numerico.  PARA VOLVER AL MENU PRINCIPAL ESCRIBE 'VOLVER' {NORMAL} "); goto potenccia; }

        }



    }

    Console.Clear();
    Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
    Console.WriteLine($"                                                                                  {BLUE}     {basse} ELEVADO A {exponente} ES {poteResult} {NORMAL}");
    Console.WriteLine("");



    //OPCIONES USUARIO
    OpcionesUsuario();
    if (operacion == "si") RealizarOtraOperacion();



}




//RAIZ
void RaizCuadrada()
{

    Console.WriteLine();



potenccia:
    while (entrada != "=" && contador < 2)
    {

        if (contador == 0)
        {
            Console.WriteLine();
            Console.WriteLine($"                                                                                   {CYAN}  A CUAL NUMERO LE BUSCAS LA RAIZ CUADRADA.  PARA VOLVER AL MENU PRINCIPAL ESCRIBE 'VOLVER' {NORMAL}  ? ");
            entrada = Console.ReadLine(); entradaMinuscula = entrada.ToLower();

        }

        if (entradaMinuscula != "=" && basse == 0)
        {
            if (entradaMinuscula == "volver")
            {
                Console.Clear();
                Calculadora();
            }

            if (double.TryParse(entradaMinuscula, out basse))
            {

                if (basse == 0) { Console.WriteLine($"                                                                                     {RED}   Introduce un valor diferente de cero.  PARA VOLVER AL MENU PRINCIPAL ESCRIBE 'VOLVER'  {NORMAL}"); goto potenccia; }

                else { contador++; goto potenccia; }


            }
            else { Console.WriteLine($"                                                                                       {RED}     Este valor no es valido, introduce un valor numerico.  PARA VOLVER AL MENU PRINCIPAL ESCRIBE 'VOLVER' {NORMAL}"); goto potenccia; }

        }

        break;

    }

    Console.Clear();
    Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
    Console.WriteLine($"                                                                                                       {BLUE}  LA RAIZ CUADRADA DE {basse} ES  {Math.Sqrt(basse)} {NORMAL}");
    Console.WriteLine("");



    //OPCIONES USUARIO
    OpcionesUsuario();
    if (operacion == "si") RealizarOtraOperacion();



}



//PI
void PI()
{

    Console.WriteLine();


    //Console.WriteLine(Math.PI);

    Console.Clear();
    Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
    Console.WriteLine($"                                                                                   {BLUE}      LA CONSTANTE PI ES IGUAL A: {Math.PI}{NORMAL}");
    Console.WriteLine("");



    //OPCIONES USUARIO
    OpcionesUsuario();
    if (operacion == "si") RealizarOtraOperacion();

}


//PORCENTAJE

void Porcentaje()
{


    double poteResult = 0;
    double exponente = 0;
    Console.WriteLine();
    double basse = 0;
    int limpiar = 0;

potenccia:
    while (entrada != "=" && contador < 2)
    {

        if (contador == 0)
        {
            Console.WriteLine();
            Console.WriteLine($"                                                                             {CYAN}    QUE PORCENTAJE QUIERES BUSCAR.  PARA VOLVER AL MENU PRINCIPAL ESCRIBE 'VOLVER' {NORMAL} ");
            entrada = Console.ReadLine(); entradaMinuscula = entrada.ToLower();

        }



        else if (contador == 1)
        {
            Console.WriteLine();
            Console.WriteLine($"                                                                               {CYAN}    A QUE NUMERO.  PARA VOLVER AL MENU PRINCIPAL ESCRIBE 'VOLVER' {NORMAL} ");
            entrada = Console.ReadLine(); entradaMinuscula = entrada.ToLower();

        }



        if (entradaMinuscula != "=" && basse == 0)
        {
            if (entradaMinuscula == "volver")
            {
                Console.Clear();
                Calculadora();
            }

            if (double.TryParse(entradaMinuscula, out basse))
            {

                if (basse == 0) { Console.WriteLine($"                                                         {RED}   Introduce un valor diferente de cero.  PARA VOLVER AL MENU PRINCIPAL ESCRIBE 'VOLVER'  {NORMAL}"); goto potenccia; }

                else { contador++; goto potenccia; }


            }
            else { Console.WriteLine($"                                                                         {RED}     Este valor no es valido, introduce un valor numerico.  PARA VOLVER AL MENU PRINCIPAL ESCRIBE 'VOLVER'  {NORMAL}"); goto potenccia; }

        }


        if (entradaMinuscula != "=" && exponente == 0)
        {
            if (entradaMinuscula == "volver")
            {
                Console.Clear();
                Calculadora();
            }

            if (double.TryParse(entradaMinuscula, out exponente))
            {

                if (exponente == 0) { Console.WriteLine($"                                                    {RED}   Introduce un valor diferente de cero.  PARA VOLVER AL MENU PRINCIPAL ESCRIBE 'VOLVER'  {NORMAL} "); goto potenccia; }

                else
                {
                    poteResult = basse / 100 * exponente;
                    contador++;

                }

            }
            else { Console.WriteLine($"                                                                       {RED}    Este valor no es valido, introduce un valor numerico.  PARA VOLVER AL MENU PRINCIPAL ESCRIBE 'VOLVER'   {NORMAL}"); goto potenccia; }

        }



    }

    Console.Clear();
    Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
    Console.WriteLine($"                                                                                      {BLUE}     EL {basse} PORCIENTO DE {exponente} ES {poteResult} {NORMAL}");
    Console.WriteLine("");



    //OPCIONES USUARIO
    OpcionesUsuario();
    if (operacion == "si") RealizarOtraOperacion();



}



//REDONDEAR

void Redondear()
{

    Console.WriteLine();



potenccia:
    while (entrada != "=" && contador < 2)
    {

        if (contador == 0)
        {
            Console.WriteLine();
            Console.WriteLine($"                                                                                  {CYAN}   QUE NUMERO QUIERES REDONDEAR.   PARA VOLVER AL MENU PRINCIPAL ESCRIBE 'VOLVER' {NORMAL} ");
            entrada = Console.ReadLine(); entradaMinuscula = entrada.ToLower();

        }

        if (entradaMinuscula != "=" && basse == 0)
        {
            if (entradaMinuscula == "volver")
            {
                Console.Clear();
                Calculadora();
            }

            if (double.TryParse(entradaMinuscula, out basse))
            {

                if (basse == 0) { Console.WriteLine($"                                                           {RED}    Introduce un valor diferente de cero.  PARA VOLVER AL MENU PRINCIPAL ESCRIBE 'VOLVER' {NORMAL} "); goto potenccia; }

                else { contador++; goto potenccia; }


            }
            else { Console.WriteLine($"                                                                           {RED}     Este valor no es valido, introduce un valor numerico PARA VOLVER AL MENU PRINCIPAL ESCRIBE 'VOLVER' {NORMAL}"); goto potenccia; }

        }

        break;

    }

    Console.Clear();
    Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
    Console.WriteLine($"                                                                                      {BLUE}      EL NUMERO {basse} REDONDEADO ES  {Math.Round(basse)} {NORMAL}");
    Console.WriteLine("");



    //OPCIONES USUARIO
    OpcionesUsuario();
    if (operacion == "si") RealizarOtraOperacion();



}


//MODULO

void Modulo()
{


    double poteResult = 0;
    double exponente = 0;
    Console.WriteLine();
    double basse = 0;
    int limpiar = 0;

potenccia:
    while (entrada != "=" && contador < 2)
    {

        if (contador == 0)
        {
            Console.WriteLine();
            Console.WriteLine($"                                                                                 {CYAN}    DAME EL PRIMER NUMERO.  PARA VOLVER AL MENU PRINCIPAL ESCRIBE 'VOLVER' {NORMAL}");
            entrada = Console.ReadLine(); entradaMinuscula = entrada.ToLower();

        }



        else if (contador == 1)
        {
            Console.WriteLine();
            Console.WriteLine($"                                                                                  {CYAN}    DAME EL SEGUNDO NUMERO.  PARA VOLVER AL MENU PRINCIPAL ESCRIBE 'VOLVER' {NORMAL}");
            entrada = Console.ReadLine(); entradaMinuscula = entrada.ToLower();

        }



        if (entradaMinuscula != "=" && basse == 0)
        {
            if (entradaMinuscula == "volver")
            {
                Console.Clear();
                Calculadora();
            }

            if (double.TryParse(entradaMinuscula, out basse))
            {

                if (basse == 0) { Console.WriteLine($"                                                                                 {RED}   Introduce un valor diferente de cero.  PARA VOLVER AL MENU PRINCIPAL ESCRIBE 'VOLVER' {NORMAL}"); goto potenccia; }

                else { contador++; goto potenccia; }


            }
            else { Console.WriteLine($"                                                                                    {RED}     Este valor no es valido, introduce un valor numerico PARA VOLVER AL MENU PRINCIPAL ESCRIBE 'VOLVER' {NORMAL}"); goto potenccia; }

        }


        if (entradaMinuscula != "=" && exponente == 0)
        {
            if (entradaMinuscula == "volver")
            {
                Console.Clear();
                Calculadora();
            }

            if (double.TryParse(entradaMinuscula, out exponente))
            {

                if (exponente == 0) { Console.WriteLine($"                                                       {RED}    Introduce un valor diferente de cero.   PARA VOLVER AL MENU PRINCIPAL ESCRIBE 'VOLVER' {NORMAL}"); goto potenccia; }

                else
                {
                    poteResult = basse % exponente;
                    contador++;

                }

            }
            else { Console.WriteLine($"                                                                             {RED}     Este valor no es valido, introduce un valor numerico.  PARA VOLVER AL MENU PRINCIPAL ESCRIBE 'VOLVER'{NORMAL}"); goto potenccia; }

        }



    }

    Console.Clear();
    Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
    Console.WriteLine($"                                                                                             {BLUE}       EL RECIDUO DE DIVIDIR {basse} ENTRE {exponente} ES {poteResult} {NORMAL}");
    Console.WriteLine("");



    //OPCIONES USUARIO
    OpcionesUsuario();
    if (operacion == "si") RealizarOtraOperacion();



}



//LOGARITMO BASENDIEZ

void LogaritmoBaseDiez()
{

    Console.WriteLine();



potenccia:
    while (entrada != "=" && contador < 2)
    {

        if (contador == 0)
        {
            Console.WriteLine();
            Console.WriteLine($"                                                                                           {CYAN}     DE QUE NUMERO QUIERES EL LOGARITMO BASE DIEZ ?  PARA VOLVER AL MENU PRINCIPAL ESCRIBE 'VOLVER' {NORMAL} ");
            entrada = Console.ReadLine(); entradaMinuscula = entrada.ToLower();

        }

        if (entradaMinuscula != "=" && basse == 0)
        {
            if (entradaMinuscula == "volver")
            {
                Console.Clear();
                Calculadora();
            }

            if (double.TryParse(entradaMinuscula, out basse))
            {

                if (basse == 0) { Console.WriteLine($"                                                                                  {RED}      Introduce un valor diferente de cero. PARA VOLVER AL MENU PRINCIPAL ESCRIBE 'VOLVER' {NORMAL}  "); goto potenccia; }

                else { contador++; goto potenccia; }


            }
            else { Console.WriteLine($"                                                                                     {RED}     Este valor no es valido, introduce un valor numerico. PARA VOLVER AL MENU PRINCIPAL ESCRIBE 'VOLVER' {NORMAL}"); goto potenccia; }

        }

        break;

    }

    Console.Clear();
    Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
    Console.WriteLine($"                                                                                         {BLUE}        EL LOGARITMO BASE DIEZ DE {basse} ES  {Math.Log10(basse)} {NORMAL}");
    Console.WriteLine("");



    //OPCIONES USUARIO
    OpcionesUsuario();
    if (operacion == "si") RealizarOtraOperacion();



}



//LOGARITMO NATURAL

void LogaritmoNatural()
{

    Console.WriteLine();



potenccia:
    while (entrada != "=" && contador < 2)
    {

        if (contador == 0)
        {
            Console.WriteLine();
            Console.WriteLine($"                                                                                   {CYAN} DE QUE NUMERO QUIERES EL LOGARITMO NATURAL ?  PARA VOLVER AL MENU PRINCIPAL ESCRIBE 'VOLVER' {NORMAL}");
            entrada = Console.ReadLine(); entradaMinuscula = entrada.ToLower();

        }

        if (entradaMinuscula != "=" && basse == 0)
        {
            if (entradaMinuscula == "volver")
            {
                Console.Clear();
                Calculadora();
            }

            if (double.TryParse(entradaMinuscula, out basse))
            {

                if (basse == 0) { Console.WriteLine($"                                                                                    {RED}    Introduce un valor diferente de cero  PARA VOLVER AL MENU PRINCIPAL ESCRIBE 'VOLVER' {NORMAL}"); goto potenccia; }

                else { contador++; goto potenccia; }


            }
            else { Console.WriteLine($"                                                                                     {RED}  Este valor no es valido, introduce un valor numerico   PARA VOLVER AL MENU PRINCIPAL ESCRIBE 'VOLVER' {NORMAL} "); goto potenccia; }

        }

        break;

    }

    Console.Clear();
    Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
    Console.WriteLine($"                                                                                                      {BLUE}        EL LOGARITMO NATURAL DE {basse} ES  {Math.Log(basse)} {NORMAL}");
    Console.WriteLine("");



    //OPCIONES USUARIO
    OpcionesUsuario();
    if (operacion == "si") RealizarOtraOperacion();



}