package _JavaSyntax.lab;

import java.util.Scanner;

public class ReadInput {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		
		String wordFirst = scanner.next();
		String wordSec = scanner.next();
		
		int numOne = scanner.nextInt();
		int numTwo = scanner.nextInt();
		int numThre = scanner.nextInt();
		
		scanner.nextLine();
		String wordThre = scanner.nextLine();
		
		int sum = numOne + numTwo + numThre;
		
		System.out.println(wordFirst + " " + wordSec + " " + wordThre + " " + sum);
	}
}
