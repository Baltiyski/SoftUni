package _03JavaOOPPrinciples._06BirthdayCelabrations;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.ArrayList;
import java.util.List;

/**
 * Created by StefanBaltiyski on 15.7.2017 г..
 */
public class Main {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        List<DateOrID> allInputs = new ArrayList<>();

        while (true) {
            String[] kinds =reader.readLine().split("\\s");
            if ("End".equals(kinds[0])) {
                break;
            }

            DateOrID date = null;
            switch (kinds[0]) {
                case "Citizen":
                    date = new Citizen(kinds[1],Integer.parseInt(kinds[2]),kinds[3],kinds[4]);
                    break;
                case "Robot":
                    continue;
                case "Pet":
                    date = new Pet(kinds[1], kinds[2]);
                    break;
                default:
                    break;
            }
            allInputs.add(date);
        }

        String year = reader.readLine();

        allInputs.stream().filter(al -> al.isDate(year)).forEach(al-> System.out.println(al.getIdDate()));
    }
}
