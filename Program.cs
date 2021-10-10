using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            //List<Aluno> aluno = new List<Aluno>();

            List<Aluno> alunos = new List<Aluno>();
            List<Disciplinas> disciplinas = new List<Disciplinas>();

            int i = 1;
            while (i != 0)
            {

                Console.WriteLine("Selecione uma opção:\n1 - Cadastrar Aluno\n2 - Listar alunos\n3 - Finalizar");
                int op = int.Parse(Console.ReadLine());
                char[] separadores = { ',', '/' };

                switch (op)
                {
                    case 1:

                        string continuar = "s";
                        while(continuar!= "n")
                        {
                            Endereco endereco = new Endereco();


                            Console.WriteLine("Digite os dados do aluno: separando-os por \",\" ou \"/\"\n" +
                                "(nome, matricula, curso, periodo, idade)");
                            string dadosAluno = Console.ReadLine();
                            string[] alunoSeparado = dadosAluno.Split(separadores);




             
                            Console.WriteLine("Digite o endereço do aluno separando-os por \",\" ou \"/\"\n" +
                                     "(rua, número, bairro, cep, cidade, estado)");
                            string dadosEndereco = Console.ReadLine();
                            string[] enderecoSeparado = dadosEndereco.Split(separadores);



                            string adicionaDisciplina = "s";

                            while (adicionaDisciplina == "s")
                            {
                                Disciplinas disciplina = new Disciplinas();
                                Console.WriteLine("Digite os dados da disciplina: separando-os por \",\" ou \"/\"\n" +
                                    "(nome da disciplina, horario, quantidade de creditos");
                                string dadosDisciplina = Console.ReadLine();
                                string[] disciplinaSeparado = dadosDisciplina.Split(separadores);

                                disciplina.SetNomeDisciplina(disciplinaSeparado[0]);
                                disciplina.SetHorario(disciplinaSeparado[1]);
                                disciplina.SetQuantidadeCreditos(int.Parse(disciplinaSeparado[2]));

                                disciplinas.Add(disciplina);

                                Console.WriteLine("Deseja adicionar outras diciplinas para {0}? (s/n)", alunoSeparado[0]);
                                adicionaDisciplina = Console.ReadLine().ToLower();


                            }

                            Aluno aluno = new Aluno(alunoSeparado[0], alunoSeparado[1], alunoSeparado[2], int.Parse(alunoSeparado[3]), int.Parse(alunoSeparado[4]), disciplinas);

                            endereco.SetRua(enderecoSeparado[0]);
                            endereco.SetNum(int.Parse(enderecoSeparado[1]));
                            endereco.SetBairro(enderecoSeparado[2]);
                            endereco.SetCep(enderecoSeparado[3]);
                            endereco.SetCidade(enderecoSeparado[4]);
                            endereco.SetEstado(enderecoSeparado[5]);

                            aluno.SetEndereco(endereco);

                            alunos.Add(aluno);

                            Console.WriteLine("Deseja continuar? (s/n)");
                            continuar = Console.ReadLine().ToLower();


                        }
                        break;

                    case 2:
                        Console.WriteLine("Deseja listar todos ou um aluno específico?");
                        string resp = Console.ReadLine().ToLower();
                        if(resp == "todos")
                        {
                            for (int j = 0; j < alunos.Count; j++)
                            {

                                Console.WriteLine("Nome: {0}, matricula: {1}, curso: {2}, período: {3}, idade: {4}", alunos[j].GetNome(), alunos[j].GetMatricula(),alunos[j].GetCurso(), 
                                    alunos[j].GetPeriodo(), alunos[j].GetIdade());

                                for (int k = 0; k < disciplinas.Count; k++)
                                {
                                    Console.WriteLine("Nome da disciplina {0}, Horário {1}, Quantidade de Créditos: {2} ", alunos[j].disciplinas[k].GetNomeDisciplina(), alunos[j].disciplinas[k].GetHorario(), alunos[j].disciplinas[k].GetQuantidadeCreditos());
                                }
                                Console.WriteLine("Rua: {0}, Número: {1}, Bairro: {2}, CEP: {3}, Cidade: {4}/{5}", alunos[j].GetEndereco().GetRua(), alunos[j].GetEndereco().GetNum(), alunos[j].GetEndereco().GetBairro(),
                                    alunos[j].GetEndereco().GetCep(), alunos[j].GetEndereco().GetCidade(), alunos[j].GetEndereco().GetEstado());
                            }

                        }
                        else if(resp == "especifico" || resp == "específico")
                        {
                            Console.WriteLine("Digite a matricula do aluno");
                            string matricula = Console.ReadLine();
                            int posicao =-1;

                            for(int k = 0; k < alunos.Count; k++)
                            {
                                if(alunos[k].GetMatricula().Trim() == matricula)
                                {
                                    posicao = k;
                                    break;
                                }
                            }

                            if (posicao == -1)
                            {
                                Console.WriteLine("Aluno não encontrado");
                            }
                            else
                            {
                                for (int j = 0; j < alunos.Count; j++)
                                {

                                    Console.WriteLine("Nome: {0}, matricula: {1}, curso: {2}, período: {3}, idade: {4}", alunos[posicao].GetNome(), alunos[posicao].GetMatricula(), alunos[posicao].GetCurso(),
                                        alunos[posicao].GetPeriodo(), alunos[posicao].GetIdade());

                                    for (int k = 0; k < disciplinas.Count; k++)
                                    {
                                        Console.WriteLine("Nome da disciplina {0}, Horário {1}, Quantidade de Créditos: {2} ", alunos[posicao].disciplinas[k].GetNomeDisciplina(), alunos[posicao].disciplinas[k].GetHorario(), alunos[posicao].disciplinas[k].GetQuantidadeCreditos());
                                    }
                                    Console.WriteLine("Rua: {0}, Número: {1}, Bairro: {2}, CEP: {3}, Cidade: {4}/{5}", alunos[posicao].GetEndereco().GetRua(), alunos[posicao].GetEndereco().GetNum(), alunos[posicao].GetEndereco().GetBairro(),
                                        alunos[posicao].GetEndereco().GetCep(), alunos[posicao].GetEndereco().GetCidade(), alunos[posicao].GetEndereco().GetEstado());
                                }
                            }

                        }
                        else
                        {
                            Console.WriteLine("Opção inválida");
                        }


                        break;

                    case 3:
                        i = 0;
                        break;

                    default:
                        Console.WriteLine("Selecione uma opção válida");
                        break;
                }
            }


        }
    }
}
