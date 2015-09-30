using System;
using System.Collections.Generic;

namespace Kaesewuerfel
{
    public class Wuerfel
    {
        /// <summary>
        /// Ein 3D Array
        /// </summary>
        public Cell[,,] _cellen = null;

        /// <summary>
        /// Stack, der den Wasser-Pfad enthält
        /// </summary>
        public Stack<Cell> _CellStack = new Stack<Cell>();

        private int _sizeX;
        private int _sizeY;
        private int _sizeZ;

        /// <summary>
        /// Käsewürfel
        /// </summary>
        /// <param name="sizeX">X-Wert</param>
        /// <param name="sizeY">Y-Wert</param>
        /// <param name="sizeZ">Z-Wert</param>
        /// <param name="newWuerfel">Der neue Würfel</param>
        public Wuerfel(int sizeX, int sizeY, int sizeZ, Cell[,,] newWuerfel)
        {
            _sizeX = sizeX;
            _sizeY = sizeY;
            _sizeZ = sizeZ;
            _InitializeWuerfel();
            _fillWurfel(newWuerfel);
        }

        public  Wuerfel(int sizeX, int sizeY, int sizeZ)
        {
            this._sizeX = sizeX;
            this._sizeY = sizeY;
            this._sizeZ = sizeZ;
            this._InitializeWuerfel();

            Random ran = new Random(28);
            for (int x = 0; x < this._sizeX; x++)
                for (int y = 0; y < this._sizeY; y++)
                    for (int z = 0; z < this._sizeZ; z++)
                    {
                        this._cellen[x, y, z] = new Cell(x, y, z) { _type = ran.Next(2) == 0 ? Cell.CellType.Käse : Cell.CellType.Luft };
                        System.Diagnostics.Trace.WriteLine(String.Format("X:{0}, Y:{1}, Z:{2}; {3}", x, y, z, this._cellen[x, y, z]._type.ToString("G")));
                    }
        }

        /// <summary>
        /// Der Käsewürfel wir initializierd
        /// </summary>
        private void _InitializeWuerfel()
        {
            _cellen = new Cell[_sizeX, _sizeY, _sizeZ];
        }


        /// <summary>
        /// Erstllt einen Würfel mit Käse oder Luft Zellen
        /// </summary>
        /// <param name="newWuerfel">Der neue Würfel</param>
        private void _fillWurfel(Cell[,,] newWuerfel)
        {
            for (int x = 0; x < _sizeX; x++)
                for (int y = 0; y < sizeY; y++)
                    for (int z = 0; z < sizeZ; z++)
                        _cellen[x, y, z] = newWuerfel[x, y, z];
        }

        /// <returns>true, wenn es einen Weg gibt</returns>
        public bool FindRoute(int x, int y, int z)
        {
            bool way = false;
            Cell wCell = new Cell(x, y, z);
            GetWay(this._cellen, wCell);
            if (_CellStack.Count > 0)
                way = true;
            return way;
        }


        /// <param name="cellen">Array von Zellen</param>
        /// <param name="cell">Eine Zelle</param>
        /// <returns></returns>
        public List<Cell> GetWay(Cell[,,] cellen, Cell cell)
        {
            List<Cell> __NeighborsCells = GetNeighbors(cell);
            List<Cell> way = new List<Cell>();

            return way;

        }
        /// <summary>
        /// Anzahl der n-Segmente in x-Richtung
        /// </summary>
        public int sizeX { get { return _sizeX; } }

        /// <summary>
        /// Anzahl der n-Segmente in y-Richtung
        /// </summary>
        public int sizeY { get { return _sizeY; } }

        /// <summary>
        /// Anzahl der n-Segmente in z-Richtung
        /// </summary>
        public int sizeZ { get { return _sizeZ; } }

        /// <summary>
        /// Sucht nach den Nachbern
        /// </summary>
        /// <param name="cell">Die Zelle</param>
        /// <returns>Eine Liste vom freien Nachbern</returns>
        public List<Cell> GetNeighbors(Cell cell)
        {
            List<Cell> _Neighbors = new List<Cell>();
            for (int x = -1; x <= 1; x++)
                for (int y = -1; y <= 1; y++)
                    for (int z = -1; z <= 1; z++)
                    {
                        if (true)
                        {
                            if (_cellen[cell._x + x, cell._y + y, cell._z + z]._type == Cell.CellType.Luft)
                                _Neighbors.Add(_cellen[cell._x + x, cell._y + y, cell._z + z]);
                        }
                    }
            return _Neighbors;
        }

    }
}
