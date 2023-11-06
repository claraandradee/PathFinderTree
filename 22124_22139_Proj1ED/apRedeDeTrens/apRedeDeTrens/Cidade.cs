//Nome: Clara Andrade Sant'Anna Santos RA:22124
//Nome: Julia Enriquetto de Brito      RA:22139 

class Cidade : IComparable<Cidade>, IRegistro
  {
    public const int tamanhoNome = 15;

    private string nome;
    private double x, y;
    private ListaSimples<Ligacao> caminhos; 
    private const int tamRegistro = tamanhoNome + sizeof(double) + sizeof(double);

    public string Nome   { get => nome; set => nome = value.PadRight(tamanhoNome, ' '); }
    public double X         { get => x; set => x = value; }
    public double Y         { get => y; set => y = value; }
    public int TamRegistro { get => tamRegistro;  }
    internal ListaSimples<Ligacao> Caminhos { get => caminhos; set => caminhos = value; }

    //construtores
    public Cidade(string nome, double x, double y)
    {
        Nome = nome;
        X = x;
        Y = y;
        Caminhos = new ListaSimples<Ligacao>();
    }

    public Cidade()
    {
        Nome = "";
        X = 0;
        y = 0;
        Caminhos = new ListaSimples<Ligacao>();
    }

    public Cidade(string nome)
    {
        Nome = nome;
    }

    public int CompareTo(Cidade outro)
    {
        return nome.ToUpperInvariant().CompareTo(outro.nome.ToUpperInvariant());
    }

    public string ParaArquivo() 
    {
      return Nome + X.ToString() + Y.ToString();
    }

    public override string ToString()
    {
        return Nome;
    }

    public void LerRegistro(BinaryReader arquivo, long qualRegistro)
    {
        if (arquivo != null)
            try
            {
                long qtosBytes = qualRegistro * TamRegistro;
                arquivo.BaseStream.Seek(qtosBytes, SeekOrigin.Begin);

                char[] nomeCidade = arquivo.ReadChars(tamanhoNome);
                
                Nome = new string(nomeCidade);
                X = arquivo.ReadDouble();
                Y = arquivo.ReadDouble();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
    }

    public void GravarRegistro(BinaryWriter arquivo)
    {
        if (arquivo != null) // arquivo aberto?
        {
            char[] nome = new char[tamanhoNome];

            for (int i = 0; i < Nome.Length; i++)
                nome[i] = Nome[i];

            arquivo.Write(nome);
            arquivo.Write(X);
            arquivo.Write(Y);

            caminhos.IniciarPercursoSequencial();
            while (caminhos.PodePercorrer())
            {
                var ligacaoAtual = caminhos.Atual.Info;

                var fluxoCaminhos = new FileStream(ligacaoAtual.CaminhoArquivo, FileMode.Append);
                var arquivoCaminhos = new BinaryWriter(fluxoCaminhos);

                ligacaoAtual.GravarRegistro(arquivoCaminhos);

                arquivoCaminhos.Close();
            }
        }
    } 
}
