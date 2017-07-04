package _01JavaBasicExercises;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

/**
 * Created by stefa on 4.7.2017 г..
 */
public class FitString {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        String content = reader.readLine();
        String fitString = "";

        if (content.length() > 19) {
            fitString = content.substring(0, 20);
            System.out.println(fitString);
        } else {
            int lenght = 20 - content.length();
            for (int i = 0; i < lenght; i++) {
                content = content.concat("*");
            }
            System.out.println(content);
        }


    }
}
