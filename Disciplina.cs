namespace ConsoleApp1
{
    class Disciplinas
    {
        string nomeDisciplina;
        string horario;
        int quantidadeCreditos;

        public string GetNomeDisciplina()
        {
            return nomeDisciplina;
        }

        public void SetNomeDisciplina(string nomeDisciplina)
        {
            this.nomeDisciplina = nomeDisciplina;
        }

        public string GetHorario()
        {
            return horario;
        }

        public void SetHorario(string horario)
        {
            this.horario = horario;
        }

        public int GetQuantidadeCreditos()
        {
            return quantidadeCreditos;
        }

        public void SetQuantidadeCreditos(int quantidadeCreditos)
        {
            this.quantidadeCreditos = quantidadeCreditos;
        }
    }
}
