using static System.Console;
using System;
using Orirentação_Objetos.src.Entities;

namespace Orirentação_Objetos
{
    class Progran
    {
        static void Main()
        {
           Kinight arus = new Kinight("Arus", 23, "Knight", "469/749", "72/72");
           Wizard jenica = new Wizard("Jenica", 23, "Devil", "292/579", "89/89");
           Ninja wedge = new Ninja("Wedge", 42, "Ninja", "292/598", "89/89");

            WriteLine(arus);
            WriteLine(arus.Attack());
            WriteLine(jenica);
            WriteLine(jenica.Attack());
            WriteLine(wedge);
            WriteLine(wedge.Attack());

        }
    }
}