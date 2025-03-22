using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1bpoo.MisClases
{
    internal class Motocicleta : Vehiculo
    {
        private int cilindrada; // Encapsulación
        private string tipoMoto; // Encapsulación
        private int nivelAceite; // Encapsulación

        public Motocicleta(int anio, string elColor, string elModelo, int cilindrada, string tipoMoto, int nivelAceite)
            : base(anio, elColor, elModelo)
        {
            this.cilindrada = cilindrada;
            this.tipoMoto = tipoMoto;
            this.nivelAceite = nivelAceite;
        }

        public override void Acelerar(int cuanto)
        {
            if (encendido)
            {
                base.Acelerar(cuanto * 2); // Aumenta la velocidad más rápido que en un auto
            }
            else
            {
                Console.WriteLine("No se puede acelerar. La motocicleta está apagada.");
            }
        }

        public int ObtenerCilindrada()
        {
            return cilindrada;
        }

        public string ObtenerTipoMoto()
        {
            return tipoMoto;
        }

        public int ObtenerNivelAceite()
        {
            return nivelAceite;
        }
    }
}