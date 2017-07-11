package _02JavaOOPOverview._08BookLibrary;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.stream.Collector;
import java.util.stream.Collectors;

/**
 * Created by StefanBaltiyski on 11.7.2017 г..
 */
public class Main {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        int amountOfBooks = Integer.parseInt(reader.readLine());
        Library library = new Library();
        for (int i = 0; i < amountOfBooks; i++) {
            String[] addBooks = reader.readLine().split("\\s");
            String title = addBooks[0];
            String author = addBooks[1];
            String publisher = addBooks[2];
            String realeaseDate = addBooks[3];
            String ISBN = addBooks[4];
            double price = Double.parseDouble(addBooks[5]);
            Book book = new Book(title, author, publisher,realeaseDate,ISBN,price);
            library.addBook(book);
        }

        library.getBooks()
                .stream()
                .collect(Collectors.groupingBy(Book::getAuthor, Collectors.summingDouble(Book::getPrice)))
                .entrySet()
                .stream()
                .sorted((a,b) -> {
                    int result = Double.compare(b.getValue(),a.getValue());
                    if (result == 0) {
                        result = a.getKey().compareTo(b.getKey());
                    }
                    return  result;
                }).forEach(a -> {
                    System.out.printf("%s -> %.2f\n",a.getKey(),a.getValue());
        });
    }
}
