


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
double suma = 0;
double diviiAcumulado = 0;
int contador = 0;
string operacion = "";

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
        Console.WriteLine($"                                    {BLUE}   ----------------------BIENVENIDO A LA CALCULADORA CIENTIFICA DE ' WALLY, RICARDO, KENNETH, Y KAREN '!---------------------- {NORMAL}");
        Console.WriteLine("\n\n\n");

        Console.WriteLine($"                                             {BLUE}                            SELECCIONA UNA OPCION DIGITANDO UN NUMERO POR FAVOR:{NORMAL} \n\n\n");
        Console.WriteLine($"                                                            {BLUE}1. SUMA{NORMAL}                    {BLUE}  2. RESTA{NORMAL}                         {BLUE} 3. MULTIPLICACION{NORMAL}\n\n ");

        Console.WriteLine($"                                                            {BLUE}4. DIVISION{NORMAL}                {BLUE}  5. RAIZ CUADRADA{NORMAL}                {BLUE}  6. POTENCIA{NORMAL} \n\n");


        Console.WriteLine($"                                                           {BLUE} 7. PI      {NORMAL}                {BLUE}  8. PORCENTAJE{NORMAL}                     {BLUE}9. REDONDEAR{NORMAL} \n\n");



        Console.WriteLine($"                                                           {BLUE}10. MODULO{NORMAL}                   {BLUE}11. LOGARITMO BASE DIEZ{NORMAL}           {BLUE}12. LOGARITMO NATURAL{NORMAL}  \n\n");
        Console.WriteLine($"                                                           {BLUE}13. SENO{NORMAL}                     {BLUE}14. COSENO{NORMAL}                        {BLUE}15. TANGENTE{NORMAL}  \n\n");
        Console.WriteLine($"                                                           {BLUE}16. COTANGENTE{NORMAL}               {BLUE}17. SECANTE{NORMAL}                       {BLUE}18. COSECANTE{NORMAL}  \n\n\n\n\n\n");

        Console.WriteLine($"                                                                                          {BLUE}20. SALIR{NORMAL}\n");
         
        

    string opcion = "";
    opcion = Console.ReadLine();
    Console.Clear();
    Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
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

        case "13":
            Console.WriteLine($"                                                                           {BLUE}  13     Has seleccionado la opcion {MAGENTA}'SENO' {NORMAL}");
            Seno();
            break;

        case "14":
            Console.WriteLine($"                                                                           {BLUE}  14     Has seleccionado la opcion {MAGENTA}'COSENO' {NORMAL}");
            Coseno();
            break;

        case "15":
            Console.WriteLine($"                                                                           {BLUE}  15     Has seleccionado la opcion {MAGENTA}'TANGENTE' {NORMAL}");
            Tangente();
            break;

        case "16":
            Console.WriteLine($"                                                                           {BLUE}  16     Has seleccionado la opcion {MAGENTA}'COTANGENTE' {NORMAL}");
            Cotangente();
            break;

        case "17":
            Console.WriteLine($"                                                                           {BLUE}  17     Has seleccionado la opcion {MAGENTA}'SECANTE' {NORMAL}");
            Secante();
            break;

        case "18":
            Console.WriteLine($"                                                                           {BLUE}  18     Has seleccionado la opcion {MAGENTA}'COSECANTE' {NORMAL}");
            Cosecante();
            break;

        case "20":
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

    suma = 0;
    Console.WriteLine();
    diviiAcumulado = 0;
    contador = 0;
    int cuentaceros = 0;
    
    while (entrada != "=" && entrada != "0")
    {
        

        if (contador > 0) Console.WriteLine($"                                                                      {CYAN}    DAME EL SIGUIENTE NUMERO PARA {MAGENTA}DIVIDIR, DE LO CONTRARIO OPRIME '=' PARA TERMINAR DE DIVIDIR {NORMAL}");
        else Console.WriteLine($"                                                                               {CYAN}    DAME EL PRIMER NUMERO PARA{MAGENTA} DIVIDIR, DE LO CONTRARIO OPRIME '=' PARA TERMINAR DE DIVIDIR{NORMAL}");
        entrada = Console.ReadLine();
        entradaMinuscula = entrada.ToLower();

        if (entradaMinuscula == "0" && cuentaceros > 0) divicero(); 
        Console.WriteLine($"                                                                                           {BLUE}   {entradaMinuscula} {NORMAL}");


        if (entradaMinuscula != "=")
        {
            if (entradaMinuscula == "0" && cuentaceros > 0) divicero(); 

            if (entradaMinuscula == "volver")
            {
                Console.Clear();
                Calculadora();
            }

            if (entradaMinuscula == "0" && cuentaceros > 0) divicero();

            if (double.TryParse(entradaMinuscula, out suma))
            {
                
               
                if (diviiAcumulado == 0) { diviiAcumulado = suma; }
              
              else diviiAcumulado /= suma;

              if(diviiAcumulado > 0) contador++;
            
            } 
             else Console.WriteLine($"                                                                               {RED} '{entradaMinuscula}'  Este valor no es valido, introduce un valor numerico.  PARA VOLVER AL MENU PRINCIPAL ESCRIBE {MAGENTA}'VOLVER'{NORMAL}");

            




        }

    }


    Console.Clear();
    Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
   
   
    Console.WriteLine("");
    if (entrada == "0") Console.WriteLine($"                                                                  {RED}        DISCULPA, NO SE PUEDE DIVIDIR POR 'CERO'. {NORMAL} ");
    else
    {
        Console.WriteLine($"                                                                                         {BLUE}    EL VALOR DE LA DIVISION ES{MAGENTA} {diviiAcumulado}{NORMAL}");
    }

    void divicero()
    {
        if (diviiAcumulado == 0) Console.WriteLine($"                                                                  {RED}        DISCULPA, NO SE PUEDE DIVIDIR POR 'CERO'. {NORMAL} ");
    }



    //OPCIONES USUARIO
    OpcionesUsuario();
    if (operacion == "si") RealizarOtraOperacion();

}

