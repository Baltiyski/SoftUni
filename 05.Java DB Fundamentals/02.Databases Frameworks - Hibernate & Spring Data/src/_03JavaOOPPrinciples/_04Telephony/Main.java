package _03JavaOOPPrinciples._04Telephony;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

/**
 * Created by StefanBaltiyski on 12.7.2017 г..
 */
public class Main {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        String[] numbers = reader.readLine().split("\\s");
        String[] urls = reader.readLine().split("\\s");
        Smartphone phone = new Smartphone();

        for (String number : numbers) {
            System.out.println(phone.call(number));
        }

        for (String url : urls) {
            System.out.println(phone.browse(url));
        }

    }
}
