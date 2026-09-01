using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prograIIDEV.Clase_ciclos
{
    public class primerwhile
    {
        public static void Main(string[] args)

        {
            int contador = 1; //inicializacion

            while (contador <= 5)  //condicion

            {
                Console.WriteLine("Tienes contador " + " " + contador);
                contador++;

            }
            Console.WriteLine("============");
            Console.WriteLine("============");
            Console.WriteLine("Fin ciclo");

        }

    }
}
