package _JavaSyntax.exercises;

import java.util.Scanner;

public class DecimalToBase7 {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		
		long num = scanner.nextLong();
		Long newInt = new Long(Long.toString(num,7));
		
		System.out.println(newInt);
	}

}
