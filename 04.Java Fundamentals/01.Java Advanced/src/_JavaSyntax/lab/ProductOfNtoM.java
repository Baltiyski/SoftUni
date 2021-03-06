package _JavaSyntax.lab;

import java.math.BigInteger;
import java.util.Scanner;

public class ProductOfNtoM {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		
		int n = scanner.nextInt();
		int m = scanner.nextInt();
		
		BigInteger product = new BigInteger("1");
		int index = n;
		
		do {
			product = product.multiply(new BigInteger(String.valueOf(index)));
			index++;
		} while (index <= m);
		
		System.out.printf("product[%s..%s] = %s",n,m,product);
	}
}
