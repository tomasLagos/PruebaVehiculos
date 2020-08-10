using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaVehiculos
{
    class Motocicleta : Vehiculo
    {
        private string _marca;
        private int _ano;
        private int _kilometraje;

        public Motocicleta(string id, TipoMotor tipoMotor,
                    int cilindrada, string marca, int ano, int kilometraje,
                    TipoMezclador tipoM, int capacidad, double litros, TipoRecubrimiento recubrimiento,
                    int minDurometro, int maxDurometro) :
                    base(id, tipoMotor, cilindrada, tipoM, capacidad, litros, recubrimiento, minDurometro,
                        maxDurometro)
        {
            _marca = marca;
            _ano = ano;
            _kilometraje = kilometraje;
        }

        public string Marca { get => _marca; set => _marca = value; }
        public int Ano { get => _ano; set => _ano = value; }
        public int Kilometraje { get => _kilometraje; set => _kilometraje = value; }


        public override string ToString()
        {
            return _marca;
        }

    }
}
