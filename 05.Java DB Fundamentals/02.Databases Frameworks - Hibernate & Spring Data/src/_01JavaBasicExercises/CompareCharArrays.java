package _01JavaBasicExercises;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

/**
 * Created by stefa on 2.7.2017 г..
 */
public class CompareCharArrays {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        String[] fArray = reader.readLine().split("\\s");
        String[] sArray = reader.readLine().split("\\s");

        int minLenght = Integer.min(fArray.length, sArray.length);

        for (int i = 0; i < minLenght; i++) {
            if (fArray[i].compareTo(sArray[i]) < 0) {
                System.out.println(String.join("",fArray));
                System.out.println(String.join("",sArray));
                return;
            } else if (fArray[i].compareTo(sArray[i]) > 0){
                System.out.println(String.join("",sArray));
                System.out.println(String.join("",fArray));
                return;
            }
        }

        if (fArray.length > sArray.length) {
            System.out.println(String.join("",sArray));
            System.out.println(String.join("",fArray));
        } else {
            System.out.println(String.join("",fArray));
            System.out.println(String.join("",sArray));
        }
    }
}
