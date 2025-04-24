public abstract class Transporte
{
    public abstract string NombreDelTransporte {get; protected set;}

    public Transporte(string NombreDelTransporte)
    {
        this.NombreDelTransporte = NombreDelTransporte;
    }
    public abstract void Moverse();
}