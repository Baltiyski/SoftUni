package _01JavaBasicExercises;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

/**
 * Created by Stefan Baltiyski on 2.7.2017 г..
 */
public class VariableHexadecimal {
    public static void main(String[] args) throws IOException {
        BufferedReader read = new BufferedReader(new InputStreamReader(System.in));
        String hexDec = read.readLine();
        int formatNumber = Integer.parseInt(hexDec,16);

        System.out.println(formatNumber);
    }
}
