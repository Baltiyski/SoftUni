package _01JavaBasicExercises;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

/**
 * Created by stefa on 2.7.2017 г..
 */
public class VowelOrDigit {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        String[] vowel = {"A", "E", "I", "O", "U"};
        String input = reader.readLine().toUpperCase();
        if (Character.isDigit(input.charAt(0))) {
            System.out.println("digit");
        } else {
            boolean isVowel = false;
            for (String letter : vowel) {
                if (letter.equals(input)) {
                    isVowel = true;
                }
            }
            if (isVowel) {
                System.out.println("vowel");
            } else {
                System.out.println("other");
            }
        }
    }
}
