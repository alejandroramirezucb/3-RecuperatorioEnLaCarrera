public class Scooter : TransporteTerrestre
{
    public override string NombreDelTransporte { get; protected set;}
    private int _porcentajeDeBateria;
    public int PorcentajeDeBateria
    {
        get => _porcentajeDeBateria;
        private set => _porcentajeDeBateria = Math.Max(0, value); 
    }
    public bool TieneLucesLED {get; private set;}

    public Scooter(string NombreDelTransporte, int PorcentajeDeBateria, bool TieneLucesLED)
        : base(NombreDelTransporte, 2, "Batería eléctrica")
    {
        this.NombreDelTransporte = NombreDelTransporte;
        this.PorcentajeDeBateria = PorcentajeDeBateria;
        this.TieneLucesLED = TieneLucesLED;
    }

    public override void Moverse()
    {
        VerificarBateria();
        if (PorcentajeDeBateria >= 10)
        {
            Console.WriteLine("Avanzando con batería eléctrica.");
            ReducirBateria(10);
        }
        else
        {
            Console.WriteLine("El Scooter no se puede mover. Batería insuficiente");
        }
    }

    public void VerificarBateria()
    {
        Console.WriteLine($"Batería al {PorcentajeDeBateria}%.");
    }
    private void ReducirBateria(int cantidad)
    {
        PorcentajeDeBateria -= cantidad;
    }
}
