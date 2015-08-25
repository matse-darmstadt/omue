using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Käsewürfel
{
    public class Logic
    {
        public SideSegment _Segment;
        public int _positionX;
        public int _positionY;
        public int _positionZ;


        public Stack<SideSegment> _SideSegment;

        public Logic()
        {

        }

        /// <summary>
        /// Gehe, solange die aktuelle Position nicht mit den Koordinaten des Ausgangs übereinstimmt
        /// </summary>
        public void _GO()
        {

        }

        /// <summary>
        /// Denn Pfad entlang gehen
        /// </summary>
        public void _Move()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="würfel">Käsewürfel</param>
        /// <returns>Gibt den Pfad zurück</returns>
        public string FindAWay(Würfel würfel)
        {
            return null;
        }

        /// <summary>
        /// Ein Käsewürfel erstellen
        /// </summary>
        public void _CreateKäsewürfel()
        {

        }

        /// <summary>
        /// Geht den Pfad zurück
        /// </summary>
        public void Go_Back() { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x">X-Position</param>
        /// <param name="y">Y-Position</param>
        /// <param name="z">Z-Position</param>
        /// <returns>true = Käse, false = Luft</returns>
        public bool _ValidCelle(int x, int y, int z)
        {
            return false;
        }


    }
}
