using System;
using CompararDosFiguras.Interfaces;

namespace CompararDosFiguras.Modelos
{
    public class Circulo : IFigura
    {
        public double Radio { get; set; }

        public double Area
        {
            get
            {
                return Math.PI * Radio * Radio;
            }
        }

        public double Perimetro
        {
            get
            {
                return 2 * Math.PI * Radio;
            }
        }

        public string Tipo
        {
            get => "Circulo";
        }

        public Circulo(double radio)
        {
            Radio = radio;
        }
    }

}

