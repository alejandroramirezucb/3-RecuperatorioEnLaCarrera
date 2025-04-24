public abstract class TransporteTerrestre : Transporte
{
    public string TipoDeTransporte {get; set;} = "Transporte Terrestre";
    public int NumeroDeRuedas {get; protected set;}
    public string TipoDeEnergia {get; protected set;}

    public TransporteTerrestre(string NombreDelTransporte, int NumeroDeRuedas, string TipoDeEnergia)
        : base(NombreDelTransporte)
    {
        this.NumeroDeRuedas = NumeroDeRuedas;
        this.TipoDeEnergia = TipoDeEnergia;
    }
}