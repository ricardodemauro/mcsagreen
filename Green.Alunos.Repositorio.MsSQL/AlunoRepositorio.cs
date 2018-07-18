using Green.Alunos.Domain.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Green.Alunos.Domain;
using System.Data.Common;
using System.Data.SqlClient;
using System.Configuration;

namespace Green.Alunos.Repositorio.MsSQL
{
    public class AlunoRepositorio : IAlunoRepositorio
    {
        public Task<Aluno> AdicionarAluno(Aluno aluno)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Aluno>> GetAlunos()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DbConnection2"].ConnectionString;
            using (DbConnection conn = new SqlConnection(connectionString))
            {
                using (DbCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT Id, Nome, Nota FROM Alunoes";
                    if (conn.State != System.Data.ConnectionState.Open)
                    {
                        conn.Open();
                    }

                    var reader = await cmd.ExecuteReaderAsync(System.Data.CommandBehavior.CloseConnection);
                    List<Aluno> alunos = new List<Aluno>();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            var aluno = new Aluno();
                            aluno.Nome = reader.GetString(1);
                            aluno.Id = reader.GetInt32(0);
                            aluno.Nota = reader.GetString(3);
                            alunos.Add(aluno);
                        }
                    }
                    return alunos;
                }
            }
        }
    }
}
