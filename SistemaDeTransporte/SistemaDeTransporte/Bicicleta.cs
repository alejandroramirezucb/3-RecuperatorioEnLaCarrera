public class Bicicleta : TransporteTerrestre
{
    public override string NombreDelTransporte {get; protected set;}
    public bool TieneCanasto {get; private set;}
    public string TipoDeBicicleta {get; private set;} 

    public Bicicleta(string NombreDelTransporte, string TipoDeBicicleta, bool TieneCanasto)
        : base(NombreDelTransporte, 2, "Energia Cinetica")
    {
        this.NombreDelTransporte = NombreDelTransporte;
        this.TipoDeBicicleta = TipoDeBicicleta;
        this.TieneCanasto = TieneCanasto;
    }

    public override void Moverse()
    {
        Pedalear();
        Console.WriteLine("Pedaleando con esfuerzo.");
    }

    public void Pedalear()
    {
        Console.WriteLine("\nClac-clac-clac");
    }
}