//POTENCIA

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

                if (basse == 0) { Console.WriteLine($"                                                                                     {RED}'{entradaMinuscula}'  Introduce un valor diferente de cero.  PARA VOLVER AL MENU PRINCIPAL ESCRIBE 'VOLVER' {NORMAL} "); goto potenccia; }

                else { contador++; goto potenccia; }


            }
            else { Console.WriteLine($"                                                                                                    {RED} '{entradaMinuscula}'   Este valor no es valido, introduce un valor numerico.  PARA VOLVER AL MENU PRINCIPAL ESCRIBE 'VOLVER' {NORMAL} "); goto potenccia; }

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

                if (exponente == 0) { Console.WriteLine($"                                                                                    {RED} '{entradaMinuscula}'  Introduce un valor diferente de cero.  PARA VOLVER AL MENU PRINCIPAL ESCRIBE 'VOLVER'  {NORMAL}"); goto potenccia; }

                else
                {
                    poteResult = Math.Pow(basse, exponente);
                    contador++;

                }

            }
            else { Console.WriteLine($"                                                                                                        {RED} '{entradaMinuscula}' Este valor no es valido, introduce un valor numerico.  PARA VOLVER AL MENU PRINCIPAL ESCRIBE 'VOLVER' {NORMAL} "); goto potenccia; }

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

                if (basse == 0) { Console.WriteLine($"                                                                                     {RED}'{entradaMinuscula}'   Introduce un valor diferente de cero.  PARA VOLVER AL MENU PRINCIPAL ESCRIBE 'VOLVER'  {NORMAL}"); goto potenccia; }

                else { contador++; goto potenccia; }


            }
            else { Console.WriteLine($"                                                                                       {RED} '{entradaMinuscula}'    Este valor no es valido, introduce un valor numerico.  PARA VOLVER AL MENU PRINCIPAL ESCRIBE 'VOLVER' {NORMAL}"); goto potenccia; }

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

                if (basse == 0) { Console.WriteLine($"                                                         {RED} '{entradaMinuscula}'  Introduce un valor diferente de cero.  PARA VOLVER AL MENU PRINCIPAL ESCRIBE 'VOLVER'  {NORMAL}"); goto potenccia; }

                else { contador++; goto potenccia; }


            }
            else { Console.WriteLine($"                                                                         {RED} '{entradaMinuscula}'    Este valor no es valido, introduce un valor numerico.  PARA VOLVER AL MENU PRINCIPAL ESCRIBE 'VOLVER'  {NORMAL}"); goto potenccia; }

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

                if (exponente == 0) { Console.WriteLine($"                                                    {RED} '{entradaMinuscula}'  Introduce un valor diferente de cero.  PARA VOLVER AL MENU PRINCIPAL ESCRIBE 'VOLVER'  {NORMAL} "); goto potenccia; }

                else
                {
                    poteResult = basse / 100 * exponente;
                    contador++;

                }

            }
            else { Console.WriteLine($"                                                                       {RED} '{entradaMinuscula}'   Este valor no es valido, introduce un valor numerico.  PARA VOLVER AL MENU PRINCIPAL ESCRIBE 'VOLVER'   {NORMAL}"); goto potenccia; }

        }



    }

    Console.Clear();
    Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
    Console.WriteLine($"                                                                                      {BLUE} '{entradaMinuscula}'    EL {basse} PORCIENTO DE {exponente} ES {poteResult} {NORMAL}");
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

                if (basse == 0) { Console.WriteLine($"                                                           {RED} '{entradaMinuscula}'   Introduce un valor diferente de cero.  PARA VOLVER AL MENU PRINCIPAL ESCRIBE 'VOLVER' {NORMAL} "); goto potenccia; }

                else { contador++; goto potenccia; }


            }
            else { Console.WriteLine($"                                                                           {RED} '{entradaMinuscula}'    Este valor no es valido, introduce un valor numerico PARA VOLVER AL MENU PRINCIPAL ESCRIBE 'VOLVER' {NORMAL}"); goto potenccia; }

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

                if (basse == 0) { Console.WriteLine($"                                                                                 {RED} '{entradaMinuscula}'  Introduce un valor diferente de cero.  PARA VOLVER AL MENU PRINCIPAL ESCRIBE 'VOLVER' {NORMAL}"); goto potenccia; }

                else { contador++; goto potenccia; }


            }
            else { Console.WriteLine($"                                                                                    {RED} '{entradaMinuscula}'    Este valor no es valido, introduce un valor numerico PARA VOLVER AL MENU PRINCIPAL ESCRIBE 'VOLVER' {NORMAL}"); goto potenccia; }

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

                if (exponente == 0) { Console.WriteLine($"                                                       {RED} '{entradaMinuscula}'   Introduce un valor diferente de cero.   PARA VOLVER AL MENU PRINCIPAL ESCRIBE 'VOLVER' {NORMAL}"); goto potenccia; }

                else
                {
                    poteResult = basse % exponente;
                    contador++;

                }

            }
            else { Console.WriteLine($"                                                                             {RED} '{entradaMinuscula}'    Este valor no es valido, introduce un valor numerico.  PARA VOLVER AL MENU PRINCIPAL ESCRIBE 'VOLVER'{NORMAL}"); goto potenccia; }

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

                if (basse == 0) { Console.WriteLine($"                                                                                  {RED}  '{entradaMinuscula}'    Introduce un valor diferente de cero. PARA VOLVER AL MENU PRINCIPAL ESCRIBE 'VOLVER' {NORMAL}  "); goto potenccia; }

                else { contador++; goto potenccia; }


            }
            else { Console.WriteLine($"                                                                                     {RED} '{entradaMinuscula}'    Este valor no es valido, introduce un valor numerico. PARA VOLVER AL MENU PRINCIPAL ESCRIBE 'VOLVER' {NORMAL}"); goto potenccia; }

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

                if (basse == 0) { Console.WriteLine($"                                                                                    {RED} '{entradaMinuscula}'   Introduce un valor diferente de cero  PARA VOLVER AL MENU PRINCIPAL ESCRIBE 'VOLVER' {NORMAL}"); goto potenccia; }

                else { contador++; goto potenccia; }


            }
            else { Console.WriteLine($"                                                                                     {RED} '{entradaMinuscula}' Este valor no es valido, introduce un valor numerico   PARA VOLVER AL MENU PRINCIPAL ESCRIBE 'VOLVER' {NORMAL} "); goto potenccia; }

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



