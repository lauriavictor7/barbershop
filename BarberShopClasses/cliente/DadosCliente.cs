﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BarberShopClasses.conexao;
using System.Data.SqlClient;
using System.Data;


namespace BarberShopClasses.cliente
{
    public class DadosCliente : Dados, InterfaceCliente
    {
        public void AtualizarCliente(Cliente c)
        {
            try
            {
                this.abrirConexao();

                string sql = "UPDATE cliente SET nome = @nome, telefone = @telefone WHERE cpf = @cpf";

                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("@cpf", SqlDbType.VarChar);
                cmd.Parameters.Add("@nome", SqlDbType.VarChar);
                cmd.Parameters.Add("@telefone", SqlDbType.VarChar);

                cmd.Parameters["@cpf"].Value = c.Cpf;
                cmd.Parameters["@nome"].Value = c.Nome;
                cmd.Parameters["@telefone"].Value = c.Telefone;

                cmd.ExecuteNonQuery();
                cmd.Dispose();

                this.fecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception ("Erro ao atualizar! " + ex.Message);
            }
        }

        public void CadastrarCliente(Cliente c)
        {
            try
            {
                this.abrirConexao();

                string sql = "INSERT INTO cliente1 (cpf, nome, sexo, telefone, cep, bairro, rua, numero, cidade, uf)";
                       sql += "VALUES(@cpf, @nome, @sexo, @telefone, @cep, @bairro, @rua, @numero, @cidade, @uf)";

                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("@cpf", SqlDbType.VarChar);
                cmd.Parameters.Add("@nome", SqlDbType.VarChar);
                cmd.Parameters.Add("@sexo", SqlDbType.VarChar);
                cmd.Parameters.Add("@telefone", SqlDbType.VarChar);
                cmd.Parameters.Add("@cep", SqlDbType.VarChar);
                cmd.Parameters.Add("@bairro", SqlDbType.VarChar);
                cmd.Parameters.Add("@rua", SqlDbType.VarChar);
                cmd.Parameters.Add("@numero", SqlDbType.Int);
                cmd.Parameters.Add("@cidade", SqlDbType.VarChar);
                cmd.Parameters.Add("@uf", SqlDbType.VarChar);

                cmd.Parameters["@cpf"].Value = c.Cpf;
                cmd.Parameters["@nome"].Value = c.Nome;
                cmd.Parameters["@sexo"].Value = c.Sexo;
                cmd.Parameters["@telefone"].Value = c.Telefone;
                cmd.Parameters["@cep"].Value = c.Cep;
                cmd.Parameters["@bairro"].Value = c.Bairro;
                cmd.Parameters["@rua"].Value = c.Rua;
                cmd.Parameters["@numero"].Value = c.Numero;
                cmd.Parameters["@cidade"].Value = c.Cidade;
                cmd.Parameters["@uf"].Value = c.Uf;

                cmd.ExecuteNonQuery();
                cmd.Dispose();

                this.fecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar ou inserir. " + ex.Message);
            }
        }

        public List<Cliente> ListarCliente()
        {
            try
            {
                List<Cliente> retorno = new List<Cliente>();

                this.abrirConexao();
                string sql = "select cpf, nome, telefone from cliente";

                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                SqlDataReader DbReader = cmd.ExecuteReader();

                while (DbReader.Read())
                {
                    Cliente c = new Cliente();
                    c.Cpf = DbReader.GetString(DbReader.GetOrdinal("cpf"));
                    c.Nome = DbReader.GetString(DbReader.GetOrdinal("nome"));
                    c.Telefone = DbReader.GetString(DbReader.GetOrdinal("telefone"));
                    retorno.Add(c);
                }

                DbReader.Close();
                cmd.Dispose();
                this.fecharConexao();
                return retorno;
            }
            catch (Exception ex)
            {
                throw new Exception ("Erro ao listar! " + ex.Message);
            }
        }

        public void RemoverCLiente(Cliente c)
        {
            try
            {
                this.abrirConexao();

                string sql = "DELETE FROM cliente WHERE cpf = @cpf";

                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("@cpf", SqlDbType.VarChar);

                cmd.Parameters["@cpf"].Value = c.Cpf;

                cmd.ExecuteNonQuery();
                cmd.Dispose();

                this.fecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception ("Erro ao remover!" + ex.Message);
            }
        }


    }
}
