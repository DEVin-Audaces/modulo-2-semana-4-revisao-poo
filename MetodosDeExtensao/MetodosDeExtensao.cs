namespace Revisao.MetodosDeExtensao
{
    public static class MetodosDeExtensao
    {
        public static int Multiplicar(this int inteiro, int valor)
        {
            return inteiro * valor;
        }

        public static decimal Multiplicar(this int inteiro, decimal valor)
        {
            return inteiro * valor;
        }

        public static decimal Multiplicar(this int inteiro, decimal valor, decimal valor2)
        {
            return inteiro * valor * valor2;
        }

        public static string Multiplicar(this int inteiro, decimal valor, decimal valor2, string mensagem)
        {
            return $"{mensagem} : {inteiro * valor * valor2}";
        }
    }
}