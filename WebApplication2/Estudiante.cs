public class Estudiante : MiembroDeLaComunidad
{
    public string Carrera { get; set; }
    public int Año { get; set; }

    public Estudiante(string nombre, string apellido, string identificacion, string carrera, int año)
        : base(nombre, apellido, identificacion)
    {
        Carrera = carrera;
        Año = año;
    }

    public override void MostrarInformacion()
    {
        base.MostrarInformacion();
        Console.WriteLine($"Carrera: {Carrera}");
        Console.WriteLine($"Año: {Año}");
    }
}
