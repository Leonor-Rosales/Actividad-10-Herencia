using Actividad_10_Herencia;

List<Devices> DevicesList = new List<Devices>();

Devices devicesObject = new Devices(DevicesList);

bool run = true;
do
{
    try
    {

        devicesObject.Menu();
        int option = int.Parse(Console.ReadLine());
        switch (option)
        {
            case 1:
                Console.Clear();
                devicesObject.IngresarProducto(DevicesList);
                break;
            case 2:
                Console.Clear();
                devicesObject.SearchDevices(DevicesList);
                break;
            case 3:
                Console.Clear();
                devicesObject.ShowList(DevicesList);
                break;
            case 4:
                Console.Clear();
                Console.WriteLine("Saliendo...");
                Console.ReadKey();
                run = false;
                break;
            default:
                Console.WriteLine("Ingrese una opción válida");
                Console.ReadKey();
                break;
        }
    }
    catch (Exception ex)
    {

        Console.WriteLine("Error: " + ex.Message);
        Console.ReadKey();
    }
} while (run == true);