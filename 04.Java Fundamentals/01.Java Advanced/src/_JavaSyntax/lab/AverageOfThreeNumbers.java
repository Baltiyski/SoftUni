package _JavaSyntax.lab;

import java.util.Scanner;

public class AverageOfThreeNumbers {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		
		double firsNum = scanner.nextDouble();
		double secondNum = scanner.nextDouble();
		double thirdNum = scanner.nextDouble();
		
		double avg = (firsNum + secondNum + thirdNum) / 3;
		
		System.out.printf("%.2f",avg);
		
	}
}
	