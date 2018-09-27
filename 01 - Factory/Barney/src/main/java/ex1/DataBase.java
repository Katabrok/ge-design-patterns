package ex1;

import java.util.Objects;

public abstract class DataBase {

    private String nome;
    private String jdbc;
    private String url;
    private TypeBd type;

    public String getNome() {
        return nome;
    }

    public void setNome(String nome) {
        this.nome = nome;
    }

    public String getUrl() {
        return url;
    }

    public void setUrl(String url) {
        this.url = url;
    }

    public String getJdbc() {
        return jdbc;
    }

    public void setJdbc(String jdbc) {
        this.jdbc = jdbc;
    }

    public TypeBd getType() {
        return type;
    }

    public void setType(TypeBd type) {
        this.type = type;
    }

    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (o == null || getClass() != o.getClass()) return false;
        DataBase dataBase = (DataBase) o;
        return Objects.equals(nome, dataBase.nome) &&
                Objects.equals(jdbc, dataBase.jdbc) &&
                type == dataBase.type;
    }

    @Override
    public int hashCode() {
        return Objects.hash(nome, jdbc, type);
    }

    @Override
    public String toString() {
        return "DataBase{" +
                "nome='" + nome + '\'' +
                ", jdbc='" + jdbc + '\'' +
                ", type=" + type +
                '}';
    }
}
