using System;
using System.Collections.Generic;
using System.Text;

namespace DisciplinaOnline.Domain.Disciplina
{
    public class Disciplina
    {
        public string Nome { get; private set; }
        public double CargaHoraria { get; private set; }
        public string PublicoAlvo { get; set; }

        public Disciplina(string nome, double cargaHoraria, string publicoAlvo) {
            this.Nome = nome;
            this.CargaHoraria = cargaHoraria;
            this.PublicoAlvo = publicoAlvo;
        }
    }
}
