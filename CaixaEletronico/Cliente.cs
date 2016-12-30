namespace CaixaEletronico
{
    class Cliente
    {
        
        public string rg;
        public string cpf;
        public string endereco;
        
        public string Nome { get; set; }
        public int Idade { get; set; }

        /// <summary>
        /// Construtor default da classe Cliente
        /// </summary>
        public Cliente()
        {

        }

        public Cliente(string nome, int idade)
        {
            this.Nome = nome;
            this.Idade = idade;
        }
        
        public bool EhMaiorDeIdade()
        {
            return this.Idade >= 18;
        }
    }
}