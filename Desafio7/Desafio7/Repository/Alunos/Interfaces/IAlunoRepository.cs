using Desafio7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio7.Repository.Alunos.Interfaces
{
    public interface IAlunoRepository
    {
        void InserirAlunos(List<Aluno> alunos);
    }
}
