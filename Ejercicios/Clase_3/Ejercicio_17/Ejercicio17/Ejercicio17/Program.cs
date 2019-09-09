using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Boli;

namespace Ejercicio17
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Boligrafo Azul = new Boligrafo(10, ConsoleColor.Blue);
            ////Boligrafo Rojo = new Boligrafo(5, ConsoleColor.Red);

            ////string blue;
            ////string red;

            ////Azul.Pintar(5, out blue);
            ////Rojo.Pintar(6, out red);

            ////Console.WriteLine(blue);
            ////Console.WriteLine(red);

            ////Console.ReadKey();

            //Boligrafo boligrafo_1 = new Boligrafo(100, ConsoleColor.Blue);
            //Boligrafo boligrafo_2 = new Boligrafo(50, ConsoleColor.Red);

            //string asteriscos;

            ////deberia restar 30, por lo que quedaria en 70
            //if (boligrafo_1.Pintar(-30, out asteriscos))
            //{
            //    Console.ForegroundColor = boligrafo_1.GetColor();
            //    Console.WriteLine(asteriscos);
            //    Console.WriteLine(boligrafo_1.GetTinta());
            //    Console.ResetColor();


            //}

            //Console.WriteLine("");
            //Console.WriteLine("");
            //Console.WriteLine("");

            ////deberia sumar 30 por lo que dejaria en 80 la cantidad de tinta
            //if (boligrafo_2.Pintar(30, out asteriscos))
            //{
            //    Console.ForegroundColor = boligrafo_2.GetColor();
            //    Console.WriteLine(asteriscos);
            //    Console.WriteLine(boligrafo_2.GetTinta());
            //    Console.ResetColor();


            //}

            //Console.ReadLine();


            Boligrafo boligrafo_1 = new Boligrafo(100, ConsoleColor.Blue);
            Boligrafo boligrafo_2 = new Boligrafo(50, ConsoleColor.Red);
            string dibujo;

            Console.WriteLine("Dibujo boligrafo_1");
            if(boligrafo_1.Pintar(50, out dibujo))
            {
                Console.ForegroundColor = boligrafo_1.GetColor();
                Console.WriteLine(dibujo);
                //Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Nivel de tinta restante: {0}",boligrafo_1.GetTinta());
                Console.ResetColor();
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Nivel de tinta superior a la capacidad disponible");
            }

            Console.ResetColor();

            Console.WriteLine("Dibujo boligrafo_2");
            if (boligrafo_2.Pintar(30, out dibujo))
            {
                Console.ForegroundColor = boligrafo_2.GetColor();
                Console.WriteLine(dibujo);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Nivel de tinta restante: {0}", boligrafo_2.GetTinta());
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Nivel de tinta superior a la capacidad disponible");
            }

        }
    }
}
