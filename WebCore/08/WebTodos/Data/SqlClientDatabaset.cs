using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebTodos.Models;

namespace WebTodos.Data
{
    public class SqlClientDatabaset : IDatabase<Todo>
    {
        public void Add(Todo todo)
        {
            using (System.Data.SqlClient.SqlConnection client = new System.Data.SqlClient.SqlConnection())
            {
                client.ConnectionString = "Databaseseseessese";

                client.Open();

                if (client.State != System.Data.ConnectionState.Open)
                {
                    //tratar erro de aberta
                }

                var cmd = client.CreateCommand();

                cmd.CommandText = "SELECT *******";
                cmd.CommandTimeout = 100;

                using (var reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
                {
                    while (reader.HasRows)
                    {
                        reader.NextResult();
                        string nome = reader.GetString(1);
                        string descricao = reader.GetString(2);
                    }
                }
            }
        }

        public List<Todo> GetAll()
        {
            throw new NotImplementedException();
        }

        public Todo GetById(string id)
        {
            throw new NotImplementedException();
        }

        public void Remove(string id)
        {
            throw new NotImplementedException();
        }

        public void Update(string id, Todo todo)
        {
            throw new NotImplementedException();
        }
    }
}
