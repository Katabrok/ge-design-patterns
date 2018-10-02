package ex2;

public class Porta implements ElementoDeLabirinto {

    private ElementoDeLabirinto sala1, sala2;
    private boolean estaAberta;

    public Porta(ElementoDeLabirinto sala1, ElementoDeLabirinto sala2) {
        this.sala1 = sala1;
        this.sala2 = sala2;
        System.out.println("Construtor porta");
    }

    public void entra() {
        System.out.println("Entrou na porta");
    }

    public ElementoDeLabirinto salaDoOutroLado(ElementoDeLabirinto sala) {
        // validar sala
        return sala2;
    }

}