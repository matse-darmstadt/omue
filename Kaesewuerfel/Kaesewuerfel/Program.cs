namespace Kaesewuerfel
{
    class Program
    {
        static void Main(string[] args)
        {
            Wuerfel wuerfel = new Wuerfel(5, 5, 5);
            wuerfel.FindRoute(wuerfel._cellen);
        }
    }
}
