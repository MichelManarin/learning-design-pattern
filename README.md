# learning-design-pattern

Learning design pattern in c#

Esse repositorio tem a finalidade de aprendizagem de padrões de projeto, destacando seus benefícios. 

## Singleton
Impede que uma classe seja instanciada mais de uma vez, se encaixa perfeitamente em uma classe de empresa ou filial.
Ao instancia a classe mais de uma vez, o singleton retornará a instancia já existente.

# Padrões Factory
Utilizado para evitar duplicidade de código e facilitar a manutenção, diminui o acoplamento da aplicação.
A criação dos objetos fica sob responsabilidades das classes de fábrica. 
## Simple Factory 
- Pode ser utilizado em um sistema de pizzaria para se controlar a criação das pizzas.
- Se encaixa em situação aonde é necessário apenas UMA fábrica de objetos 
- Estrutura:
   Classe: PizzaFactory com um IF de acordo com o parâmetro enviado, e retorna a construção da classe de negocio.
   Classe: Pizza4Queijos, PizzaPeperoni, Pizza Mussarela
## Factory Method
- Pode ser utilizado em um sistema de pizzaria para se controlar a criação das pizzas multiregionalmente. 
- Se encaixa em uma situação aonde é uma pizzaria tem várias filiais que tem pizzas de mesmo sabor, mas com preparos diferentes.
- Estrutura:
  Classe abstrata: metodo abstrato criar pizza. (PizzaFactory)
  Classes concretas representando as fabricas. (PizzaFactorySC, PizzaFactoryRS) 
  Classes concretas representando as pizzas de cada fabrica. (SCPizzaPeperoni, RSPizzaPeperoni)
## Facade
- É utilizado para diminuir a complexidade de um código, basicamente é uma classe concreta contendo um conjunto de outras classes concretas para facilitar o desenvolvimento, assim quem usar a classe não precisará saber 
saber a respeito de todas as classes.
- Estrutura:
   Classe concreta: RealizarDoacaoDestinadaONG(Double valor) - Chamara dentro do seu código as outras classes, assim o código ficará mais limpo.
   Classe concreta: EstouroOrcamentoDoacao(Double valor)
   Classe concreta: EmpresaLucroSatisfatorio
## Strategy
 - É utilizado para criar uma estratégia para dependencia da abstração.
 - Pode ser aplicado em cálculo de imposto aonde o existirá vários impostos com diversas aliquotas, contudo, o método responsável por calcular imposto receberá uma abstração e não um classe concreta, ou seja, um único metodo cálculara todos os impostos.
 - Estrutura:
   Classe concreta: FaturamentoAnual
   Interface IImposto com metodo obtervalorimposto(FaturamentoAnual)
   Classe Imposto1 com aliquota 15%
   Classe Imposto1 com aliquota 9%
 
