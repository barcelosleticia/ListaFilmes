using System;
using Xunit;

namespace testesUnitarios
{
    public class Test1
    {
        ListaFilmeBLL Lista = new ListaFilmeBLL();

        [Fact]
        public void TestarSeNotaAceitaNumeroMenorQueInformado()
        {
            int notaAntiga = 5; 
            int notaAtual = 4;

            int resultado1 = Lista.AlterarNota(notaAntiga,notaAtual);

            Assert.False(resultado1 == 4);
        }

        [Fact]
        public void TestarSeNotaPodeSerAcimaDe10()
        {
             int notaAntiga = 5; 
            int notaAtual = 11;

            int resultado2 = Lista.AlterarNota(notaAntiga,notaAtual);

            Assert.False(resultado2 == 11);
        }

        [Fact]
        public void TestarSeNotaAceitaNumeroNormal()
        {
             int notaAntiga = 5; 
            int notaAtual = 8;

            int resultado3 = Lista.AlterarNota(notaAntiga,notaAtual);

            Assert.True(resultado3 == 8);
        }

        [Fact]
        public void TestarSeNotaAceitaNegativo()
        {
            int notaAntiga = 5; 
            int notaAtual = -1;

            int resultado4 = Lista.AlterarNota(notaAntiga,notaAtual);

            Assert.False(resultado4 == 9);
        }

        [Fact]
        public void TestarSeNotaAtualMenorQueNotaAntiga()
        {
            int notaAntiga = 5; 
            int notaAtual = 4;

            int resultado5 = Lista.AlterarNota(notaAntiga,notaAtual);

            Assert.True(resultado5 == 5);
        }

        [Fact]
        public void TesteGeneroNovoSubstituido()
        {
            string genero = "comedia";
            string generoNovo = "acao";

            string resultado6 = Lista.AlterarGenero(genero, generoNovo);

            Assert.Equal("acao", resultado6);
        }
        
        [Fact]
        public void TesteGeneroSemSubstituicao()
        {
            string genero = "acao";
            string generoNovo = "acao";

            string resultado7 = Lista.AlterarGenero(genero, generoNovo);

            Assert.Equal(genero, generoNovo);
        }

        [Fact]
        public void TestarSeAnoLancamentoEstaCorreto()
        {
            int ano = 2017;
            int anoCorreto = 2018;

            int resultado8 = Lista.AlterarAnoLancamento(ano, anoCorreto);

            Assert.Equal(2018, resultado8);
        }

        [Fact]
        public void TestarAnoLancamentoSemSubstituicao()
        {
            int ano = 2017;
            int anoCorreto = 2017;

            int resultado9 = Lista.AlterarAnoLancamento(ano, anoCorreto);

            Assert.Equal(2017, resultado9);
        }

        [Fact]
        public void TestarSeCategoriaPremium()
        {
            int notaCritico = 8;

            string resultado10 = Lista.SelecionarCategoriaFilme(notaCritico);

            Assert.Equal("PREMIUM", resultado10);
        }

        [Fact]
        public void TestarSeCategoriaSessaoDaTarde()
        {
            int notaCritico = 6;

            string resultado11 = Lista.SelecionarCategoriaFilme(notaCritico);

            Assert.Equal("Sessão da Tarde", resultado11);
        }

        [Fact]
        public void TestarSeCategoriaAceitaNotaAcimade10()
        {
            int notaCritico = 15;

            string resultado12 = Lista.SelecionarCategoriaFilme(notaCritico);

            Assert.Equal("PREMIUM", resultado12);
        }

        [Fact]
        public void TestarSeCategoriaAceitaNotaAbaixo0()
        {
            int notaCritico = -5;

            string resultado13 = Lista.SelecionarCategoriaFilme(notaCritico);

            Assert.Equal("Nota negativa", resultado13);
        }
    }
}
