using System.Reflection;
using CompararDosFiguras.Modelos;
using CompararDosFiguras.Interfaces;

namespace CompararDosFiguras;
class Program
{
    static void Main(string[] args)
    {
        Console.ReadKey();
    }

    static IFigura ObtenerFiguraMayor(List<IFigura> figuras)
    {
        var figuraMayor = figuras[0];
        foreach(var figura in figuras)
        {
            if (figura.Area > figuraMayor.Area)
            {
                figuraMayor = figura;
            }
        }
        return figuraMayor;
    }

    static void ImprimirFigura(IFigura figura)
    {
        Console.WriteLine($"La figura es un {figura.Tipo}," +
            $" su área es de {figura.Area} y su perímetro es de " +
            $"{figura.Perimetro}.");
    }

    static IFigura CrearFigura()
    {
        Console.WriteLine("Que figura quieres crear?");
        Console.WriteLine("1) Cuadrado 2) Circulo 3) Triangulo");
        string opcionSeleccionada = Console.ReadLine();

        switch(opcionSeleccionada)
        {
            case "1":
                {
                    Console.WriteLine("Dame el lado del cuadrado:");
                    var lado = LeerNumero();
                    var cuadrado = new Cuadrado(lado);
                    return cuadrado;
                }
            case "2":
                {
                    Console.WriteLine("Dame el radio del circulo:");
                    var radio = LeerNumero();
                    var circulo = new Circulo(radio);
                    return circulo;
                }
            case "3":
                {
                    Console.WriteLine("Dame la base del triangulo");
                    var _base = LeerNumero();
                    Console.WriteLine("Dame la altura del triangulo:");
                    var altura = LeerNumero();
                    var triangulo = new TrianguloEquilatero(_base, altura);
                    return triangulo;
                }
            default:
                {
                    return null;
                }
        }
    }

    static double LeerNumero() => double.Parse(Console.ReadLine());
}






