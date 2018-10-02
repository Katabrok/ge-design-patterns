package ex3;

import org.junit.jupiter.api.Test;

class FactoryBdTest {

    @Test
    void getBd() throws Exception {
        var factory = new FactoryBd();
        System.out.println(factory.getBd(TypeBd.POSTGRE));
    }
}