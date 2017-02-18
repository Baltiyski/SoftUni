package _SetsAndMaps.LabProblems;

import java.util.HashMap;
import java.util.Scanner;
import java.util.TreeMap;

public class _05AcademyGraduation {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		int amountOfStudents = Integer.parseInt(scanner.nextLine());
		
		HashMap<String, Double> studentsAndGrades = new HashMap<>();
		
		
		for (int i = 0; i < amountOfStudents; i++) {
			String studentname = scanner.nextLine();
			String[] studentGrades = scanner.nextLine().split(" ");
			double avgStudGrad = 0;
			for (String string : studentGrades) {
				avgStudGrad += Double.parseDouble(string);
			}
			studentsAndGrades.put(studentname, (avgStudGrad / studentGrades.length));
		}
		
		TreeMap<String, Double> result = new TreeMap<>(studentsAndGrades);
		for (String key : result.keySet()) {
			System.out.println(key + " is graduated with " + result.get(key));
		}
		
	}
}
