using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Introduzca una cadena de al menos 40 carácteres");
        string cadena = Console.ReadLine();

        while(cadena.Length < 40)
        {
            Console.WriteLine($"La cadena introducida posee únicamente {cadena.Length} caracteres. Por favor, introduzca una nueva cadena con más de 40 caracteres: ");
            cadena = Console.ReadLine();
        }

        int opcion = -1;
        while (opcion != 0)
        {
            try
            {
                Console.WriteLine("Indique la acción a realizar.");
                Console.WriteLine("1 - Sustituir una palabra por otra.");
                Console.WriteLine("2 - Buscar un texto en la cadena.");
                Console.WriteLine("3 - Buscar un texto de inicio en la cadena.");
                Console.WriteLine("4 - Completo un digito con 0 al inico hasta llegar a 12 carácteres.");
                Console.WriteLine("0 - Salir");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        SustituirPalabra();
                        break;
                    case 2:
                        BuscarTexto();
                        break;
                    case 3:
                        BuscarTextoInicio();
                        break;
                    case 4:
                        CompletarDigitoConCero();
                        break;
                    case 0:
                        Console.WriteLine("Saliendo...");
                        break;
                    default:
                        Console.WriteLine("Introduzca una opción valida");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Introduzca un formato válido.\n" + ex.Message);
            }

            //Método que comprueba si una palabra está presente en el texto y la cambia por otra introducida por el usuario.
            void SustituirPalabra()
            {
                Console.WriteLine("Introduzca, separadas por un espacio, la palabra a sustituir y la palabra sustituta.");
                string[] sustitucion = Console.ReadLine().Split(' ');
                while (sustitucion.Length!= 2)
                {
                    Console.WriteLine("Debe introducir las dos palabras, por favor vuelva a intentarlo.");
                    sustitucion = Console.ReadLine().Split(' ');
                }
                while (!cadena.Contains(sustitucion[0]))
                {
                    Console.WriteLine("La palabra a sustituir no está presente en el texto, por favor vuelva a intentarlo.");
                    sustitucion = Console.ReadLine().Split(' ');
                }

                cadena = cadena.Replace(sustitucion[0], sustitucion[1]);
                Console.WriteLine("El resultado es: " + cadena);

            }

            //Método que comprueba si un texto está presente en la cadena.
            void BuscarTexto()
            {
                Console.WriteLine("Introduzca un texto a buscar para comprobar si existe o no.");
                string texto = Console.ReadLine();
                if (cadena.Contains(texto)) 
                {
                    Console.WriteLine("El texto está presente en la cadena: " + cadena);
                }
                else
                {
                    Console.WriteLine("El texto no está presente en la cadena.");

                }

            }

            //Método que comprueba si la cadena empieza por el texto introducido.
            void BuscarTextoInicio()
            {
                Console.WriteLine("Introduzca un texto para comprobar si es o no el inicio de la cadena.");
                string texto = Console.ReadLine();
                if (cadena.StartsWith(texto))
                {
                    Console.WriteLine("La cadena empieza por el texto introduzca.");
                }
                else
                {
                    Console.WriteLine("La cadena no empieza por el texto introduzca.");

                }

            }

            void CompletarDigitoConCero()
            {
                Console.WriteLine("Introduzca un numero entero.");
                int digito = int.Parse(Console.ReadLine());
                int longitud = 12 - digito.ToString().Length;
                if(longitud > 0)
                {
                    string ceros = new string('0', longitud);
                    Console.WriteLine(ceros + digito);
                }
                else
                {
                    Console.WriteLine(digito);
                }

            }


        }

    }
}
