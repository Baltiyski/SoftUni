package _SetsAndMaps.LabProblems;

import java.util.HashSet;
import java.util.Scanner;

public class _01Parkinglot {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		
		HashSet<String> parking = new HashSet<>();
		
		while (true) {
			String input = scanner.nextLine();
			if ("END".equals(input)) {
				break;
			} else {
				String[] cars = input.split(", ");
				if ("IN".equals(cars[0])) {
					parking.add(cars[1]);
				} else {
					parking.remove(cars[1]);
				}
			}
		}
		
		if (parking.size() <= 0) {
			System.out.println("Parking Lot is Empty");
		} else {
			for (String cars : parking) {
				System.out.println(cars);
			}
		}
	}
}
