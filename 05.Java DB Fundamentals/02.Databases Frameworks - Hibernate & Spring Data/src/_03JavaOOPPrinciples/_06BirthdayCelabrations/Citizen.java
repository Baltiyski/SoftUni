package _03JavaOOPPrinciples._06BirthdayCelabrations;

/**
 * Created by StefanBaltiyski on 15.7.2017 г..
 */
public class Citizen extends DateOrID{
    private String name;
    private int age;
    private String id;

    public Citizen(String name, int age, String id, String idDate) {
        super(idDate);
        this.name = name;
        this.age = age;
        this.id = id;
    }
}