//SENO
void Seno()
{

    Console.WriteLine();



potenccia:
    while (entrada != "=" && contador < 2)
    {

        if (contador == 0)
        {
            Console.WriteLine();
            Console.WriteLine($"                                                                                   {CYAN} DE QUE NUMERO QUIERES EL SENO ?  PARA VOLVER AL MENU PRINCIPAL ESCRIBE 'VOLVER' {NORMAL}");
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

               // if (basse == 0) { Console.WriteLine($"                                                                                    {RED} '{entradaMinuscula}'   Introduce un valor diferente de cero  PARA VOLVER AL MENU PRINCIPAL ESCRIBE 'VOLVER' {NORMAL}"); goto potenccia; }

                 { contador++; goto potenccia; }


            }
            else { Console.WriteLine($"                                                                                     {RED} '{entradaMinuscula}' Este valor no es valido, introduce un valor numerico   PARA VOLVER AL MENU PRINCIPAL ESCRIBE 'VOLVER' {NORMAL} "); goto potenccia; }

        }

        break;

    }

    Console.Clear();
    Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
    Console.WriteLine($"                                                                                                      {BLUE}        EL SENO DE {basse} ES  {Math.Sin(basse)} {NORMAL}");
    Console.WriteLine("");



    //OPCIONES USUARIO
    OpcionesUsuario();
    if (operacion == "si") RealizarOtraOperacion();



}




