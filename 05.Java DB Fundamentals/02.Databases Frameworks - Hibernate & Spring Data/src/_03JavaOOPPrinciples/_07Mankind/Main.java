package _03JavaOOPPrinciples._07Mankind;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

/**
 * Created by StefanBaltiyski on 16.7.2017 г..
 */
public class Main {
    public static void main(String[] args) throws IOException {
        try{
            BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

            String[] studentsInput = reader.readLine().split("\\s");
            String[] workerInput = reader.readLine().split("\\s");

            String studentFirstName = studentsInput[0];
            String studentLastName = studentsInput[1];
            String studentFacNum = studentsInput[2];
            Student student = new Student(studentFirstName, studentLastName, studentFacNum);

            String workerFirstName = workerInput[0];
            String workerLastName = workerInput[1];
            double workerSalary = Double.parseDouble(workerInput[2]);
            double workerHoursPerDay = Double.parseDouble(workerInput[3]);
            Worker worker = new Worker(workerFirstName, workerLastName, workerSalary, workerHoursPerDay);

            System.out.println(student);
            System.out.println();
            System.out.println(worker);


        } catch (IllegalArgumentException msg) {
            System.out.println(msg.getMessage());
        }


    }
}
