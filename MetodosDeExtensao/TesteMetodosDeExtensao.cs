using System;

namespace Revisao.MetodosDeExtensao
{
    public static class TesteMetodosDeExtensao
    {
        public static void IniciarTeste()
        {
            int inteiro = 10;
            Console.WriteLine(inteiro.Multiplicar(10));
            Console.WriteLine(inteiro.Multiplicar(1.1m, 1.2m, "Resultado"));
        }
    }
}