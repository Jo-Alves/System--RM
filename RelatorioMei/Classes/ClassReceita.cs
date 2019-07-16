using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelatorioMei
{
    class ClassReceita
    {
        private int id;
        private decimal RevendaMer_SNF;
        private decimal RevendaMer_NF;
        private decimal RevendaMer_Total;
        private decimal Servico_NF;
        private decimal Servico_SNF;
        private decimal Servico_Total;
        private decimal VendaInd_NF;
        private decimal VendaInd_SFN;
        private decimal VendaInd_Tortal;
        private decimal TotalReceitas;
        private string periodo;
        private string Ano;

        public int _id
        {
            get { return id; }
            set { id = value; }
        }

        public decimal _RevendaMer_SNF
        {
            get { return RevendaMer_SNF; }
            set { RevendaMer_SNF = value; }
        }

        public decimal _RevendaMer_NF
        {
            get { return RevendaMer_NF; }
            set { RevendaMer_NF = value; }
        }

        public decimal _RevendaMer_Total
        {
            get { return RevendaMer_Total; }
            set { RevendaMer_Total = value; }
        }

        public decimal _Servico_NF
        {
            get { return Servico_NF; }
            set { Servico_NF = value; }

        }

        public decimal _Servico_SNF
        {
            get { return Servico_SNF; }
            set { Servico_SNF = value; }
        }

        public decimal _Servico_Total
        {
            get { return Servico_Total; }
            set { Servico_Total = value; }
        }

        public decimal _VendaInd_NF
        {
            get { return VendaInd_NF; }
            set { VendaInd_NF = value; }
        }

        public decimal _VendaInd_SNF
        {
            get { return VendaInd_SFN; }
            set { VendaInd_SFN = value; }
        }

        public decimal _VendaInd_Tortal
        {
            get { return VendaInd_Tortal; }
            set { VendaInd_Tortal = value; }

        }

        public decimal _TotalReceitas
        {
            get { return TotalReceitas; }
            set { TotalReceitas = value; }
        }

        public string _periodo
        {
            get { return periodo; }
            set { periodo = value; }
        }

        public string _Ano
        {
            get { return Ano; }
            set { Ano = value; }
        }

        string _sql;
        public bool GerarSalvarReceita()
        {
            SqlConnection conexao = new SqlConnection(ClassSecurity.Dry("9UUEoK5YaRaXjDXC9eLqkg7Prh31kSiCYidze0zIx2X787RW+Zpgc9frlclEXhdHlL+EPQ/vbiEFWCzepyTvrf01bWpwKlUnEPjCx+FMNHo5c5RJ8KoPKdn7Q9gRpERZ"));
            _sql = "Select PeriodoApuracao, AnoApuracao from Relatorio where PeriodoApuracao = @Periodo and AnoApuracao = @Ano";
            SqlDataAdapter adapter = new SqlDataAdapter(_sql, conexao);
            adapter.SelectCommand.Parameters.AddWithValue("@Periodo", _periodo);
            adapter.SelectCommand.Parameters.AddWithValue("@Ano", _Ano);
            adapter.SelectCommand.CommandText = _sql;
            DataTable Tabela = new DataTable();
            adapter.Fill(Tabela);
            if (Tabela.Rows.Count == 0)
            {

                _sql = "Insert into Relatorio values(@RevendaNF, @RevendaSNF, @RevendaTotal, @ServicoNF, @ServicoSNF, @ServicoTotal, @VendaNF, @VendaSNF, @VendaTotal, @TotalReceitas, @Periodo, @Ano)";
                SqlCommand comando = new SqlCommand(_sql, conexao);
                comando.Parameters.AddWithValue("@RevendaNF", _RevendaMer_NF);
                comando.Parameters.AddWithValue("@RevendaSNF", _RevendaMer_SNF);
                comando.Parameters.AddWithValue("@RevendaTotal", _RevendaMer_Total);
                comando.Parameters.AddWithValue("@ServicoNF", _Servico_NF);
                comando.Parameters.AddWithValue("@ServicoSNF", _Servico_SNF);
                comando.Parameters.AddWithValue("@ServicoTotal", _Servico_Total);
                comando.Parameters.AddWithValue("@VendaNF", _VendaInd_NF);
                comando.Parameters.AddWithValue("@VendaSNF", _VendaInd_SNF);
                comando.Parameters.AddWithValue("@VendaTotal", _VendaInd_Tortal);
                comando.Parameters.AddWithValue("@TotalReceitas", _TotalReceitas);
                comando.Parameters.AddWithValue("@Periodo", _periodo);
                comando.Parameters.AddWithValue("@Ano", _Ano);
                comando.CommandText = _sql;
                try
                {
                    conexao.Open();
                    comando.ExecuteNonQuery();
                    return true;
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
            else
            {
                return false;
            }
        }

        public void AlterarRelatorio()
        {
            SqlConnection conexao = new SqlConnection(ClassSecurity.Dry("9UUEoK5YaRaXjDXC9eLqkg7Prh31kSiCYidze0zIx2X787RW + Zpgc9frlclEXhdHlL + EPQ / vbiEFWCzepyTvrR8wZHttyJURXa30oWvHiR5ucknSbCkbY / Y2hBkj8300"));
            _sql = "update Relatorio set RevendaMer_NF = @RevendaNF, RevendaMer_SNF = @RevendaSNF, RevendaMer_Total = @RevendaTotal, Servico_NF = @ServicoNF, Servico_SNF = @ServicoSNF, Servico_Total = @ServicoTotal, VendaInd_NF = @VendaNF, VendaInd_SNF = @VendaSNF, VendaInd_Total = @VendaTotal, TotalReceitas = @TotalReceitas where PeriodoApuracao = @Periodo and AnoApuracao = @Ano ";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@RevendaNF", _RevendaMer_NF);
            comando.Parameters.AddWithValue("@RevendaSNF", _RevendaMer_SNF);
            comando.Parameters.AddWithValue("@RevendaTotal", _RevendaMer_Total);
            comando.Parameters.AddWithValue("@ServicoNF", _Servico_NF);
            comando.Parameters.AddWithValue("@ServicoSNF", _Servico_SNF);
            comando.Parameters.AddWithValue("@ServicoTotal", _Servico_Total);
            comando.Parameters.AddWithValue("@VendaNF", _VendaInd_NF);
            comando.Parameters.AddWithValue("@VendaSNF", _VendaInd_SNF);
            comando.Parameters.AddWithValue("@VendaTotal", _VendaInd_Tortal);
            comando.Parameters.AddWithValue("@TotalReceitas", _TotalReceitas);
            comando.Parameters.AddWithValue("@Periodo", _periodo);
            comando.Parameters.AddWithValue("@Ano", _Ano);
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

        public void BuscarReceita()
        {
            SqlConnection conexao = new SqlConnection(ClassSecurity.Dry("9UUEoK5YaRaXjDXC9eLqkg7Prh31kSiCYidze0zIx2X787RW+Zpgc9frlclEXhdHlL+EPQ/vbiEFWCzepyTvrf01bWpwKlUnEPjCx+FMNHo5c5RJ8KoPKdn7Q9gRpERZ"));
            _sql = "Select Id_Relatorio from Relatorio where PeriodoApuracao = @Periodo and AnoApuracao = @Ano";
            SqlDataAdapter adapter = new SqlDataAdapter(_sql, conexao);
            adapter.SelectCommand.Parameters.AddWithValue("@Periodo", _periodo);
            adapter.SelectCommand.Parameters.AddWithValue("@Ano", _Ano);
            adapter.SelectCommand.CommandText = _sql;
            try
            {
                DataTable Tabela = new DataTable();
                adapter.Fill(Tabela);
                if (Tabela.Rows.Count > 0)
                {
                    _id = int.Parse(Tabela.Rows[0]["Id_Relatorio"].ToString());
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
