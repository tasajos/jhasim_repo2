using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prograIIDEV.Clase_ciclos
{
    public class CicloWhile

    {
       public  static void Main(string[] args)

        {
            int contador = 1; //inicializacion

            while (contador <=5)  //condicion

            {
                Console.WriteLine("Tienes contador " +" " + contador);
                contador++;

            }

        }



    }
}
