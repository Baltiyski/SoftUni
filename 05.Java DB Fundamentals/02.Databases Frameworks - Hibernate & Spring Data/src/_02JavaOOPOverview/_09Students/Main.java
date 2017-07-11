package _02JavaOOPOverview._09Students;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

/**
 * Created by StefanBaltiyski on 11.7.2017 г..
 */
public class Main {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        while (true) {
            String input = reader.readLine();
            if ("End".equals(input)) {
                break;
            }
            Student student = new Student(input);
        }

        System.out.println(Student.count);
    }
}
