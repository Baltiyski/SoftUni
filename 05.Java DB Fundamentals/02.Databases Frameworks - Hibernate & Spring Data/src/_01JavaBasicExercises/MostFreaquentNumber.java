package _01JavaBasicExercises;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.stream.Stream;

/**
 * Created by stefa on 3.7.2017 г..
 */
public class MostFreaquentNumber {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        int[] sequence = Stream.of(reader.readLine().split("\\s")).mapToInt(Integer::parseInt).toArray();

        int count = 0;
        int mostFreqNum = 0;
        for (int i = 0; i < sequence.length; i++) {
            int currentCount = 0;
            for (int j = i; j < sequence.length; j++) {
                if (sequence[j] == sequence[i]){
                    currentCount++;
                }
            }
            if (currentCount > count) {
                count = currentCount;
                mostFreqNum = sequence[i];
            }
        }

        System.out.println(mostFreqNum);

    }
}
