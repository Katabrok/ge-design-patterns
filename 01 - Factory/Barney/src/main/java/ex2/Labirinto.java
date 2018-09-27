package ex2;

import java.util.ArrayList;
import java.util.List;

public class Labirinto {

    private List<ElementoDeLabirinto> salas = new ArrayList<ElementoDeLabirinto>();

    public Labirinto() {
    }

    public void adicionaSala(ElementoDeLabirinto sala) {
        salas.add(sala);
    }

    public ElementoDeLabirinto getSala(int numeroDaSala) {
        return salas.get(numeroDaSala);
    }

}
