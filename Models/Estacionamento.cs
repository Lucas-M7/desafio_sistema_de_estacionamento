using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace sistema_de_estacionamento.Models
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
            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            Console.WriteLine("Digite a placa do veículo para estacionar:");
#pragma warning disable CS8604 // Possível argumento de referência nula.
            veiculos.Add(Console.ReadLine());
#pragma warning restore CS8604 // Possível argumento de referência nula.
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            // Pedir para o usuário digitar a placa e armazenar na variável placa
#pragma warning disable CS8600 // Conversão de literal nula ou possível valor nulo em tipo não anulável.
            string placa = Console.ReadLine();
#pragma warning restore CS8600 // Conversão de literal nula ou possível valor nulo em tipo não anulável.

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.Equals(placa, StringComparison.CurrentCultureIgnoreCase)))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                decimal horas = Convert.ToInt32(Console.ReadLine());
                decimal valorTotal = precoInicial + (precoPorHora * horas);

                // TODO: Remover a placa digitada da lista de veículos
#pragma warning disable CS8604 // Possível argumento de referência nula.
                _ = veiculos.Remove(placa);
#pragma warning restore CS8604 // Possível argumento de referência nula.

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
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                for(int cont = 0; cont < veiculos.Count; cont++)
                {
                    Console.WriteLine($"{veiculos[cont]}");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}