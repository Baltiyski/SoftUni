package _02JavaOOPOverview._04NumberInReversedOrder;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

/**
 * Created by StefanBaltiyski on 6.7.2017 г..
 */
public class Main {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        double number = Double.parseDouble(reader.readLine());

        DecimalNumber reversNum = new DecimalNumber();
        reversNum.reverNum(number);
    }
}
