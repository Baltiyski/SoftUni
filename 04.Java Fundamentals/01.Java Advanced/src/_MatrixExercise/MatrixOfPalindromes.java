package _MatrixExercise;

import java.util.Scanner;

public class MatrixOfPalindromes {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		String[] input = scanner.nextLine().split(" ");
		int row = Integer.parseInt(input[0]);
		int col = Integer.parseInt(input[1]);
		
		char letter = 'a';
		char changeLetter = 'a';
		
		for (int i = 0; i < row; i++) {
			changeLetter = letter;
			for (int j = 0; j < col; j++) {
				System.out.printf("%s%s%s ",letter,changeLetter,letter);
				changeLetter++;
				
			}
			letter++;
			System.out.println();
		}
		
	}
}
