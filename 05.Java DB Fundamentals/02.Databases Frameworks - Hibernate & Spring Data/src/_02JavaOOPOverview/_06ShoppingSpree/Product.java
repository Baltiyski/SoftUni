package _02JavaOOPOverview._06ShoppingSpree;

/**
 * Created by StefanBaltiyski on 8.7.2017 г..
 */
public class Product {
    private String name;
    private double cost;

    public Product(String name, double cost) {
        this.setName(name);
        this.setCost(cost);
    }

    public String getName() {
        return name;
    }

    private void setName(String name) {

        if (name == null || name.trim().length() == 0){
            throw new IllegalArgumentException("Name cannot be empty");
        }
        this.name = name;
    }

    public double getCost() {
        return cost;
    }

    private void setCost(double cost) {
        if (cost < 0 ) {
            throw new IllegalArgumentException("Monney cannot be negative");
        }
        this.cost = cost;
    }

    @Override
    public String toString() {
       return this.getName();
    }
}
