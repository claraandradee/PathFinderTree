//Nome: Clara Andrade Sant'Anna Santos RA:22124
//Nome: Julia Enriquetto de Brito      RA:22139 

public class ListaSimples<Dado> where Dado : IComparable<Dado>
{
    NoLista<Dado> primeiro, ultimo, atual, anterior;
    int quantosNos, posicaoAtual;
    bool primeiroAcessoDoPercurso;

    public ListaSimples()
    { 
        primeiro = ultimo = anterior = atual = null; 
        quantosNos = 0; 
        posicaoAtual = 0;
        primeiroAcessoDoPercurso = false; 
    }

    public bool EstaVazia
    {
        get => primeiro == null;
    }

    public NoLista<Dado> Primeiro { get => primeiro; }
    public NoLista<Dado> Ultimo { get => ultimo; }
    public NoLista<Dado> Atual { get => atual;  }
    public NoLista<Dado> Anterior { get => anterior; }
    public bool EstaVazio { get => quantosNos == 0;  }
    public int Tamanho { get => quantosNos; }
    public int PosicaoAtual { get => posicaoAtual; set => posicaoAtual = value; }

    public List<Dado> Lista() 
    {
        var lista = new List<Dado>();
        atual = primeiro; 
        while (atual != null) 
        { 
            lista.Add(atual.Info);
            atual = atual.Prox; 
        }
        return lista;
    }

    public void InserirAntesDoInicio(Dado novoDado)
    {
        var novoNo = new NoLista<Dado>(novoDado);
        if (EstaVazia)          // se a lista está vazia, estamos
            ultimo = novoNo;    // incluindo o 1o e o último nós!
        
        novoNo.Prox = primeiro;
        primeiro = novoNo;
        quantosNos++;
    }

    public void InserirAposFim(Dado novoDado)
    {
        var novoNo = new NoLista<Dado>(novoDado);
        if (EstaVazia)
            primeiro = novoNo;
        else
            ultimo.Prox = novoNo;

        ultimo = novoNo;
        ultimo.Prox = null;
        quantosNos++;
    }

    public void InserirAposFim(NoLista<Dado> noExistente)
    {
        if (EstaVazia)
            primeiro = noExistente;
        else
            ultimo.Prox = noExistente;

        ultimo = noExistente;
        ultimo.Prox = null;

        quantosNos++;
    }

    public bool ExisteDado(Dado procurado)
    {
        // atual apontará o nó com o Dado procurado, e
        // anterior apontará o nó anterior a este
        anterior = atual = null;
        if (EstaVazia)
            return false;

        // se a lista não está vazia, podemos usar os ponteiros da lista

        // se o campo chave do Dado procurado é menor que o
        // campo chave do primeiro nó, o Dado procurado não existe

        if (procurado.CompareTo(primeiro.Info) < 0)
        {
            atual = primeiro;  // anterior continua com null
            return false;
        }

        // se o campo chave do Dado procurado é maior que o
        // campo chave do último nó, o Dado procurado não existe

        if (procurado.CompareTo(ultimo.Info) > 0)
        {
            anterior = ultimo;  // atual continua com null
            return false;
        }

        // o Dado procurado pode estar na lista, temos que procurar
        // um a um, até encontrá-lo ou achar uma chave maior que a 
        // do procurado

        atual = primeiro;
        bool achou = false;      // fica true quando acha chave igual
        bool maiorOuFim = false; // fica true quando acha chave maior
                                 // ou chegou no fim da lista
        while (!achou && !maiorOuFim)
            if (atual == null)
                maiorOuFim = true;
            else // como atual != null, podemos acessar o nó atual
                 // se atual aponta nó com chave maior que a procurada
                if (atual.Info.CompareTo(procurado) > 0)
                    maiorOuFim = true;
                else
                  // testamos se as chaves são iguais
                  if (atual.Info.CompareTo(procurado) == 0)
                     achou = true; // encontramos o nó com a chave procurada,
                                   // e atual aponta para ele
                  else
                    {
                       anterior = atual;
                       atual = atual.Prox;
                    }

        return achou;  // anterior e atual definem região do nó
    }

    public void InserirEmOrdem(Dado dados)
    {
        if (EstaVazia) // se a lista está vazia, então o
            InserirAntesDoInicio(dados); // novo nó é o primeiro da lista
        else
          // testa se nova chave < primeira chave
          if (dados.CompareTo(primeiro.Info) < 0)  // novo nó será ligado
             InserirAntesDoInicio(dados);          // antes do primeiro
          else
            // testa se nova chave > última chave
            if (dados.CompareTo(ultimo.Info) > 0)
               InserirAposFim(dados);  // cria nó e o liga no fim da lista
            else
              if (!ExisteDado(dados))  // insere entre os nós anterior 
              {                        // e atual 
                 var novo = new NoLista<Dado>(dados, null, null);
                 anterior.Prox = novo; // liga anterior ao novo
                 novo.Prox = atual; // e novo no atual
                 if (anterior == ultimo) // se incluiu ao final da lista,
                    ultimo = novo; // atualiza o apontador ultimo
                 quantosNos++;
              }
              else
                throw new Exception("Já existe!");
    }

    public bool Remover(Dado dadoARemover)
    {
        if (ExisteDado(dadoARemover))
        {  // lista não está vazia, temos um 1o e um último
            if (atual == primeiro)  // caso especial
            {
                primeiro = primeiro.Prox;
                atual = primeiro;
                if (primeiro == null)  // se esvaziou a lista!!!!
                    ultimo = null;     // ultimo passa a apontar nada
            }
            else
                if (atual == ultimo)  // caso especial
                {
                   ultimo = anterior;
                   ultimo.Prox = null;
                   atual = ultimo;
                }
                else  // caso geral, nó interno sendo excluído
                    {
                        anterior.Prox = atual.Prox;
                        atual = atual.Prox;
                    }

            quantosNos--;
            return true;  // conseguiu excluir
        }

        return false;
    }

