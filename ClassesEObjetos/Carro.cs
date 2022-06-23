namespace Revisao.ClassesEObjetos
{
    public class Carro {

        // Exemplo de atributo
        private string _cor;

        // Exemplo de propridade
        public string Cor
        {
            get { return _cor; }
            set { _cor = value; }
        }

        // Exemplo de propriedade automática readonly (Somente leitura)
        // Apesar de não ter "set" é possível definir um valor para essa propriedade
        // Através do construtor
        public double Velocidade {get; }
        // Exemplo de propriedade automática
        public string Modelo { get; private set;}


        public Carro()
        {

        }

        // Exemplo de sobrecarga
        public Carro(string modelo) {
            Modelo = modelo;
        }

        // Exemplo de sobrecarga
        public Carro(string modelo, string cor)
        {
            Cor = cor;
            Modelo = modelo;
        }

        // Exemplo de método para setar valor usando o "SET" privado
        public void DefinirModelo(string modelo)
        {
            Modelo = modelo;
        }

        // Exemplo de métodos
        public void Acelerar() {
            /* código do carro para acelerar */
        }

        public void Frear() {
            /* código do carro para frear */
        }

        public void AcenderFarol() {
            /* código do carro para acender o farol */
        }
    }

}