package _01JavaBasicExercises;

        import java.io.BufferedReader;
        import java.io.IOException;
        import java.io.InputStreamReader;

/**
 * Created by stefa on 4.7.2017 г..
 */
public class ReverseString {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        String words = reader.readLine();
        char[] revers = words.toCharArray();

        for (int i = revers.length - 1; i >= 0; i--) {
            System.out.print(revers[i]);
        }
    }
}
