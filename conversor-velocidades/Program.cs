using System;

namespace conversor_velocidades
{
    class Program
    {
        static void Main()
        {
            int opcion, repetir = 0;
            var con = new Conversor();
            do
            {
                Console.WriteLine("Escoja una de las opciones");
                Console.WriteLine("1- Convertir m/s a km/h");
                Console.WriteLine("2- Convertir km/h a m/s");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        con.Conversor1();
                        break;
                    case 2:
                        con.Conversor2();
                        break;
                    default:
                        Console.WriteLine("Opcion incorrecta");
                        break;
                }
                Console.WriteLine("Si desea repetir coloque el valor de 1 o  cualquier tecla para salir");
                repetir = Convert.ToInt32(Console.ReadLine());

                //si coloca 1 vulve el loop, si coloca cualquier otra tecla se termina
            } while (repetir == 1);
        }
        class Conversor
        {
            private double velocidad;

            public void Conversor1()
            {
                Console.WriteLine("Introduzca una velocidad en m/s");

                //convertir el datos string que obtenemos de la consola en double
                velocidad = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($"{ velocidad} m/s = { velocidad * 3600 / 1000 } km/h");
            }
            public void Conversor2()
            {
                Console.WriteLine("Introduzca una velocidad en km/h");

                //convertir el datos string que obtenemos de la consola en double
                velocidad = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($"{ velocidad} km/h = { velocidad * 1000 / 3600 } m/s");
            }
        }
    }
}
