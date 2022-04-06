using System;

class Program
{
    static void Main(string[] args)
    {
        No no0 = new No(0);

        No no1 = new No(1);
        No no2 = new No(2);

        No no3 = new No(3); //no1
        No no4 = new No(4); //no1

        No no5 = new No(5); //no2
        No no6 = new No(6); //no2

        //pais
        no1.SetNoPai (no0);
        no2.SetNoPai (no0);

        no3.SetNoPai (no1);
        no4.SetNoPai (no1);

        no5.SetNoPai (no2);
        no6.SetNoPai (no2);

        //rotas
        no0.SetNoEsquerda (no1);
        no0.SetNoDireita (no2);

        no1.SetNoEsquerda (no3);
        no1.SetNoDireita (no4);

        no2.SetNoEsquerda (no5);
        no2.SetNoDireita (no6);

        BuscaEmAltura buscaAtividade = new BuscaEmAltura(no6.GetValor());

        buscaAtividade.buscarResultado (no0);
        buscaAtividade.contarNosFolha();
    }
}
