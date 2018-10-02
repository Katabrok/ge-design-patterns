package ex2.concreto;

import org.junit.jupiter.api.Test;

class JogoNormalTest {

    @Test
    void gerarLabirinto() {
        System.out.println("JogoNormal");
        var jn = new JogoPerigoso();
        jn.gerarLabirinto();
//        jn.montaLabirintoSemFactory();
    }
}