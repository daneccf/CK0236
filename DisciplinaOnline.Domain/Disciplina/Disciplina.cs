
using DisciplinaOnline.Domain.Disciplina.Enums;

namespace DisciplinaOnline.Domain.Disciplina
{
    public class Disciplina
    {
        public string Nome { get; private set; }
        public double CargaHoraria { get; private set; }
        public PublicoAlvo PublicoAlvo { get; set; }

        public Disciplina(string nome, double cargaHoraria, PublicoAlvo publicoAlvo) {
            this.Nome = nome;
            this.CargaHoraria = cargaHoraria;
            this.PublicoAlvo = publicoAlvo;
        }
    }
}
