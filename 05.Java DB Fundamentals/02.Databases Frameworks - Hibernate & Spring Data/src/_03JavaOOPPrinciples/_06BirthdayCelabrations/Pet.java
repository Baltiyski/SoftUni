package _03JavaOOPPrinciples._06BirthdayCelabrations;

/**
 * Created by StefanBaltiyski on 15.7.2017 г..
 */
public class Pet extends DateOrID {
    private String name;

    protected Pet(String name, String idDate) {
        super(idDate);
        this.name = name;
    }
}
