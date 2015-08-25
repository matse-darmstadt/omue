using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Käsewürfel
{
    public class Würfel
    {
        /// <summary>
        /// Cell Type (Käse, Luft)
        /// </summary>
        public enum CellType
        {
            Käse,
            Luft
        }


        public CellType[,,] _Type;
        public Celle _Size;
        public Würfel _Würfel;
        public int _sizeX, _sizeY, _sizeZ;

        /// <summary>
        /// Käsewürfel
        /// </summary>
        /// <param name="sizeX">X-Wert</param>
        /// <param name="sizeY">Y-Wert</param>
        /// <param name="sizeZ">Z-Wert</param>
        public Würfel(int sizeX, int sizeY, int sizeZ)
        {

        }

        /// <summary>
        /// Sucht nach dem ersten freien Eingang im Würfel
        /// </summary>
        /// <param name="würfel">Käsewürfel</param>
        /// <returns>Koordinaten(x,y,z) der Celle</returns>
        public Celle FindInputPosition(Würfel würfel)
        {
            return null;
        }

        /// <summary>
        /// Sucht nach dem ersten freien Ausgang im Würfel
        /// </summary>
        /// <param name="würfel">Käsewürfel</param>
        /// <returns>Koordinaten(x,y,z) der Celle</returns>
        public Celle FindOutputPosition(Würfel würfel)
        {
            return null;
        }


        /// <summary>
        /// Überprüft ob die Zelle aus Luft oder Käse besteht
        /// </summary>
        /// <param name="value">Type</param>
        /// <returns>true = Käse, false = Luft</returns>
        public bool Contains(CellType value)
        {
            return false;
        }
    }
}
