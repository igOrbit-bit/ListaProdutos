using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CadastroProduto_TP04
{
    public partial class Form1 : Form
    {
        List<Produto> produtos = new List<Produto>();

        private bool renderizado = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AtualizarDataGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = produtos;
        }


        private void Renderizar()
        {
            Label lb_Quantidade = new Label
            {
                Name = "lb_Quantidade",
                Text = "Quantidade",
                Width = 65,
                Location = new Point(44, 140),

            };

            this.Controls.Add(lb_Quantidade);


            TextBox txtQuantidade = new TextBox
            {

                Name = "txtQuantidade",
                Location = new Point(109, 140),

            };

            this.Controls.Add(txtQuantidade);




            Label lb_descrição = new Label
            {
                Name = "lb_descricao",
                Text = "Descrição",
                Width = 65,
                Location = new Point(44, 170),

            };

            this.Controls.Add(lb_descrição);


            TextBox txtDescricao = new TextBox
            {

                Name = "txtDescricao",
                Location = new Point(109, 170),

            };

            this.Controls.Add(txtDescricao);

            Button btSalvar = new Button
            {
                Name = "btSalvar",
                Text = "Salvar",
                Size = new Size(108, 62),
                Location = new Point(265, 150),
            };

            this.Controls.Add(btSalvar);

           

            btSalvar.Click += (s, e) =>
            {
                
                string nome = txtNome.Text;
                string preco = txtPreco.Text;
                string quantidade = txtQuantidade.Text;
                string descricao = txtDescricao.Text;


                if (!string.IsNullOrEmpty(nome) || !string.IsNullOrEmpty(preco)|| !string.IsNullOrEmpty(quantidade) || !string.IsNullOrEmpty(descricao))
                {
                    produtos.Add(new Produto(nome,preco,quantidade,descricao));
                    AtualizarDataGrid();

                    txtNome.Clear();
                    txtPreco.Clear();   
                    txtQuantidade.Clear();
                    txtDescricao.Clear();


                }
                else
                {
                    MessageBox.Show("Preencha os campos!", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }



            };

        }


        private void btCriar_Click(object sender, EventArgs e)
        {

            string nome = txtNome.Text;
            string preco = txtPreco.Text;



            if (!string.IsNullOrEmpty(nome) || !string.IsNullOrEmpty(preco))
            {

                MessageBox.Show($"Produto Criado: {nome}, {preco}");
                if (!renderizado)
                {
                    this.Renderizar();
                }


            }
            else
            {
                MessageBox.Show("Preencha os campos!", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


           

        }


    }
}
