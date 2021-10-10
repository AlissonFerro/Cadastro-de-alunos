using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Endereco
    {
        string rua;
        int num;
        string bairro;
        string cep;
        string cidade;
        string estado;

        public string GetRua()
        {
            return rua;
        }

        public void SetRua(string rua)
        {
            this.rua = rua;
        }

        public int GetNum()
        {
            return num;
        }

        public void SetNum(int num)
        {
            this.num = num;
        }

        public string GetBairro()
        {
            return bairro;
        }

        public void SetBairro(string bairro)
        {
            this.bairro = bairro;
        }

        public string GetCep()
        {
            return cep;
        }

        public void SetCep(string cep)
        {
            this.cep = cep;
        }

        public string GetCidade()
        {
            return cidade;
        }

        public void SetCidade(string cidade)
        {
            this.cidade = cidade;
        }


        public string GetEstado()
        {
            return estado;
        }

        public void SetEstado(string estado)
        {
            this.estado = estado;
        }
    }
}
