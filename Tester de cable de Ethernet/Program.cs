//PROGRAMA DE TESTER DE CABLE DE ETHERNET

using System.Formats.Asn1;
using System;

class Program
{
    static void Main(string[] args)
    {   //Yonill
        while (true)
        {
            
            Console.WriteLine("\t~~~Bienvenido al Tester de cables de Ethernet~~~");
            Console.WriteLine("Seleccione una opcion por favor:");
            Console.WriteLine("1. Armar Cable T568A ");
            Console.WriteLine("2. Armar Cable T568B ");
            Console.WriteLine("3. Comprobar estandares");
            Console.WriteLine("4. Salir");

            int opcion = Convert.ToInt32(Console.ReadLine());
            string c1, c2, c3, c4, c5, c6, c7, c8;
            // Yonill

            //Yeury
            switch (opcion)
            {
                
                case 1:
                    const string A1 = "verdeblanco";
                    const string A2 = "verde";
                    const string A3 = "naranjablanco";
                    const string A4 = "azul";
                    const string A5 = "azulblanco";
                    const string A6 = "naranja";
                    const string A7 = "marronblanco";
                    const string A8 = "marron";

                    Console.WriteLine("Ingrese los colores en orden (sin espacios, en formato verdeblanco, azul, etc.)");

                    Console.Write("Posición 1: "); c1 = Console.ReadLine()?.ToLower() ?? "";
                    Console.Write("Posición 2: "); c2 = Console.ReadLine()?.ToLower() ?? "";
                    Console.Write("Posición 3: "); c3 = Console.ReadLine()?.ToLower() ?? "";
                    Console.Write("Posición 4: "); c4 = Console.ReadLine()?.ToLower() ?? "";
                    Console.Write("Posición 5: "); c5 = Console.ReadLine()?.ToLower() ?? "";
                    Console.Write("Posición 6: "); c6 = Console.ReadLine()?.ToLower() ?? "";
                    Console.Write("Posición 7: "); c7 = Console.ReadLine()?.ToLower() ?? "";
                    Console.Write("Posición 8: "); c8 = Console.ReadLine()?.ToLower() ?? "";

                    //Yeury


                    //Mariely
                    bool esT568A = (c1 == A1 && c2 == A2 && c3 == A3 && c4 == A4 &&
                                     c5 == A5 && c6 == A6 && c7 == A7 && c8 == A8);

                     if (esT568A)
                    {
                        Console.WriteLine("\nEl cable está correctamente armado. Lo has logrado");
                    }
                    else
                    {
                        Console.WriteLine("\nEl cable está mal armado. Intente otra combinacion");
                    }
                    //Mariely


                break;

                //Yeury
                case 2:
                    const string B1 = "naranjablanco";
                    const string B2 = "naranja";
                    const string B3 = "verdeblanco";
                    const string B4 = "azul";
                    const string B5 = "azulblanco";
                    const string B6 = "verde";
                    const string B7 = "marronblanco";
                    const string B8 = "marron";

                    Console.WriteLine("Ingrese los colores en orden (sin espacios, en formato verdeblanco, azul, etc.)");

                    Console.Write("Posición 1: "); c1 = Console.ReadLine()?.ToLower() ?? "";
                    Console.Write("Posición 2: "); c2 = Console.ReadLine()?.ToLower() ?? "";
                    Console.Write("Posición 3: "); c3 = Console.ReadLine()?.ToLower() ?? "";
                    Console.Write("Posición 4: "); c4 = Console.ReadLine()?.ToLower() ?? "";
                    Console.Write("Posición 5: "); c5 = Console.ReadLine()?.ToLower() ?? "";
                    Console.Write("Posición 6: "); c6 = Console.ReadLine()?.ToLower() ?? "";
                    Console.Write("Posición 7: "); c7 = Console.ReadLine()?.ToLower() ?? "";
                    Console.Write("Posición 8: "); c8 = Console.ReadLine()?.ToLower() ?? "";

                    //Yeury


                    //Mariely
                     bool esT568B = (c1 == B1 && c2 == B2 && c3 == B3 && c4 == B4 &&
                                     c5 == B5 && c6 == B6 && c7 == B7 && c8 == B8);

                 if (esT568B)
                    {
                        Console.WriteLine("\nEl cable está correctamente armado. Lo has logrado");
                    }
                    else
                    {
                        Console.WriteLine("\nEl cable está mal armado. Intente otra combinacion");
                    }

                    //Mariely

                break;

                //Eudy
                case 3:
                    Console.WriteLine("\nEstandar T568A:");
                    Console.WriteLine("1. VerdeBlanco");
                    Console.WriteLine("2. Verde");
                    Console.WriteLine("3. NaranjaBlanco");
                    Console.WriteLine("4. Azul");
                    Console.WriteLine("5. AzulBlanco");
                    Console.WriteLine("6. Naranja");
                    Console.WriteLine("7. MarronBlanco");
                    Console.WriteLine("8. Marron");
                    
                    Console.WriteLine("\nEstandar T568B:");
                    Console.WriteLine("1. NaranjaBlanco");
                    Console.WriteLine("2. Naranja");
                    Console.WriteLine("3. VerdeBlanco");
                    Console.WriteLine("4. Azul");
                    Console.WriteLine("5. AzulBlanco");
                    Console.WriteLine("6. Verde");
                    Console.WriteLine("7. MarronBlanco");
                    Console.WriteLine("8. Marron");
                break;

                case 4:
                    Console.WriteLine("Saliendo...");

                return;

                default:
                    Console.WriteLine("Opción inválida. Inténtelo de nuevo.");
                    
                break;

                //Eudy

            }
        }
    
    }
}


