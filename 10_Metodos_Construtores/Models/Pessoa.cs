namespace Models
{

    public class Pessoa
    {
        //Atributos da nossa classe Pessoa
        private string nome { get; set; }

        private int idade { get; set; }

        private string email { get; set; }

        private int anoNascimento { get; set; }

        //Método construtor da classe pessoa

        public Pessoa(string nomePessoa, int idadePessoa, string emailPessoa)
        {
            this.nome = nomePessoa;
            this.idade = idadePessoa;
            this.email = emailPessoa;
            this.anoNascimento = 2023 - idade;
        }

        //Método da classe pessoa

        public void Cantar()
        {
            Console.WriteLine($"{nome} está cantando");
        }

        public void Informacoes()
        {
            Console.WriteLine($"{nome} tem {idade} anos (nasceu no ano de {anoNascimento}) e seu email para contato é {email}");
        }

    }
}