using System;
namespace CompararDosFiguras.Interfaces
{
    public interface IFigura
    {
        double Area { get; }
        double Perimetro { get; }
        string Tipo { get; }
    }
}

