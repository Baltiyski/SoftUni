package _02JavaOOPOverview._06ShoppingSpree;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.HashMap;
import java.util.LinkedHashMap;
import java.util.Map;

/**
 * Created by StefanBaltiyski on 8.7.2017 г..
 */
public class Main {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        Map<String, Person> people = new LinkedHashMap<>();
        String[] peoplesInput = reader.readLine().split(";");
        for (String personInfo : peoplesInput) {
            String[] personArg = personInfo.split("=");
            String name = personArg[0];
            double money = Double.parseDouble(personArg[1]);

            try {
                Person person = new Person(name, money);
                people.put(name,person);

            } catch (IllegalArgumentException msg) {
                System.out.println(msg.getMessage());
                return;
            }
        }

        Map<String, Product> products = new HashMap<>();
        String[] productsInput = reader.readLine().split(";");
        for (String productInfo : productsInput) {
            String [] productArg = productInfo.split("=");
            String name = productArg[0];
            double cost = Double.parseDouble(productArg[1]);

            try {
                Product product = new Product(name, cost);
                products.put(name, product);
            } catch (IllegalArgumentException msgi) {
                System.out.println(msgi.getMessage());
                return;
            }
        }

        while (true) {
            String[] puraches = reader.readLine().split("\\s+");
            if ("END".equals(puraches[0])){
                break;
            }

            String personName = puraches[0];
            String productName = puraches[1];

            try{
                people.get(personName).buyProduct(products.get(productName));
                System.out.printf("%s bought %s\n", personName,productName);
            } catch (IllegalArgumentException msgii) {
                System.out.println(msgii.getMessage());
            }
        }

        people.values().forEach(System.out::println);
    }
}
