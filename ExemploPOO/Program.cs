using System;
using ExemploPOO.Models;

namespace ExemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {

            Retangulo r = new Retangulo();
            r.DefinirMedidas(30, 30);
            r.ObterArea();

            System.Console.WriteLine($"Área: {r.ObterArea()}");

            Retangulo r2 = new Retangulo();
            r2.DefinirMedidas(0, 0);
            r2.ObterArea();

            System.Console.WriteLine($"Área: {r2.ObterArea()}");

        //     //Pessoa é a classe e p1 o objeto manipulável
        //     Pessoa p1 = new Pessoa();

        //     p1.Nome = "Bob";
        //     p1.Idade =  20;

        //     p1.Apresentar();
         }
     }
}
