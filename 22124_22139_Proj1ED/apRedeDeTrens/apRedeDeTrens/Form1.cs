//Nome: Clara Andrade Sant'Anna Santos RA:22124
//Nome: Julia Enriquetto de Brito      RA:22139 

namespace apRedeDeTrens
{
    public partial class FrmMapeamentoCidades : Form
    {
        Arvore<Cidade> arvore; //arvore binaria

        public FrmMapeamentoCidades()
        {
            InitializeComponent();
        }

        private void FrmMapeamentoCidades_Load(object sender, EventArgs e)
        {
            if (dlgCidades.ShowDialog() == DialogResult.OK)
            {
                arvore = new Arvore<Cidade>();
                arvore.LerArquivoDeRegistros(dlgCidades.FileName);

                if(dlgCaminhos.ShowDialog() == DialogResult.OK)
                {
                    var fluxoDeLigacoes = new FileStream(dlgCaminhos.FileName, FileMode.Open);
                    var arqCaminhos = new BinaryReader(fluxoDeLigacoes);

                    for (int registro = 0; 
                        registro < (int)fluxoDeLigacoes.Length / new Ligacao().TamRegistro;
                        registro ++)
                    {
                        var ligacao = new Ligacao(dlgCaminhos.FileName);
                        ligacao.LerRegistro(arqCaminhos, registro);

                        //se a cidade existir na arvore 
                        if (arvore.Existe(new Cidade(ligacao.IdCidadeOrigem)))
                           //incluimos na lista de ligacoes
                            arvore.Atual.Info.Caminhos.InserirEmOrdem(ligacao);
                    }

                    fluxoDeLigacoes.SetLength(0);
                    arqCaminhos.Close();
                    fluxoDeLigacoes.Close();
                }

                AtualizarCombobox();

                // força o picture box da árvore
                // a ser atualizado, printando as cidades
                // e os caminhos de novo
                pbArvore.Invalidate();

                ExibirCidade(arvore.Raiz.Info);
            }
        }

        private List<string> GerarListaCidadesOrdenada()
        {
            var cidadeNomes = new List<string>();

            void GerarNomes(NoArvore<Cidade> no)
            {
                if (no == null)
                    return;

                cidadeNomes.Add(no.Info.Nome);

                GerarNomes(no.Esq);
                GerarNomes(no.Dir);
            }

            GerarNomes(arvore.Raiz);

            cidadeNomes.Sort();

            return cidadeNomes;
        }

        private void AtualizarCombobox()
        {
            foreach (var cidadeNome in GerarListaCidadesOrdenada())
            {
                cbOrigem.Items.Add(cidadeNome);
                cbDestino.Items.Add(cidadeNome);
            }
        }

        //metodo para exibir os dados da cidade 
        private void ExibirCidade(Cidade cidade)
        {
            if (cidade != null)
            {
                txtNomeCidade.Text = cidade.Nome;
                udCoordenadaX.Value = (decimal)cidade.X;
                udCoordenadaY.Value = (decimal)cidade.Y;

                dgvCaminhos.Rows.Clear();
                cidade.Caminhos.IniciarPercursoSequencial();
                while (cidade.Caminhos.PodePercorrer())
                {
                    var caminho = cidade.Caminhos.DadoAtual();
                    dgvCaminhos.Rows.Add(caminho.IdCidadeDestino, caminho.Distancia, caminho.Tempo);
                }

                cidade.Caminhos.PosicionarNoPrimeiro();
                if (cidade.Caminhos.DadoAtual() != null)
                    ExibirCaminho(cidade.Caminhos.DadoAtual());
                else
                    LimparCaminhos();
            }
            else
            {
                txtNomeCidade.Clear();
                udCoordenadaX.Value = 0;
                udCoordenadaY.Value = 0;
            }
        }

