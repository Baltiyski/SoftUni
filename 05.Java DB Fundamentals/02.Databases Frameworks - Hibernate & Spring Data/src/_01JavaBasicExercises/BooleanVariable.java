package _01JavaBasicExercises;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

/**
 * Created by stefa on 2.7.2017 г..
 */
public class BooleanVariable {
    public static void main(String[] args) throws IOException{
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        boolean inputBoolean = Boolean.parseBoolean(reader.readLine());

        if(inputBoolean) {
            System.out.println("Yes");
        }else {
            System.out.println("No");
        }
    }
}
