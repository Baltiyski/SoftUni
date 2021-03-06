package _SetsAndMaps.HomeProblems;

import java.util.HashMap;
import java.util.Scanner;

public class _05Phonebook {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		
		HashMap<String, String> phonebook = new HashMap<>();
		
		while (true) {
			String[] input = scanner.nextLine().split("-");
			if ("search".equals(input[0])) {
				break;
			} else {
				phonebook.put(input[0], input[1]);
			}
		}
		
		while (true) {
			String input = scanner.nextLine();
			if ("stop".equals(input)) {
				break;
			} else {
				boolean isExist = false;
				for (String name : phonebook.keySet()) {
					if (input.equals(name)) {
						System.out.printf("%s -> %s\n",input, phonebook.get(name));
						isExist =true;
						break;
					}
				}
				if (!isExist) {
					System.out.printf("Contact %s does not exist.\n",input);
				}
			}
		}
	}
}
