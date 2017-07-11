package _02JavaOOPOverview._08BookLibrary;

/**
 * Created by StefanBaltiyski on 11.7.2017 г..
 */
public class Book {
    private String title;
    private String author;
    private String publisher;
    private String realeaseDate;
    private String ISBN;
    private double price;

    public Book(String title, String author, String publisher, String realeaseDate, String ISBN, double price) {
        this.setTitle(title);
        this.setAuthor(author);
        this.setPublisher(publisher);
        this.setRealeaseDate(realeaseDate);
        this.setISBN(ISBN);
        this.setPrice(price);
    }

    public String getTitle() {
        return title;
    }

    private void setTitle(String title) {
        this.title = title;
    }

    public String getAuthor() {
        return author;
    }

    private void setAuthor(String author) {
        this.author = author;
    }

    private String getPublisher() {
        return publisher;
    }

    private void setPublisher(String publisher) {
        this.publisher = publisher;
    }

    private String getRealeaseDate() {
        return realeaseDate;
    }

    private void setRealeaseDate(String realeaseDate) {
        this.realeaseDate = realeaseDate;
    }

    private String getISBN() {
        return ISBN;
    }

    private void setISBN(String ISBN) {
        this.ISBN = ISBN;
    }

    public double getPrice() {
        return price;
    }

    private void setPrice(double price) {
        this.price = price;
    }
}
