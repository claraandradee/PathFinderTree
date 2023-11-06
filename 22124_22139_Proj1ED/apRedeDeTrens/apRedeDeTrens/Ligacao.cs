//Nome: Clara Andrade Sant'Anna Santos RA:22124
//Nome: Julia Enriquetto de Brito      RA:22139 

class Ligacao : IComparable<Ligacao>, IRegistro
{
    const int tamCidade = 15;

    private string idCidadeOrigem, idCidadeDestino;
    private int distancia, tempo;
    private string caminhoArquivo;

    const int tamRegistro = tamCidade + // cidade origem
                           tamCidade + // cidade destino
                           sizeof(int) + //distancia
                           sizeof(int);  //tempo

    public Ligacao(string idCidadeOrigem, string idCidadeDestino, int distancia, int tempo, string caminhoArquivo)
    {
        this.idCidadeDestino = idCidadeDestino;
        this.idCidadeOrigem = idCidadeOrigem;
        this.distancia = distancia;
        this.tempo = tempo;
        this.caminhoArquivo = caminhoArquivo;
    }

    public Ligacao(string idCidadeOrigem, string idCidadeDestino)
    {
        this.idCidadeOrigem = idCidadeOrigem;
        this.idCidadeDestino = idCidadeDestino;
    }

    public Ligacao() {}
    public Ligacao(string caminhoArquivo) 
    {
        this.caminhoArquivo = caminhoArquivo;
    }

    public string IdCidadeOrigem { get => idCidadeOrigem; set => idCidadeOrigem = value; }
    public string IdCidadeDestino { get => idCidadeDestino; set => idCidadeDestino = value; }
    public int Distancia { get => distancia; set => distancia = value; }
    public int Tempo { get => tempo; set => tempo = value; }
    public int TamRegistro => tamRegistro;
    public string CaminhoArquivo { get => caminhoArquivo; set => caminhoArquivo = value; }

    public int CompareTo(Ligacao outro)
    {
        return (idCidadeOrigem + idCidadeDestino).CompareTo(outro.idCidadeOrigem + outro.idCidadeDestino);
    }

    public void LerRegistro(BinaryReader arquivo, long registro)
    {
        if (arquivo != null)
            try
            {
                long qtosBytes = registro * tamRegistro;
                //arquivo le tamanhoRegistro bytes e separa pelos campos
                arquivo.BaseStream.Seek(qtosBytes, SeekOrigin.Begin);

                char[] cidadeOrigem = arquivo.ReadChars(tamCidade);
                IdCidadeOrigem = new string(cidadeOrigem);

                char[] cidadeDestino = arquivo.ReadChars(tamCidade);
                IdCidadeDestino = new string(cidadeDestino);

                Distancia = arquivo.ReadInt32();
                Tempo = arquivo.ReadInt32();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
    }

    public string ParaArquivo()
    {
        return $"{IdCidadeOrigem}{IdCidadeDestino}{Distancia:00000}";
    }

    public override string ToString()
    {
        return $"{IdCidadeOrigem} {IdCidadeDestino} {Distancia:00000}";
    }

    public void GravarRegistro(BinaryWriter arq)
    {
        if (arq != null)
        {
            char[] cidadeOrigem = new char[tamCidade];

            for (int i = 0; i < tamCidade; i++)
                cidadeOrigem[i] = idCidadeOrigem[i];

            char[] cidadeDestino = new char[tamCidade];

            for (int i = 0; i < tamCidade; i++)
                cidadeDestino[i] = idCidadeDestino[i];

            arq.Write(cidadeOrigem);
            arq.Write(cidadeDestino);
            arq.Write(Distancia);
            arq.Write(Tempo);
        }
    }
}