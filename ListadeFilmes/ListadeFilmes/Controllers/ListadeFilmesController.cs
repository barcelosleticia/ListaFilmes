using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ListadeFilmes.Controllers
{
    [Route("api/[controller]")]
    public class ListadeFilmesController : Controller
    {
        ListaFilmeBLL Listagem = new ListaFilmeBLL();
        public List<Filme> listaFilmes = new List<Filme>()
        {
            new Filme {Id= 1, NomeFilme = "Guardioes da Galaxia", AnoLancamento=2017, Genero = "Comédia", Nota=10},
            new Filme {Id= 2, NomeFilme = "Mulher Maravilha", AnoLancamento=2017, Genero = "Ação", Nota=5},
            new Filme {Id= 3, NomeFilme = "Holmes & Watson", AnoLancamento=2018, Genero = "Comédia", Nota=8},
            new Filme {Id= 4, NomeFilme = "Vingadores: Guerra Infinita", AnoLancamento=2018, Genero = "Ação", Nota=6},
            new Filme {Id= 5, NomeFilme = "Aquaman", AnoLancamento=2018, Genero = "Ação", Nota=9}
        };

        [HttpPut("{Id}/{notaCritico}")]
        public IActionResult SelecionarCategoriaFilme (int notaCritico)
        {
            Listagem.SelecionarCategoriaFilme(notaCritico);
            return Json(listaFilmes[0].notaCritico);
        }

        //PUT api/ListadeFilmes/2/Comedia
        [HttpPut("{Id}/{Genero}")]
        public IActionResult AlterarGenero(string Genero, string GeneroNovo)
        {
            Listagem.AlterarGenero(Genero, GeneroNovo);
            return Json(listaFilmes[0].Genero);
        }

        //PUT api/ListadeFilmes/1/7
        [HttpPut("{Id}/{Nota}")]
        public IActionResult AlterarNota(int notaAntiga, int notaAtual)
        {
            Listagem.AlterarNota(notaAntiga, notaAtual);
            return Json(listaFilmes[0].Nota);
        }

        //PUT api/ListadeFilmes/1/2015
        [HttpPut("{Id}/{AnoLancamento}")]
        public IActionResult AlterarAnoLancamento(int ano, int anoCorreto)
        {
            Listagem.AlterarAnoLancamento(ano, anoCorreto);
            return Json(listaFilmes[0].AnoLancamento);
        }

        private static string GetCharacterNome(string NomeFilme)
        {
            return NomeFilme;
        }

        private static int GetCharacterAnoLancamento(int AnoLancamento)
        {
            return AnoLancamento;
        }

        private static string GetCharacterGenero(string Genero)
        {
            return Genero;
        }

        private static string GetCharacterNota(string Nota)
        {
            return Nota;
        }

        private static int GetCharacterValorArrecadado(int ValorArrecadado)
        {
            return ValorArrecadado;
        }

        private static string GetCharacterCategoria(string Categoria)
        {
            return Categoria;
        }

        private static int GetCharacterNotaCritico(int notaCritico)
        {
            return notaCritico;
        }


        [HttpPut("{Id}")]
        public IActionResult Put([FromBody] Filme filme)
        {
            var AtualizarNomeFilme = listaFilmes.Where(x => x.Id == filme.Id).FirstOrDefault();
            return StatusCode(201);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Filme filme)
        {
            listaFilmes.Add(new Filme());
            return StatusCode(201, filme);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Json(listaFilmes);
        }

        [HttpGet("Id")]
        public IActionResult GetCharacterId()
        {
            return Json(listaFilmes[0].Id);
        }

        [HttpGet("NomeFilme")]
        public IActionResult GetCharacterNomeFilme()
        {
            return Json(listaFilmes[0].NomeFilme);
        }

        [HttpGet("AnoLancamento")]
        public IActionResult GetCharacterAnoLancamento()
        {
            return Json(listaFilmes[0].AnoLancamento);
        }

        [HttpGet("Genero")]
        public IActionResult GetCharacterGenero()
        {
            return Json(listaFilmes[0].Genero);
        }

        [HttpGet("Nota")]
        public IActionResult GetCharacterNota()
        {
            return Json(listaFilmes[0].Nota);
        }

        [HttpGet("ValorArrecadado")]
        public IActionResult GetCharacterValorArrecadado()
        {
            return Json(listaFilmes[0].ValorArrecadado);
        }

        [HttpGet("Categoria")]
        public IActionResult GetCharacterCategoria()
        {
            return Json(listaFilmes[0].Categoria);
        }

        [HttpGet("notaCritica")]
        public IActionResult GetCharacterNotaCritico()
        {
            return Json(listaFilmes[0].notaCritico);
        }

        [HttpDelete("{Id}")]
        public IActionResult Delete(int Id)
        {
            var deletado = listaFilmes.Where(x => x.Id == Id).FirstOrDefault();
            if (deletado == null)
            {
                return NotFound();
            }
            listaFilmes.Remove(deletado);
            return NoContent();
        }

        public class Filme
        {
            public int Id { get; set; }
            public string NomeFilme { get; set; }
            public int AnoLancamento { get; set; }
            public string Genero { get; set; }
            public int Nota { get; set; }
            public int ValorArrecadado { get; set; }
            public string Categoria{get;set;}
            public int notaCritico{get;set;}
        }
    }
}
