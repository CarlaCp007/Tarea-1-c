using System;

class Persona
{
    // Atributos
    private string nombre;
    private string apellido;
    private int edad;
    private string genero;

    // Métodos para establecer los valores
    public void SetNombre(string nombre)
    {
        this.nombre = nombre;
    }

    public void SetApellido(string apellido)
    {
        this.apellido = apellido;
    }

    public void SetEdad(int edad)
    {
        this.edad = edad;
    }

    public void SetGenero(string genero)
    {
        this.genero = genero;
    }

    // Métodos para obtener los valores
    public string GetNombre()
    {
        return nombre;
    }

    public string GetApellido()
    {
        return apellido;
    }

    public int GetEdad()
    {
        return edad;
    }

    public string GetGenero()
    {
        return genero;
    }

    // Método para imprimir la información
    public void ImprimirInformacion()
    {
        Console.WriteLine($"Nombre: {nombre} {apellido}");
        Console.WriteLine($"Edad: {edad}");
        Console.WriteLine($"Género: {genero}");
    }
}

class Program
{
    static void Main()
    {
        // Crear una instancia de Persona
        Persona persona = new Persona();

        // Establecer valores
        persona.SetNombre("Luis");
        persona.SetApellido("Pérez");
        persona.SetEdad(30);
        persona.SetGenero("Masculino");

        // Imprimir información
        persona.ImprimirInformacion();
    }
}
