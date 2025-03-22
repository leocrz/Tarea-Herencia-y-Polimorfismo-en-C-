using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace p1bpoo.MisClases
{
    internal class CarroElectrico : Vehiculo
    {
        private int cargaBateria;

        public CarroElectrico(int anio, string elColor, string elModelo) : base(anio, elColor, elModelo)
        {
            cargaBateria = 50;
        }

        public override void Acelerar(int cuanto)
        {
            if (encendido)
            {
                base.Acelerar(cuanto);
                cargaBateria--;
            }
            else
            {
                Console.WriteLine("No se puede acelerar. El carro eléctrico está apagado.");
            }
        }

        public override void Frenar()
        {
            if (encendido)
            {
                base.Frenar();
                cargaBateria -= 2;
            }
            else
            {
                Console.WriteLine("No se puede frenar. El carro eléctrico está apagado.");
            }
        }

        public override void Encender()
        {
            encendido = true;
            Console.WriteLine("Carro eléctrico encendido.");
        }

        public override void Apagar()
        {
            encendido = false;
            Console.WriteLine("Carro eléctrico apagado.");
        }

        public int NivelBateria()
        {
            return cargaBateria;
        }

        public void CargarBateria()
        {
            cargaBateria++;
        }
    }
}