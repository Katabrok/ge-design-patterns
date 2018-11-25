# Template method
#### behavioral
O objetivo deste padrão é definir o esqueleto de um algoritmo dentro de um método,
tranferindo alguns de seus passos para as subclasses, permitindo assim que subclasses redefinam certos passos de um algoritmo sem alterar a estrutura do mesmo.

#### Diagrama de classe UML :
![alt text](https://www.thiengo.com.br/img/post/normal/2mukgjhalorsrofoqh4tsmkoo7d6109366674f9e6415c8aac1e22b99ea.jpg)

#### Os participantes :
- A ClasseTemplateAbstract define um conjunto de operações abstratas que podem (opcionalmente) ser implementadas pelos objetos da ClasseConcreta. Também implementa um método de modelo que controla a ordem em que essas operações abstratas ocorrem.
- Os objetos ClasseConcreta implementam as operações definidas pela ClasseTempateAbstract.

### Quando usar : 
- É necessário implementar as partes invariantes de um algoritimo uma única vez e deixar para subclasses a implentação da parte variante.
- Há comportamento semelhante entre subclasses.
- É necessário controlar extensões de classes com métodos.


### Vantagens:
- A principal vantagem do padrão Template Method é a facilidade de alteração do algoritmo principal.

### Desvantagens
- após instanciar um algoritmo, não será possível alterar o passo da execução;
