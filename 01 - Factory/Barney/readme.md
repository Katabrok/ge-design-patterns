Fectory Method
    Padrões Factory (Simple Factory, Factory Method, Abstract Factory) encapsulam a criação de objetos

    Fectory Method - encapsula a criação de objetos deixando as subclasses decidirem quais classes instanciar.
                     Permite adiar a instanciação para subclasses;

    GOF o padrão Factory Method é: “Um padrão que define uma interface para criar um objeto,
        mas permite às classes decidirem qual classe instanciar. O Factory Method permite a uma classe deferir
        a instanciação para subclasses”.

Este padrão pode ser utilizado quando:
    O sistema deve ser flexível com relação a como seus produtos são criados, compostos e representados;
    O sistema deve ser configurado para utilizar uma única família de produtos dentre várias outras famílias.
    Quando se pretende fornecer bibliotecas de classes, revelando as suas interfaces e não as suas implementações.

Consequências do uso do padrão Factory Method
    Factory Methods eliminam a necessidade de colocar classes específicas da aplicação no código
        O código só lida com a interface Produto
        O código pode portanto funcionar com qualquer classe ProdutoConcreto

    Provê ganchos para subclasses
        Criar objetos dentro de uma classe com um Factory Method é sempre mais flexível do que criar objetos diretamente
        O Factory Method provê um gancho para que subclasses forneçam uma versão estendida de um objeto

Dois tipos:
    Dois variedades principais
    Métodos-fabrica parametrizados

Comparação
        Builder X Factory
            Criacao de obj que recebe diferentes atributos variaveis
            Centraliza a criacao de obj e isola o processo de criação, sem variaveis


Um padrão de projeto pode usar e abusar de classes abstratas e interfaces; (BARNEY, 2018)

O mais importante do Factory e atrasar a escolha do tipo do objeto; (VOZERA, 1960)