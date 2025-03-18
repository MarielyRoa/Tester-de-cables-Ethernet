<h1>TESTER DE CABLES DE ETHERNET</h1>
- Estado: COMPLETO

## El programa cuenta con un menu que contiene varias opciones

      Console.WriteLine("\t~~~Bienvenido al Tester de cables de Ethernet~~~");
            Console.WriteLine("Seleccione una opcion por favor:");
            Console.WriteLine("1. Armar Cable T568A ");
            Console.WriteLine("2. Armar Cable T568B ");
            Console.WriteLine("3. Comprobar estandares");
            Console.WriteLine("4. Salir");
            
![Captura de pantalla (307)](https://github.com/user-attachments/assets/57464e96-0fb1-4656-baf4-2c35185b5efa)

            int opcion = Convert.ToInt32(Console.ReadLine());
## Posee un Switch para darle entrada y ejecucion a cada opcion
- Los colores de combinaciones en cables ethernet

        case 1:
                    const string A1 = "verdeblanco";
                    const string A2 = "verde";

- Entrada de datos por teclao

      Console.WriteLine("Ingrese los colores en orden (sin espacios, en formato verdeblanco, azul, etc.)");

                    Console.Write("Posición 1: "); c1 = Console.ReadLine()?.ToLower() ?? "";
                    Console.Write("Posición 2: "); c2 = Console.ReadLine()?.ToLower() ?? "";

- Comparacion de combinacion estandar con la entrada de datos
 
           bool esT568A = (c1 == A1 && c2 == A2 && c3 == A3 && c4 == A4 && c5 == A5 && c6 == A6 && c7 == A7 && c8 == A8);

- Exepciones

          default:
                    Console.WriteLine("Opción inválida. Inténtelo de nuevo.");
                    
                break;
