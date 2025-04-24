public class Auto : TransporteTerrestre
{
    public override string NombreDelTransporte {get; protected set;}
    public string Propietario {get; private set;}
    public int Placa {get; private set;}
    public string Modelo { get; private set;}

    public Auto(string NombreDelTransporte, string Propietario, int Placa, string Modelo)
        : base(NombreDelTransporte, 4, "Gasolina")
    {
        this.NombreDelTransporte = NombreDelTransporte;
        this.Propietario = Propietario;
        this.Placa = Placa;
        this.Modelo = Modelo;
    }

    public override void Moverse()
    {
        EncenderMotor();
        Console.WriteLine("Conduciendo usando gasolina.");
    }

    public void EncenderMotor()
    {
        Console.WriteLine($"{NombreDelTransporte}: Encendiendo su motor");
    }
}
