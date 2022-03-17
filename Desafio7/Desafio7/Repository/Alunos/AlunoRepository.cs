using Dapper;
using Desafio7.Models;
using Desafio7.Repository.Alunos.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio7.Repository.Alunos
{
    public class AlunoRepository : IAlunoRepository
    {
        public void InserirAlunos(List<Aluno> alunos)
        {
            using (var con = new SqlConnection(GetConnection())) 
            {
                try
                {
                    con.Open();
                    var query = "INSERT INTO Alunos(Nome, Idade, Nota) VALUES(@nome, @idade, @nota);";
                    foreach (var aluno in alunos)
                    {
                        var result = con.Query(query, new { nome = aluno.Nome, idade = aluno.Idade, nota = aluno.Nota });
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public string GetConnection() 
        {
            var connection = @"Data Source=DESKTOP-1G82VRK;Initial Catalog=Desafio07;Integrated Security=true";
            return connection;
        }
    }
}
