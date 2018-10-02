package ex2;

public class JogoNormal extends Jogo {

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

    public void gerarLabirinto() {
        System.out.println("JogoNormal");
        montaLabirinto();
    }
}
