using Desafio7.Models;
using Desafio7.Repository.Alunos;
using System;
using System.Collections.Generic;

namespace Desafio7
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();
            List<Aluno> alunos = new List<Aluno>();
            Console.WriteLine("Bem Vindo Ao Console Mil Grau do CSV\n");


            Console.WriteLine("Começa digitando o nome  Aluno:");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("\nAgora Digita a Idade do pilanta:");
            aluno.Idade = Console.ReadLine();
            Console.WriteLine("\nDigite a Nota do sem vergonha(reprova ele :c)");
            aluno.Nota = Console.ReadLine();

            alunos.Add(aluno);

            AlunoRepository repository = new AlunoRepository();
            repository.InserirAlunos(alunos);

            Console.WriteLine("Dados salvos com Sucesso");
            Console.ReadKey();
        }
    }
}