using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace SqlSeverAula
{
    public partial class Form1 : Form
    {
        MySqlConnection conn;

        ConnectionDB connection = new ConnectionDB();

        public void LimpaFormulario()
        {
            txtDescProduto.Text = null;
            txtNomeProduto.Text = null;
            txtQtdProduto.Text = null;
            txtIdProduto.Text = null;
        }

        public Form1()
        {
            InitializeComponent();

            conn = connection.Connection(conn);

            AtualizaTabela();
        }

        public void AtualizaTabela()
        {
            dgProdutos.DataSource = connection.AtualizaDados(conn);
            dgProdutos.DataMember = "Produtos";
        }


        private void btnConsulta_Click(object sender, EventArgs e)
        {
            AtualizaTabela();

            LimpaFormulario();
        }               

        private void dgProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

            string IdProduto = dgProdutos.Rows[e.RowIndex].Cells[0].Value.ToString();
            string NomeProduto = dgProdutos.Rows[e.RowIndex].Cells[1].Value.ToString();
            string DescProduto = dgProdutos.Rows[e.RowIndex].Cells[2].Value.ToString();
            string QtdProduto = dgProdutos.Rows[e.RowIndex].Cells[3].Value.ToString();

            txtNomeProduto.Text = NomeProduto;
            txtIdProduto.Text = IdProduto;
            txtQtdProduto.Text = QtdProduto;
            txtDescProduto.Text = DescProduto;

            btnInserir.Enabled = false;
            btnListar.Enabled = false;
            btnEditar.Enabled = true;
            btnDeletar.Enabled = true;
            
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {            
            Produto produto = new Produto { NomeProduto = txtNomeProduto.Text, DescProduto = txtDescProduto.Text, QtdProduto = Int32.Parse(txtQtdProduto.Text) };
           
            connection.InsereDados(produto, conn);

            MessageBox.Show("Dados inseridos com sucesso!");

            LimpaFormulario();

            AtualizaTabela();
        }

        private void btnDeletarTudo_Click(object sender, EventArgs e)
        {
            connection.DeletarDb(conn);

            MessageBox.Show("Todo o banco de dados foi deletado.");

            AtualizaTabela();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto {IdProduto = Int32.Parse(txtIdProduto.Text) };

            connection.DeletarProduto(conn, produto);

            btnInserir.Enabled = true;
            btnListar.Enabled = true;
            btnEditar.Enabled = false;
            btnDeletar.Enabled = false;

            MessageBox.Show("O produto " + txtNomeProduto.Text + " foi deletado com sucesso.");

            AtualizaTabela();
            LimpaFormulario();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto { NomeProduto = txtNomeProduto.Text, DescProduto = txtDescProduto.Text, QtdProduto = Int32.Parse(txtQtdProduto.Text), IdProduto = Int32.Parse(txtIdProduto.Text) };

            connection.AtualizaProduto(conn, produto);

            btnInserir.Enabled = true;
            btnListar.Enabled = true;
            btnEditar.Enabled = false;
            btnDeletar.Enabled = false;

            AtualizaTabela();
            LimpaFormulario();
        }
    }
}
