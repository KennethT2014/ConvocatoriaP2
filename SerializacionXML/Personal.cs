using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializacionXML
{
    public class Personal
    {
        private int codigo;
        private string nombre;
        private string direccion;
        private float salario;
        private float comision;

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public float Salario { get => salario; set => salario = value; }
        public float Comision { get => comision; set => comision = value; }

        public Personal()
        {
            codigo = 00001;
            nombre = "Kenneth";
            direccion = "De los semaforos del colonial, 2 cuadras arriba";
            salario = 50000;
            comision = 2500;

            codigo = 00002;
            nombre = "Santiago";
            direccion = "De los semaforos del colonial, 2 cuadras abajo";
            salario = 40000;
            comision = 1600;

            codigo = 00003;
            nombre = "Dylan";
            direccion = "Barrio Hugo Chavez, anden 11";
            salario = 60000;
            comision = 900;

            codigo = 00004;
            nombre = "Diego";
            direccion = "rotonda bello horizonte, 3 cuadras al sur, y 1 al este";
            salario = 20000;
            comision = 6000;

            codigo = 00005;
            nombre = "Harvey";
            direccion = "De metrocentro, 2 cuadras al norte";
            salario = 500000;
            comision = 120000;
        }
        public void MuestraInformacion()
        {

            for (int i = 0; i < 0; i++)
            {
                Console.WriteLine($"Código: {Codigo}");
                Console.WriteLine($"Nombre: {Nombre}");
                Console.WriteLine($"Dirección: {Direccion}");
                Console.WriteLine($"Salario: {Salario}");
                Console.WriteLine($"Comisión: {Comision}");
            }

        }
    }
}
