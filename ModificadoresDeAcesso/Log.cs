using System;

namespace Revisao.ModificadoresDeAcesso
{
    public abstract class Log
    {
        public abstract void ImprimirLogAvancado();

        public int MetodoDeExemplo(int a, int b)
        {
            return a + b;
        }
    }

}