using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using DashboardLogistico.Core;
using System.IO;

namespace DashboardLogistico.Data
{
    public class DBConnection
    {
        internal SQLiteConnection sqliteConnection;

        public DBConnection(string caminho)
        {

            if (!File.Exists(caminho))
            {
                CriarBancoSQLite(caminho);
                sqliteConnection = new SQLiteConnection($"Data Source={caminho}; Version=3;");
                CriarTabelaSQlite();
            }
            else
            {
                sqliteConnection = new SQLiteConnection($"Data Source={caminho}; Version=3;");
            }
            
        }

        public void CloseConnection()
        {
            sqliteConnection.Close();
        }
        internal void CriarBancoSQLite(string caminho)
        {
            try
            {
                SQLiteConnection.CreateFile(caminho);
            }
            catch
            {
                throw;
            }
        }
        internal void CriarTabelaSQlite()
        {
            try
            {
                sqliteConnection.Open();

                using (var cmd = sqliteConnection.CreateCommand())
                {
                    cmd.CommandText = @"CREATE TABLE IF NOT EXISTS Notas (
                                          CodCliente VARCHAR(45) NULL,
                                          Cliente VARCHAR(200) NULL,
                                          Endereco VARCHAR(200) NULL,
                                          Bairro VARCHAR(200) NULL,
                                          Cidade VARCHAR(200) NULL,
                                          Placa VARCHAR(200) NULL,
                                          Motorista VARCHAR(200) NULL,
                                          Cooperativa VARCHAR(200) NULL,
                                          InicioEntrega DATETIME NULL,
                                          FimEntrega DATETIME NULL,
                                          NF VARCHAR(200) NULL,
                                          SeqProgramada INT NULL,
                                          SeqReal INT NULL,
                                          Identificador VARCHAR(200) NULL,
                                          CodAnomalia VARCHAR(200) NULL,
                                          Anomalia VARCHAR(200) NULL,
                                          PesoBruto DECIMAL(20,2) NULL,
                                          Longitude VARCHAR(200) NULL,
                                          DataAnomalia DATETIME NULL,
                                          InicioViagem DATETIME NULL,
                                          Unidade VARCHAR(200) NULL,
                                          FimViagem DATETIME NULL,
                                          Baixa VARCHAR(200) NULL,
                                          MetrosEntrega DECIMAL(10,2) NULL,
                                          EntregaPrevistas DECIMAL(10,2) NULL,
                                          EntregasRealizadas DECIMAL(10,2) NULL,
                                          FimDescarregamento DATETIME NULL,
                                          Valor DECIMAL(20,2) NULL,
                                          Latitude DECIMAL(20,5) NULL,
                                          SeriePernoite VARCHAR(200) NULL,
                                          StatusViagem VARCHAR(200) NULL,
                                          Entrega VARCHAR(200) NULL,
                                          Linha BLOB NULL
                                          );";
                    cmd.ExecuteNonQuery();


                    cmd.CommandText = @"CREATE TABLE IF NOT EXISTS Unidades (
                                        Unidade VARCHAR(200) NULL,
                                        HoraLargada VARCHAR(100) NOT NULL
                                        );";

                    cmd.ExecuteNonQuery();

                    cmd.CommandText = @"INSERT INTO Unidades (Unidade, HoraLargada) VALUES ('Exemplo', '10:00');";

                    cmd.ExecuteNonQuery();

                    cmd.CommandText = @"CREATE TABLE IF NOT EXISTS Indicadores (
                                        Unidade VARCHAR(200) NULL,
                                        Regional VARCHAR(200) NULL,
                                        Identificador VARCHAR(200) NULL,
                                        Placa VARCHAR(200) NULL,
                                        Cooperativa VARCHAR(200) NULL,
                                        Data DATETIME NULL,
                                        Aderencia DECIMAL(10,2) NULL,
                                        Homologacao DECIMAL(10,2) NULL,
                                        Largada INT NULL,
                                        Linha BLOB NULL
                                        );";

                    cmd.ExecuteNonQuery();
                }

