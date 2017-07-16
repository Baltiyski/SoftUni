package _03JavaOOPPrinciples._09Animals;

/**
 * Created by StefanBaltiyski on 16.7.2017 г..
 */
public class Dog extends Animal {
    public Dog(String name, int age, String gender) {
        super(name, age, gender);
    }

    @Override
    public String produceSound() {
        return "BauBau";
    }
}
