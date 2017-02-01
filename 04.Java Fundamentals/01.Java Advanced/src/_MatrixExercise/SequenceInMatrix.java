package _MatrixExercise;

import java.util.Scanner;

public class SequenceInMatrix {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		String[] input = scanner.nextLine().split(" ");
		int rows = Integer.parseInt(input[0]);
		int cols = Integer.parseInt(input[1]);
		
		String[][] matrix = new String[rows][cols];
		
		fillTheMatrix(matrix, scanner);
		
		
	}
	
	public static void countSequence(String[][] matrix) {
		int count = 0;
		
		
		
	}
	
	public static void fillTheMatrix(String[][] matrix, Scanner scanner) {
		for (int row = 0; row < matrix.length; row++) {
			String[] reamainders = scanner.nextLine().split(" ");
			for (int col = 0; col < reamainders[row].length(); col++) {
				matrix[row][col] = reamainders[col];
			}
		}
	}
}