        //pegar as coordenadas das cidades 
        private void pbMapa_Click(object sender, EventArgs e)
        {
            MouseEventArgs mouse = (MouseEventArgs)e;

            decimal w = pbMapa.Width;
            decimal h = pbMapa.Height;
            decimal x = mouse.Location.X;
            decimal y = mouse.Location.Y;

            decimal xUd = x / w;
            decimal yUd = y / h;

            udCoordenadaX.Value = Math.Round(xUd, 3);
            udCoordenadaY.Value = Math.Round(yUd, 3);
        }

        private Cidade BuscarCidadePorNome(string nome)
        {
            var cidadeProcurada = new Cidade(nome);

            if (arvore.Existe(cidadeProcurada))
                return arvore.Atual.Info;

            return default(Cidade);
        }
        
        //desenhar na tela os movimentos
        private void pbMapaPaint(object sender, PaintEventArgs e)
        {
            void PrintarCidade(NoArvore<Cidade> no)
            {
                if (no == null)
                    return;

                Cidade cidade = no.Info;

                int x = (int)(cidade.X * pbMapa.Width);
                int y = (int)(cidade.Y * pbMapa.Height);

                e.Graphics.FillEllipse(Brushes.Black, new Rectangle(x, y, 6, 6));
                e.Graphics.DrawString(cidade.Nome, new Font("Arial", 10), Brushes.Black, x, y);

                cidade.Caminhos.IniciarPercursoSequencial();
                while (cidade.Caminhos.PodePercorrer())
                {
                    var caminho = cidade.Caminhos.DadoAtual();

                    var cidadeOrigem = BuscarCidadePorNome(caminho.IdCidadeOrigem);
                    var cidadeDestino = BuscarCidadePorNome(caminho.IdCidadeDestino);

                    if (cidadeOrigem != null && cidadeDestino != null)
                    {
                        int xCidadeOrigem = (int)(cidadeOrigem.X * pbMapa.Width);
                        int yCidadeOrigem = (int)(cidadeOrigem.Y * pbMapa.Height);

                        int xCidadeDestino = (int)(cidadeDestino.X * pbMapa.Width);
                        int yCidadeDestino = (int)(cidadeDestino.Y * pbMapa.Height);

                        var linha = new Pen(Brushes.Black, 1);

                        e.Graphics.DrawLine(linha, xCidadeOrigem, yCidadeOrigem, xCidadeDestino, yCidadeDestino);

                    }
                }

                PrintarCidade(no.Esq);
                PrintarCidade(no.Dir);
            }

            PrintarCidade(arvore.Raiz);
        }

        //metodo para desabilitar os botoes superiores
        private void DefinirBotoes(bool habilitado)
        {
            btnProcurar.Enabled = habilitado;
            btnNovo.Enabled = habilitado;
            btnCancelar.Enabled = habilitado;
            btnSalvar.Enabled = habilitado;
            btnExcluir.Enabled = habilitado;
            btnEditar.Enabled = habilitado;
        }

        private void tpCaminhos_Enter(object sender, EventArgs e)
        {
            DefinirBotoes(false);
            pbArvore.Invalidate();
        }

        private void tpCidades_Enter(object sender, EventArgs e)
        {
            DefinirBotoes(true);
        }

        //procurar cidade
        private void btnProcurar_Click(object sender, EventArgs e)
        {
            if (txtNomeCidade.Text == "") //se não tem nada para procurar
                MessageBox.Show("Coloque os dados antes de procurar a cidade");
            else //caso esteja preenchido 
            {
                if (arvore.Existe(new Cidade(txtNomeCidade.Text))) //podemos procurar a cidade
                    ExibirCidade(arvore.Atual.Info);
                else
                {
                    MessageBox.Show("A cidade não existe!");
                    LimparCampos();
                    LimparCaminhos();
                }
            }
        }

