public class Maestro : Docente
{
    public string Materia { get; set; }

    public Maestro(string nombre, string apellido, string identificacion, string puesto, decimal salario, string departamento, string materia)
        : base(nombre, apellido, identificacion, puesto, salario, departamento)
    {
        Materia = materia;
    }

    public override void MostrarInformacion()
    {
        base.MostrarInformacion();
        Console.WriteLine($"Materia: {Materia}");
    }
}
