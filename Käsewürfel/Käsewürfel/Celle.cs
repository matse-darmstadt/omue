using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Käsewürfel
{
    public class Celle
    {
        /// <summary>
        /// X-Position der Celle
        /// </summary>
        public int _x { }

        /// <summary>
        /// Y-Position der Celle
        /// </summary>
        public int _y { }

        /// <summary>
        /// Z-Position der Celle
        /// </summary>
        public int _z { }

        /// <summary>
        /// Eine Celle mit den Koordinaten(x,y,z)
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        public Celle(int x, int y, int z)
        {

        }

        /// <summary>
        /// Gibt die Nachbarcelle zurück
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public Celle GetSideSegment(SideSegment value)
        {
            Celle cel = this;
            return cel;
        }
    }
}
