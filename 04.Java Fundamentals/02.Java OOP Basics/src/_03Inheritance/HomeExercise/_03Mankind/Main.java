package _03Inheritance.HomeExercise._03Mankind;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class Main {
	public static void main(String[] args) throws IOException {
		BufferedReader read = new BufferedReader(new InputStreamReader(System.in));
		
		String[] students = read.readLine().split("\\s+");
		String[] workers = read.readLine().split("\\s+");
		
		try {
			Student student = new Student(students[0], students[1], students[2]);
			System.out.println(student);
			System.out.println();
			
			Worker worker = new Worker(workers[0], workers[1], Double.valueOf(workers[2]), Double.valueOf(workers[3]));
			System.out.println(worker);
		} catch (IllegalArgumentException illArgEx) {
			System.out.println(illArgEx.getMessage());
		}
	}
}
