using System;
using Interfaces.Interfaces;
namespace Interfaces.Modelos
{
    public class Circulo : IFigura
    {
        public double Radio { get; set; }

        public double Area => Math.PI * Radio * Radio;

        public double Perimetro => 2 * Radio * Math.PI;

        public string Tipo => "Circulo";

        public Circulo(double radio)
        {
            Radio = radio;
        }
    }
}

