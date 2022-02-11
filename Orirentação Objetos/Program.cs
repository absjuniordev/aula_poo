using static System.Console;
using System;
using Orirentação_Objetos.src.Entities;

namespace Orirentação_Objetos
{
    class Progran
    {
        static void Main()
        {
           Kinight arus = new Kinight("Arus", 23, "Knight");
           Wizard wizard = new Wizard("Malefios", 23, "Devil");
          

            WriteLine(arus.Attack(8));
            WriteLine(wizard.Attack(5));
        }
    }
}