using System.Reflection;
using CompararDosFiguras.Modelos;
using CompararDosFiguras.Interfaces;

namespace CompararDosFiguras;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Creamos la primera figura:");
        var figura1 = CrearFigura();


        if(figura1 is Cuadrado cuadrado)
        {
            Console.WriteLine("Es un cuadrado.");
        }
        else if (figura1 is Circulo circulo)
        {
            Console.WriteLine("Es un circulo.");
        }

        
        
        Console.WriteLine("Creamos la segunda figura:");
        var figura2 = CrearFigura();
        MostrarMayor(figura1, figura2);
        Console.ReadKey();
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

    static void MostrarMayor(IFigura figura1, IFigura figura2)
    {
        var figuraMayor = figura1.Area >= figura2.Area ? figura1 : figura2;
        Console.WriteLine($"La figura mayor fue un {figuraMayor.Tipo}," +
            $" su área es de {figuraMayor.Area} y su perímetro es de " +
            $"{figuraMayor.Perimetro}.");
    }

    static double LeerNumero() => double.Parse(Console.ReadLine());
}






