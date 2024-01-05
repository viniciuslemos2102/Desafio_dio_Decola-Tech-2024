using System;
using System.Collections.Generic;
using System.Linq;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<Veiculo> veiculos = new List<Veiculo>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            // *IMPLEMENTE AQUI*
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();

            if (!VeiculoExiste(placa))
            {
                Veiculo novoVeiculo = new Veiculo(placa);
                veiculos.Add(novoVeiculo);
                Console.WriteLine("Veículo estacionado com sucesso!");   
            }
            else
            {
                Console.WriteLine("Erro: Este veículo já está estacionado!");
            }
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine();

            // Pedir para o usuário digitar a placa e armazenar na variável placa
            // *IMPLEMENTE AQUI*

            // Verifica se o veículo existe
            Veiculo veiculoRemover = veiculos.Find(v => v.Placa.ToUpper() == placa.ToUpper());
            if (veiculoRemover != null)
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                // *IMPLEMENTE AQUI*
                int horas = Convert.ToInt32(Console.ReadLine());

                decimal valorTotal = CalcularValorCobrado(horas);

                // Remover o veículo da lista
                veiculos.Remove(veiculoRemover);

                // TODO: Remover a placa digitada da lista de veículos
                // *IMPLEMENTE AQUI*
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
                Console.WriteLine("Os veículos estacionados são:");
                foreach (Veiculo veiculo in veiculos)
                {
                    Console.WriteLine($"Placa: {veiculo.Placa}");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
        private bool VeiculoExiste(string placa)
        {
            return veiculos.Any(v => v.Placa.ToUpper() == placa.ToUpper());
        }

        private decimal CalcularValorCobrado(int horas)
        {
            return precoInicial + precoPorHora * horas;
        }


    }
    public class Veiculo
    {
        public string Placa { get; }

        public Veiculo(string placa)
        {
            Placa = placa;
        }
    }
}
