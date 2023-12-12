using System;
using Interfaces.Interfaces;

namespace Interfaces.Modelos
{
    public class TrianguloEquilatero : IFigura
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public double Area => Base * Altura;

        public double Perimetro => Base * 3;

        public string Tipo => "Triangulo";

        public TrianguloEquilatero(double _base, double altura)
        {
            Base = _base;
            Altura = altura;
        }
    }
}

