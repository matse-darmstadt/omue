namespace Kaesewuerfel
{
    public class Cell
    {
        /// <summary>
        /// Cell Typen (Käse, Luft, Besucht)
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
        public CellType _type { get; set; }

        /// <summary>
        /// Konstruktor
        /// </summary> 
        public Cell(int x, int y, int z)
        {
            this._x = x;
            this._y = y;
            this._z = z;
        }
    }
}
