package _03JavaOOPPrinciples._01InterfacePerson;

/**
 * Created by StefanBaltiyski on 11.7.2017 г..
 */
public class Citizen implements Person {
    private String name;
    private int age;

    public Citizen(String name, int age) {
        this.name = name;
        this.age = age;
    }

    @Override
    public String getName() {
        return this.name;
    }

    @Override
    public int getAge() {
        return this.age;
    }
}
