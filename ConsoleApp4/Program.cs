using System;

class Punto
{
    // Atributos
    private double x;
    private double y;

    // Métodos para establecer los valores
    public void SetX(double x)
    {
        this.x = x;
    }

    public void SetY(double y)
    {
        this.y = y;
    }

    // Métodos para obtener los valores
    public double GetX()
    {
        return x;
    }

    public double GetY()
    {
        return y;
    }
}

class Program
{
    static void Main()
    {
        // Crear una instancia de Punto
        Punto punto = new Punto();

        // Establecer valores
        punto.SetX(5.0);
        punto.SetY(7.0);

        // Obtener valores
        Console.WriteLine("Coordenada X: " + punto.GetX());
        Console.WriteLine("Coordenada Y: " + punto.GetY());
    }
}
