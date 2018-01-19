interface IListaFilmesBLL
{
    int AlterarNota(int notaAntiga, int notaAtual);
    string AlterarGenero(string Genero, string GeneroNovo);
    int AlterarAnoLancamento(int ano, int anoCorreto);
    string SelecionarCategoriaFilme (int notaCritico);
}
