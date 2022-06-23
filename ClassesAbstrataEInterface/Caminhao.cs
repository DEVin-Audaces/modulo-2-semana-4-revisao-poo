namespace Revisao.ClassesAbstrataEInterface
{
    public class Caminhao : IAutomovel
    {
        public void Acelerar()
        {
            throw new System.NotImplementedException();
        }

        public void Freiar()
        {
            throw new System.NotImplementedException();
        }

        public string Modelo { get; set; }
    }
}