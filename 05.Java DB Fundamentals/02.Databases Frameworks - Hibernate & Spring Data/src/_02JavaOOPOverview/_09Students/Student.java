package _02JavaOOPOverview._09Students;

/**
 * Created by StefanBaltiyski on 11.7.2017 г..
 */
public class Student {
    private String name;
    public static int count = 0;

    public Student(String name) {
        this.name = name;
        count++;
    }
}
