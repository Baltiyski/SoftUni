package _StacksAndQueues.LabProblems;

import java.util.ArrayDeque;
import java.util.Scanner;

public class _07PalindromeChecker {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		String word = scanner.nextLine();
		
		ArrayDeque<Character> symbol = new ArrayDeque<>();
		
		for (Character c : word.toCharArray()) {
			symbol.offer(c);
		}
		
		boolean isPalindrome = true;
		while (symbol.size() > 1) {
			char first = symbol.poll();
			char last = symbol.pollLast();
			
			if (first != last) {
				isPalindrome = false;
				break;
			}
		}
		
		System.out.println(isPalindrome);
	}
}
