using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DisciplinaOnline.Domain.Test.Disciplinas
{
    public class DisciplinaTest
    {
        [Fact]
        public void CriarDisciplina() // curso-criarcurso-retornacurso
{
            var DisciplinaEsperada = new {
                Nome = "Técnicas de Programação 2",
                CargaHoraria = (double)64,
                PublicoAlvo = "Alunos da UFC"
            };

            var disciplina = new Disciplina(DisciplinaEsperada.Nome,
                                            DisciplinaEsperada.CargaHoraria,
                                            DisciplinaEsperada.PublicoAlvo);

            Assert.Equal(DisciplinaEsperada.Nome, disciplina.Nome);
        }
    }
}
