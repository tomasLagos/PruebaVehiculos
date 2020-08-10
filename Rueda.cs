using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaVehiculos
{
    enum TipoRecubrimiento
    {
        FENOL, HULE, POLIUTERANO
    }

    class Rueda : VehiculoComponentes
    {
        private TipoRecubrimiento _recubrimiento;
        private int _minDurometro;
        private int _maxDurometro;




        public Rueda(TipoRecubrimiento recubrimiento, int minDurometro,
            int maxDurometro)

        {
            _recubrimiento = recubrimiento;
            _minDurometro = minDurometro;
            _maxDurometro = maxDurometro;
        }



        public TipoRecubrimiento Recubrimiento
        {
            get => _recubrimiento;
            set => Enum.TryParse(value.ToString(), out _recubrimiento);
        }
        internal int MinDurometro { get => _minDurometro; set => _minDurometro = value; }
        internal int MaxDurometro { get => _maxDurometro; set => _maxDurometro = value; }
    }
}

