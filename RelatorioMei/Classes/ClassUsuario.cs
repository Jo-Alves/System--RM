using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelatorioMei
{
    class ClassUsuario
    {
        string stringConn = ClassSecurity.Dry("9UUEoK5YaRaXjDXC9eLqkg7Prh31kSiCYidze0zIx2X787RW+Zpgc9frlclEXhdHlL+EPQ/vbiEFWCzepyTvrf01bWpwKlUnEPjCx+FMNHo5c5RJ8KoPKdn7Q9gRpERZ"), _sql;

        private int id;
        private string usuario;
        private string senha;

        public int _id
        {
            get { return id; }
            set { id = value; }
        }
        public string _usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
        public string _senha
        {
            get { return senha; }
            set { senha = value; }
        }

        public bool Salvar()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "select Usuario from Usuario where Usuario = @Usuario" ;
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@Usuario", _usuario);
            try
            {
                conexao.Open();
                SqlDataReader dr = comando.ExecuteReader();
              
                if (!dr.Read())
                {
                    conexao.Close();

                    _sql = "insert into Usuario values (@usuario, @senha)";
                    conexao = new SqlConnection(stringConn);
                    comando = new SqlCommand(_sql, conexao);
                    comando.Parameters.AddWithValue("@usuario", _usuario);
                    comando.Parameters.AddWithValue("@senha", _senha);
                    comando.CommandText = _sql;
                    conexao.Open();
                    comando.ExecuteNonQuery();

                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                conexao.Close();
            }
        }

        public bool Editar()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "select Usuario from Usuario where Usuario = @Usuario";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@Usuario", _usuario);
            try
            {
                conexao.Open();
                SqlDataReader dr = comando.ExecuteReader();

                if (dr.Read())
                {
                    conexao.Close();
                    _sql = "update Usuario set  Senha = @senha where Usuario = @usuario";
                    comando = new SqlCommand(_sql, conexao);
                    comando.Parameters.AddWithValue("@usuario", _usuario);
                    comando.Parameters.AddWithValue("@senha", _senha);
                    comando.CommandText = _sql;
                    try
                    {
                        conexao.Open();
                        comando.ExecuteNonQuery();
                    }
                    catch
                    {
                        throw;
                    }
                    return true;
                }
                else
                    return false;
            }
            catch
            {
                throw;
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Excluir()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "delete from Usuario where Usuario = @usuario and Senha = @senha";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@usuario", _usuario);
            comando.Parameters.AddWithValue("@senha", _senha);
            comando.CommandText = _sql;
            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                conexao.Close();
            }
        }
        public bool Autenticar()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "Select Usuario, Senha from Usuario where Usuario = @Usuario and Senha= @Senha";
            SqlDataAdapter comando = new SqlDataAdapter(_sql, conexao);
            comando.SelectCommand.Parameters.AddWithValue("@Usuario", _usuario);
            comando.SelectCommand.Parameters.AddWithValue("@Senha", _senha);
            comando.SelectCommand.CommandText = _sql;
            try
            {
                conexao.Open();
                DataTable Tabela = new DataTable();
                comando.Fill(Tabela);
                if (Tabela.Rows.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
