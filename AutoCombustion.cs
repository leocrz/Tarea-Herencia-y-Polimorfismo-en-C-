using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1bpoo.MisClases
{
    internal class AutoDeCombustion : Vehiculo
    {
        private int nivelCombustible; // Encapsulación
        private int capacidadTanque;  // Encapsulación
        private string tipoCombustible; // Encapsulación

        public AutoDeCombustion(int anio, string elColor, string elModelo, int capacidadTanque, string tipoCombustible)
            : base(anio, elColor, elModelo)
        {
            this.capacidadTanque = capacidadTanque;
            this.tipoCombustible = tipoCombustible;
            this.nivelCombustible = capacidadTanque; // Inicialmente el tanque está lleno
        }

        public override void Acelerar(int cuanto)
        {
            if (encendido)
            {
                if (nivelCombustible > 0)
                {
                    base.Acelerar(cuanto);
                    nivelCombustible--;
                    Console.WriteLine("Nivel de combustible: {0}", nivelCombustible);
                }
                else
                {
                    Console.WriteLine("No se puede acelerar. El tanque está vacío.");
                }
            }
            else
            {
                Console.WriteLine("No se puede acelerar. El auto está apagado.");
            }
        }

        public override void Frenar()
        {
            if (encendido)
            {
                base.Frenar();
                nivelCombustible -= 1; // Disminuye un poco el nivel de combustible al frenar
                if (nivelCombustible < 0) nivelCombustible = 0;
                Console.WriteLine("Frenando. Nivel de combustible: {0}", nivelCombustible);
            }
            else
            {
                Console.WriteLine("No se puede frenar. El auto está apagado.");
            }
        }

        public override void Encender()
        {
            encendido = true;
            Console.WriteLine("Auto de combustión encendido.");
        }

        public override void Apagar()
        {
            encendido = false;
            Console.WriteLine("Auto de combustión apagado.");
        }

        public void RellenarTanque()
        {
            nivelCombustible = capacidadTanque;
            Console.WriteLine("Tanque lleno. Nivel de combustible: {0}", nivelCombustible);
        }
    }
}