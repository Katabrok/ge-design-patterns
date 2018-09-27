package ex1;

import org.junit.jupiter.api.Test;

class FactoryBdTest {

    @Test
    void getBd() {
        try {
            DataBase db = new FactoryBd().getBd(TypeBd.POSTGRE);
            System.out.println(db.getType().toString());
        } catch (Exception e) {
            e.printStackTrace();
        }
    }
}