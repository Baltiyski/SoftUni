package _JavaSyntax.lab;

public class Lottery {
	public static void main(String[] args) {
		
		for (int i = 1; i <= 8; i++) {
			for (int j = i + 1; j <= 9; j++) {
				for (int j2 = j + 1; j2 <= 10; j2++) {
					System.out.printf("%s %s %s%n",i,j,j2);
				}
			}
		}
	}
}
