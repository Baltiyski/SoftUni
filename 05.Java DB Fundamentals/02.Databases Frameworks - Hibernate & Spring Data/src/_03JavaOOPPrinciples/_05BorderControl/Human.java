package _03JavaOOPPrinciples._05BorderControl;

/**
 * Created by StefanBaltiyski on 15.7.2017 г..
 */
public class Human extends Identification{
    private String name;
    private int age;


    protected Human(String name,int age, String id) {
        super(id);
        this.name = name;
        this.age = age;
    }
}
