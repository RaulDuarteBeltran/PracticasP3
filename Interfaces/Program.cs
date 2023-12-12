using System.Reflection.Metadata.Ecma335;
using Interfaces.Modelos;
using Interfaces.Interfaces;

namespace Interfaces;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Vamos a crear la primera figura:");
        var figura1 = CrearFigura();

        var cuadrado = figura1 as Cuadrado;
        if(cuadrado == null)
        {
            Console.WriteLine("Esto no es un cuadrado");
            return;
        }

        cuadrado.Lado = 10;



        Console.WriteLine("Ahora creemos la segunda figura:");
        var figura2 = CrearFigura();
        ImprimirFiguraMayor(figura1, figura2);
        Console.ReadKey();
        
    }

    static IFigura CrearFigura()
    {
        Console.WriteLine("¿Qué figura deseas crear?");
        Console.WriteLine("1) Cuadrado 2) Circulo 3) Triangulo");
        string respuesta = Console.ReadLine();
        switch (respuesta)
        {
            case "1":
                {
                    Console.WriteLine("Dime cuanto mide el lado del cuadrado:");
                    double lado = double.Parse(Console.ReadLine());
                    var cuadrado = new Cuadrado(lado);
                    return cuadrado;
                }
            case "2":
                {
                    Console.WriteLine("Cuanto mide el radio del circulo?:");
                    double radio = double.Parse(Console.ReadLine());
                    var circulo = new Circulo(radio);
                    return circulo;
                }
            case "3":
                {
                    Console.WriteLine("Dime cuanto mide la base:");
                    double _base = double.Parse(Console.ReadLine());
                    Console.WriteLine("Dime cuanto mide la altura:");
                    double altura = double.Parse(Console.ReadLine());
                    var triangulo = new TrianguloEquilatero(_base, altura);
                    return triangulo;
                }
            default:
                Console.WriteLine("No escogiste una opción válida");
                return null;
        }
    }

    static void ImprimirFiguraMayor(IFigura figura1, IFigura figura2)
    {
        IFigura figuraMayor = figura1.Area >= figura2.Area ? figura1 : figura2;
        Console.WriteLine($"La figura mayor fue un {figuraMayor.Tipo}, su área fue de {figuraMayor.Area}" +
            $" y su perímetro fue de {figuraMayor.Perimetro}");
        
    }
}


