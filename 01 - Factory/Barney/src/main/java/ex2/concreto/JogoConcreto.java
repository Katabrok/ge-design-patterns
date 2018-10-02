package ex2.concreto;

import ex2.*;

public class JogoConcreto {

    public Labirinto criaLabirinto() {
        return new Labirinto();
    }

    public Sala criaSala(int numeroDaSala) {
        System.out.println("Sala");
        return new Sala(numeroDaSala);
    }

    public Parede criaParede() {
        System.out.println("Parede");
        return new Parede();
    }

    public Porta criaPorta(Sala sala1, Sala sala2) {
        System.out.println("Porta");
        return new Porta(sala1, sala2);
    }

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

}
