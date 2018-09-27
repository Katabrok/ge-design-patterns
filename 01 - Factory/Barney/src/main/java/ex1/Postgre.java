package ex1;

public class Postgre extends DataBase {

    public Postgre(TypeBd typeBd) {
        this.setType(typeBd);
        System.out.println("new Postgre");
    }
}