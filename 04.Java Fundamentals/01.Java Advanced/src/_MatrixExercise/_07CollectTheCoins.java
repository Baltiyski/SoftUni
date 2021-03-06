package _MatrixExercise;

import java.util.Scanner;

public class _07CollectTheCoins {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		
		char[][] matrix = new char[4][];
		
		fillMatrix(matrix, scanner);
		coinsWallsCounter(matrix, scanner);
		
		
	}
	
	public static void coinsWallsCounter(char[][] matrix, Scanner scanner) {
		char[] commands = scanner.nextLine().toCharArray();
		
		int coints = 0;
		int walls = 0;
		
		int currentLocRow = 0;
		int currentLocCol = 0;
		
		for (char comand : commands) {
			switch (comand) {
			case 'V':
				currentLocRow++;
				if ((currentLocRow > matrix.length-1) || (currentLocCol > matrix[currentLocRow].length)) {
					currentLocRow--;
					walls++;
				} else if (matrix[currentLocRow][currentLocCol] == '$'){
					coints++;
				}
				break;
			case '^':
				currentLocRow--;
				if(currentLocRow < 0) {
					currentLocRow++;
					walls++;
				} else if (matrix[currentLocRow][currentLocCol] == '$') {
					coints++;
				}
				break;
			case '<':
				currentLocCol--;
				if (currentLocCol < 0) {
					currentLocCol++;
					walls++;
				} else if (matrix[currentLocRow][currentLocCol] == '$'){
					coints++;
				}
				break;
			case '>':
				currentLocCol++;
				if (currentLocCol > matrix[currentLocRow].length -1) {
					currentLocCol--;
					walls++;
				} else if (matrix[currentLocRow][currentLocCol] == '$'){
					coints++;
				}
				break;
				
			default:
				break;
			}
		}
		
		System.out.println("Coins = " + coints);
		System.out.println("Walls = " + walls);
		
	}
	
	public static void fillMatrix(char[][] matrix, Scanner scanner) {
		
		for (int row = 0; row < matrix.length; row++) {
			char[] remainders = scanner.nextLine().toCharArray();
			matrix[row] = new char[remainders.length];
			for (int col = 0; col < matrix[row].length; col++) {
				matrix[row][col] = remainders[col];
			}
		}	
		
	}
}
