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
      string connetionString = "Data Source=ServerName;Initial Catalog=DatabaseName;User ID=UserName;Password=Password";
      connection = new SqlConnection(connetionString);
    }

    private Receita ConverterDataReaderToReceita(SqlDataReader reader)
    {
      return new Receita()
      {
        Id = (long)reader.GetValue(0),
        Descricao = (string)reader.GetValue(1),
        ImgUrl = (string)reader.GetValue(2),
        Votos = (int)reader.GetValue(3)
      };
    }

    private SqlDataReader CriarReader(string sql)
    {
      connection.Open();
      SqlCommand command = new SqlCommand(sql, connection);
      return command.ExecuteReader();
    }

    private void ExecuteNoQuery(string sql)
    {
      connection.Open();
      SqlCommand command = new SqlCommand(sql, connection);
      command.ExecuteNonQuery();
    } 

    public List<Receita> Buscar()
    {
      SqlDataReader dataReader = CriarReader("SELECT * FROM RECEITAS");
      List<Receita> receitas = new List<Receita>();

      while (dataReader.Read())
      {
        receitas.Add(ConverterDataReaderToReceita(dataReader));
      }

      dataReader.Close();
      connection.Close();
      return receitas;
    }

    public Receita Buscar(long id)
    {
      SqlDataReader reader = CriarReader($"SELECT * FROM RECEITAS WHERE ID = {id}");
      return ConverterDataReaderToReceita(reader);
    }

    public void AtualizarVotos(Receita receita)
    {
      ExecuteNoQuery($"UPDATE RECEITAS SET VOTOS = {receita.Votos} WHERE ID = {receita.Id}");
    }
  }
}
