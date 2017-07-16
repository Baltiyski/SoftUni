package _03JavaOOPPrinciples._03Ferrari;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

/**
 * Created by StefanBaltiyski on 12.7.2017 г..
 */
public class Main {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        String name = reader.readLine();
        Car car = new Ferrari(name);
        System.out.println(car.toString());
    }
}
