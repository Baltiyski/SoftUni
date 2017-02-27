package _02Encapsulation.Lab._04FirstAndReserveTeam;

import java.util.List;
import java.util.Scanner;
import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.ArrayList;
import java.util.Collections;

public class Main {

	public static void main(String[] args) throws IOException {
		Scanner in = new Scanner(System.in);

        Team team = new Team("Vladix");

        int n = Integer.parseInt(in.nextLine());
        for (int i = 0; i < n; i++) {
            String[] tokens = in.nextLine().split("\\s+");
            String firstName = tokens[0];
            String lastName = tokens[1];
            int age = Integer.parseInt(tokens[2]);
            double salary = Double.parseDouble(tokens[3]);

            Person person = new Person(firstName, lastName, age, salary);

            team.addPlayer(person);
        }

        System.out.println("First team have " + team.getFirstTeam().size() + " players");
        System.out.println("Reserve team have " + team.getReserveTeam().size() + " players");
	}
}
