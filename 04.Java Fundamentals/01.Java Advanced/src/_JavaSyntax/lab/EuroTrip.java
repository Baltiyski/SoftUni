package _JavaSyntax.lab;

import java.math.BigDecimal;
import java.util.Scanner;

public class EuroTrip {

	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		
		double money = scanner.nextDouble();
		
		BigDecimal exchange = new BigDecimal("4210500000000");
		BigDecimal priceInLv = new BigDecimal(1.20 * money);
		BigDecimal priceInmarks = exchange.multiply(priceInLv);
		
		System.out.printf("%.2f marks", priceInmarks);

	}
}
