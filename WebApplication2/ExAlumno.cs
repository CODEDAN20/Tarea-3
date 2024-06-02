public class ExAlumno : MiembroDeLaComunidad
{
    public string AñoGraduacion { get; set; }

    public ExAlumno(string nombre, string apellido, string identificacion, string añoGraduacion)
        : base(nombre, apellido, identificacion)
    {
        AñoGraduacion = añoGraduacion;
    }

    public override void MostrarInformacion()
    {
        base.MostrarInformacion();
        Console.WriteLine($"Año de Graduación: {AñoGraduacion}");
    }
}
