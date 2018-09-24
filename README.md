# learning-design-pattern

Learning design pattern in c#

Esse repositorio tem a finalidade de aprendizagem de padrões de projeto, destacando seus benefícios. 

## Singleton
Impede que uma classe seja instanciada mais de uma vez, se encaixa perfeitamente em uma classe de empresa ou filial.
Ao instancia a classe mais de uma vez, o singleton retornará a instancia já existente.

# Padrões Factory
Utilizado para evitar duplicidade de código e facilitar a manutenção, diminui o acoplamento da aplicação.
# Simple Factory 
- Pode ser utilizado em um sistema de pizzaria para se controlar a criação das pizzas.
- Se encaixa em situação aonde é necessário apenas UMA fábrica de objetos 
- Estrutura:
   Classe: PizzaFactory com um IF de acordo com o parâmetro enviado, e retorna a construção da classe de negocio.
   Classe: Pizza4Queijos, PizzaPeperoni, Pizza Mussarela
