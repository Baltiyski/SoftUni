package _01JavaBasicExercises;

        import java.io.BufferedReader;
        import java.io.IOException;
        import java.io.InputStreamReader;
        import java.util.LinkedHashMap;
        import java.util.Map;

/**
 * Created by stefa on 4.7.2017 г..
 */
public class PhoneBookUpgrade {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        Map<String, String> phoneBook = new LinkedHashMap<>();

        while (true) {
            String line = reader.readLine();

            if (line.equals("END")) {
                break;
            }

            String[] sequence = line.split("\\s");
            String operation = sequence[0];


            if (operation.equals("A")) {
                String name = sequence[1];
                String phoneNumber = sequence[2];
                phoneBook.put(name, phoneNumber);
            } else if (operation.equals("S")) {
                String name = sequence[1];
                if (phoneBook.containsKey(name)) {
                    System.out.printf("%s -> %s\n",name,phoneBook.get(name));
                } else {
                    System.out.printf("Contact %s does not exist.\n", name);
                }
            } else {
                phoneBook
                        .entrySet()
                        .stream()
                        .sorted((a,b) -> a.getKey().compareTo(b.getKey()))
                        .forEach(a -> System.out.println(a.getKey() + " -> " + a.getValue()));
            }
        }
    }
}