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

        private static int _sizeX;
        private static int _sizeY;
        private static int _sizeZ;

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
        public bool FindRoute(Cell[,,] cellen)
        {
            bool way = false;
            Cell wCell = new Cell(0, 0, 0);
            GetWay(cellen, wCell);
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
        public static int sizeX { get { return _sizeX; } }

        /// <summary>
        /// Anzahl der n-Segmente in y-Richtung
        /// </summary>
        public static int sizeY { get { return _sizeY; } }

        /// <summary>
        /// Anzahl der n-Segmente in z-Richtung
        /// </summary>
        public static int sizeZ { get { return _sizeZ; } }

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
