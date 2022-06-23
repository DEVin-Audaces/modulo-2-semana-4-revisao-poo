namespace Revisao.ClassesAbstrataEInterface
{
    public class Carro : IAutomovel
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

    public class Moto : IAutomovel
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