        //criar uma nova cidade no arquivo 
        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (txtNomeCidade.Text != "" && udCoordenadaX.Value != 0 && udCoordenadaY.Value != 0)
            {
                var cidadeAIncluir = new Cidade(txtNomeCidade.Text, (double)udCoordenadaX.Value, (double)udCoordenadaY.Value);
                arvore.IncluirNovoRegistro(cidadeAIncluir);
                MessageBox.Show("Cidade incluída com sucesso!");
                pbMapa.Invalidate();
                LimparCaminhos();
                AtualizarCombobox();
            }
            else
                MessageBox.Show("Insira os dados corretamnete para criar uma cidade!");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            LimparCaminhos();
            ExibirCidade(arvore.Raiz.Info);
        }

        //limpa todos os campos
        private void LimparCampos()
        {
            txtNomeCidade.Clear();
            udCoordenadaX.Value = 0;
            udCoordenadaY.Value = 0;
        }

        private void LimparCaminhos()
        {
            dgvCaminhos.Rows.Clear();
            cbOrigem.SelectedIndex = 0;
            cbDestino.SelectedIndex = 0;
            udTempo.Value = 0;
            udDistancia.Value = 0;
        }

        //salvar as alterações
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
            MessageBox.Show("Cidades e caminhos salvos com sucesso!");
        }

        //excluir uma cidade que deseja 
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var cidadeAExcluir = new Cidade(txtNomeCidade.Text);
            if (arvore.Existe(cidadeAExcluir))
                if (arvore.ApagarNo(cidadeAExcluir))
                {
                    MessageBox.Show("Cidade excluída!");
                    LimparCaminhos();
                    ExibirCidade(arvore.Raiz.Info);
                    AtualizarCombobox();
                    pbMapa.Invalidate();
                }
                else
                    MessageBox.Show("Ocorreu um erro ao excluir a cidade!");
            else
                MessageBox.Show("A cidade não existe!");
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close(); //para sair do formulário
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string nomeCidade = txtNomeCidade.Text.Trim();

            if (nomeCidade == "")
                MessageBox.Show("Campo 'Nome da Cidade' vazio!");
            else
            {
                Cidade cidade = new Cidade(nomeCidade);

                //se a cidade existe
                if (arvore.Existe(cidade))
                {
                   double x = (double)udCoordenadaX.Value;
                   double y = (double)udCoordenadaY.Value;

                    if (x == 0 || y == 0)
                        MessageBox.Show("Coordenadas inválidas!");
                    else
                    {
                        cidade.X = x;
                        cidade.Y = y;
                        cidade.Caminhos = arvore.Atual.Info.Caminhos;

                        if (arvore.ApagarNo(cidade))
                        {
                            arvore.InserirBalanceado(cidade);
                            MessageBox.Show("Cidade editada!");
                            pbArvore.Invalidate();
                            pbMapa.Invalidate();
                        }
                        else
                            MessageBox.Show("Não foi possível editar cidade!");
                    }
                }
                else
                    MessageBox.Show("Cidade inexistente!");
            }
         }

        private void pbArvore_Paint(object sender, PaintEventArgs e)
        {
            arvore.DesenharArvore(pbArvore.Width / 2, 0, e.Graphics);
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string nomeCidadeOrigem = cbOrigem.Text;
            string nomeCidadeDestino = cbDestino.Text;
            int distancia = (int)udDistancia.Value;
            int tempo = (int)udTempo.Value;

            if (nomeCidadeOrigem == "" || nomeCidadeDestino == "" || distancia == 0 || tempo == 0)
                MessageBox.Show("Dados inválidos para inclusão de novo caminho!");

            else
            {
                if (arvore.ExisteRegistro(new Cidade(nomeCidadeDestino)) && arvore.ExisteRegistro(new Cidade(nomeCidadeOrigem)))
                {
                    var ligacao = new Ligacao(nomeCidadeOrigem, nomeCidadeDestino, distancia, tempo, dlgCaminhos.FileName);
                    arvore.Atual.Info.Caminhos.InserirEmOrdem(ligacao);
                    MessageBox.Show("Caminho incluído com sucesso!");
                    ExibirCidade(arvore.Atual.Info);
                    pbArvore.Invalidate();
                    pbMapa.Invalidate();
                }

                else
                    MessageBox.Show("Não foi possível incluir o caminho!");
            }
        }

        private void btnExcluirCaminho_Click(object sender, EventArgs e)
        {
            string nomeCidadeOrigem = cbOrigem.Text;
            string nomeCidadeDestino = cbDestino.Text;

            if (nomeCidadeOrigem == "" || nomeCidadeDestino == "")
                MessageBox.Show("Nomes inválidos para exclusão de caminho!");

            else
            {
                if (MessageBox.Show($"Excluir caminho?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    if (arvore.ExisteRegistro(new Cidade(nomeCidadeDestino)) && arvore.ExisteRegistro(new Cidade(nomeCidadeOrigem)))
                    {
                        if (arvore.Atual.Info.Caminhos.RemoverDado(new Ligacao(nomeCidadeOrigem, nomeCidadeDestino)))
                        {
                            MessageBox.Show("Caminho excluído com sucesso!");
                            pbArvore.Invalidate();
                            pbMapa.Invalidate();
                            ExibirCidade(arvore.Atual.Info);
                        }

                        else
                            MessageBox.Show("Não foi possível excluir o caminho!");
                    }
                
                    else
                        MessageBox.Show("Caminho inválido!");
            }
        }

        private void btnEditarCaminhos_Click(object sender, EventArgs e)
        {
            string nomeCidadeOrigem = cbOrigem.Text;
            string nomeCidadeDestino = cbDestino.Text;

            if (nomeCidadeOrigem == "" || nomeCidadeDestino == "")
                MessageBox.Show("Nomes inválidos para exclusão de caminho!");

            else
            {
                int distancia = (int)udDistancia.Value;
                int tempo = (int)udTempo.Value;

                if (distancia == 0 || tempo == 0)
                    MessageBox.Show("Dados inválidos para alteração de caminho!");

                else
                if (arvore.Existe(new Cidade(nomeCidadeDestino)) && arvore.Existe(new Cidade(nomeCidadeOrigem)))
                {
                    var caminho = new Ligacao(nomeCidadeOrigem, nomeCidadeDestino, distancia, tempo, dlgCaminhos.FileName);

                    if (arvore.Atual.Info.Caminhos.Existe(caminho, out _))
                    {
                        arvore.Atual.Info.Caminhos.Atual.Info = caminho;
                        MessageBox.Show("Caminho alterado com sucesso!");
                        pbArvore.Invalidate();
                        pbMapa.Invalidate();
                        ExibirCidade(arvore.Atual.Info);
                    }

                    else
                        MessageBox.Show("Não foi possível alterar o caminho!");
                }

                else
                    MessageBox.Show("Caminho inválido");
            }
        }

        private void FrmMapeamentoCidades_FormClosing(object sender, FormClosingEventArgs e)
        {
            Salvar();
        }

        private void Salvar()
        {
            if (arvore != null && dlgCidades.FileName != "")
                arvore.GravarArquivoDeRegistros(dlgCidades.FileName);
        }

        private void dgvCaminhos_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var linhaClicada = dgvCaminhos.Rows[e.RowIndex];

            var nomeOrigemCaminho = txtNomeCidade.Text;
            var nomeDestinoCaminho = linhaClicada.Cells[0].Value.ToString();
            var distanciaCaminho = (int)linhaClicada.Cells[1].Value;
            var tempoCaminho = (int)linhaClicada.Cells[2].Value;

            var caminho = new Ligacao(nomeOrigemCaminho, nomeDestinoCaminho, distanciaCaminho, tempoCaminho, dlgCaminhos.FileName);

            ExibirCaminho(caminho);
        }

        private void ExibirCaminho(Ligacao caminho)
        {
            var listaCidades = GerarListaCidadesOrdenada();

            cbOrigem.SelectedIndex = listaCidades.IndexOf(caminho.IdCidadeOrigem);
            cbDestino.SelectedIndex = listaCidades.IndexOf(caminho.IdCidadeDestino);
            udDistancia.Value = caminho.Distancia;
            udTempo.Value = caminho.Tempo;
        }
    }
}