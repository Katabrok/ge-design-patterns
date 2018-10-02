package ex2;

import org.junit.jupiter.api.Test;

class JogoNormalTest {

    @Test
    void gerarLabirinto() {
        var jn = new JogoNormal();
//        jn.gerarLabirinto();
        jn.montaLabirintoSemFactory();
    }

}