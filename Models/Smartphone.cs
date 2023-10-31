using System.Text.RegularExpressions;

namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public Smartphone(string numero, string modeloTelefone, string numeroImei, int quantidadeMemoria)
        {
            Numero = formatarTelefone(numero);
            // TODO: Passar os parâmetros do construtor para as propriedades
            modelo = modeloTelefone;
            imei = numeroImei;
            memoria = quantidadeMemoria;
        }

        private string formatarTelefone(string numero)
        {
            string regexNumero = @"^(\d{2})9(\d{4,5})(\d{4})$";
            string formato = "($1) 9$2-$3";
            string celularFormatado = Regex.Replace(numero, regexNumero, formato);
            return celularFormatado;
        }

        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        private string modelo;
        private string imei;
        private int memoria;

        public string Numero { get; set; }
        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);

        public void ExibirDadosTelefone()
        {
            Console.WriteLine("---- DADOS DO TELEFONE ----");
            Console.WriteLine($"Nº tel.: {Numero}\n" +
                              $"Modelo: {modelo}\n" +
                              $"IMEI: {imei}\n" +
                              $"Capacidade de Memória: {memoria}GB");
        }
    }
}