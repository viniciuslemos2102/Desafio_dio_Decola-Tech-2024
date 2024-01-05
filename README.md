# Desafio Estacionamento Desafio DIO[https://www.dio.me/] Bootcamp Decola Tech 2024

## Introdução
Este projeto implementa um Sistema de Gerenciamento de Estacionamento em C#, proporcionando funcionalidades básicas para adicionar, remover e listar veículos estacionados. Ele foi desenvolvido como parte de um desafio de laboratório para demonstrar habilidades de programação em um ambiente .NET.

## Funcionalidades Principais

### 1. Adicionar Veículo
- O método `AdicionarVeiculo` permite ao usuário adicionar um veículo ao estacionamento, fornecendo a placa como entrada.
- A placa do veículo é verificada para evitar duplicatas, garantindo que cada veículo seja único no estacionamento.
- Exibe mensagens informativas para indicar se o veículo foi adicionado com sucesso ou se já está estacionado.

### 2. Remover Veículo
- O método `RemoverVeiculo` solicita a placa do veículo a ser removido e a quantidade de horas que o veículo permaneceu estacionado.
- Calcula o valor total a ser cobrado com base no tempo estacionado, usando um preço inicial e uma taxa por hora.
- Remove o veículo da lista e exibe uma mensagem indicando o sucesso da operação.

### 3. Listar Veículos
- O método `ListarVeiculos` exibe as placas de todos os veículos estacionados no momento.
- Fornece uma mensagem informativa caso não haja veículos estacionados.

## Estrutura do Código
O código está organizado de maneira modular, com uma classe principal `Estacionamento` que encapsula as funcionalidades principais. A classe `Veiculo` é utilizada para representar um veículo no sistema.

## Uso de Boas Práticas
- Uso de encapsulamento para proteger variáveis privadas, garantindo a coesão e a segurança do código.
- Utilização de funções para dividir a lógica do programa, tornando o código mais legível e fácil de manter.
- Implementação de verificações para garantir a integridade dos dados, evitando duplicatas na lista de veículos.

## Considerações Adicionais
Este sistema pode ser expandido e aprimorado para incluir mais funcionalidades, como persistência de dados, interface gráfica, relatórios de atividades, entre outros, conforme as necessidades específicas de um ambiente de estacionamento real.

**Observação:** O código foi ajustado para utilizar a classe `Veiculo` para representar um veículo, fornecendo uma estrutura mais adequada e modular. Certifique-se de adaptar conforme necessário para integrar ao contexto geral do seu projeto.
