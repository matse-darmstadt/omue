using System;

namespace Kaesewuerfel
{
    class Program
    {
        static void Main(string[] args)
        {
            Wuerfel _Cube2 = new Wuerfel(3, 3, 3);
            Cell c = _Cube2.isStart();
            if (c != null)
                _Cube2.FindRoute(c._x, c._y, c._z);
            for (int x = 0; x < _Cube2.sizeX; x++)
                for (int y = 0; y < _Cube2.sizeY; y++)
                    for (int z = 0; z < _Cube2.sizeZ; z++)
                    {
                        Cell ce = _Cube2._cellen[x, y, z];
                        Console.WriteLine("({0},{1},{2},) Type: {3}", x, y, z, ce._type);
                    }

            Console.WriteLine(_Cube2.way.Count);
            Console.In.ReadLine();

        }
    }
}