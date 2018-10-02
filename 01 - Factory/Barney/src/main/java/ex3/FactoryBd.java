package ex3;

public class FactoryBd {

    public String getBd(TypeBd typeBd) throws Exception {
        switch (typeBd) {
            case POSTGRE:
                return new Postgre().getConnection();
            case FIREBIRD:
                return new FireBird().getConnection();
            case MYSQL:
                return new MySql().getConnection();
            default:
                throw new Exception("Type default");
        }
    }

}
