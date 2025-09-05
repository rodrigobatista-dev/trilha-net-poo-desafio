using System.Buffers;

namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama

        protected string Modelo { get; set; } 
        private string IMEI { get; set; }
        private int Memoria { get; set; }

        protected string ModeloExibicao { get; set; }
        protected string LigandoExibicao { get; set; }
        protected string RecebendoLigacaoExibicao { get; set; }
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            // TODO: Passar os parâmetros do construtor para as propriedades
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;

        }

        public void Ligar()
        {
            Console.WriteLine($"Ligando  para o {LigandoExibicao}");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine($"Recebendo ligação do {RecebendoLigacaoExibicao}");
        }

        

        public abstract void InstalarAplicativo(string nomeApp);
    }
}