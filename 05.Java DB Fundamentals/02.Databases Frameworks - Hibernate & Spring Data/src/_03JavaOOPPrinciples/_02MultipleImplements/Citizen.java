package _03JavaOOPPrinciples._02MultipleImplements;

/**
 * Created by StefanBaltiyski on 11.7.2017 г..
 */
public class Citizen implements Identifiable, Birthable, Person{
    private String name;
    private int age;
    private String birthDate;
    private String id;

    public Citizen(String name, int age, String birthDate, String id) {
        this.name = name;
        this.age = age;
        this.birthDate = birthDate;
        this.id = id;
    }

    @Override
    public String getName() {
        return this.name;
    }

    @Override
    public String birthDate() {
        return this.birthDate;
    }

    @Override
    public String id() {
        return this.id;
    }

    @Override
    public int getAge() {
        return this.age;
    }
}
