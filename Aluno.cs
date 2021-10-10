using System.Collections.Generic;

namespace ConsoleApp1
{
    class Aluno
    {
        string nome;
        string matricula;
        string curso;
        int periodo;
        string datNascimento;
        public List<Disciplinas> disciplinas = new List<Disciplinas>();
        Endereco endereco;


        public Aluno(string nome, string matricula, string curso, int periodo, string datNascimento, List<Disciplinas> disciplinas)
        {
            this.nome = nome;
            this.matricula = matricula;
            this.curso = curso;
            this.periodo = periodo;
            this.datNascimento = datNascimento;
            this.disciplinas = disciplinas;
        }



        public string GetNome()
        {
            return nome;
        }

        public void SetNome(string nome)
        {
            this.nome = nome;
        }

        public string GetMatricula()
        {
            return matricula;
        }

        public void SetMatricula(string matricula)
        {
            this.matricula = matricula;
        }

        public string GetCurso()
        {
            return curso;
        }

        public void SetCurso(string curso)
        {
            this.curso = curso;
        }

        public int GetPeriodo()
        {
            return periodo;
        }

        public void SetPeriodo(int periodo)
        {
            this.periodo = periodo;
        }

        public string GetDataNascimento()
        {
            return datNascimento;
        }

        public void SetDataNascimento(string datNascimento)
        {
            this.datNascimento = datNascimento;
        }

        public Endereco GetEndereco()
        {
            return endereco;
        }

        public void SetEndereco(Endereco endereco)
        {
            this.endereco = endereco;
        }

    }
}