//COSENO


void Coseno()
{

    Console.WriteLine();



potenccia:
    while (entrada != "=" && contador < 2)
    {

        if (contador == 0)
        {
            Console.WriteLine();
            Console.WriteLine($"                                                                                   {CYAN} DE QUE NUMERO QUIERES EL COSENO ?  PARA VOLVER AL MENU PRINCIPAL ESCRIBE 'VOLVER' {NORMAL}");
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

               // if (basse == 0) { Console.WriteLine($"                                                                                    {RED} '{entradaMinuscula}'   Introduce un valor diferente de cero  PARA VOLVER AL MENU PRINCIPAL ESCRIBE 'VOLVER' {NORMAL}"); goto potenccia; }

                { contador++; goto potenccia; }


            }
            else { Console.WriteLine($"                                                                                     {RED} '{entradaMinuscula}' Este valor no es valido, introduce un valor numerico   PARA VOLVER AL MENU PRINCIPAL ESCRIBE 'VOLVER' {NORMAL} "); goto potenccia; }

        }

        break;

    }

    Console.Clear();
    Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
    Console.WriteLine($"                                                                                                      {BLUE}        EL COSENO DE {basse} ES  {Math.Cos(basse)} {NORMAL}");
    Console.WriteLine("");



    //OPCIONES USUARIO
    OpcionesUsuario();
    if (operacion == "si") RealizarOtraOperacion();



}




//TANGENTE


void Tangente()
{

    Console.WriteLine();



potenccia:
    while (entrada != "=" && contador < 2)
    {

        if (contador == 0)
        {
            Console.WriteLine();
            Console.WriteLine($"                                                                                   {CYAN} DE QUE NUMERO QUIERES LA TANGENTE ?  PARA VOLVER AL MENU PRINCIPAL ESCRIBE 'VOLVER' {NORMAL}");
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

               // if (basse == 0) { Console.WriteLine($"                                                                                    {RED} '{entradaMinuscula}'   Introduce un valor diferente de cero  PARA VOLVER AL MENU PRINCIPAL ESCRIBE 'VOLVER' {NORMAL}"); goto potenccia; }

                 contador++; goto potenccia;


            }
            else { Console.WriteLine($"                                                                                     {RED} '{entradaMinuscula}' Este valor no es valido, introduce un valor numerico   PARA VOLVER AL MENU PRINCIPAL ESCRIBE 'VOLVER' {NORMAL} "); goto potenccia; }

        }

        break;

    }

    Console.Clear();
    Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
    Console.WriteLine($"                                                                                                      {BLUE}        LA TANGENTE DE {basse} ES  {Math.Tan(basse)} {NORMAL}");
    Console.WriteLine("");



    //OPCIONES USUARIO
    OpcionesUsuario();
    if (operacion == "si") RealizarOtraOperacion();



}



//COTANGENTE


