package _JavaSyntax.exercises;

import java.util.Scanner;

public class HitTheTarget {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		
		int num = Integer.parseInt(scanner.nextLine());
		
		for (int i = 1; i <= 20; i++) {
			for (int j = 20; j >= 1; --j) {
				if (i + j == num) {
					System.out.printf("%s + %s = %s\n",i,j,num);
				}
			}
		}
		
		
		for (int i = 1; i <= 20; i++) {
			for (int j = 1; j <= 20; j++) {
				if (i - j == num) {
					System.out.printf("%s - %s = %s\n",i,j,num);
				}
			}
		}
	}
}
