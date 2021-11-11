using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsDecorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Personaje hobbit = new Hobbit();
            Personaje elfo = new Elfo();
            hobbit = new ChalecoDecorator(hobbit);
            hobbit = new BotasDecorator(hobbit);
            elfo = new CapaDecorator(elfo);
            elfo = new BotasDecorator(elfo);
            Console.WriteLine("Elfo");
            Console.WriteLine(elfo.GetDescripcion());
            Console.WriteLine("Su armadura es de " + elfo.GetArmadura());
            Console.WriteLine("Hobbit");
            Console.WriteLine(hobbit.GetDescripcion());
            Console.WriteLine("Su armadura es de " + hobbit.GetArmadura());
            Console.ReadKey();
        }
    }
}
