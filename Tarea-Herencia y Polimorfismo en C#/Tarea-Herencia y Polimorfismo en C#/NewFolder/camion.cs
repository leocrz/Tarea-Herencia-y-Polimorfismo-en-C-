using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1bpoo.MisClases
{
    internal class Camion : Vehiculo
    {
        private int capacidadCarga; // Encapsulación
        private int numeroEjes;     // Encapsulación
        private double pesoMaximo;  // Encapsulación

        public Camion(int anio, string elColor, string elModelo, int capacidadCarga, int numeroEjes, double pesoMaximo)
            : base(anio, elColor, elModelo)
        {
            this.capacidadCarga = capacidadCarga;
            this.numeroEjes = numeroEjes;
            this.pesoMaximo = pesoMaximo;
        }

        public override void Acelerar(int cuanto)
        {
            if (encendido)
            {
                base.Acelerar(cuanto);
                Console.WriteLine("El camión está acelerando.");
            }
            else
            {
                Console.WriteLine("No se puede acelerar. El camión está apagado.");
            }
        }

        public override void Frenar()
        {
            if (encendido)
            {
                base.Frenar();
                Console.WriteLine("El camión está frenando.");
            }
            else
            {
                Console.WriteLine("No se puede frenar. El camión está apagado.");
            }
        }

        public override void Encender()
        {
            encendido = true;
            Console.WriteLine("Camión encendido.");
        }

        public override void Apagar()
        {
            encendido = false;
            Console.WriteLine("Camión apagado.");
        }

        public int ObtenerCapacidadCarga()
        {
            return capacidadCarga;
        }

        public int ObtenerNumeroEjes()
        {
            return numeroEjes;
        }

        public double ObtenerPesoMaximo()
        {
            return pesoMaximo;
        }
    }
}