void Cotangente()
{

    Console.WriteLine();



potenccia:
    while (entrada != "=" && contador < 2)
    {

        if (contador == 0)
        {
            Console.WriteLine();
            Console.WriteLine($"                                                                                   {CYAN} DE QUE NUMERO QUIERES LA COTANGENTE ?  PARA VOLVER AL MENU PRINCIPAL ESCRIBE 'VOLVER' {NORMAL}");
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

                if (basse == 0) { Console.WriteLine($"                                                                                    {RED} '{entradaMinuscula}'  NO SE PUEDE DIVIDIR POR CERO Introduce un valor diferente de cero  PARA VOLVER AL MENU PRINCIPAL ESCRIBE 'VOLVER' {NORMAL}"); goto potenccia; }

                else { contador++; goto potenccia; }


            }
            else { Console.WriteLine($"                                                                                     {RED} '{entradaMinuscula}' Este valor no es valido, introduce un valor numerico   PARA VOLVER AL MENU PRINCIPAL ESCRIBE 'VOLVER' {NORMAL} "); goto potenccia; }

        }

        break;

    }

    Console.Clear();
    Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
    Console.WriteLine($"                                                                                                      {BLUE}        LA COTANGENTE DE {basse} ES  {Math.Atan(basse)} {NORMAL}");
    Console.WriteLine("");



    //OPCIONES USUARIO
    OpcionesUsuario();
    if (operacion == "si") RealizarOtraOperacion();



}


//SECANTE


void Secante()
{

    Console.WriteLine();



potenccia:
    while (entrada != "=" && contador < 2)
    {

        if (contador == 0)
        {
            Console.WriteLine();
            Console.WriteLine($"                                                                                   {CYAN} DE QUE NUMERO QUIERES LA SECANTE ?  PARA VOLVER AL MENU PRINCIPAL ESCRIBE 'VOLVER' {NORMAL}");
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

                //if (basse == 0) { Console.WriteLine($"                                                                                    {RED} '{entradaMinuscula}'   Introduce un valor diferente de cero  PARA VOLVER AL MENU PRINCIPAL ESCRIBE 'VOLVER' {NORMAL}"); goto potenccia; }

               contador++; goto potenccia; 


            }
            else { Console.WriteLine($"                                                                                     {RED} '{entradaMinuscula}' Este valor no es valido, introduce un valor numerico   PARA VOLVER AL MENU PRINCIPAL ESCRIBE 'VOLVER' {NORMAL} "); goto potenccia; }

        }

        break;

    }

    Console.Clear();
    Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
    Console.WriteLine($"                                                                            {BLUE}        LA SECANTE DE {basse} ES  {Math.Acos(basse)} {NORMAL}");
    Console.WriteLine("");



    //OPCIONES USUARIO
    OpcionesUsuario();
    if (operacion == "si") RealizarOtraOperacion();



}


//COSECANTE

void Cosecante()
{

    Console.WriteLine();



potenccia:
    while (entrada != "=" && contador < 2)
    {

        if (contador == 0)
        {
            Console.WriteLine();
            Console.WriteLine($"                                                                                   {CYAN} DE QUE NUMERO QUIERES LA COSECANTE ?  PARA VOLVER AL MENU PRINCIPAL ESCRIBE 'VOLVER' {NORMAL}");
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

                if (basse == 0) { Console.WriteLine($"                                                                       {RED} '{entradaMinuscula}' NO SE PUEDE DIVIDIR POR CERO.  Introduce un valor diferente de cero.  PARA VOLVER AL MENU PRINCIPAL ESCRIBE 'VOLVER' {NORMAL}"); goto potenccia; }

                else { contador++; goto potenccia; }


            }
            else { Console.WriteLine($"                                                                                     {RED}'{entradaMinuscula}' Este valor no es valido, introduce un valor numerico   PARA VOLVER AL MENU PRINCIPAL ESCRIBE 'VOLVER' {NORMAL} "); goto potenccia; }

        }

        break;

    }

    Console.Clear();
    Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
    Console.WriteLine($"                                                                                                      {BLUE}       LA COSECANTE DE {basse} ES  {Math.Asin(basse)} {NORMAL}");
    Console.WriteLine("");



    //OPCIONES USUARIO
    OpcionesUsuario();
    if (operacion == "si") RealizarOtraOperacion();



}