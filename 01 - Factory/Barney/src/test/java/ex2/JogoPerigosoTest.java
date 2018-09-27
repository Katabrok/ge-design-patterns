package ex2;

import org.junit.jupiter.api.Test;

class JogoPerigosoTest {

    @Test
    void gerarLabirinto() {
        var jp = new JogoPerigoso();
//        jp.montaLabirinto();

        jp.montaLabirintoSemFactory();
    }


}