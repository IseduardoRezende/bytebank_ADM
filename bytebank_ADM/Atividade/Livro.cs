using System;
using System.Collections.Generic;
using System.Text;

namespace bytebank_ADM.Atividade
{
    public class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }

        public string ISBN { get; set; }

        public int AnoDePublicacao { get; set; }

        public string EstiloLiterario { get; set; }
        public int NumeroDePagina { get; set; }
        public string Pais { get; set; }

        public Livro(string _ISBN, string _titulo)
        {
            this.ISBN = _ISBN;
            this.Titulo = _titulo;
        }
    }
}
