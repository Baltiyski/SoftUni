package _02Encapsulation.HomeExercise._03AnimalFarm;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class Main {
	public static void main(String[] args) throws IOException {
		BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

		String chickenName = reader.readLine();
		int chickenAge = Integer.parseInt(reader.readLine());
		
		try {
			Chicken chick = new Chicken(chickenName, chickenAge);
			System.out.printf("Chicken %s (age %d) can produce %.0f eggs per day.",chick.getName(), chick.getAge(), chick.productPerDay());
						
		} catch (IllegalArgumentException illArgEx) {
			System.out.println(illArgEx.getMessage());
		}
	}
}
