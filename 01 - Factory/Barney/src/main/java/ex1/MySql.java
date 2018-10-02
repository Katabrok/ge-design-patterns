package ex1;

public class MySql extends DataBase {

    public MySql(TypeBd typeBd) {
        this.setType(typeBd);
        System.out.println("new MySql");
    }
}
