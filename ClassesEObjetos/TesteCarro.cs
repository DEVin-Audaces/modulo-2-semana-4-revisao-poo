namespace Revisao.ClassesEObjetos
{
    public static class TesteCarro
    {

        public static void Iniciar()
        {
            // Sobrecargas
            Carro carroGenerico = new Carro();
            Carro uno = new Carro("Uno");
            Carro camaroAmarelo = new Carro("Camaro", "Amarelo");

            // Encapsulamento
            // uno.Modelo = "";   <= Este código é inviável pois o atributo "modelo" está encapsulado

            var modeloDoCarro = uno.Modelo; // O "get" é público, porém o "set" é privado

            // Porém é possível modificar o modelo através do método público DefinirModelo
            carroGenerico.DefinirModelo("Celta");

        }
    }
}