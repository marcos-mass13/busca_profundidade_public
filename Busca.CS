using System;

public abstract class Busca
{
    private int valorBusca;

#pragma warning disable CS8618
    private string textoResposta;

    public abstract bool buscarResultado(No no);

    public abstract int contarNosFolha();

    public void obterResultadoNoPAI(No no)
    {
        string retorno = " ";
        No noValor = no;
        retorno += noValor.GetValor();
        while (noValor.GetNoPai() != null)
        {
            noValor = noValor.GetNoPai();
            retorno = noValor.GetValor() + " " + retorno;
        }
        this.SetTextoResposta(retorno);
    }

    public void exibirResultado()
    {
        if (this.GetTextoResposta() != null)
        {
            Console
                .WriteLine("O caminho percorrido é: " +
                this.GetTextoResposta());
        }
    }

    public bool isResultadoBusca(No no)
    {
        return no.GetValor() == valorBusca;
    }

    public int GetValorBusca()
    {
        return valorBusca;
    }

    public void SetValorBusca(int value)
    {
        valorBusca = value;
    }

    public string GetTextoResposta()
    {
        return textoResposta;
    }

    public void SetTextoResposta(string value)
    {
        textoResposta = value;
    }
}
