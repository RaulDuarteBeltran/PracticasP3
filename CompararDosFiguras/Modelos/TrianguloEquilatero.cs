using System;
using CompararDosFiguras.Interfaces;

namespace CompararDosFiguras.Modelos
{
    public class TrianguloEquilatero : IFigura
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public double Area
        {
            get => Base * Altura / 2;
        }

        public double Perimetro
        {
            get => Base * 3;
        }

        public string Tipo => "Triangulo";

        public TrianguloEquilatero(double _base, double altura)
        {
            Base = _base;
            Altura = altura;
        }
    }
}