                sqliteConnection.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        internal void AddNota(NotaFiscal nota)
        {
            using (var cmd = sqliteConnection.CreateCommand())
            {
                cmd.CommandText = @"INSERT INTO Notas (CodCLiente, Cliente, Endereco, Bairro, Cidade, Placa, Motorista, Cooperativa, InicioEntrega, FimEntrega, NF, SeqProgramada, SeqReal,
	                                    Identificador, CodAnomalia, Anomalia, PesoBruto, Longitude, DataAnomalia, InicioViagem, Unidade, FimViagem, Baixa, MetrosEntrega, EntregaPrevistas, EntregasRealizadas,
                                        FimDescarregamento, Valor, Latitude, SeriePernoite, StatusViagem, Entrega, Linha) values (@CodCLiente, @Cliente, @Endereco, @Bairro, @Cidade, @Placa, @Motorista, @Cooperativa, @InicioEntrega, @FimEntrega, @NF, @SeqProgramada, @SeqReal,
	                                    @Identificador, @CodAnomalia, @Anomalia, @PesoBruto, @Longitude, @DataAnomalia, @InicioViagem, @Unidade, @FimViagem, @Baixa, @MetrosEntrega, @EntregaPrevistas, @EntregasRealizadas,
                                        @FimDescarregamento, @Valor, @Latitude, @SeriePernoite, @StatusViagem, @Entrega, @Linha); ";

                cmd.Parameters.AddWithValue("@CodCLiente", nota.CodCliente);
                cmd.Parameters.AddWithValue("@Cliente", nota.Cliente);
                cmd.Parameters.AddWithValue("@Endereco", nota.Endereco);
                cmd.Parameters.AddWithValue("@Bairro", nota.Bairro);
                cmd.Parameters.AddWithValue("@Cidade", nota.Cidade);
                cmd.Parameters.AddWithValue("@Placa", nota.Placa);
                cmd.Parameters.AddWithValue("@Motorista", nota.Motorista);
                cmd.Parameters.AddWithValue("@Cooperativa", nota.Cooperativa);
                cmd.Parameters.AddWithValue("@InicioEntrega", nota.InicioEntrega);
                cmd.Parameters.AddWithValue("@FimEntrega", nota.FimEntrega);
                cmd.Parameters.AddWithValue("@NF", nota.NF);
                cmd.Parameters.AddWithValue("@SeqProgramada", nota.SeqProgramada);
                cmd.Parameters.AddWithValue("@SeqReal", nota.SeqReal);
                cmd.Parameters.AddWithValue("@Identificador", nota.Identificador);
                cmd.Parameters.AddWithValue("@CodAnomalia", nota.CodAnomalia);
                cmd.Parameters.AddWithValue("@Anomalia", nota.Anomalia);
                cmd.Parameters.AddWithValue("@PesoBruto", nota.PesoBruto);
                cmd.Parameters.AddWithValue("@Longitude", nota.Longitude);
                cmd.Parameters.AddWithValue("@DataAnomalia", nota.DataAnomalia);
                cmd.Parameters.AddWithValue("@InicioViagem", nota.InicioViagem);
                cmd.Parameters.AddWithValue("@Unidade", nota.Unidade);
                cmd.Parameters.AddWithValue("@FimViagem", nota.FimViagem);
                cmd.Parameters.AddWithValue("@Baixa", nota.Baixa);
                cmd.Parameters.AddWithValue("@MetrosEntrega", nota.MetrosEntrega);
                cmd.Parameters.AddWithValue("@EntregaPrevistas", nota.EntregasPrevistas);
                cmd.Parameters.AddWithValue("@EntregasRealizadas", nota.EntregasRealizadas);
                cmd.Parameters.AddWithValue("@FimDescarregamento", nota.FimDescarregamento);
                cmd.Parameters.AddWithValue("@Valor", nota.Valor);
                cmd.Parameters.AddWithValue("@Latitude", nota.Latitude);
                cmd.Parameters.AddWithValue("@SeriePernoite", nota.SeriePernoite);
                cmd.Parameters.AddWithValue("@StatusViagem", nota.StatusViagem);
                cmd.Parameters.AddWithValue("@Entrega", nota.Entrega);
                cmd.Parameters.AddWithValue("@Linha", nota.Linha);


                cmd.ExecuteNonQuery();

            }

        }

        internal void AddIndicador(Indicador indicador)
        {
            using (var cmd = sqliteConnection.CreateCommand())
            {
                cmd.CommandText = @"INSERT INTO Indicadores (Regional, Unidade, Data, Identificador, Placa, Cooperativa, Aderencia, Homologacao,
	                                    Largada, Linha) values (@Regional, @Unidade, @Data, @Identificador, @Placa, @Cooperativa, @Aderencia,
	                                    @Homologacao, @Largada, @Linha); ";

                cmd.Parameters.AddWithValue("@Regional", indicador.Regional);
                cmd.Parameters.AddWithValue("@Unidade", indicador.Unidade);
                cmd.Parameters.AddWithValue("@Data", indicador.Data);
                cmd.Parameters.AddWithValue("@Identificador", indicador.Identificador);
                cmd.Parameters.AddWithValue("@Placa", indicador.Placa);
                cmd.Parameters.AddWithValue("@Cooperativa", indicador.Cooperativa);
                cmd.Parameters.AddWithValue("@Aderencia", indicador.Aderencia);
                cmd.Parameters.AddWithValue("@Homologacao", indicador.Homologacao);
                cmd.Parameters.AddWithValue("@Largada", indicador.Largada);
                cmd.Parameters.AddWithValue("@Linha", indicador.Linha);


                cmd.ExecuteNonQuery();

            }

        }
        internal async Task<IEnumerable<NotaFiscal>> GetNotasAsync(Filtros filtros)
        {
            List<NotaFiscal> notaFiscals = new List<NotaFiscal>();

            sqliteConnection.Open();
            using (var cmd = sqliteConnection.CreateCommand())
            {
                string where = QueryGenerator.GenerateWhere(filtros);

                string command = @"SELECT * FROM Notas " + where;
                cmd.CommandText = command;
                var rdr = await cmd.ExecuteReaderAsync();

                while (await rdr.ReadAsync())
                {
                    NotaFiscal nota = new NotaFiscal();

                    if (rdr["CodCliente"] != DBNull.Value) nota.CodCliente = Convert.ToString(rdr["CodCliente"]);
                    if (rdr["Cliente"] != DBNull.Value) nota.Cliente = Convert.ToString(rdr["Cliente"]);
                    if (rdr["Identificador"] != DBNull.Value) nota.Identificador = Convert.ToString(rdr["Identificador"]);
                    if (rdr["Endereco"] != DBNull.Value) nota.Endereco = Convert.ToString(rdr["Endereco"]);
                    if (rdr["Bairro"] != DBNull.Value) nota.Bairro = Convert.ToString(rdr["Bairro"]);
                    if (rdr["Cidade"] != DBNull.Value) nota.Cidade = Convert.ToString(rdr["Cidade"]);
                    if (rdr["Placa"] != DBNull.Value) nota.Placa = Convert.ToString(rdr["Placa"]);
                    if (rdr["Motorista"] != DBNull.Value) nota.Motorista = Convert.ToString(rdr["Motorista"]);
                    if (rdr["Cooperativa"] != DBNull.Value) nota.Cooperativa = Convert.ToString(rdr["Cooperativa"]);
                    if (rdr["InicioEntrega"] != DBNull.Value) nota.InicioEntrega = Convert.ToDateTime(rdr["InicioEntrega"]);
                    if (rdr["FimEntrega"] != DBNull.Value) nota.FimEntrega = Convert.ToDateTime(rdr["FimEntrega"]);
                    if (rdr["NF"] != DBNull.Value) nota.NF = Convert.ToString(rdr["NF"]);
                    if (rdr["SeqProgramada"] != DBNull.Value) nota.SeqProgramada = Convert.ToInt64(rdr["SeqProgramada"]);
                    if (rdr["SeqReal"] != DBNull.Value) nota.SeqReal = Convert.ToInt64(rdr["SeqReal"]);
                    if (rdr["Anomalia"] != DBNull.Value) nota.Anomalia = Convert.ToString(rdr["Anomalia"]);
                    if (rdr["PesoBruto"] != DBNull.Value) nota.PesoBruto = Convert.ToDouble(rdr["PesoBruto"]);
                    if (rdr["Longitude"] != DBNull.Value) nota.Longitude = Convert.ToDouble(rdr["Longitude"]);
                    if (rdr["DataAnomalia"] != DBNull.Value) nota.DataAnomalia = Convert.ToDateTime(rdr["DataAnomalia"]);
                    if (rdr["InicioViagem"] != DBNull.Value) nota.InicioViagem = Convert.ToDateTime(rdr["InicioViagem"]);
                    if (rdr["Unidade"] != DBNull.Value) nota.Unidade = Convert.ToString(rdr["Unidade"]);
                    if (rdr["FimViagem"] != DBNull.Value) nota.FimViagem = Convert.ToDateTime(rdr["FimViagem"]);
                    if (rdr["Baixa"] != DBNull.Value) nota.Baixa = Convert.ToString(rdr["Baixa"]);
                    if (rdr["MetrosEntrega"] != DBNull.Value) nota.MetrosEntrega = Convert.ToDouble(rdr["MetrosEntrega"]);
                    if (rdr["EntregaPrevistas"] != DBNull.Value) nota.EntregasPrevistas = Convert.ToDouble(rdr["EntregaPrevistas"]);
                    if (rdr["EntregasRealizadas"] != DBNull.Value) nota.EntregasRealizadas = Convert.ToDouble(rdr["EntregasRealizadas"]);
                    if (rdr["FimDescarregamento"] != DBNull.Value) nota.FimDescarregamento = Convert.ToDateTime(rdr["FimDescarregamento"]);
                    if (rdr["Valor"] != DBNull.Value) nota.Valor = Convert.ToDouble(rdr["Valor"]);
                    if (rdr["Latitude"] != DBNull.Value) nota.Latitude = Convert.ToDouble(rdr["Latitude"]);
                    if (rdr["SeriePernoite"] != DBNull.Value) nota.SeriePernoite = Convert.ToString(rdr["SeriePernoite"]);
                    if (rdr["StatusViagem"] != DBNull.Value) nota.StatusViagem = Convert.ToString(rdr["StatusViagem"]);
                    if (rdr["Entrega"] != DBNull.Value) nota.Entrega = Convert.ToString(rdr["Entrega"]);
                    if (rdr["Linha"] != DBNull.Value) nota.Linha = Convert.ToString(rdr["Linha"]);

                    notaFiscals.Add(nota);

                }


            }
            sqliteConnection.Close();
            return notaFiscals;
        }
        internal async Task<bool> VerifyIfNotasExist(IEnumerable<string> notas)
        {
            await sqliteConnection.OpenAsync();

            bool result = false;

            using (var cmd = sqliteConnection.CreateCommand())
            {

                cmd.CommandText = $@"SELECT COUNT(*) FROM Notas WHERE Entrega in ('${string.Join("','", notas)}')";

                var rdr = await cmd.ExecuteReaderAsync();

                await rdr.ReadAsync();

                long resultado = Convert.ToInt64(rdr[0]);
                if (resultado > 0) result = true;

                

            }

            sqliteConnection.Close();

            return result;
        }

        internal async Task<bool> VerifyIfIndicadorExist(IEnumerable<string> Indicadores)
        {
            await sqliteConnection.OpenAsync();

            bool result = false;

            using (var cmd = sqliteConnection.CreateCommand())
            {
                cmd.CommandText = $@"SELECT COUNT(*) FROM Indicadores WHERE Identificador in ('${string.Join("','", Indicadores)}')";

                var rdr = await cmd.ExecuteReaderAsync();

                await rdr.ReadAsync();

                long resultado = Convert.ToInt64(rdr[0]);
                if (resultado > 0) result = true;



            }

            sqliteConnection.Close();

            return result;
        }

        internal async Task<Dictionary<string, List<object>>> ExecuteQuery(string query)
        {
            Dictionary<string, List<object>> data = new Dictionary<string, List<object>>();

            await sqliteConnection.OpenAsync();
            using (var cmd = sqliteConnection.CreateCommand())
            {
                cmd.CommandText = query;

                var rdr = await cmd.ExecuteReaderAsync();

                while (await rdr.ReadAsync())
                {
                    for (int i = 0; i < rdr.FieldCount; i++)
                    {
                        if (!data.ContainsKey(rdr.GetName(i)))
                        {
                            data.Add(rdr.GetName(i), new List<object>());
                        }

                        data[rdr.GetName(i)].Add(rdr[i]);
                    }
                }
            }

            sqliteConnection.Close();

            return data;
        }
        internal async Task<List<Jornada>> GetJornadaAsync(string query)
        {
            List<Jornada> jornadas = new List<Jornada>();

            await sqliteConnection.OpenAsync();

            using (var cmd = sqliteConnection.CreateCommand())
            {
                cmd.CommandText = query;

                var rdr = await cmd.ExecuteReaderAsync();

                while (await rdr.ReadAsync())
                {
                    Jornada jornada = new Jornada();
                    jornada.DiaViagem = rdr["dataInicio"].ToString();
                    jornada.Placa = rdr["Placa"].ToString();
                    jornada.TempoViagem = Convert.ToDouble(rdr["Jornada"]);

                    jornadas.Add(jornada);
                }
            }

            sqliteConnection.Close();

            return jornadas;

        }
        internal async Task<List<Descarga>> GetDescargaAsync(string query)
        {
            List<Descarga> jornadas = new List<Descarga>();

            await sqliteConnection.OpenAsync();

            using (var cmd = sqliteConnection.CreateCommand())
            {
                cmd.CommandText = query;

                var rdr = await cmd.ExecuteReaderAsync();

                while (await rdr.ReadAsync())
                {
                    Descarga descarga = new Descarga();
                    descarga.DiaViagem = rdr["dataInicio"].ToString();
                    descarga.Cliente = rdr["Cliente"].ToString();
                    descarga.CodCliente = rdr["CodCliente"].ToString();
                    descarga.TempoEntrega = Convert.ToDouble(rdr["Tempo"]);

                    jornadas.Add(descarga);
                }
            }

            sqliteConnection.Close();

            return jornadas;
        }
        internal async Task<bool> AddUnidadeAsync(string unidade, string horaLargada)
        {
            await sqliteConnection.OpenAsync();

            using (var cmd = sqliteConnection.CreateCommand())
            {
                cmd.CommandText = @"INSERT INTO Unidades (Unidade, HoraLargada) VALUES (@Unidade, @HoraLargada);";

                cmd.Parameters.AddWithValue("@Unidade", unidade);
                cmd.Parameters.AddWithValue("@HoraLargada", horaLargada);


                cmd.ExecuteNonQuery();

            }

            sqliteConnection.Close();

            return true;

        }
        internal async Task<bool> UpdateUnidadeAsync(string unidade, string horaLargada)
        {
            await sqliteConnection.OpenAsync();

            using (var cmd = sqliteConnection.CreateCommand())
            {
                cmd.CommandText = @"UPDATE Unidades SET horaLargada = @HoraLargada WHERE Unidade = @Unidade;";

                cmd.Parameters.AddWithValue("@Unidade", unidade);
                cmd.Parameters.AddWithValue("@HoraLargada", horaLargada);


                cmd.ExecuteNonQuery();

            }

            sqliteConnection.Close();

            return true;
        }
        internal async Task<IEnumerable<string>> GetFiterAsync(string query)
        {
            List<string> data = new List<string>();

            await sqliteConnection.OpenAsync();
            using (var cmd = sqliteConnection.CreateCommand())
            {
                cmd.CommandText = query;

                var rdr = await cmd.ExecuteReaderAsync();

                while (await rdr.ReadAsync())
                {
                    if(rdr[0] != DBNull.Value)
                    {
                        data.Add(rdr[0].ToString());
                    }
                }
            }

            sqliteConnection.Close();

            return data;
        }
        internal async Task<List<DadoIndicador>> GetDadoIndicaodAsync(string query)
        {
            List<DadoIndicador> indicadores = new List<DadoIndicador>();

            await sqliteConnection.OpenAsync();

            using (var cmd = sqliteConnection.CreateCommand())
            {
                cmd.CommandText = query;

                var rdr = await cmd.ExecuteReaderAsync();

                while (await rdr.ReadAsync())
                {
                    DadoIndicador indicador = new DadoIndicador();
                    indicador.Agrupamento = rdr["Agrupamento"].ToString();
                    indicador.Aderencia = Math.Round(Convert.ToDouble(rdr["Aderencia"]),2);
                    indicador.Homologacao = Math.Round(Convert.ToDouble(rdr["Homologacao"]), 2);
                    indicador.Largada = Math.Round(Convert.ToDouble(rdr["Largada"]), 2);
                    indicador.Transportes = Convert.ToInt64(rdr["Transportes"]);

                    indicadores.Add(indicador);
                }
            }

            sqliteConnection.Close();

            return indicadores;
        }
        internal async Task<List<DTOChart>> GetIndicadordAsync(string query)
        {
            List<DTOChart> indicadores = new List<DTOChart>();

            await sqliteConnection.OpenAsync();

            using (var cmd = sqliteConnection.CreateCommand())
            {
                cmd.CommandText = query;

                var rdr = await cmd.ExecuteReaderAsync();

                while (await rdr.ReadAsync())
                {
                    DTOChart indicador = new DTOChart();
                    indicador.Agrupamento = rdr["Agrupamento"].ToString();
                    indicador.MesAno = rdr["dataInicio"].ToString();
                    indicador.Valor = Math.Round(Convert.ToDouble(rdr["Valor"]), 2);

                    indicadores.Add(indicador);
                }
            }

            sqliteConnection.Close();

            return indicadores;
        }
    }
}
