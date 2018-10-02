package ex3;

public class FireBird implements DataBase {

    public FireBird() {
        System.out.println("new FireBird");
    }

    @Override
    public String getConnection() {
        return "connection FireBird";
    }
}
