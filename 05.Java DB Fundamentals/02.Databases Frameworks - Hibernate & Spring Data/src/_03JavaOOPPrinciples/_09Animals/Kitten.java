package _03JavaOOPPrinciples._09Animals;

/**
 * Created by StefanBaltiyski on 16.7.2017 г..
 */
public class Kitten extends Cat {
    private static final String GENDER = "Female";

    public Kitten(String name, int age) {
        super(name, age, GENDER);
    }

    @Override
    public String produceSound() {
        return "Miau";
    }
}
