﻿using System;
using CompararDosFiguras.Interfaces;

namespace CompararDosFiguras.Modelos
{
    public class Cuadrado : IFigura
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
    }
}

