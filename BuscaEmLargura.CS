using System.Collections.Generic;

public class BuscaEmLargura : Busca
{
    private Queue<No> filaNos;
    
    public BuscaEmLargura(int valorBusca){
        this.filaNos = new Queue<No>();
        this.SetValorBusca(valorBusca);
    }
    public override bool buscarResultado(No no)
    {
        if(isResultadoBusca(no)){
            obterResultadoNoPAI(no);
            return true;
        }
        else{
            if (no.GetNoEsquerda() != null){
                this.filaNos.Enqueue(no.GetNoEsquerda());
            
            }
            if (no.GetNoDireita() != null){
                this.filaNos.Enqueue(no.GetNoDireita());
        
            }
            No noPonta = this.filaNos.Peek();
            if (noPonta != null && buscarResultado(noPonta)){
                return true;
            }
        }
        return false;
    }

    public override int contarNosFolha()
    {
        if (this.filaNos != null){
            return this.filaNos.Count;
        }
        return 0;
    }

    
}