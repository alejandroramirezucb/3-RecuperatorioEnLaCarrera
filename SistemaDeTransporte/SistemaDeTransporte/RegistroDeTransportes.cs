public class RegistroDeTransportes
{
    private List<Transporte> transportesRegistrados;
    public RegistroDeTransportes()
    {
        transportesRegistrados = new List<Transporte>();
    }

    public void RegistrarTransporte(Transporte transporte)
    {
        transportesRegistrados.Add(transporte);
    }
    public void MostrarTransportes()
    {
        Console.WriteLine("\nTransportes registrados:");
        foreach (Transporte transporte in transportesRegistrados)
        {
            Console.WriteLine($"- {transporte.NombreDelTransporte}");
        }
    }

    public void MoverTodos()
    {
        Console.WriteLine("\nMoviendo transportes registrados:");
        foreach (var transporte in transportesRegistrados)
        {
            transporte.Moverse();
        }
    }
}




