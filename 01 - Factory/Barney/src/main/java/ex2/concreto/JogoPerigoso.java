package ex2.concreto;

import ex2.Parede;
import ex2.Porta;
import ex2.Sala;

public class JogoPerigoso extends JogoConcreto {

    public Parede criaParede() {
        System.out.println("JogoPerigoso ParedeDestrutível");
//        return new ParedeDestrutível();
        return new Parede();
    }

    public Sala criaSala(int numeroDaSala) {
        System.out.println("JogoPerigoso SalaComBomba");
        return new Sala(numeroDaSala);
//        return new SalaComBomba(numeroDaSala);
    }

    public Porta criaPorta(Sala sala1, Sala sala2) {
//        return new PortaLoka(sala1, sala2);
        System.out.println("JogoPerigoso PortaLoka");
        return new Porta(sala1, sala2);
    }

    public void gerarLabirinto() {
        System.out.println("JogoPerigoso");
        montaLabirinto();
    }

}
