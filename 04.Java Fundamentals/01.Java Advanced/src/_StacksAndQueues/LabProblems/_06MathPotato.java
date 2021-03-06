package _StacksAndQueues.LabProblems;

import java.util.ArrayDeque;
import java.util.Collections;
import java.util.Scanner;

public class _06MathPotato {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		String[] children = scanner.nextLine().split("\\s+");
		int n = Integer.parseInt(scanner.nextLine());
		
		ArrayDeque<String> collect = new ArrayDeque<>();
		Collections.addAll(collect, children);
		
		int counter = 1;
		while (collect.size() > 1) {
			for (int index = 1; index < n; index++) {
				String token = collect.poll();
				collect.offer(token);
			}
			
			if (isPrime(counter)) {
				System.out.println("Prime " + collect.peek());
			} else {
				System.out.println("Removed " + collect.poll());
			}
			counter++;
		}
		
		System.out.println("Last is " + collect.poll());
	}

	private static boolean isPrime(int number) {
		if(number <= 1) {
			return false;
		}
		
		for (int i = 2; i <= Math.sqrt(number); i++) {
			if (number % i == 0) {
				return false;
			}
		}
		
		return true;
	}
}
