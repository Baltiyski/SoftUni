package _StacksAndQueues.LabProblems;

import java.util.ArrayDeque;
import java.util.Scanner;

public class _01ReverseString {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		String input = scanner.nextLine();
		
		ArrayDeque<Character> reversString = new ArrayDeque<>();
		
		for (Character ch : input.toCharArray()) {
			reversString.push(ch);
		}
		
		while (!reversString.isEmpty()) {
			System.out.print(reversString.pop());
			
		}
		
	}
}
