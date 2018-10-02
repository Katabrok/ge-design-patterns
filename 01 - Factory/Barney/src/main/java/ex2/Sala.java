package ex2;

public class Sala implements ElementoDeLabirinto {

    private ElementoDeLabirinto[] vizinhos = new ElementoDeLabirinto[4];

    private int numeroDaSala;

    public Sala(int numeroDaSala) {
        this.numeroDaSala = numeroDaSala;
        System.out.println("Construtor sala");
    }

    public void entra() {
        System.out.println("Entrou na sala");
    }

    public ElementoDeLabirinto getVizinho(int direcao) {
        return vizinhos[direcao];
    }

    public void setVizinho(int direcao, ElementoDeLabirinto vizinho) {
        vizinhos[direcao] = vizinho;
    }


    public ElementoDeLabirinto[] getVizinhos() {
        return vizinhos;
    }

    public void setVizinhos(ElementoDeLabirinto[] vizinhos) {
        this.vizinhos = vizinhos;
    }

    public int getNumeroDaSala() {
        return numeroDaSala;
    }

    public void setNumeroDaSala(int numeroDaSala) {
        this.numeroDaSala = numeroDaSala;
    }

}
