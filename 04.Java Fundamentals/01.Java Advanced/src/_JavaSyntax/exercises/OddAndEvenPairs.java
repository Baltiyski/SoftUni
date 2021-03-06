package _JavaSyntax.exercises;

import java.util.Scanner;

public class OddAndEvenPairs {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		
		String[] numbers = scanner.nextLine().split(" ");
		
		if (numbers.length % 2 !=0) {
			System.out.println("invalid length");
		}
		else {
			for (int i = 0; i < numbers.length - 1; i++) {
				int num1 = Integer.parseInt(numbers[i]);
				int num2 = Integer.parseInt(numbers[i + 1]);
				
				if (num1 % 2 == 0 && num2 % 2 == 0) {
					System.out.printf("%s, %s -> both are even%n", num1, num2);
				}
				else if (num1 % 2 != 0 && num2 % 2 != 0) {
					System.out.printf("%s, %s -> both are odd%n", num1, num2);
				}
				else {
					System.out.printf("%d, %d -> different%n", num1, num2);
				}
				++i;
			}
		}
	}
}
