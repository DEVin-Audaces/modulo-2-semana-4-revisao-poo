using System;

namespace Revisao.ModificadoresDeAcesso
{
    public static class TesteUsuario
    {
        public static void Iniciar()
        {
            Usuario usuario = new Usuario(DateTime.Now, "Usuario",10);

            // Apesar deste propriedade ser da classe Auditoria, é possível modificá-la
            // Pois a mesma está pública
            usuario.UsuarioInclusaoId = 11;

            //Neste caso não é possível acessar esta propriedade pois a mesma
            // está definida como protected
            //usuario.DataInclusao <= Erro: não funciona

            // Neste caso conseguimos obter o valor da propriedade Auditoria.DataInclusao através
            // do método público da classe Usuário que herda de Auditoria
            usuario.ObterDataDeInclusao();

            // Irá acessar o método padrão da classe Auditoria
            usuario.ImprimirLog();

            Pessoa pessoa = new Pessoa();
            // Irá acessar o método sobreescrito da classe Pessoa
            pessoa.ImprimirLog();
            pessoa.ImprimirLogAvancado();
            pessoa.MetodoDeExemplo(1, 2);
        }
    }
}