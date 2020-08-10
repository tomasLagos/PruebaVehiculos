using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaVehiculos
{
    class Estanque
    {
        private readonly int _capacidad;
        private double _litros;

        public int Capacidad => _capacidad;

        public double Litros { get => _litros; set => _litros = value; }

        public Estanque(int capacidad)
        {
            _capacidad = capacidad;

        }

        public bool MitadCombustible()
        {
            return _litros >= (_capacidad * 0.105) && _litros <= (_capacidad * 0.5);
        }

        public bool BajoCombustible()
        {
            return _litros <= (_capacidad * 0.105);
        }
    }
}

