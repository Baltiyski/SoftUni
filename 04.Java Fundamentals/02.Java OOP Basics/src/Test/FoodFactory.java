package Test;

public class FoodFactory extends Food{
	String name;
    public Food getFood(String string) {
        if (string.equals("FastFood")) {
            Food f = new FastFood();
            f.name = string;
            return f;
        } else {
            Food f = new Fruit();
            f.name = string;
            return f;
        }
    }	
}
