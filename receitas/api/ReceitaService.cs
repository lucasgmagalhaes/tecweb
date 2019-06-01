using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace api
{
  public class ReceitaService
  {
    private readonly SqlConnection connection;

    public ReceitaService()
    {
      string connetionString = "Server=localhost;Database=receitas;User ID=sa;Password=senha;";
      connection = new SqlConnection(connetionString);

      OpenCon();
      ExecuteNoQuery("if not exists (select * from sysobjects where name='Receita' and xtype='U') " +
        "create table Receita(" +
        "Id BIGINT IDENTITY(1,1)," +
        "Nome varchar(50) not null," +
        "Descricao TEXT not null," +
        "ImgUrl TEXT NOT NULL," +
        "Votos INT NOT NULL" +
        ") ");
    }

    private Receita ConverterDataReaderToReceita(ref SqlDataReader reader)
    {
      return new Receita()
      {
        Id = reader.GetInt64(0),
        Nome = reader.GetString(1),
        Descricao = reader.GetString(2),
        ImgUrl = reader.GetString(3),
        Votos = reader.GetInt32(4)
      };
    }

    ~ReceitaService()
    {
      connection.Close();
      connection.Dispose();
    }

    private void OpenCon()
    {
      try
      {
        connection.Open();
      }
      catch
      {
        connection.Close();
        connection.Open();
      }
    }

    private SqlDataReader ExecuteReader(string sql)
    {
      OpenCon();
      SqlCommand command = new SqlCommand(sql, connection);
      SqlDataReader reader = command.ExecuteReader();
      return reader;
    }

    private void ExecuteNoQuery(string sql)
    {
      OpenCon();
      SqlCommand command = new SqlCommand(sql, connection);
      command.ExecuteNonQuery();
      connection.Close();
    }

    public List<Receita> Buscar()
    {
      SqlDataReader dataReader = ExecuteReader("SELECT * FROM RECEITA");
      List<Receita> receitas = new List<Receita>();

      while (dataReader.Read())
      {
        receitas.Add(ConverterDataReaderToReceita(ref dataReader));
      }

      dataReader.Close();
      connection.Close();
      return receitas;
    }

    public Receita Buscar(long id)
    {
      SqlDataReader reader = ExecuteReader($"SELECT * FROM RECEITA WHERE ID = {id}");
      Receita receita = null;

      if (reader.Read())
      {
        receita = ConverterDataReaderToReceita(ref reader);
      }

      connection.Close();
      reader.Close();

      return receita;
    }

    public void Atualizar(Receita receita)
    {
      ExecuteNoQuery($"UPDATE RECEITA SET " +
        $"VOTOS = {receita.Votos}, DESCRICAO = '{receita.Descricao}', IMGURL = '{receita.ImgUrl}', NOME = '{receita.Nome}'" +
        $" WHERE ID = {receita.Id}");
    }

    public void AtualizarVotos(Receita receita)
    {
      ExecuteNoQuery($"UPDATE RECEITA SET VOTOS = {receita.Votos} WHERE ID = {receita.Id}");
    }

    public void CriarReceita(Receita receita)
    {
      ExecuteReader($"" +
         $"INSERT INTO RECEITA(DESCRICAO, IMGURL, VOTOS, NOME) " +
         $"VALUES('{receita.Descricao}', '{receita.ImgUrl}', {receita.Votos}, '{receita.Nome}')");
    }

    public void DeletarReceita(long id)
    {
      ExecuteNoQuery($"DELETE FROM RECEITA WHERE ID = {id}");
    }
  }
}
