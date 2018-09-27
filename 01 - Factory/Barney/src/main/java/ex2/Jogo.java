package ex2;

public abstract class Jogo {

    // Factory Methods com default
    public Labirinto criaLabirinto() {
        return new Labirinto();
    }

    public abstract Sala criaSala(int numeroDaSala);

    public abstract Parede criaParede();

    public abstract Porta criaPorta(Sala sala1, Sala sala2);

    /**
     * Em vez de um cliente que precisa de um objeto chamar new e assim especificar a classe concreta que ele instancia,
     * o cliente chama um método abstrato (Factory Method) especificado em alguma classe abstrata (ou interface) e a subclasse concreta vai decidir que tipo exato de objeto criar e retornar
     *
     * Observe como o método só trata da estrutura do labirinto e não do tipo de elemento que o compõe
     * @return
     */
    public Labirinto montaLabirinto() {
        System.out.println("montaLabirinto");

        Labirinto umLabirinto = criaLabirinto();

        Sala sala1 = criaSala(1);
        Sala sala2 = criaSala(2);

        Porta porta = criaPorta(sala1, sala2);

        umLabirinto.adicionaSala(sala1);
        umLabirinto.adicionaSala(sala2);

        sala1.setVizinho(Direcao.NORTE.getNumero(), criaParede());
        sala1.setVizinho(Direcao.LESTE.getNumero(), porta);
        sala1.setVizinho(Direcao.SUL.getNumero(), criaParede());
        sala1.setVizinho(Direcao.OESTE.getNumero(), criaParede());

        sala2.setVizinho(Direcao.NORTE.getNumero(), criaParede());
        sala2.setVizinho(Direcao.LESTE.getNumero(), criaParede());
        sala2.setVizinho(Direcao.SUL.getNumero(), criaParede());
        sala2.setVizinho(Direcao.OESTE.getNumero(), porta);

        return umLabirinto;
    }


    /**
     * O problema desta solução é sua inflexibilidade
     *      O método montaLabirinto() não é reutilizável em outras situações
     *      Motivo: montaLabirinto() mistura a questão da estrutura do labirinto com a questão dos tipos exatos de elementos que compõem o labirinto
     *      New cria um forte acoplamento entre a classe Jogo e as classes dos objetos
     * @return
     */
    public Labirinto montaLabirintoSemFactory() {
        Labirinto umLabirinto = new Labirinto();

        Sala sala1 = new Sala(1);
        Sala sala2 = new Sala(2);
        Porta aporta = new Porta(sala1,sala2);

        umLabirinto.adicionaSala(sala1);
        umLabirinto.adicionaSala(sala2);

        sala1.setVizinho(Direcao.NORTE.getNumero(), new Parede());
        sala1.setVizinho(Direcao.LESTE.getNumero(), aporta);
        sala1.setVizinho(Direcao.SUL.getNumero(), new Parede());
        sala1.setVizinho(Direcao.OESTE.getNumero(), new Parede());

        sala2.setVizinho(Direcao.NORTE.getNumero(), new Parede());
        sala2.setVizinho(Direcao.LESTE.getNumero(), new Parede());
        sala2.setVizinho(Direcao.SUL.getNumero(), new Parede());
        sala2.setVizinho(Direcao.OESTE.getNumero(), aporta);

        return umLabirinto;
    }

}
