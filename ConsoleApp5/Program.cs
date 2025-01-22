using System;

class Circulo
{
    // Atributos
    private double x;
    private double y;
    private double radio;

    // Métodos para establecer los valores
    public void SetX(double x)
    {
        this.x = x;
    }

    public void SetY(double y)
    {
        this.y = y;
    }

    public void SetRadio(double radio)
    {
        this.radio = radio;
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

    public double GetRadio()
    {
        return radio;
    }

    // Método para calcular el área
    public double CalcularArea()
    {
        return Math.PI * radio * radio; // Fórmula del área del círculo: π * r²
    }
}

class Program
{
    static void Main()
    {
        // Crear una instancia de Circulo
        Circulo circulo = new Circulo();

        // Establecer valores
        circulo.SetX(0.0);
        circulo.SetY(0.0);
        circulo.SetRadio(5.0);

        // Obtener valores
        Console.WriteLine("Centro del círculo: (" + circulo.GetX() + ", " + circulo.GetY() + ")");
        Console.WriteLine("Radio: " + circulo.GetRadio());
        Console.WriteLine("Área: " + circulo.CalcularArea());
    }
}
