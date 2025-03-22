using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace p1bpoo.MisClases
{
    internal class Vehiculo
    {
        public string Color { get; set; }
        public string Modelo { get; }
        public int Year { get; }

        private int velocidad = 0;  // Encapsulación
        protected bool encendido = false;

        public Vehiculo(int anio, string elColor, string elModelo)
        {
            this.Color = elColor;
            this.Modelo = elModelo;
            this.Year = anio;
        }

        public void InformacionVehiculo()
        {
            Console.WriteLine("Color: {0}", this.Color);
            Console.WriteLine("Modelo: {0}", this.Modelo);
            Console.WriteLine("Año: {0}", this.Year);
        }

        public virtual void Acelerar(int cuanto)
        {
            if (encendido)
            {
                velocidad += cuanto;
                Console.WriteLine("Vas a {0} KMS / Hora", velocidad);
            }
            else
            {
                Console.WriteLine("No se puede acelerar. El vehículo está apagado.");
            }
        }

        public virtual void Frenar()
        {
            if (encendido)
            {
                velocidad -= 10;
                if (velocidad < 0) velocidad = 0;
                Console.WriteLine("Frenando. Velocidad: {0} km/h", velocidad);
            }
            else
            {
                Console.WriteLine("No se puede frenar. El vehículo está apagado.");
            }
        }

        public virtual void Encender()
        {
            encendido = true;
            Console.WriteLine("Vehículo encendido.");
        }

        public virtual void Apagar()
        {
            encendido = false;
            Console.WriteLine("Vehículo apagado.");
        }

        // Método para obtener la velocidad actual
        public int ObtenerVelocidad()
        {
            return velocidad;
        }
    }
}