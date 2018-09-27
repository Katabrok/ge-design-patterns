package ex2;

public enum Direcao {

    NORTE(0),
    LESTE(1),
    SUL(2),
    OESTE(3);

    private final int numero;

    Direcao(int numero) {
        this.numero = numero;
    }

    public int getNumero() {
        return numero;
    }

}
