using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaVehiculos
{

    enum TipoMezclador
    {
        CARBURADOR, INYECTOR
    }

    internal class Mezclador : VehiculoComponentes
{
    private TipoMezclador _tipoM;

    public Mezclador(TipoMezclador tipoM)
    {
        _tipoM = tipoM;
    }


    internal TipoMezclador TipoM { get => _tipoM; set => _tipoM = value; }
}
}

