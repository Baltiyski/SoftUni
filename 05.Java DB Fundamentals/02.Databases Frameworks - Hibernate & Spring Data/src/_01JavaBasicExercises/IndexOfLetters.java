package _01JavaBasicExercises;

        import java.io.BufferedReader;
        import java.io.IOException;
        import java.io.InputStreamReader;

/**
 * Created by stefa on 3.7.2017 г..
 */
public class IndexOfLetters {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        String[] words = reader.readLine().toLowerCase().split("");
        Character[] englishAlphabet = {'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'};

        for (String letter : words) {
            char c = letter.charAt(0);
            for (int i = 0; i < englishAlphabet.length; i++) {
                if (c == englishAlphabet[i]) {
                    System.out.printf("%s -> %d%n",letter,i);
                    break;
                }
            }
        }
    }
}
