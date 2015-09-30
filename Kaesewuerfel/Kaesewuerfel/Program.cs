using System;

namespace Kaesewuerfel
{
    class Program
    {
        static void Main(string[] args)
        {
            Cell[,,] newWuerfel = new Cell[3, 3, 1];
            Wuerfel wuerfel = new Wuerfel(3, 3, 1, newWuerfel);           

        }
    }
}