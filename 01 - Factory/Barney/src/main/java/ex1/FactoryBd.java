package ex1;

public class FactoryBd {

    public DataBase getBd(TypeBd typeBd) throws Exception {
        switch (typeBd) {
            case POSTGRE:
                return new Postgre(typeBd);
            case FIREBIRD:
                return new FireBird(typeBd);
            case MYSQL:
                return new MySql(typeBd);
            default:
                throw new Exception("Type default");
        }
    }

}
