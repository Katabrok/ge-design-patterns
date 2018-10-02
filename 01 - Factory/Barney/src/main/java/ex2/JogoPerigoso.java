package ex2;

public class JogoPerigoso extends Jogo {

    public Parede criaParede() {
        System.out.println("ParedeDestrutível");
//        return new ParedeDestrutível();
        return new Parede();
    }

    public Sala criaSala(int numeroDaSala) {
        System.out.println("SalaComBomba");
        return new Sala(numeroDaSala);
//        return new SalaComBomba(numeroDaSala);
    }

    public Porta criaPorta(Sala sala1, Sala sala2) {
//        return new PortaLoka(sala1, sala2);
        System.out.println("PortaLoka");
        return new Porta(sala1, sala2);
    }

    public void gerarLabirinto() {
        System.out.println("JogoPerigoso");
        montaLabirinto();
    }

}
