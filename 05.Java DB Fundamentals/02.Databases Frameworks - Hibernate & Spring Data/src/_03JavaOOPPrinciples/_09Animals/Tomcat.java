package _03JavaOOPPrinciples._09Animals;

/**
 * Created by StefanBaltiyski on 16.7.2017 г..
 */
public class Tomcat extends  Cat{
    private static final String GENDER = "Male";

    public Tomcat(String name, int age) {
        super(name, age, GENDER);
    }

    @Override
    public String produceSound() {
        return "Give me one million b***h";
    }
}
