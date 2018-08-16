using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2Encapsulamiento
{
    class Program
    {
        static void Main(string[] args)
        {
            Enemy Enemigo = new Enemy();

            Enemigo.X = "Posicion X: ";
            Enemigo.Y = "Posicion Y: ";
            Enemigo.Move = "Se ha movio: ";
            Enemigo.Shoot = "Disparo hacia: ";
            Enemigo.Explode = "Exploto";

            Console.ReadLine();
        }
    }
}

