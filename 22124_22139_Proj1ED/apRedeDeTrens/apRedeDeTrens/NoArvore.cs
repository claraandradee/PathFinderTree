//Nome: Clara Andrade Sant'Anna Santos RA:22124
//Nome: Julia Enriquetto de Brito      RA:22139 

public class NoArvore<Dado> : IComparable<NoArvore<Dado>> 
                                where Dado : IComparable<Dado>
  {
    Dado info;
    NoArvore<Dado> esq;
    NoArvore<Dado> dir;
    private int altura;

    public Dado Info { get => info; set => info = value; }
    public NoArvore<Dado> Esq { get => esq; set => esq = value; }
    public NoArvore<Dado> Dir { get => dir; set => dir = value; }
    public int Altura { get => altura; set => altura = value; }

    public NoArvore(Dado info, NoArvore<Dado> esq, 
                    NoArvore<Dado> dir, int altura)
    {
      this.info = info;
      this.esq = esq;
      this.dir = dir;
      this.altura = altura;
    }

    public NoArvore(Dado info)
    {
      this.info = info;
      this.esq = this.dir = null; // importantíssimo!!!
      altura = 0;
    }

    public int CompareTo(NoArvore<Dado> outro)
    {
      return info.CompareTo(outro.info);
    }

    public bool Equals(NoArvore<Dado> outro)
    {
      return info.Equals(outro.info);
    }
  }

