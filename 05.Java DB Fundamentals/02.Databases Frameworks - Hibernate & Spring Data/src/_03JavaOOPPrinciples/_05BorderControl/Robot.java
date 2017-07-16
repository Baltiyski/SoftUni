package _03JavaOOPPrinciples._05BorderControl;

/**
 * Created by StefanBaltiyski on 15.7.2017 г..
 */
public class Robot extends Identification {
    private String name;

    protected Robot(String name, String id) {
        super(id);
        this.name = name;
    }
}
