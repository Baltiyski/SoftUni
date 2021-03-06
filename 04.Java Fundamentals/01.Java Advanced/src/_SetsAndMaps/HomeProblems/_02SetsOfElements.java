package _SetsAndMaps.HomeProblems;

import java.util.LinkedHashSet;
import java.util.Scanner;

public class _02SetsOfElements {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		String[] nM = scanner.nextLine().split(" ");
		int n = Integer.parseInt(nM[0]);
		int m = Integer.parseInt(nM[1]);
		
		LinkedHashSet<Integer> firstSet = new LinkedHashSet<>();
		LinkedHashSet<Integer> secondSet = new LinkedHashSet<>();
		
		for (int i = 0; i < n; i++) {
			int inputNum = Integer.parseInt(scanner.nextLine());
			firstSet.add(inputNum);
		}
		for (int i = 0; i < m; i++) {
			int inputNum = Integer.parseInt(scanner.nextLine());
			secondSet.add(inputNum);
		}
		
		for (Integer num1 : firstSet) {
			for (Integer num2 : secondSet) {
				if (num1 == num2) {
					System.out.printf("%s ",num1);
				}
			}
		}
		
	}
}