    public void Ordenar()
    {
        var listaOrdenada = new ListaSimples<Dado>();
        while (!this.EstaVazia)
        {
            // percorre - se a lista original, não ordenada, e encontra-se
            // o elemento com a menor chave da lista. Deve-se guardar o
            // apontador para o nó anterior e para o nó onde se encontra o
            // menor elemento

            NoLista<Dado> anteriorAoMenor = null;
            NoLista<Dado> oMenor = this.primeiro;
            this.anterior = null;
            this.atual = this.primeiro;
            while (this.atual != null)
            {
                if (atual.Info.CompareTo(oMenor.Info) < 0)
                {
                    anteriorAoMenor = this.anterior;
                    oMenor = this.atual;
                }
                this.anterior = this.atual;
                this.atual = this.atual.Prox;
            }

            // Remove-se o menor elemento da lista original (para isso
            // usam-se os apontadores anterior ao menor e menor)

            if (anteriorAoMenor == null) // estamos removendo o 1o
                                         // da lista original!!
            {
                this.primeiro = this.primeiro.Prox;
            }
            else
            { 
                anteriorAoMenor.Prox = oMenor.Prox;
            // cuidado ao remover o último!! tratar disso!
            }
            this.quantosNos--;

            // Inclui-se ao final da lista ordenada o nó recém-
            // retirado da lista original (o menor de todos)

            listaOrdenada.InserirAposFim(oMenor);
        }
        this.primeiro = listaOrdenada.primeiro;
        this.ultimo = listaOrdenada.ultimo;
        this.atual = primeiro;
        this.anterior = null;
        this.quantosNos = listaOrdenada.quantosNos;
    }

    public Dado DadoAtual() //retorna dado atualmente visitado
    {
        if(atual != null)
            return atual.Info;
        return default; 
    }

    public bool PodePercorrer()
    {
        if (!primeiroAcessoDoPercurso)
        {
            anterior = atual;
            atual = atual.Prox;
        }
        else
            primeiroAcessoDoPercurso = false;

        return atual != null;
    }

    public void IniciarPercursoSequencial()
    {
        primeiroAcessoDoPercurso = true;
        atual = primeiro;
        anterior = null;
    }

    public void AvancarPosicao()
    {
        if(atual != null)
        {
            atual = atual.Prox;
            posicaoAtual++;
        }
    }

    public bool Existe(Dado procurado, out int ondeEsta)
    {
        PosicionarNoPrimeiro();

        if (EstaVazio || procurado == null)
        {
            ondeEsta = -1;
            return false;
        }

        if (procurado.CompareTo(primeiro.Info) < 0)
        {
            ondeEsta = -1;
            return false;
        }

        if (procurado.CompareTo(ultimo.Info) > 0)
        {
            PosicionarNoUltimo();
            ondeEsta = -1;
            return false;
        }

        bool achou = false;
        bool fim = false;
        ondeEsta = 0;

        while (!achou && !fim)
        {
            if (atual == null)
                fim = true;
            else
            {
                if (procurado.CompareTo(DadoAtual()) == 0)
                    achou = true;
                else
                  if (DadoAtual().CompareTo(procurado) > 0)
                    fim = true;
                else
                {
                    ondeEsta++;
                    AvancarPosicao();
                }
            }
        }

        return achou;
    }

    public void PosicionarNoPrimeiro()
    {
        atual = primeiro;
    }

    public void PosicionarNoUltimo()
    {
        atual = ultimo;
    }

    public bool Incluir(Dado novoValor)
    {
        if (novoValor == null)
            return false;

        if (!Existe(novoValor, out _))
        {

            NoLista<Dado> novoNo = new NoLista<Dado>(novoValor);

            novoNo.Anterior = atual.Anterior;

            if (novoNo.Anterior != null)
                novoNo.Anterior.Prox = novoNo;

            novoNo.Prox = atual;
            atual.Anterior = novoNo;
            atual = novoNo;
            quantosNos++;

            return true;
        }
        return false;
    }

    public void PosicionarEm(int posicaoDesejada)
    {
        if(posicaoDesejada < Tamanho)
        {
            PosicionarNoPrimeiro();

            for(int i=0; i < posicaoDesejada; i++)
            {
                AvancarPosicao();
            }
        }
    }

    public void GravarDados(string nomeArquivo)
    {
        if (nomeArquivo != null)
        {
            using (FileStream fileStream = new FileStream(nomeArquivo, FileMode.Create))
            using (BinaryWriter arq = new BinaryWriter(fileStream))
            {
                PosicionarNoPrimeiro();

                while (atual != null)
                {
                    Ligacao ligacao = new Ligacao();
                    ligacao.GravarRegistro(arq);
                    AvancarPosicao();
                }
                arq.Close();
            }
        }
    }

    public bool RemoverDado(Dado dado)
    {
        if (ExisteDado(dado))
        {
            RemoverNo(ref atual, ref anterior);
            return true;
        }

        return false;
    }

    private void RemoverNo(ref NoLista<Dado> atual, ref NoLista<Dado> anterior)
    {
        if (!EstaVazia)
        {
            if (atual == primeiro)
            {
                primeiro = primeiro.Prox;

                if (EstaVazia)
                    ultimo = null;
            }
            else
                if (atual == ultimo)
            {
                ultimo = anterior;
                ultimo.Prox = null;
            }
            else
                anterior.Prox = atual.Prox;

            quantosNos--;
        }
    }

}

