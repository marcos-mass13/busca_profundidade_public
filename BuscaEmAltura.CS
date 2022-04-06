using System;
using System.Collections;
using System.Collections.Generic;

public class BuscaEmAltura : Busca
{
    private Stack<No> pilha;

    private Stack<No> route;

    public BuscaEmAltura(int valorBusca)
    {
        this.pilha = new Stack<No>();
        this.route = new Stack<No>();
        this.SetValorBusca(valorBusca);
    }

    public override bool buscarResultado(No no)
    {
        if (isResultadoBusca(no))
        {
            obterResultadoNoPAI (no);
            exibirResultado();
            return true;
        }
        else
        {
            this.pilha.Push(no);
            // Console.WriteLine(this.pilha.Peek().GetValor());

            if (no.GetNoEsquerda() != null || no.GetNoDireita() != null)
            {
                if (no.GetNoEsquerda() != null)
                {
                    buscarResultado(no.GetNoEsquerda());
                }
                if (no.GetNoDireita() != null)
                {
                    buscarResultado(no.GetNoDireita());
                }
            }
            else
            {
                this.pilha.Pop();
            }
        }

        return false;
    }

    public override int contarNosFolha()
    {
        if (this.pilha != null)
        {
            return this.pilha.Count;
        }
        return 0;
    }
}
