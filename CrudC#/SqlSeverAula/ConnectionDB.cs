using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SqlSeverAula
{
    public class ConnectionDB
    {
        public MySqlConnection Connection(MySqlConnection conn)
        {
            try
            {
                string connectionString = "SERVER=localhost;" +
                            "DATABASE=testeproduto;" +
                            "UID=root;" +
                            "PASSWORD=1234;";

                conn = new MySqlConnection(connectionString);

                conn.Open();                
                conn.Close();

                return conn;
            }
            catch (MySqlException error)
            {
                return conn;
            }
        }


        public DataSet AtualizaDados(MySqlConnection conn)
        {
            DataSet bdList = new DataSet();

            try
            {
                conn.Open();
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT * FROM tblproduto", conn);

                dataAdapter.Fill(bdList, "Produtos");

                conn.Close();

                return bdList;
            }
            catch (Exception error)
            {                
                return bdList;
            }
        }

        public void DeletarDb(MySqlConnection conn)
        {
            try
            {
                conn.Open();

                MySqlCommand command = new MySqlCommand("DELETE FROM tblproduto", conn);

                command.ExecuteNonQuery();

                conn.Close();
            }
            catch (Exception error)
            {
                throw;
            }
        }

        public void DeletarProduto(MySqlConnection conn, Produto produto)
        {
            try
            {
                conn.Open();

                MySqlCommand command = new MySqlCommand("DELETE FROM tblproduto WHERE IdProduto = "+ produto.IdProduto +"", conn);

                command.ExecuteNonQuery();

                conn.Close();
            }
            catch (Exception error)
            {
                throw;
            }
        }


        public void InsereDados(Produto produto, MySqlConnection conn)
        {
            try
            {                
                conn.Open();

                MySqlCommand command = new MySqlCommand("INSERT INTO tblproduto (NomeProduto, desc_produto, qtd_produto) values('" + produto.NomeProduto + "', '" + produto.DescProduto + "', '" + produto.QtdProduto + "' )", conn);

                command.ExecuteNonQuery();

                conn.Close();                
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void AtualizaProduto(MySqlConnection conn, Produto produto)
        {
            try
            {                
                conn.Open();

                MySqlCommand command = new MySqlCommand("UPDATE tblproduto SET NomeProduto = '" + produto.NomeProduto + "' , desc_produto = '" + produto.DescProduto + "' , qtd_produto = '" + produto.QtdProduto + "' WHERE IdProduto = " + produto.IdProduto +"", conn);

                command.ExecuteNonQuery();

                conn.Close();
            }
            catch (Exception error)
            {
                throw;
            }

        }

    }
}
