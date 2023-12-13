using System;
using CompararDosFiguras.Interfaces;

namespace CompararDosFiguras.Modelos
{
    public class Cuadrado : IFigura, IComparable
    {
        public double Lado { get; set; }

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

        public int CompareTo(object? obj)
        {
            if(obj == null)
            {
                return 1;
            }

            var cuadradoRecibido = obj as Cuadrado;
            if(cuadradoRecibido == null)
            {
                throw new Exception("El objeto pasado no es un cuadrado");
            }

            if(this.Area > cuadradoRecibido.Area)
            {
                return 1; //Indica que nuestro objeto es mayor
            }
            else if(this.Area == cuadradoRecibido.Area)
            {
                return 0; //Indica que ambos objetos son iguales en valor
            }
            else
            {
                return -1; //Indica que nuestro objeto es menor que el recibido
            }
        }
    }
}

