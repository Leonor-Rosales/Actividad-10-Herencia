using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_10_Herencia
{
    internal class Devices
    {
        public string Nombre { get; set; }
        public string Marca { get; set; }
        public string Tipo { get; set; }

        public Devices(string nombre, string marca, string tipo)
        {
            Nombre = nombre;
            Marca = marca;
            Tipo = tipo;
        }

        public Devices(List<Devices> devicesList)
        {
        }

        public void Menu()
        {
            Console.Clear();
            Console.WriteLine("--- Aparatos Electrónicos ---");
            Console.WriteLine("1. Agregar Producto");
            Console.WriteLine("2. Buscar Producto");
            Console.WriteLine("3. Mostrar");
            Console.WriteLine("4. Salir");
            Console.WriteLine("Ingrese una opción válida: ");
        }
        public void menutype()
        {
            Console.WriteLine("--- Escoja un tipo de aparato electrónico ---");
            Console.WriteLine("1. Télefono");
            Console.WriteLine("2. Tableta");
            Console.WriteLine("3. Ordenador");
            Console.WriteLine("Ingrese el tipo: ");
        }
        public void IngresarProducto(List<Devices> devicesList)
        {
            try
            {

                Console.Write("Ingrese el nombre del producto: ");
                string nameDevices = Console.ReadLine();
                nameDevices.ToLower();
                Console.Write("Ingrese el precio del producto: ");
                string brandDevices = Console.ReadLine();
                menutype();
                int option = int.Parse(Console.ReadLine());
                string typeDevices = "";
               switch(option)
                {
                    case 1:
                        typeDevices = "Teléfono";
                        devicesList.Add(new Phone(nameDevices, brandDevices, typeDevices));
                        Console.WriteLine("Producto Agregado con Éxito");
                        Console.ReadKey();
                        break;
                    case 2:
                        typeDevices = "Tableta";
                        devicesList.Add(new Tablet(nameDevices, brandDevices, typeDevices));
                        Console.WriteLine("Producto Agregado con Éxito");
                        Console.ReadKey();
                        break;
                    case 3:
                        typeDevices = "Ordenador";
                        devicesList.Add(new Computer(nameDevices, brandDevices, typeDevices));
                        Console.WriteLine("Producto Agregado con Éxito");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Ingrese una opción válida");
                        Console.ReadKey();
                        break;
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error:" + ex.Message);
            }
           
        }
        public void SearchDevices(List<Devices> devicesList)
        {
            if(devicesList.Count == 0)
            {
                Console.WriteLine("No hay Datos Añadidos");

            }
           else
            {
                Console.Write("Ingrese el nombre del producto: ");
                string nameDevices = Console.ReadLine();
                Devices DeviceFind = devicesList.Find(p => p.Nombre == nameDevices);
                if (DeviceFind != null)
                {
                    Console.WriteLine($"Nombre: {DeviceFind.Nombre}\nPrecio: {DeviceFind.Marca}\nCantidad: {DeviceFind.Tipo}");
                    Console.WriteLine("");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("\n[!] Producto Inexistente");
                    Console.ReadKey();
                } 
            }
        }
        public void ShowList(List<Devices> devicesList)
        {
            foreach(Devices device in devicesList)
            {
                Console.WriteLine("--- Aparatos Electrónicos ---");
                Console.WriteLine($"Nombre: {device.Nombre}\nIngredientes: {device.Marca}\nPreparación: {device.Tipo} ");
            }
        }
    }
}
