// Clase base
public class Vehiculo
{
    public string Marca { get; set; }
    public int Año { get; set; }

    public virtual string MostrarInfo()
    {
        return $"Marca: {Marca}, Año: {Año}";
    }
}

// Clase derivada
public class Motocicleta : Vehiculo
{
    public int Cilindrada { get; set; } // cc de la moto

    // Se sobrescribe el método para incluir la cilindrada
    public override string MostrarInfo()
    {
        return base.MostrarInfo() + $", Cilindrada: {Cilindrada}cc";
    }
}

// Uso en el método Main
class Program
{
    static void Main()
    {
        Motocicleta miMoto = new Motocicleta()
        {
            Marca = "Yamaha",
            Año = 2023,
            Cilindrada = 600
        };

        Console.WriteLine(miMoto.MostrarInfo());
    }
}