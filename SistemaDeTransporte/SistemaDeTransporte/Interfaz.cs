using System;

public static class Interfaz
{
    private static RegistroDeTransportes registro = new RegistroDeTransportes();

    public static void MostrarMenu()
    {
        bool salir = false;
        while (!salir)
        {
            Console.Clear();
            Console.WriteLine("---------------------- Menu de Transportes ----------------------\n");
            Console.WriteLine("1. Agregar Transporte");
            Console.WriteLine("2. Mostrar Transportes Registrados");
            Console.WriteLine("3. Mover Todos los Transportes");
            Console.WriteLine("4. Salir\n");
            Console.Write("Opcion: ");
            if (!int.TryParse(Console.ReadLine(), out int opcion))
            {
                Console.WriteLine("\nERROR: Entrada invalida.");
                Console.ReadKey();
                continue;
            }
            switch (opcion)
            {
                case 1:
                    AgregarTransporte();
                    break;

                case 2:
                    registro.MostrarTransportes();
                    Console.ReadKey();
                    break;

                case 3:
                    registro.MoverTodos();
                    Console.ReadKey();
                    break;
                case 4:
                    salir = true;
                    break;
                default:
                    Console.WriteLine("\nERROR: Opcion no valida.");
                    Console.ReadKey();
                    break;
            }
        }
    }

    private static void AgregarTransporte()
    {
        Console.Clear();
        Console.WriteLine("Seleccione el tipo de transporte a agregar:\n");
        Console.WriteLine("1. Auto");
        Console.WriteLine("2. Bicicleta");
        Console.WriteLine("3. Scooter\n");
        Console.Write("Opción: ");

        if (!int.TryParse(Console.ReadLine(), out int tipo) || tipo < 1 || tipo > 3)
        {
            Console.WriteLine("\nERROR: Tipo de transporte no valido");
            Console.ReadKey();
            return;
        }
        Console.Write("\nIngrese el nombre del transporte: ");
        string nombre = Console.ReadLine()?.Trim() ?? "";
        Transporte nuevo = null;
        switch (tipo)
        {
            case 1: 
                Console.Write("Propietario: ");
                string propietario = Console.ReadLine()?.Trim() ?? "";
                Console.Write("Placa (número): ");
                int.TryParse(Console.ReadLine(), out int placa);
                Console.Write("Modelo: ");
                string modelo = Console.ReadLine()?.Trim() ?? "";
                nuevo = new Auto(nombre, propietario, placa, modelo);
                break;

            case 2:
                Console.Write("Tipo de bicicleta: ");
                string tipoBici = Console.ReadLine()?.Trim() ?? "";
                Console.Write("¿Tiene canasto? (s/n): ");
                bool tieneCanasto = Console.ReadLine()?.Trim().ToLower() == "s";
                nuevo = new Bicicleta(nombre, tipoBici, tieneCanasto);
                break;

            case 3: 
                Console.Write("Porcentaje de batería (0–100): ");
                int.TryParse(Console.ReadLine(), out int bateria);
                Console.Write("¿Tiene luces LED? (s/n): ");
                bool tieneLuces = Console.ReadLine()?.Trim().ToLower() == "s";
                nuevo = new Scooter(nombre, bateria, tieneLuces);
                break;
        }
        if (nuevo != null)
        {
            registro.RegistrarTransporte(nuevo);
            Console.WriteLine("\nEXITO: Transporte agregado correctamente");
        }
        else
        {
            Console.WriteLine("\nERROR: No se pudo crear el transporte");
        }
        Console.ReadKey();
    }
}
