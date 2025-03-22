using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using p1bpoo.MisClases;

namespace p1bpoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehiculo miCarrito = new Vehiculo(2026, "Azul", "Alfa Romeo");
            Vehiculo elOtro = new Vehiculo(2000, "Rojo", "DELOREAN");
            CarroElectrico miBYD = new CarroElectrico(2026, "Gris", "Tesla");
            Console.WriteLine("\tCarro Electrico");
            miBYD.InformacionVehiculo();
            miBYD.CargarBateria();
            Console.WriteLine("El nivel de batería es: {0}", miBYD.NivelBateria());

            // Llamadas a métodos heredados para CarroElectrico
            miBYD.Encender();
            miBYD.Acelerar(20);
            miBYD.Frenar();
            //miBYD.Apagar();

            // Creación de instancia de AutoDeCombustion
            AutoDeCombustion miAutoCombustion = new AutoDeCombustion(2025, "Negro", "Ford Mustang", 50, "Gasolina");
            Console.WriteLine("\n");
            Console.WriteLine("\tAutoCombustion");
            // Llamadas a métodos de AutoDeCombustion
            miAutoCombustion.InformacionVehiculo();
            miAutoCombustion.Encender();
            miAutoCombustion.Acelerar(30);
            miAutoCombustion.Frenar();
            //miAutoCombustion.Apagar();
            miAutoCombustion.RellenarTanque();

            // Creación de instancia de Motocicleta
            Motocicleta miMoto = new Motocicleta(2025, "Rojo", "Ducati", 1000, "Deportiva", 80);
            Console.WriteLine("\n");
            Console.WriteLine("\tMotocicleta");
            // Llamadas a métodos de Motocicleta
            miMoto.InformacionVehiculo();
            miMoto.Encender();
            miMoto.Acelerar(15);
            Console.WriteLine("Cilindrada: {0}", miMoto.ObtenerCilindrada());
            Console.WriteLine("Tipo de motocicleta: {0}", miMoto.ObtenerTipoMoto());
            Console.WriteLine("Nivel de aceite: {0}", miMoto.ObtenerNivelAceite());
            miMoto.Frenar();
            //miMoto.Apagar();

            // Creación de instancia de Camion
            Camion miCamion = new Camion(2025, "Blanco", "Isuzu", 10000, 4, 20000);
            Console.WriteLine("\n");
            Console.WriteLine("\tcamion");
            // Llamadas a métodos de Camion
            miCamion.InformacionVehiculo();
            miCamion.Encender();
            miCamion.Acelerar(10);
            Console.WriteLine("Capacidad de carga: {0}", miCamion.ObtenerCapacidadCarga());
            Console.WriteLine("Número de ejes: {0}", miCamion.ObtenerNumeroEjes());
            Console.WriteLine("Peso máximo: {0} kg", miCamion.ObtenerPesoMaximo());
            miCamion.Frenar();
            //miCamion.Apagar();
        }
    }
}