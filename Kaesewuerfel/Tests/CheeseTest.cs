using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kaesewuerfel;

namespace Tests
{
    [TestClass]
    public class CheeseTest
    {
        private Wuerfel _Cube;

        /// <summary>
        /// Initializes the cheese-cube.
        /// </summary>
        [TestInitialize]
        public void Initialize_Cube()
        {
            Cell[, ,] cells = new Cell[3, 3, 3];
            for (int x = 0; x < cells.GetLength(0); x++)
                for (int y = 0; y < cells.GetLength(1); y++)
                    for (int z = 0; z < cells.GetLength(2); z++)
                        cells[x, y, z] = new Cell(x, y, z)
                            {
                                _type = (x == 1 && y == 1) ? Cell.CellType.Luft : Cell.CellType.Kaese
                            };
            this._Cube = new Wuerfel(3, 3, 3, cells);
        }

        /// <summary>
        /// Test if a System.OverflowException is thrown when creating a cheese-cube with negative sizes.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void Negative_Cube()
        {
            new Wuerfel(-3, -3, -3);
        }

        /// <summary>
        /// Test if a System.IndexOutOfRangeException is thrown when creating a cheese-cube with sizes of 0.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void Empty_Cube()
        {
            Wuerfel w = new Wuerfel(0, 0, 0);
            w.FindRoute(0, 0, 0);
        }
        
        /// <summary>
        /// With the above defined cheese-cube no route should be found with the given entry point: {X: 0, Y: 0, Z: 0}.
        /// </summary>
        [TestMethod]
        public void No_Route_Found()
        {
            Assert.IsFalse(this._Cube.FindRoute(0, 0, 0));
        }


        /// <summary>
        /// Test if a System.Exception is thrown when the entry point is inside the cheese-cube and not on the surface.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Entry_Point_Inside_Cube()
        {
            this._Cube.FindRoute(1, 1, 1);
        }

        /// <summary>
        /// With the above defined cheese-cube a route should be found with the given entry point: {X: 1, Y: 1, Z: 0}.
        /// </summary>
        [TestMethod]
        public void Route_Found()
        {
            Assert.IsTrue(this._Cube.FindRoute(1, 1, 0));
        }

        /// <summary>
        /// Validate that there is no way found with the given entry point: {X: 0, Y: 0, Z: 0}.
        /// </summary>
        [TestMethod]
        public void Validate_No_Found_Route()
        {
            Assert.Equals(this._Cube.GetWay(this._Cube._cellen, this._Cube._cellen[0, 0, 0]).ToArray(), new Cell[0]);
        }

        /// <summary>
        /// Validate the way which should be returned with the given cheese-cube-cell: {X: 1, Y: 1, Z: 0}.
        /// </summary>
        [TestMethod]
        public void Validate_Found_Route_1()
        {
            Cell[] expectedWay = new Cell[3];
            for (int z = 0; z < expectedWay.Length; z++)
                expectedWay[z] = this._Cube._cellen[1, 1, z];
            Assert.Equals(this._Cube.GetWay(this._Cube._cellen, this._Cube._cellen[1, 1, 0]).ToArray(), expectedWay);
        }

        /// <summary>
        /// Validate the way which should be returned with the given cheese-cube-cell: {X: 1, Y: 1, Z: 2}.
        /// </summary>
        [TestMethod]
        public void Validate_Found_Route_2()
        {
            Assert.Equals(this._Cube.GetWay(this._Cube._cellen, this._Cube._cellen[1, 1, 2]).ToArray(), new Cell[] { this._Cube._cellen[1, 1, 2] });
        }

        /// <summary>
        /// Validate the neighbours which should be returned with the given cheese-cube-cell: {X: 0, Y: 0, Z: 0}.
        /// </summary>
        [TestMethod]
        public void Validate_Neighbours_1()
        {
            Assert.Equals(this._Cube.GetNeighbors(this._Cube._cellen[0, 0, 0]).ToArray(), new Cell[0]);
        }

        /// <summary>
        /// Validate the neighbours which should be returned with the given cheese-cube-cell: {X: 1, Y: 1, Z: 0}.
        /// </summary>
        [TestMethod]
        public void Validate_Neighbours_2()
        {
            Assert.Equals(this._Cube.GetNeighbors(this._Cube._cellen[1, 1, 0]).ToArray(), new Cell[1] { this._Cube._cellen[1, 1, 1] });
        }
    }
}
