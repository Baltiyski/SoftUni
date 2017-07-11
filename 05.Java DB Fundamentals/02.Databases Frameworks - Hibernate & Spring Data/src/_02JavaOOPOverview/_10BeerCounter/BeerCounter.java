package _02JavaOOPOverview._10BeerCounter;

/**
 * Created by StefanBaltiyski on 11.7.2017 г..
 */
public class BeerCounter {
    private static int beerInStock = 0;
    private static int beersDrankCount = 0;

    public BeerCounter () {
    }

    public static void buyBeer(int beers) {
        beerInStock += beers;
    }

    public static void drinkBeer(int beers) {
        beersDrankCount += beers;
        beerInStock -= beers;
    }

    public static int getBeerInStock() {
        return beerInStock;
    }

    private static void setBeerInStock(int beerInStock) {
        BeerCounter.beerInStock = beerInStock;
    }

    public static int getBeersDrankCount() {
        return beersDrankCount;
    }

    private static void setBeersDrankCount(int beersDrankCount) {
        BeerCounter.beersDrankCount = beersDrankCount;
    }
}
