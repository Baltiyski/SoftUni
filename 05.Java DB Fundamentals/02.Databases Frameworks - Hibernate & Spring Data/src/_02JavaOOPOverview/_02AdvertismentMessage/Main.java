package _02JavaOOPOverview._02AdvertismentMessage;

import java.util.Random;
import java.util.Scanner;

/**
 * Created by stefa on 5.7.2017 г..
 */
public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        Random rdm = new Random();

        int numberOfAdd = Integer.parseInt(sc.nextLine());

        String[] phrase = {
                "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can’t live without this product."
        };

        String[] events = {
                "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!"
        };

        String[] author = {
                "Diana",
                "Petya",
                "Stella",
                "Elena",
                "Katya",
                "Iva",
                "Annie",
                "Eva"
        };

        String[] cities = {
                "Burgas",
                "Sofia",
                "Plovdiv",
                "Varna",
                "Ruse"
        };

        for (int i = 0; i < numberOfAdd; i++) {
            int phraseIndex = rdm.nextInt(phrase.length);
            int eventsIndex = rdm.nextInt(events.length);
            int authorIndex = rdm.nextInt(author.length);
            int citiesIndex = rdm.nextInt(cities.length);
            System.out.printf("%s %s %s - %s\n",phrase[phraseIndex], events[eventsIndex], author[authorIndex], cities[citiesIndex]);
        }

    }
}
