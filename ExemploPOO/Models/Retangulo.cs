namespace ExemploPOO.Models
{
    public class Retangulo
    {
        //criar 2 propriedades privadas
        private double comprimento;
        private double largura;
        private bool valido;

        //o método DefinirMedidas é o único lugar onde se pode alterar os atributos compr e larg acima 
        public void DefinirMedidas(double comprimento, double largura)
        {
            if (comprimento > 0 && largura > 0)
            {
            this.comprimento = comprimento;
            this.largura = largura;
            valido = true;
            }
            else
            {
                System.Console.WriteLine("Valores inválidos");
            }
        }

        public double ObterArea()
        {
            if (valido)
            {
            return comprimento * largura;
            }
            else
            {
                System.Console.WriteLine("Preencha valores válidos");
                return 0;
            }
        }
    }
}