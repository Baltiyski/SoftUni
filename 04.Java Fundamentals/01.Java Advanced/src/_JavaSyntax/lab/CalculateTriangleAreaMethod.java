package _JavaSyntax.lab;

import java.util.Scanner;

public class CalculateTriangleAreaMethod {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		
		double base = scanner.nextDouble();
		double hight = scanner.nextDouble();
		
		double area = calcArea(base, hight);
		
		System.out.printf("Area = %.2f",area);
	}
	
	public static double calcArea(double base, double hight){
		double area = (base * hight) / 2;
		return area;
	}

}
