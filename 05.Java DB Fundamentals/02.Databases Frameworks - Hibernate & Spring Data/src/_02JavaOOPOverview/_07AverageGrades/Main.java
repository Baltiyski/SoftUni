package _02JavaOOPOverview._07AverageGrades;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.ArrayList;
import java.util.List;

/**
 * Created by StefanBaltiyski on 11.7.2017 г..
 */
public class Main {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        List<Student> students = new ArrayList<>();
        int studentsAmount = Integer.parseInt(reader.readLine());
        for (int i = 0; i < studentsAmount; i++) {
            String[] inputStudent = reader.readLine().split("\\s+");
            String name = inputStudent[0];
            List<Double> grades = new ArrayList<>();
            for (int j = 1; j < inputStudent.length; j++) {
                grades.add(Double.parseDouble(inputStudent[j]));
            }

            Student student = new Student(name, grades);
            student.calculateAvgGrades();
            students.add(student);
        }

        students.stream().filter(s -> s.getAvgGrade() >= 5)
                            .sorted((s1,s2) -> {
                                int result = s1.getName().compareTo(s2.getName());
                                if (result == 0) {
                                    result = Double.compare(s2.getAvgGrade(), s1.getAvgGrade());
                                }
                            return result;})
                            .forEach(System.out::println);
    }
}
