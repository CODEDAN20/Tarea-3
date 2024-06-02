public class Administrativo : Empleado
{
    public string Seccion { get; set; }

    public Administrativo(string nombre, string apellido, string identificacion, string puesto, decimal salario, string seccion)
        : base(nombre, apellido, identificacion, puesto, salario)
    {
        Seccion = seccion;
    }

    public override void MostrarInformacion()
    {
        base.MostrarInformacion();
        Console.WriteLine($"Sección: {Seccion}");
    }
}
