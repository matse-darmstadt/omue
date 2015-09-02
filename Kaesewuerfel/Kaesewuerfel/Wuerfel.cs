using System.Collections.Generic;

namespace Kaesewuerfel
{
    public class Wuerfel
    {
        /// <summary>
        /// Ein 3D Array
        /// </summary>
        public Cell.CellType[,,] _cellen = null;

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
        public Wuerfel(int sizeX, int sizeY, int sizeZ)
        {
            _sizeX = sizeX;
            _sizeY = sizeY;
            _sizeZ = sizeZ;
            InitializeWuerfel();
        }

        /// <summary>
        /// Der Käsewürfel wir initializierd
        /// </summary>
        private void InitializeWuerfel()
        {
            _cellen = new Cell.CellType[_sizeX, _sizeY, _sizeZ];

        }

        /// <returns>true, wenn es einen Weg gibt</returns>
        public bool FindRoute(Cell.CellType[,,] cellen)
        {
            bool way = false;
            for (int x = 0; x != _cellen.GetLength(_sizeX); x++)
            {
                if (cellen[x, 0, 0] == Cell.CellType.Luft)
                {
                    Cell wCell = new Cell(x, 0, 0);
                    _CellStack.Push(wCell);
                    GetWay(cellen, wCell);
                }
            }
            if (_CellStack.Count > 0)
                way = true;
            return way;
        }


        /// <param name="cellen">Array von Zellen</param>
        /// <param name="cell">Eine Zelle</param>
        /// <returns></returns>
        public Stack<Cell> GetWay(Cell.CellType[,,] cellen, Cell cell)
        {
            if (cellen[cell._x, cell._y, cell._z] == Cell.CellType.Luft)
            {

            }
            return _CellStack;

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
        /// <returns>Eine Liste vom Type Cell</returns>
        public List<Cell> GetNeighbors(Cell cell)
        {
            List<Cell> _Neighbors = new List<Cell>();

            return _Neighbors;
        }

    }
}
