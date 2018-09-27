package ex3;

public class MySql implements DataBase {

    public MySql() {
        System.out.println("new MySql");
    }

    @Override
    public String getConnection() {
        return "connection MySql";
    }
}
