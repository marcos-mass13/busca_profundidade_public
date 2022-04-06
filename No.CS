public class No
{
    private int valor;

    #pragma warning disable CS8625
    #pragma warning disable CS8618
    private No noPai;

    private No noEsquerda;

    private No noDireita;

    public No(int valor)
    {
        this.SetValor(valor);
    }

    public int GetValor()
    {
        return valor;
    }

    public void SetValor(int value)
    {
        valor = value;
    }

    public No GetNoPai()
    {
        return noPai;
    }

    public void SetNoPai(No value)
    {
        noPai = value;
    }

    public No GetNoEsquerda()
    {
        return noEsquerda;
    }

    public void SetNoEsquerda(No value)
    {
        noEsquerda = value;
    }

    public No GetNoDireita()
    {
        return noDireita;
    }

    public void SetNoDireita(No value)
    {
        noDireita = value;
    }
}
