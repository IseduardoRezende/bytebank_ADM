using bytebank_ADM.Funcionarios;
using System;
using System.Collections.Generic;
using System.Text;

namespace bytebank_ADM.SistemaInternos
{
    public interface Iautenticavel
    {
        public bool Autenticar(string _senha);
    }
}