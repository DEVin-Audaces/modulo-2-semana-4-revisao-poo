namespace Revisao.ClassesAbstrataEInterface
{
    public interface IAutomovel
    {
        void Acelerar();
        void Freiar();
        public string Modelo { get; set; }
    }
}