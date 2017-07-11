package _02JavaOOPOverview._07AverageGrades;

import java.util.List;

/**
 * Created by StefanBaltiyski on 11.7.2017 г..
 */
public class Student {
    private String name;
    private List<Double> grades;
    private double avgGrade;

    public Student(String name, List<Double> grades) {
        this.name = name;
        this.grades = grades;
    }

    private void addGrades (List<Double> grades) {
        this.grades.addAll(grades);
    }

    public void calculateAvgGrades() {
        this.avgGrade = this.grades.stream().mapToDouble(g -> g).average().getAsDouble();
    }

    public String getName() {
        return this.name;
    }

    public double getAvgGrade() {
        return this.avgGrade;
    }

    @Override
    public String toString() {
        return String.format("%s -> %.2f",this.getName(), this.getAvgGrade());
    }
}
