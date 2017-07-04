package _01JavaBasicExercises;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

/**
 * Created by stefa on 4.7.2017 г..
 */
public class ChangeToUppercase {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        String text = reader.readLine();
        int startTag = text.indexOf("<upcase>");

        while (startTag != -1) {
            int endTag = text.indexOf("</upcase>");
            String changedText = text.substring(startTag + 8, endTag);
            text = text.replace("<upcase>" + changedText + "</upcase>", changedText.toUpperCase());
            startTag = text.indexOf("<upcase>");
        }

        System.out.println(text);
    }
}
