namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            
            Console.WriteLine("Digite a placa do veículo para estacionar:");

            //Adicinando um veículo ao estacionamento
            string placa = Console.ReadLine();

            
            if (placa != null)
            {

                string texto;
                texto = placa;
                veiculos.Add(texto);
                                  
                Console.WriteLine(value: $"Placa Cadastrada:" + texto);
            

            }
            else
            {
                Console.WriteLine("Sem caracteres para cadastrar por fasvor tente novamente.");

            }
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            
            //Recebendo a placa a ser removida 
            string placa = Console.ReadLine();


            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {

                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

            
                int horas = 0;
                decimal valorTotal = 0;
                
                //Recebe a quantidade de horas do veículo no estacionamento
                string h = Console.ReadLine();
                horas = Convert.ToInt32(h);

                //Calcúlo para ver o valor a pagar
                valorTotal = (precoInicial + precoPorHora) * horas;


                
                veiculos.Remove(placa);
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {

                /*Faço que mostra a lista de todos veículos no estacionamento*/
                foreach (string item in veiculos)
                    Console.WriteLine($"Os veículos estacionados são:" + item);

            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
