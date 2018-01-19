using System;

public class ListaFilmeBLL : IListaFilmesBLL
{
    public int AlterarNota(int notaAntiga, int notaAtual)
    {
        if (notaAntiga > notaAtual)
        {
            return notaAntiga;
        }
        else
        {
            if (notaAtual < 5)
            {
                return notaAntiga;
            }
            else
            {
                if (notaAtual > 10)
                {
                    return notaAntiga;
                }
                else
                {
                    if (notaAtual == null)
                    {
                        return notaAntiga;
                    }
                    else
                    {
                        return notaAtual;
                    }
                }
            }
        }
    }

    public string AlterarGenero(string Genero, string GeneroNovo)
    {
        if (Genero != GeneroNovo)
        {
            return GeneroNovo;
        }
        else
        {
            return Genero;
        }
    }

    public int AlterarAnoLancamento(int ano, int anoCorreto)
    {
        if (ano != anoCorreto)
        {
            return anoCorreto;
        }
        else
        {
            return ano;
        }
    }

    public string SelecionarCategoriaFilme(int notaCritico)
    {
        if ((notaCritico >= 7) && (notaCritico <= 10))
        {
            string mensagem = "PREMIUM";
            return mensagem;
        }
        else
        {
            if ((notaCritico >= 4)&&(notaCritico < 7))
            {
                string mensagem = "Sessão da Tarde";
                return mensagem;
            }
            else
            {
                if ((notaCritico <= 3)&&(notaCritico >=0))
                {
                    string mensagem = "PESSIMA";
                    return mensagem;
                }
                else
                {
                    if ((notaCritico < 0))
                    {
                        string mensagem = "Nota negativa";
                        return mensagem;
                    }
                    else
                    {
                        if (notaCritico > 10)
                        {
                            string mensagem = "PREMIUM";
                            return mensagem;
                        }
                        else
                        {
                            if (notaCritico == null)
                            {
                                string mensagem = "Não enquadra";
                                return mensagem;
                            }                   
                            else
                            {
                                string mensagem = "Obrigada";
                                return mensagem;
                            }        
                                
                        }
                    }
                }
            }
        }
    }

}