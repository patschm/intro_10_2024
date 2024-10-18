using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tekenprogramma.Figuren;

internal class Driehoek: Figuur
{
    public int Basis { get; set; }
    public int Hoogte { get; set; }
    public int Hoek { get; set; }

    public override void Teken()
    {
        Console.Write($"Driehoek met basis: {Basis}, hoogte: {Hoogte} en hoek: {Hoek}. ");
        base.Teken();
    }

}
