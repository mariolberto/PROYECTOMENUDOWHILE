using System;

namespace Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;
            while (continuar)
            {
                //Menu de opciones 
                Console.Clear();
                Console.WriteLine("----MENU de tienda de Anime----");
                Console.WriteLine("1-) OPCION DE PLAYERAS 1");
                Console.WriteLine("2-) OPCION DE JUGUETES 2");
                Console.WriteLine("3-) OPCION DE LLAVEROS 3");
                Console.WriteLine("4-) OPCION DE SALIR 4");
                Console.WriteLine("INGRESA UNA OPCION PARA CONTINUAR");
                int opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("HAS ENTRADO A LA OPCION PLAYERA 1");
                        Console.WriteLine("PRESIONA CUALQUIER TECLA PARA CONTINUAR");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine("HAS ENTRADO A LA OPCION JUGUETE 2");
                        Console.WriteLine("PRESIONA CUALQUIER TECLA PARA CONTINUAR");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("HAS ENTRADO A LA OPCION LLAVEROS 3");
                        Console.WriteLine("PRESIONA CUALQUIER TECLA PARA CONTINUAR");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.WriteLine("ESTAS SEGURO QUE DESEAS SALIR?");
                        Console.WriteLine("SI/NO");
                        string deside = Console.ReadLine();
                        if (deside == "SI")
                        {
                            continuar = false;
                        }
                        break;
                    default:
                        Console.WriteLine("Ustedes ha ingresado una opcion no valida intente de nuevo . :");
                        break;