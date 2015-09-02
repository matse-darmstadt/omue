namespace Kaesewuerfel
{
    public class Cell
    {
        /// <summary>
        /// Cell Typen (Käse, Luft)
        /// </summary>
        public enum CellType
        {
            Käse,
            Luft,
            Besucht
        }
        public int _x, _y, _z;
        /// <summary>
        /// Der Type der Zelle
        /// </summary>
        public CellType _type { get; }

        /// <summary>
        /// Konstruktor
        /// </summary> 
        public Cell(int x, int y, int z) {

        }


    }
}
