using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA
{
    public partial class ListaCarro : Form
    {
        string nomeantigo = string.Empty;
        List<Carro> carros = new List<Carro>();
        public ListaCarro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtNome.Text = "";
            txtMarca.Text = "";
            txtAno.Text = "";
            txtValor.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Carro carro = new Carro()
           {
               Nome = txtNome.Text,
               Marca = txtMarca.Text,
               AnoFabricacao = Convert.ToInt16(txtAno.Text),
               Valor = Convert.ToDecimal(txtValor.Text)
           };
                if (nomeantigo == "")
                {
                    carros.Add(carro);
                    AdicionarCarroATabela(carro);
                }
                else
                {
                    /*
                    for (int i = 0; i < carros.Count(); i++)
                    {
                        Carro carroaux = carros[i];
                        if (carroaux.Nome == nomeantigo)
                        {
                            carros[i] = carro;
                        }
                    } //Mesma coisa que o trecho de codigo abaixo
                     */
                    
                    int linha = carros.FindIndex(x => x.Nome == nomeantigo);
                    carros[linha] = carro;
                    EditarCarroNaTabela(carro, linha);
                    MessageBox.Show("Alterado com sucesso");
                    nomeantigo = string.Empty;
                }
                LimparCampos();
                tabControl1.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EditarCarroNaTabela(Carro carro, int linha)
        {
            dataGridView1.Rows[linha].Cells[0].Value = carro.Nome;
            dataGridView1.Rows[linha].Cells[1].Value = carro.Marca;
            dataGridView1.Rows[linha].Cells[2].Value = carro.AnoFabricacao;
            dataGridView1.Rows[linha].Cells[3].Value = carro.Valor;
        }

        private void AdicionarCarroATabela(Carro carro)
        {
            dataGridView1.Rows.Add(new Object[]{
                carro.Nome, carro.Marca, carro.AnoFabricacao, carro.Valor
            });
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Cadastre um carro");
                tabControl1.SelectedIndex = 1;
                return;
            }
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Selecione uma linha");
                return;
            }

            int LinhaSelecionada = dataGridView1.CurrentRow.Index;
            string nome = dataGridView1.Rows[LinhaSelecionada].Cells[0].Value.ToString();
            for (int i = 0; i < carros.Count(); i++)
            {
                Carro carro = carros[i];
                if (carro.Nome == nome)
                {
                    carros.RemoveAt(i);
                }
            }
            dataGridView1.Rows.RemoveAt(LinhaSelecionada);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int LinhaSelecionada = dataGridView1.CurrentRow.Index;
            string nome = dataGridView1.Rows[LinhaSelecionada].Cells[0].Value.ToString();
            foreach(Carro carro in carros)
            {
                if (carro.Nome == nome )
                {
                    txtNome.Text = carro.Nome;
                    txtMarca.Text = carro.Marca;
                    txtAno.Text = Convert.ToString(carro.AnoFabricacao);
                    txtValor.Text = Convert.ToString(carro.Valor);
                    nomeantigo = carro.Nome;
                    tabControl1.SelectedIndex = 1;
                    break;
                }
            }
        }
    }
}
