package _01JavaBasicExercises;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Objects;
import java.util.stream.Stream;

/**
 * Created by stefa on 3.7.2017 г..
 */
public class MaxSequenceOfEqualElements {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        Integer[] sequence = Stream.of(reader.readLine().split("\\s")).map(Integer::parseInt).toArray(Integer[]::new);

        int startIndex = 0;
        int bestLenght = 1;

        for (int i = 0; i < sequence.length ; i++) {
            int currentLenght = 1;
            for (int nextIndex =  i + 1; nextIndex < sequence.length; nextIndex++) {
                if (Objects.equals(sequence[i], sequence[nextIndex])) {
                    currentLenght++;
                } else {
                    break;
                }
            }

            if (currentLenght > bestLenght) {
                bestLenght = currentLenght;
                startIndex = i;
            }
        }

        for (int i = 0; i <bestLenght ; i++) {
            System.out.print(sequence[startIndex] + " ");
        }
    }
}
