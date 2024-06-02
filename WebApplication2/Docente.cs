public class Docente : Empleado
{
    public string Departamento { get; set; }

    public Docente(string nombre, string apellido, string identificacion, string puesto, decimal salario, string departamento)
        : base(nombre, apellido, identificacion, puesto, salario)
    {
        Departamento = departamento;
    }

    public override void MostrarInformacion()
    {
        base.MostrarInformacion();
        Console.WriteLine($"Departamento: {Departamento}");
    }
}
