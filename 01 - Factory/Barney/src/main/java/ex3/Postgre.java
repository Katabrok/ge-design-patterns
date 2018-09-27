package ex3;

public class Postgre implements DataBase {

    public Postgre() {
        System.out.println("new Postgre");
    }

    @Override
    public String getConnection() {
        return "connection Postgre";
    }
}