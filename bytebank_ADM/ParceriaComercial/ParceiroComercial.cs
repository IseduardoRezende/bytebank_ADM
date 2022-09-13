using bytebank_ADM.SistemaInternos;
using System;
using System.Collections.Generic;
using System.Text;

namespace bytebank_ADM.ParceriaComercial
{
    public class ParceiroComercial: Iautenticavel
    {
        public ParceiroComercial()
        {
        }

        public string Senha { get; set; }

        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }
    }
}
