using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaVehiculos
{
    abstract class Vehiculo
    {
        private Motor _motor;
        private Mezclador _tipoM;
        private Estanque _estanque;
        private Rueda _rueda;


        protected Vehiculo(string id, TipoMotor tipoMotor, int cilindrada,
            TipoMezclador tipoM, int capacidad, double litros,
            TipoRecubrimiento recubrimiento,
            int minDurometro, int maxDurometro)
        {
            _motor = new Motor(id, tipoMotor, cilindrada);
            _tipoM = new Mezclador(tipoM);
            _estanque = new Estanque(capacidad);
            _rueda = new Rueda(recubrimiento, minDurometro, maxDurometro);
        }

        internal Motor Motor { get => _motor; set => _motor = value; }
        internal Mezclador TipoM { get => _tipoM; set => _tipoM = value; }
        internal Estanque Estanque { get => _estanque; set => _estanque = value; }
        internal Rueda Rueda { get => _rueda; set => _rueda = value; }
    }
}
