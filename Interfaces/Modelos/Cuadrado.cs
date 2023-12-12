using System;
using Interfaces;
using Interfaces.Interfaces;


namespace Interfaces.Modelos
{
    public class Cuadrado : IFigura
    {
        public double Lado
        {
            get; set;
        }

        public double Area
        {
            get
            {
                return Lado * Lado;
            }
        }

        public double Perimetro
        {
            get
            {
                return Lado * 4;
            }
        }

        public string Tipo
        {
            get => "Cuadrado";
        }

        public Cuadrado(double lado)
        {
            Lado = lado;
        }
    }
}

