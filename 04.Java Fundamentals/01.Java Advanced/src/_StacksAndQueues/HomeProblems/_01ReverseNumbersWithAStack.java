package _StacksAndQueues.HomeProblems;

import java.util.ArrayDeque;
import java.util.Scanner;

public class _01ReverseNumbersWithAStack {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		String[] token = scanner.nextLine().split("\\s+");
		
		ArrayDeque<Integer> revNumbers = new ArrayDeque<>();
		
		for (int i = 0; i < token.length; i++) {
			revNumbers.push(Integer.parseInt(token[i]));
		}
		
		while (revNumbers.size() > 0) {
			System.out.print(revNumbers.pop() + " ");
			
		}
		
	}
}
