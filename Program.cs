using System;

//graamata - viena
namespace graamata
{
    //nodalja - var buut vairaakas
    class klase
    {
        //starta metode
        static void Main(string[] args)
        {


            Console.WriteLine(args[0]);
            Console.WriteLine(args[1]);

            //komentaars
            Console.WriteLine("Hello World!");
            Console.Write("Hello World 2");

            //es zinu, ka ievadiis tikai skaitljus
            int ievade = Int32.Parse(Console.ReadLine());

            Console.WriteLine(ievade);

            //Console.WriteLine("5");//super !!!
            Console.WriteLine("5");


            //es izvadu kautko
            //kas notiek, ja argumenti ir nepareizi ???

            /*
             * 
             * 
             *   SUPER KOMENTAARS
             * 
             * 
            */


            Sarkans();



        }

        //aktuaalais kods
        static void Sarkans()
        {
            Console.WriteLine("9");
            Console.WriteLine("8");
            Console.WriteLine("7");

        }

        //vecaa versija
        /*
        static void Sarkans()
        {
            Console.WriteLine("9");
            Console.WriteLine("8");
            Console.WriteLine("7");

        }
        */

    }

}
