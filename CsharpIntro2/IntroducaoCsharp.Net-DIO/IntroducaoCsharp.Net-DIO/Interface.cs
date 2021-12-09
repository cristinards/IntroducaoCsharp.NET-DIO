
namespace Interface
{
    //interface Inome
    internal interface IAnimal
    {
        void Nome(string nome);
        void Dono(string nomeDono);
        void Especie(string especie);

    }

    //classe referencial
    class Animal : IAnimal
    {
        public string Nome { get; set; }
        public string NomeDono { get; set; }
        public string Especie { get; set; }

        void IAnimal.Nome(string nome)
        {
            this.Nome = nome;
        }

        void IAnimal.Dono(string nomeDono)
        {
            this.NomeDono = nomeDono;
        }

        void IAnimal.Especie(string especie)
        {
            this.Especie = especie;
        }

    }
}
