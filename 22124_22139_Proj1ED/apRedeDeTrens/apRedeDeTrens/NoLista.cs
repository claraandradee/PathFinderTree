//Nome: Clara Andrade Sant'Anna Santos RA:22124
//Nome: Julia Enriquetto de Brito      RA:22139 

public class NoLista<Dado> where Dado : IComparable<Dado>
{
    Dado info;
    NoLista<Dado> prox, anterior;


    public NoLista(Dado novaInfo, NoLista<Dado> proximoNo, NoLista<Dado> anterior)
    {
        Info = novaInfo;
        Prox = proximoNo;
        Anterior = anterior; 
    }

    public NoLista(Dado novaInfo)
    {
        Info = novaInfo;
        Prox = null;
    }
    public Dado Info
    {
        get => info;
        set
        {
            if (value != null)
                info = value;
        }
    }

    public NoLista<Dado> Prox
    {
        get => prox;
        set => prox = value;
    }
    public NoLista<Dado> Anterior 
    { 
        get => anterior; 
        set => anterior = value;
    }
}