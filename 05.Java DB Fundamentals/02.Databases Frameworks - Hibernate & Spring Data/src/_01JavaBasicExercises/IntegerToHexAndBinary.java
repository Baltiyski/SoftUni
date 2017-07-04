package _01JavaBasicExercises;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

/**
 * Created by stefa on 2.7.2017 г..
 */
public class IntegerToHexAndBinary {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        int  inputNumber = Integer.parseInt(reader.readLine());
        String toHex = Integer.toHexString(inputNumber).toUpperCase();
        String toBinary = Integer.toBinaryString(inputNumber).toUpperCase();

        System.out.println(toHex);
        System.out.println(toBinary);
    }
}
