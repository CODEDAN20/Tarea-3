public class Empleado : MiembroDeLaComunidad
{
    public string Puesto { get; set; }
    public decimal Salario { get; set; }

    public Empleado(string nombre, string apellido, string identificacion, string puesto, decimal salario)
        : base(nombre, apellido, identificacion)
    {
        Puesto = puesto;
        Salario = salario;
    }

    public override void MostrarInformacion()
    {
        base.MostrarInformacion();
        Console.WriteLine($"Puesto: {Puesto}");
        Console.WriteLine($"Salario: {Salario:C}");
    }
}
